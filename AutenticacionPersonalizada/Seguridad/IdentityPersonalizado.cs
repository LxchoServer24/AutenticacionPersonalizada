using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Security.Principal;

namespace AutenticacionPersonalizada.Seguridad
{
    public class IdentityPersonalizado : IIdentity
    {
        public string Name
        {
            get { return loger; }
        }
        public string AuthenticationType
        {
            get { return Identity.AuthenticationType; }
        }

        public bool IsAuthenticated
        {
            get { return Identity.IsAuthenticated; }
        }

        public int id { get; set; }
        public string loger { get; set; }
        public string pasword { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }

        public IIdentity Identity { get; set; }

        public IdentityPersonalizado(IIdentity identity)
        {
            this.Identity = identity;
            var us = Membership.GetUser(identity.Name) as UsuarioMembership;

            id = us.id;
            loger = us.loger;
            pasword = us.pasword;
            nombre = us.nombre;
            apellidos = us.apellidos;
        }
    }
}