using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Web.Mvc;
using System.Web.Security;
using AutenticacionPersonalizada.Models;
using Newtonsoft.Json;
using System.Net.Http;

namespace AutenticacionPersonalizada.Controllers
{
    public class CitasController : Controller    //Controller
    {
        // GET: Citas
        //AUTENTICO INDEX
        /*public ActionResult Index()
        {
            return View(); 
        }*/
        //index con la 'primera prueba de api web
        /*public ActionResult Index()
        {
            //return View();
            using (usrEntities entities = new usrEntities())
            {
                return Json(entities.cita.ToList(), JsonRequestBehavior.AllowGet);
            }
        }*/
        //INDEX con las api's 
        // GET: Student
        public ActionResult Index()
        {
            List<cita> lista = new List<cita>();
            using (usrEntities3 entities = new usrEntities3())
            {
                lista = entities.cita.ToList();
            }  
            // IEnumerable<cita> cita = null;

            /*using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:44336/api/Citas");
                //HTTP GET
                var responseTask = client.GetAsync("cita");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<cita>>();
                    readTask.Wait();

                    cita = readTask.Result;
                }
                else //web api sent error response 
                {
                    //log response status here..

                    cita = Enumerable.Empty<cita>();

                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }*/
            return View(lista);    //return View();
        }

        /*public JsonResult GetEvents() 
        {
            using (usrEntities entities = new usrEntities())
            {
                var events = entities.cita.ToList();
                return new JsonResult { Data = events, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
            }
        }*/
    }
}