using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using AutenticacionPersonalizada.Models;
using AutenticacionPersonalizada.Utilidades;
using System.ComponentModel.DataAnnotations;

namespace AutenticacionPersonalizada.Seguridad
{
    public class UsuarioMembership:MembershipUser
    {
        public int id { get; set; }
        [Display(Name="Usuario")]
        public string loger { get; set; }
        [Display(Name = "Contraseña")]
        public string pasword { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }

        public UsuarioMembership(usuario us)
        {
            id = us.id;
            loger = us.loger;
            pasword = SeguridasdUtilidades.GetSha1(us.pasword);
            nombre = us.nombre;
            apellidos = us.apellidos;
        }
    }
}