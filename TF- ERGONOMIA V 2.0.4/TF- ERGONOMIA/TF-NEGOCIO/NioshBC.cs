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

        //public DataTable Reba_ResultadoBC(Reba oReba)
        //{
        //    RebaDAC oRebaDAC = new RebaDAC();
        //    DataTable dt = oRebaDAC.Reba_ResultadoDAC(oReba);
        //    return dt;
        //}

        //public DataTable RebaTablaABC(Reba oReba)
        //{
        //    RebaDAC oRebaDAC = new RebaDAC();
        //    DataTable dt = oRebaDAC.RebaTablaADAC(oReba);
        //    return dt;
        //}

        //public DataTable RebaTablaBBC(Reba oReba)
        //{
        //    RebaDAC oRebaDAC = new RebaDAC();
        //    DataTable dt = oRebaDAC.RebaTablaBDAC(oReba);
        //    return dt;
        //}


        //public DataTable RebaTablaCRdoBC(Reba oReba)
        //{
        //    RebaDAC oRebaDAC = new RebaDAC();
        //    DataTable dt = oRebaDAC.RebaTablaCRdoDAC(oReba);
        //    return dt;
        //}








    }
}
