using NetworxBusinessLayer.Models;
using NetworxDataLayer.Entities;
using NetworxDataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworxBusinessLayer.Interfaces
{
    public interface IEmployeeService
    {
         List<EmployeeModel> GetAllEmployees(bool IsAdminAccess, string Id);

         EmployeeModel GetEmployee(string Id);
         bool DeleteEmployee(string Id);

         void UpdateEmployee(EmployeeRequestModel employeeRequestModel);
         void InsertEmployee(EmployeeRequestModel employeeRequestModel);
    }
}
