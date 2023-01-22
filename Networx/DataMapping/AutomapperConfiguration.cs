using AutoMapper;
using Networx.Models;
using NetworxBusinessLayer.Models;
using NetworxDataLayer.Models;

namespace Networx.DataMapping
{
    public class AutomapperConfiguration : Profile
    {
        public AutomapperConfiguration()
        {
            CreateMap<EmployeeModel, EmployeeViewModel>();
            CreateMap<StatusModel, StatusViewModel>();
            CreateMap<EmployeeViewRequestModel, EmployeeRequestModel>();
            CreateMap<EmployeeStatusModel, EmployeeStatusViewModel>();
        }
    }
}