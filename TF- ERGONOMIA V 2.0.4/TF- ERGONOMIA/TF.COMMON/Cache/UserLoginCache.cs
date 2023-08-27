using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TF.COMMON.Cache
{
    public static class UserLoginCache
    {
        public static int IdUsuario { get; set; }
        public static string Usuario { get; set; }
        public static string Clave { get; set; }
        public static string Nombre { get; set; }
        public static string Apellido { get; set; }
        public static string Cargo { get; set; }
        public static string Correo { get; set; }
    }
}
