using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TF.DAC;
using TF.ENTITIES;

namespace TF.BC
{
    public class NioshBC
    {

        public int InsertNioshPORTADABC(Niosh oNiosh)
        {
            NioshDAC oNioshDAC = new NioshDAC();
            return oNioshDAC.InsertNioshPORTADADAC(oNiosh);
        }
        public DataTable NioshMaxIDBC(Niosh oNiosh)
        {
            NioshDAC oNioshDAC = new NioshDAC();
            DataTable dt = oNioshDAC.NioshMaxIdDAC(oNiosh);
            return dt;
        }
        public int UpdateNiosh1BC(Niosh oNiosh)
        {
            NioshDAC oNioshDAC = new NioshDAC();
            return oNioshDAC.UpdateNiosh1DAC(oNiosh);
        }

        public DataTable NioshTablaADestinoBC(Niosh oNiosh)
        {
            NioshDAC oNioshDAC = new NioshDAC();
            DataTable dt = oNioshDAC.NioshTablaADestinoDAC(oNiosh);
            return dt;
        }

        public DataTable NioshTablaAInicialBC(Niosh oNiosh)
        {
            NioshDAC oNioshDAC = new NioshDAC();
            DataTable dt = oNioshDAC.NioshTablaAInicialDAC(oNiosh);
            return dt;
        }

        public DataTable NioshTablaCMDestinoBC(Niosh oNiosh)
        {
            NioshDAC oNioshDAC = new NioshDAC();
            DataTable dt = oNioshDAC.NioshTablaCMDestinoDAC(oNiosh);
            return dt;
        }

        public DataTable NioshTablaCMnicialBC(Niosh oNiosh)
        {
            NioshDAC oNioshDAC = new NioshDAC();
            DataTable dt = oNioshDAC.NioshTablaCMInicioDAC(oNiosh);
            return dt;
        }

        public DataTable Niosh_ResultadoBC(Niosh oNiosh)
        {
            NioshDAC oNioshDAC = new NioshDAC();
            DataTable dt = oNioshDAC.Niosh_ResultadoDAC(oNiosh);
            return dt;
        }


    }
}
