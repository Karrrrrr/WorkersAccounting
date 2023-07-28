using Microsoft.Extensions.Logging.Abstractions;
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

namespace WorkersAccounting
{
	public partial class CreateDepartmentForm : Form
	{
		public CreateDepartmentForm()
		{
			InitializeComponent();

			List<string> departments = DbConnection.GetDepartmentsString();
			HeadDepartmentCB.Items.Add("(нет)");
			HeadDepartmentCB.Items.AddRange(departments.ToArray());
			HeadDepartmentCB.SelectedIndex = 0;

			DirectorCB.DataSource = DbConnection.GetCurrentWorkersList();

			StatusCB.SelectedIndex = 0;
		}

		private void CreateButton_Click(object sender, EventArgs e)
		{
			if (NameTB.Text != "")
			{
				Department department = new Department() { Name = NameTB.Text, DirectorId = DbConnection.FindWorker((string)DirectorCB.SelectedItem), Status = StatusCB.SelectedIndex == 0 ? true : false };
				if (HeadDepartmentCB.SelectedIndex != 0)
				{
					department.HeadDepartmentId = DbConnection.FindDepartment((string)HeadDepartmentCB.SelectedItem);
				}
				else
				{
					department.HeadDepartmentId = null;
				}
				DbConnection.CreateDepartment(department);
				Close();
			}
			else
			{
				MessageBox.Show("Заполните все поля");
			}
		}
	}
}
