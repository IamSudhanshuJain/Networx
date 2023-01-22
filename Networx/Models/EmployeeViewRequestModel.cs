using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Networx.Models
{
    public class EmployeeViewRequestModel
    {
        public string Id { get; set; }
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Status { get; set; }
    }

}