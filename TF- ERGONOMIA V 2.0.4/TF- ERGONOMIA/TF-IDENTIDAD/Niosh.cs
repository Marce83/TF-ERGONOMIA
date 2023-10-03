using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TF.ENTITIES
{
    public class Niosh
    {
        //Portada

        public string CUITNiosh { get; set; }
        public string PuestoDeTrabajoNiosh { get; set; }
        public string DniEmpleadoNiosh { get; set; }
        public string EmpleadoNiosh { get; set; }
        public string EmpresaNiosh { get; set; }

        //Proceso de Carga

        public int cargaIdNiosh { get; set; }

        //Datos de Carga Niosh

        public int LCNiosh { get; set; }
        public int HMNiosh { get; set; }
        public int VMNiosh { get; set; }
        public int DMNiosh { get; set; }
        public int AMNiosh { get; set; }
        public int FMNiosh { get; set; }
        public int CMRNiosh { get; set; }
        public string Duraciontarea { get; set; }
        public int FrecuenciaNiosh { get; set; }
        public string CADNiosh { get; set; }
        public int PesoCargaNiosh { get; set; }





        ////Grupo B

        //public int AntebrazoReba { get; set; }
        //public int MunecaReba { get; set; }
        //public int BrazoReba { get; set; }
        //public int AgarreReba { get; set; }

        ////Otras variables

        //public int ActividadReba { get; set; }

        ////Procesos de Obtención Resultado Final



        //// Resultados VALOR Tablas A, B y C //

        //public int ValorTablaAReba { get; set; }
        //public int ValorTablaBReba { get; set; }
        //public int ValorTablaCReba { get; set; }


        //public int ValorA { get; set; }
        //public int ValorB { get; set; }

    }








}

