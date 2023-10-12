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


        public double HMNioshD { get; set; }
        public double HMNioshI { get; set; }
        public double VMNioshD { get; set; }
        public double VMNioshI { get; set; }
        public double DMNioshD { get; set; }
        public double AMNioshD { get; set; }
        public double AMNioshI { get; set; }
        public double FMNioshD { get; set; }
        public double FMNioshI { get; set; }
        public double CMRNioshD { get; set; }
        public double CMRNioshI { get; set; }
        public int Duraciontarea { get; set; }
        public int CalidadAgarreD { get; set; }
        public int CalidadAgarreI { get; set; }
        public int LCNiosh { get; set; }
        public int FrecuenciaNiosh { get; set; }
        public int DistanciaVerticalD { get; set; }
        public int DistanciaVerticali { get; set; }

        // Tabla A NIOSH



        public int FrecuenciaFM { get;set; }
        public int DuracionFM { get; set; }
        public int DistanciaVerticalFM { get; set; }
        public int ValorFM { get; set; }

        public int FrecuenciaFMi { get; set; }
        public int DuracionFMi { get; set; }
        public int DistanciaVerticalFMi { get; set; }
        public int ValorFMi { get; set; }





    }








}

