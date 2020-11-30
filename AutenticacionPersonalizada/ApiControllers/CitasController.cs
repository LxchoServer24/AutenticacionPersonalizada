using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using AutenticacionPersonalizada.Models;
using Newtonsoft.Json.Linq;

namespace AutenticacionPersonalizada.ApiControllers
{
    public class CitasController : ApiController
    {

        //autentico apicontroller
        // GET api/<controller>
      /*  public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }*/
        /*
        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody] string value)
        {      
        }
        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }*/



        //APICONTROLER PERSONALIZADO
        [ActionName("vercita")]
        public HttpResponseMessage Get()
        {
            using(usrEntities3 entities = new usrEntities3())
            {
                DateTime hoy = DateTime.Now;
                var eventos = (from cita in entities.cita select new { title = cita.titulo, start = cita.inicio, tipo=cita.TiposCitas.nombre }).ToList();
                
                return new HttpResponseMessage()
                {
                    Content = new StringContent(JArray.FromObject(eventos).ToString(), Encoding.UTF8, "application/json")
                };
            }
        }
        /*
        // GET api/<controller>/5
        public cita Get(int id)
        {
            using (usrEntities entities = new usrEntities())
            {
                return entities.cita.FirstOrDefault(e => e.id == id);
            }
        }

        // POST api/<controller>
        public void Post([FromBody] string value)
        {
        }
        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }*/



        //APICONTROLER DE LA PAGINA CHIDA
        //GET
        /*public IHttpActionResult GetAllCitas()
        {
            IList<cita> cita = null;

            if (cita.Count == 0)
            {
                return Ok("prueba...,");
            }
            
            return Ok("hola");
        }*/

        //POST
        [ActionName("agregarcita")]
        public IHttpActionResult PostNewCitas(cita cita)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid model");

            using (var ctx = new usrEntities3())
            {
                ctx.cita.Add(new cita()
                {
                    Id = Guid.NewGuid(),
                    titulo = cita.titulo,
                    inicio= cita.inicio,
                    estatus = "active",
                    IdTipoCita = cita.IdTipoCita
                });

                ctx.SaveChanges();
            }

            return Ok();
        }

        //PUT
        [ActionName("editarcita")]
        public IHttpActionResult Put(cita cita)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid data");

            using (var ctx = new usrEntities3())
            {
                var existingcita = ctx.cita.Where(s =>s.Id == cita.Id).FirstOrDefault<cita>();

                if (existingcita != null)
                {
                    existingcita.titulo = cita.titulo;
                    existingcita.inicio = cita.inicio;
                    existingcita.estatus = cita.estatus;
                    existingcita.IdTipoCita = cita.IdTipoCita;

                    ctx.SaveChanges();
                }
                else
                {
                    return NotFound();
                }
            }
            return Ok();
        }
        //DELETE
        [HttpDelete]
        [ActionName("borrarcita")]
       
        public IHttpActionResult Delete(Guid ? Id)
        {
            if (Id == null || Id == Guid.Empty)
                return BadRequest("Not a valid appointment id");

            using (var ctx = new usrEntities3())
            {
                var cita = ctx.cita
                    .Where(s => s.Id == Id)
                    .FirstOrDefault();
                if (cita != null)
                {
                    ctx.Entry(cita).State = System.Data.Entity.EntityState.Deleted;
                    ctx.SaveChanges();
                }
                else
                {
                    return NotFound();
                }
            }

            return Ok();
        }
    }
}