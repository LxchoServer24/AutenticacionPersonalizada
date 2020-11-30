using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutenticacionPersonalizada.Models;

namespace AutenticacionPersonalizada.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        usrEntities3 db = new usrEntities3();
        // GET: Home
        public ActionResult Index()
        {
            var datos = db.usuario;
            return View(datos);
        }
        public ActionResult Users()
        {
            var datos = db.usuario;
            return View(datos);
        }
    }
}