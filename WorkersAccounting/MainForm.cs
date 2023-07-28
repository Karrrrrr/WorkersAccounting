using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkersAccounting.Models;
using Excel = Microsoft.Office.Interop.Excel;

namespace WorkersAccounting
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		void LoadForm()
		{
			if (tabControl.SelectedIndex == 0)
			{
				LoadWorkers();
				LoadDepartmentsCB();
			}
			else if (tabControl.SelectedIndex == 1)
			{
				LoadDepartments();
			}
			else
			{
				LoadStatisticsDepartmentsCB();
				LoadStatistics();
			}
		}

		void LoadWorkers()
		{
			List<Worker> workers = DbConnection.GetWorkers();
			if ((string)DepartmentsCB.SelectedItem != "(нет)")
			{
				workers = workers.Where(item => item.DepartmentName ==  (string)DepartmentsCB.SelectedItem).ToList();
			}
			if (SearchWorkerTB.Text != "")
			{
				workers = workers.Where(item => item.FullName.ToLower().Contains(SearchWorkerTB.Text.ToLower()) || item.ServiceNumber.Contains(SearchWorkerTB.Text) || item.Id.ToString() == SearchWorkerTB.Text).ToList();
			}
			WorkersGrid.DataSource = workers;
			WorkersGrid.Columns["ID"].Visible = false;
			WorkersGrid.Columns["Status"].Visible = false;
			WorkersGrid.Columns["DepartmentID"].Visible = false;
			WorkersGrid.Columns["Department"].Visible = false;
		}

		void LoadDepartmentsCB()
		{
			DepartmentsCB.Items.Clear();
			List<string> departments = DbConnection.GetDepartmentsString();
			DepartmentsCB.Items.Add("(нет)");
			DepartmentsCB.Items.AddRange(departments.ToArray());
			DepartmentsCB.SelectedIndex = 0;
		}

		void LoadStatisticsDepartmentsCB()
		{
			StatisticsDepartmentCB.Items.Clear();
			List<string> departments = DbConnection.GetDepartmentsString();
			StatisticsDepartmentCB.Items.Add("Все");
			StatisticsDepartmentCB.Items.AddRange(departments.ToArray());
			StatisticsDepartmentCB.SelectedIndex = 0;
		}

		void LoadStatistics()
		{
			int[] statistics;
			if ((string)PeriodCalendar.Tag == "NoDate")
			{
				statistics = DbConnection.GetStatistics(StatisticsDepartmentCB.SelectedIndex == 0 ? "" : (string)StatisticsDepartmentCB.SelectedItem);
			}
			else
			{
				statistics = DbConnection.GetStatistics(StatisticsDepartmentCB.SelectedIndex == 0 ? "" : (string)StatisticsDepartmentCB.SelectedItem, PeriodCalendar.SelectionStart, PeriodCalendar.SelectionEnd);
			}
			EmolyedLabel.Text = statistics[0].ToString();
			DismissedLabel.Text = statistics[1].ToString();
		}

		private void CreateWorkerButton_Click(object sender, EventArgs e)
		{
			CreateWorkerForm cwf = new CreateWorkerForm();
			cwf.ShowDialog();
		}

		private void MainForm_Activated(object sender, EventArgs e)
		{
			LoadForm();
		}

		private void DeleteWorker_Click(object sender, EventArgs e)
		{
			DbConnection.DeleteWorker(WorkersGrid.SelectedRows[0].DataBoundItem as Worker);
			LoadWorkers();
		}

		private void DepartmentsCB_SelectedIndexChanged(object sender, EventArgs e)
		{
			LoadWorkers();
		}

		private void SearchWorkerTB_TextChanged(object sender, EventArgs e)
		{
			LoadWorkers();
		}

		void LoadDepartments()
		{
			List<Department> departments = DbConnection.GetDepartments();
			if (SearchDepartmentTB.Text != "")
			{
				departments = departments.Where(item => item.Id.ToString() == SearchDepartmentTB.Text).ToList();
			}
			DepartmentsGrid.DataSource = departments;
			DepartmentsGrid.Columns["ID"].Visible = false;
			DepartmentsGrid.Columns["Status"].Visible = false;
			DepartmentsGrid.Columns["HeadDepartmentId"].Visible = false;
			DepartmentsGrid.Columns["DirectorId"].Visible = false;
			DepartmentsGrid.Columns["Worker"].Visible = false;
		}

		private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
		{
			LoadForm();
		}

		private void CreateDepartmentButton_Click(object sender, EventArgs e)
		{
			CreateDepartmentForm cdf = new CreateDepartmentForm();
			cdf.ShowDialog();
		}

		private void DeleteDepartment_Click(object sender, EventArgs e)
		{
			DbConnection.DeleteDepartment(DepartmentsGrid.SelectedRows[0].DataBoundItem as Department);
			LoadDepartments();
		}

		private void SearchDepartmentTB_TextChanged(object sender, EventArgs e)
		{
			LoadDepartments();
		}

		private void StatisticsDepartmentCB_SelectedIndexChanged(object sender, EventArgs e)
		{
			LoadStatistics();
		}

		private void PeriodCalendar_DateChanged(object sender, DateRangeEventArgs e)
		{
			PeriodCalendar.Tag = "Date";
			LoadStatistics();
		}

		private void ClearCalendar_Click(object sender, EventArgs e)
		{
			PeriodCalendar.Tag = "NoDate";
			PeriodCalendar.SelectionStart = DateTime.Now;
			PeriodCalendar.SelectionEnd = DateTime.Now;
		}

		private void ImportButton_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog() { DefaultExt = "*.xlsx", Filter = "Данные для БД по ТЗ Учет сотрудников.xlsx|*.xlsx", Title = "Выберите файл" };
			if (ofd.ShowDialog() == DialogResult.Cancel)
			{
				return;
			}
			string[,] workers;
			string[,] departments;
			Excel.Application app = new Excel.Application();
			Excel.Workbook wb = app.Workbooks.Open(ofd.FileName);
			Excel.Worksheet workersWorksheet = wb.Sheets[1];
			Excel.Worksheet departmentsWorksheet = wb.Sheets[2];
			var workersLastCell = workersWorksheet.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell);
			var departmentsLastCell = departmentsWorksheet.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell);
			int workersColumns = workersLastCell.Column - 1;
			int workersRows = workersLastCell.Row - 1;
			int departmentsColumns = departmentsLastCell.Column - 1;
			int departmentsRows = departmentsLastCell.Row - 1;
			workers = new string[workersRows, workersColumns];
			departments = new string[departmentsRows, departmentsColumns];
			for (int i = 0; i < workersColumns; i++)
			{
				for (int j = 0; j < workersRows; j++)
				{
					workers[j, i] = workersWorksheet.Cells[j + 2, i + 2].Text;
				}
			}
			for (int i = 0; i < departmentsColumns; i++)
			{
				for (int j = 0; j < departmentsRows; j++)
				{
					departments[j, i] = departmentsWorksheet.Cells[j + 2, i + 2].Text;
				}
			}
			wb.Close();
			app.Quit();
			GC.Collect();
			DbConnection.Import(workers, departments);
			LoadForm();
		}
	}
}
