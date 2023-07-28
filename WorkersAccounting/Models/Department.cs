using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WorkersAccounting.Models
{
    public partial class Department
    {
        public Department()
        {
            Worker = new HashSet<Worker>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool? Status { get; set; }
        public int? HeadDepartmentId { get; set; }
        public int DirectorId { get; set; }

        public virtual ICollection<Worker> Worker { get; set; }

        public string EntryStatus
        {
            get
            {
                return Status == true ? "Действующая" : "Закрытая";
			}
        }

        public string HeadDepartment
        {
            get
            {
                using (WorkersAccountingContext db = new WorkersAccountingContext())
                {
                    return HeadDepartmentId != null ? db.Department.Find(HeadDepartmentId).Name : "";
                }
            }
        }

        public string Director
        {
            get
            {
                using (WorkersAccountingContext db = new WorkersAccountingContext())
                {
                    return db.Worker.Find(DirectorId).FullName;
                }
			}
        }
    }
}
