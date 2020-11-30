using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using AutenticacionPersonalizada.Models;

namespace AutenticacionPersonalizada.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(usuario model)
        {
            
            if (Membership.ValidateUser(model.loger, model.pasword))
            {
                FormsAuthentication.RedirectFromLoginPage(model.loger, false);
                return null;
            }
            return View(model);
        }
        [HttpGet]
        public ActionResult Logoff()  //LogOut 
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index");
        }
    }
}