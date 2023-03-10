using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FitnessServices.BusinessLogic.Interfaces;
using FitnessServices.Domain.Entities.User;

namespace FitnessServices.web.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        private  readonly ISession _sessionBL;
        public LoginController()
        {
             BusinessLogic.BusinessLogic bl = new BusinessLogic.BusinessLogic();
             _sessionBL = bl.GetSessionBL();

        }
        public ActionResult Index()
        {
             ULoginData loginData = new ULoginData();
             loginData.Credential = "test";
             loginData.Password = "password";
             loginData.LoginIp = "ip";
             loginData.LoginDateTime = DateTime.Now;
             string cookies = _sessionBL.GetCookies(loginData);
             if(_sessionBL.ValidateCookies(cookies))
             {

             }
               return View();
        }
    }
}