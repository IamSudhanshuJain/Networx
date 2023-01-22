using System.Collections.Generic;
using System.Web.Mvc;
using AutoMapper;
using Networx.Models;
using NetworxBusinessLayer;

namespace Networx.Controllers
{
    public class LoginController : SessionController // Custom Controller
    {
        private readonly EmployeeService _employeeService;
        private readonly AuthenticationService _authenticationService;

        public LoginController(AuthenticationService authenticationService, EmployeeService employeeService, IMapper mapper) : base(mapper)
        {
            _employeeService = employeeService;
            _authenticationService = authenticationService;


        }
        public ActionResult Index()
        {
            if (GetSession())
            {
                return RedirectToAction("Dashboard");
            }
            return View();
        }

        public ActionResult Login(UserModel model)
        {
            var getAuthenticatedResult = _authenticationService.ValidateAuthenticationAndSetAccess(model.UserName, model.Password);
            if (getAuthenticatedResult!=null)
            {
                SetSession(model.UserName, getAuthenticatedResult);
                return RedirectToAction("Dashboard");
            }
            Session["Message"] = "Username and password is not correct";
            return RedirectToAction("Index");

        }

        public ActionResult Logout()
        {
            Session["Message"] = string.Empty;
            CheckoutSession();
            return RedirectToAction("Index");
        }

        public ActionResult Dashboard()
        {
            if (GetSession())
            {
                var getAllEmployees = _mapper.Map<List<EmployeeViewModel>>(_employeeService.GetAllEmployees(IsAdmin(), GetId()));
                return View(getAllEmployees);
            }
            return RedirectToAction("Index");

        }
    }
}