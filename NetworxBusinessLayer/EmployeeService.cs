using System;
using System.Collections.Generic;
using System.Linq;
using NetworxBusinessLayer.Models;
using NetworxDataLayer.Entities;
using NetworxDataLayer.Interface;
using NetworxDataLayer.Models;

namespace NetworxBusinessLayer
{
    public class EmployeeService
    {
        private readonly IRepository<Employee> _employeeRepository;
        public EmployeeService(IRepository<Employee> employeeRepository)
        {
            _employeeRepository = employeeRepository;

        }
        public List<EmployeeModel> GetAllEmployees(bool IsAdminAccess, string Id)
        {

            var getEmployees = _employeeRepository.GetAll().Where(x=>x.IsActive);
            var IsAdmin = IsAdminAccess;
            if (!IsAdmin)
            {
                getEmployees = getEmployees.Where(x=>x.Id == Id);
            }
            var mappedEmployees = getEmployees.Select(x => new EmployeeModel()
            {
                Id = x.Id,
                EmployeeId = x.EmployeeId,
                FirstName = x.FirstName,
                LastName = x.LastName,
                Email = x.Email,
                EmployeeStatus = new EmployeeStatusModel() { Id = x.Status.Id, Name = x.Status.Name }
           }).ToList();
            return mappedEmployees;
        }
        public EmployeeModel GetEmployee(string Id)
        {
            EmployeeModel mappedEmployee = null;
            var getEmployee = _employeeRepository.GetById(Id);
            if (getEmployee.IsActive)
            {
                mappedEmployee = new EmployeeModel()
                {
                    Id = getEmployee.Id,
                    EmployeeId = getEmployee.EmployeeId,
                    FirstName = getEmployee.FirstName,
                    LastName = getEmployee.LastName,
                    Email = getEmployee.Email,
                    EmployeeStatus = new EmployeeStatusModel() { Id = getEmployee.Status.Id, Name = getEmployee.Status.Name }

                };
            }
            return mappedEmployee;

        }

        public bool DeleteEmployee(string Id)
        {
            try
            {
                var getEmployee = _employeeRepository.GetById(Id);
                if (getEmployee != null)
                {
                    getEmployee.IsActive = false;
                    _employeeRepository.Update(getEmployee);
                    return true;
                }
                return false;
            }
            catch (System.Exception ex )
            {
                return false;
            }
        }

        public void UpdateEmployee(EmployeeRequestModel employeeRequestModel)
        {
            var employee = _employeeRepository.GetById(employeeRequestModel.Id);
            if (employee != null)
            {
                employee.FirstName = employeeRequestModel.FirstName;
                employee.LastName= employeeRequestModel.LastName;
                employee.Email= employeeRequestModel.Email;
                employee.EmployeeStatusId= employeeRequestModel.Status;
               _employeeRepository.Update(employee);
            }
        }
        public void InsertEmployee(EmployeeRequestModel employeeRequestModel)
        {
            var employee = new Employee()
            {
                Id =Guid.NewGuid().ToString(),
                EmployeeId = employeeRequestModel.EmployeeId,
                FirstName = employeeRequestModel.FirstName,
                LastName = employeeRequestModel.LastName,
                Email = employeeRequestModel.Email,
                IsActive=true,
                EmployeeStatusId = employeeRequestModel.Status
            };
            _employeeRepository.Insert(employee);
        }
    }
}
