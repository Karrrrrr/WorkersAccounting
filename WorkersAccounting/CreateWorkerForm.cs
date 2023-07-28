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
	public partial class CreateWorkerForm : Form
	{
		public CreateWorkerForm()
		{
			InitializeComponent();

			StatusCB.SelectedIndex = 0;
			DepartmentCB.DataSource = DbConnection.GetDepartmentsString();
		}

		private void CreateButton_Click(object sender, EventArgs e)
		{
			if ((FullNameTB.Text != "") && (ServiceNumberTB.Text != "") && (PositionTB.Text != "") && (EmailTB.Text != "") && (PhoneTB.Text != ""))
			{
				Worker worker = new Worker() { FullName = FullNameTB.Text, ServiceNumber = ServiceNumberTB.Text, Position = PositionTB.Text, Email = EmailTB.Text, Phone = PhoneTB.Text, EmploymentDate = EmploymentDatePicker.Value, Status = StatusCB.SelectedIndex == 0 ? true : false, Department = new Department() { Name = (string)DepartmentCB.SelectedItem } };
				if (IsDismissedChB.Checked)
				{
					worker.DismissalDate = DismissalDatePicker.Value;
				}
				DbConnection.CreateWorker(worker);
				Close();
			}
			else
			{
				MessageBox.Show("Заполните все поля");
			}
		}

		private void IsDismissedChB_CheckedChanged(object sender, EventArgs e)
		{
			if (IsDismissedChB.Checked)
			{
				DismissalDatePicker.Enabled = true;
			}
			else
			{
				DismissalDatePicker.Enabled = false;
			}	
		}
	}
}
