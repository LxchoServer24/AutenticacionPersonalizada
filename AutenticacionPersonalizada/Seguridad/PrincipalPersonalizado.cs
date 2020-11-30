using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Threading.Tasks;
using System.Security.Principal;

namespace AutenticacionPersonalizada.Seguridad
{
    public class PrincipalPersonalizado : IPrincipal
    {
        public bool IsInRole(string role)
        {
            throw new NotImplementedException();
        }

        public IIdentity Identity { get; private set; }

        public IdentityPersonalizado MiIdentidadPersonalizada
        {
            get { return (IdentityPersonalizado)Identity; }
            set { Identity = value; }
        }

        public PrincipalPersonalizado(IdentityPersonalizado identity)
        {
            Identity = identity;
        }
    }
}