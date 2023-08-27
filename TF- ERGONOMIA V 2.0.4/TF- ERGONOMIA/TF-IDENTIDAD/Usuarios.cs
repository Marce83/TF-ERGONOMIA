using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TF.ENTITIES
{
    public class Usuarios
    {
        public int IdUsuario { get; set; }
        public string Usuario { get; set; }
        public string Clave { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cargo { get; set; }
        public string Correo { get; set; }
    }
}
