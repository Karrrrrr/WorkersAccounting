using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WorkersAccounting.Models
{
    public partial class Worker
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string ServiceNumber { get; set; }
        public string Position { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime EmploymentDate { get; set; }
        public DateTime? DismissalDate { get; set; }
        public bool? Status { get; set; }
        public int DepartmentId { get; set; }

        public virtual Department Department { get; set; }

        public string EntryStatus
        {
            get
            {
                return Status == true ? "Действующая" : "Закрытая";
            }
        }

        public string DepartmentName
        {
            get
            {
                using (WorkersAccountingContext db = new WorkersAccountingContext())
                {
                    return db.Department.Find(DepartmentId).Name;
                }
            }
        }
    }
}
