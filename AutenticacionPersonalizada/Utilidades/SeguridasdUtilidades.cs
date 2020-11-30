using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace AutenticacionPersonalizada.Utilidades
{
    public class SeguridasdUtilidades
    {
        public static String GetSha1(String texto)
        {
            if (texto == null)
            {
                return "";
            }
            var sha = SHA1.Create();
            UTF8Encoding encoding = new UTF8Encoding();
            byte[] datos;
            StringBuilder builder = new StringBuilder();
            datos = sha.ComputeHash(encoding.GetBytes(texto));
            for (int i = 0; i < datos.Length; i++)
            {
                builder.AppendFormat("{0:x2}", datos[i]);
            }
            return builder.ToString();
        }
    }
}