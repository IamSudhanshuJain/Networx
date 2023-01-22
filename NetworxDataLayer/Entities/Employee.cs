using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworxDataLayer.Entities
{
    [Table("tbl_employee_m")]
    public class Employee : BaseEntity
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public bool IsAdmin { get; set; }
        public bool IsActive { get; set; }
        public string EmployeeStatusId { get; set; }

        [ForeignKey("EmployeeStatusId")]
        public virtual EmployeeStatus Status { get; set; }
    }
}
