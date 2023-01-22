using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Networx.Models
{
    public class EmployeeViewModel
    {
        public string Id { get; set; }
        public int EmployeeId { get; set; }
        public string Name => FirstName +" "+LastName;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public EmployeeStatusViewModel EmployeeStatus { get; set; }
    }

    public class EmployeeStatusViewModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }
}