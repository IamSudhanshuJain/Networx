using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using Networx.Models;
using NetworxBusinessLayer;

namespace Networx.Controllers
{
    public class DataSourceController : SessionController // Custom Controller
    {
        private readonly DataSourceService _dataSourceService;

        // GET: Employee
        public DataSourceController(DataSourceService dataSourceService, IMapper mapper) : base(mapper)
        {
            _dataSourceService = dataSourceService;
        }
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult GetAllStatus()
        {
            var getAllEmployees = _mapper.Map<List<StatusViewModel>>(_dataSourceService.GetEmployeeStatus());
            return Json(getAllEmployees, JsonRequestBehavior.AllowGet);
        }


    }
}