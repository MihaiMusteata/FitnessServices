using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using System.Web.Security;
using FitnessServices.web.Models;

namespace FitnessServices.web.Controllers
{
     public class AccountController : Controller
     {
          FitnessServices_DBEntities db = new FitnessServices_DBEntities();
          // GET: Account
          public ActionResult Login()
          {
               return View();
          }
          public ActionResult Signup()
          {
               return View();
          }

          [HttpPost]
          public ActionResult Login(UsersTable userinfo)
          {
               bool userExist = db.UsersTables.Any(user => user.Email == userinfo.Email && user.Password == userinfo.Password);
               UsersTable u = db.UsersTables.FirstOrDefault(user => user.Email == userinfo.Email && user.Password == userinfo.Password);

               if (userExist)
               {
                    FormsAuthentication.SetAuthCookie(u.Username, false);
                    return RedirectToAction("Index", "Home");
               }

               ModelState.AddModelError("", "Invalid Email or Password");

               return View();
          }
          [HttpPost]
          public ActionResult Signup(UsersTable userinfo)
          {
               //userinfo.Password = Crypto.Hash(userinfo.Password, "SHA256");
               db.UsersTables.Add(userinfo);
               db.SaveChanges();
               return RedirectToAction("Login");
          }
          public ActionResult Signout()
          {
               FormsAuthentication.SignOut();
               return RedirectToAction("Login");
          }
     }
}