﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TF.ENTITIES
{
    public class PuestoTrabajo
    {
        public int IdPuesto { get; set; }

        public string NombrePuesto { get; set; }
        public string AreaEmpresa { get; set; }

        public DateTime FechaIngreso { get; set; }
        public DateTime FechaEgreso { get; set; }


        // Puesto Empleado

        public int IdEmpleado { get; set; }
        public int IdEmpresa { get; set; }


        //vista Puesto de Trabajo
        public string DNI { get; set; }

        public string NombreEmpleado { get; set; }

        public DateTime FechaIngreso2 { get; set; }

        public string CUITEMPRESAPUESTO { get; set; }

    }
}
