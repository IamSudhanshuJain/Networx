using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworxDataLayer.Entities
{
    [Table("tbl_employee_status_m")]
    public class EmployeeStatus : BaseEntity
    {
        public string Name { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }

    }
}
