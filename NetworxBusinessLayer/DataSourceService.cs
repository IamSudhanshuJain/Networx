using System.Collections.Generic;
using System.Linq;
using NetworxDataLayer.Entities;
using NetworxDataLayer.Interface;
using NetworxDataLayer.Models;

namespace NetworxBusinessLayer
{
    public class DataSourceService
    {
        private readonly IRepository<EmployeeStatus> _employeeStatusRepository;
        public DataSourceService(IRepository<EmployeeStatus> employeeStatusRepository)
        {
            _employeeStatusRepository = employeeStatusRepository;
        }
        public IEnumerable<StatusModel> GetEmployeeStatus() {
            var getAllStatus = _employeeStatusRepository.GetAll();
            return getAllStatus.Select(x => new StatusModel()
            {
                Id = x.Id,
                Name = x.Name

            }).ToList();
        }
    }
}
