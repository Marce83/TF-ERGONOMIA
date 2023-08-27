using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TF.ENTITIES
{
    public class Empleados
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string DNI { get; set; }
        public string Genero { get; set; }
        public string PuestoDeTrabajo { get; set; }
        public float Peso { get; set; }
        public float Altura { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime FechaEgreso { get; set; }
        public int IdEmpresa { get; set; }
    }
}
