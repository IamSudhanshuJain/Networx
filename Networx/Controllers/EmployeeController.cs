using System;
using System.Collections.Generic;
using System.Net;
using System.Web.Mvc;
using AutoMapper;
using Networx.Models;
using NetworxBusinessLayer;
using NetworxBusinessLayer.Interfaces;
using NetworxBusinessLayer.Models;

namespace Networx.Controllers
{
    public class EmployeeController : SessionController // Custom Controller
    {
        private readonly IEmployeeService _employeeService;

        // GET: Employee
        public EmployeeController(IEmployeeService employeeService, IMapper mapper): base(mapper)
        {
            _employeeService = employeeService;
        }
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult EditEmployee(EmployeeViewRequestModel employee)
        {
            var EmployeeRequestModel = _mapper.Map<EmployeeRequestModel>(employee);
            _employeeService.UpdateEmployee(EmployeeRequestModel);
            return Json("Data Updated Successfully",JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult AddEmployeePopup()
        {
            if (GetSession())
            {
                EmployeeViewModel newEmployee= new EmployeeViewModel();
                return PartialView("AddEditEmployee", newEmployee);
            }
            return RedirectToAction("Index","Home");
        }

        [HttpPost]
        public ActionResult SaveEmployee(EmployeeViewRequestModel employee)
        {
            var EmployeeRequestModel = _mapper.Map<EmployeeRequestModel>(employee);
            _employeeService.InsertEmployee(EmployeeRequestModel);
            return Json("Employee Record Save Successfully", JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult GetAllEmployees()
        {
            if (GetSession())
            {
                var getAllEmployees = _mapper.Map<List<EmployeeViewModel>>(_employeeService.GetAllEmployees(IsAdmin(), GetId()));
                return PartialView("_GetAllEmployees", getAllEmployees);
            }
            return RedirectToAction("Index");

        }

        [HttpGet]
        public ActionResult GetEmployee(string Id)
        {
            if (GetSession())
            {
                var result = _mapper.Map<EmployeeViewModel>(_employeeService.GetEmployee(Id));
                if (result != null)
                {
                    return PartialView("AddEditEmployee",result);
                }
            }
            return HttpNotFound();
        }

        [HttpPost]
        public ActionResult DeleteEmployee(string Id)
        {
            try
            {
                var IsDeleted = _employeeService.DeleteEmployee(Id);
                if (IsDeleted)
                {
                    return Json(IsDeleted, JsonRequestBehavior.AllowGet);
                }
            }
            catch (Exception ex)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest, "Server failed to delete the resource");
            }
            return HttpNotFound();
        }

    }
}