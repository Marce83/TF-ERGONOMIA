using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TF.ENTITIES
{
    public class Reba
    {
        //Portada

        public string CUITReba { get; set; }
        public string PuestoDeTrabajoReba { get; set; }
        public string DniEmpleadoReba { get; set; }
        public string EmpleadoReba { get; set; }
        public string EmpresaReba { get; set; }

        //Proceso de Carga

        public int cargaIdReba { get; set; }

        //Grupo A

        public int CuelloReba { get; set; }
        public int PiernasReba { get; set; }
        public int TroncoReba { get; set; }
        public int CargafuerzaReba { get; set; }


        //Grupo B

        public int AntebrazoReba { get; set; }
        public int MunecaReba { get; set; }
        public int BrazoReba { get; set; }
        public int AgarreReba { get; set; }

        //Otras variables

        public int ActividadReba { get; set; }

        //Procesos de Obtención Resultado Final



        // Resultados VALOR Tablas A, B y C //

        public int ValorTablaAReba { get; set; }
        public int ValorTablaBReba { get; set; }
        public int ValorTablaCReba { get; set; }


        public int ValorA { get; set; }
        public int ValorB { get; set; }

    }








}

