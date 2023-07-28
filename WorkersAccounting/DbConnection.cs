using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using WorkersAccounting.Models;

namespace WorkersAccounting
{
	internal class DbConnection
	{
		static public List<Worker> GetWorkers()
		{
			using (WorkersAccountingContext db = new WorkersAccountingContext())
			{
				return db.Worker.ToList();
			}
		}

		static public List<string> GetDepartmentsString()
		{
			using (WorkersAccountingContext db = new WorkersAccountingContext())
			{
				return db.Department.Select(item => item.Name).ToList();
			}
		}

		static public void CreateWorker(Worker worker)
		{
			using (WorkersAccountingContext db = new WorkersAccountingContext())
			{
				worker.Department = db.Department.Where(item => item.Name == worker.Department.Name).FirstOrDefault();
				worker.DepartmentId = worker.Department.Id;
				db.Worker.Add(worker);
				db.SaveChanges();
			}
		}

		static public void DeleteWorker(Worker worker)
		{
			using (WorkersAccountingContext db = new WorkersAccountingContext())
			{
				db.Worker.Remove(worker);
				db.SaveChanges();
			}
		}

		static public List<Department> GetDepartments()
		{
			using (WorkersAccountingContext db = new WorkersAccountingContext())
			{
				return db.Department.ToList();
			}
		}

		static public List<string> GetCurrentWorkersList()
		{
			using (WorkersAccountingContext db = new WorkersAccountingContext())
			{
				return db.Worker.Where(item => item.DismissalDate == null).Select(item => item.FullName).ToList();
			}
		}

		static public int FindDepartment(string name)
		{
			using (WorkersAccountingContext db = new WorkersAccountingContext())
			{
				return db.Department.Where(item => item.Name ==  name).FirstOrDefault().Id;
			}
		}

	    static public int FindWorker(string fullName)
		{
			using (WorkersAccountingContext db = new WorkersAccountingContext())
			{
				return db.Worker.Where(item => item.FullName == fullName).FirstOrDefault().Id;
			}
		}

		static public void CreateDepartment(Department department)
		{
			using (WorkersAccountingContext db = new WorkersAccountingContext())
			{
				db.Department.Add(department);
				db.SaveChanges();
			}
		}

		static public void DeleteDepartment(Department department)
		{
			using (WorkersAccountingContext db = new WorkersAccountingContext())
			{
				db.Department.Remove(department);
				db.SaveChanges();
			}
		}

		static public int[] GetStatistics(string department)
		{
			int[] statistics = new int[2];
			using (WorkersAccountingContext db = new WorkersAccountingContext())
			{
				statistics[0] = db.Worker.Where(item => (department == "" ? true : item.Department.Name == department)).Count();
				statistics[1] = db.Worker.Where(item => (department == "" ? true : item.Department.Name == department) && item.DismissalDate != null).Count();
			}
			return statistics;
		}

		static public int[] GetStatistics(string department, DateTime startDate, DateTime endDate)
		{
			int[] statistics = new int[2];
			using (WorkersAccountingContext db = new WorkersAccountingContext())
			{
				statistics[0] = db.Worker.Where(item => (department == "" ? true : item.Department.Name == department) && item.EmploymentDate >= startDate && item.EmploymentDate <= endDate).Count();
				statistics[1] = db.Worker.Where(item => (department == "" ? true : item.Department.Name == department) && item.DismissalDate != null && item.DismissalDate >= startDate && item.DismissalDate <= endDate).Count();
			}
			return statistics;
		}

		static public void Import(string[,] workers, string[,] departments)
		{
			using (WorkersAccountingContext db = new WorkersAccountingContext())
			{
				for (int i = 0; i < departments.GetLength(0); i++)
				{
					Department department = new Department() { Name = departments[i, 0], Status = int.Parse(departments[i, 1]) == 1 ? true : false, DirectorId = int.Parse(departments[i, 3]) };
					if (departments[i, 2] != "")
					{
						department.HeadDepartmentId = int.Parse(departments[i, 2]);
					}
					db.Department.Add(department);
				}
				for (int i = 0; i < workers.GetLength(0); i++)
				{
					Worker worker = new Worker() { FullName = workers[i, 0], ServiceNumber = workers[i, 1], Position = workers[i, 2], Email = workers[i, 3], Phone = workers[i, 4], EmploymentDate = DateTime.Parse(workers[i, 5]), Status = int.Parse(workers[i, 7]) == 1 ? true : false, DepartmentId = int.Parse(workers[i, 8]) };
					worker.Department = db.Department.Find(worker.DepartmentId);
					if (workers[i, 6] != "")
					{
						worker.DismissalDate = DateTime.Parse(workers[i, 6]);
					}
					db.Worker.Add(worker);
				}
				db.SaveChanges();
			}
		}
	}
}
