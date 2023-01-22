using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using NetworxDataLayer.Entities;

namespace Networx.Controllers
{
    public class SessionController : Controller
    {
        protected readonly IMapper _mapper;
        public SessionController(IMapper mapper)
        {
            _mapper = mapper;
        }
        // GET: Session
        protected bool GetSession()
        {
            return Session["IsAuthenticate"] != null ? bool.Parse(Session["IsAuthenticate"].ToString()) : false;
        }
        protected bool IsAdmin()
        {
            return Session["IsAdmin"] != null? bool.Parse(Session["IsAdmin"].ToString()):false;
        }
        protected string GetId()
        {
            return Session["Id"] != null ? Session["Id"].ToString() : string.Empty;
        }

        protected void SetSession(string userName, AuthenticatedEntity authenticatedEntity)
        {
            Session["Id"] = authenticatedEntity.Id;
            Session["IsAdmin"] = authenticatedEntity.IsAdmin =="1"? true:false;
            Session["UserName"] = userName;
            Session["IsAuthenticate"] = true;
        }
        protected void CheckoutSession()
        {
            Session["Id"] = string.Empty;
            Session["IsAdmin"] = false;
            Session["UserName"] = string.Empty; 
            Session["IsAuthenticate"] = false;
        }
    }
}