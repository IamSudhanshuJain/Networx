using System;

namespace NetworxDataLayer.Models
{
    public class EmployeeModel
    {
        public string Id { get; set; }
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public EmployeeStatusModel EmployeeStatus { get; set; }
    }
   
}