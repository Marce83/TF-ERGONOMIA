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
    public class RebaBC
    {

        public int InsertRebaPORTADABC(Reba oReba)
        {
            RebaDAC oRebaDAC = new RebaDAC();
            return oRebaDAC.InsertRebaPORTADADAC(oReba);
        }
        public DataTable RebaMaxIDBC(Reba oReba)
        {
            RebaDAC oRebaDAC = new RebaDAC();
            DataTable dt = oRebaDAC.RebaMaxIdDAC(oReba);
            return dt;
        }
        public int UpdateReba1BC(Reba oReba)
        {
            RebaDAC oRebaDAC = new RebaDAC();
            return oRebaDAC.UpdateReba1DAC(oReba);
        }

        public DataTable Reba_ResultadoBC(Reba oReba)
        {
            RebaDAC oRebaDAC = new RebaDAC();
            DataTable dt = oRebaDAC.Reba_ResultadoDAC(oReba);
            return dt;
        }

        public DataTable RebaTablaABC(Reba oReba)
        {
            RebaDAC oRebaDAC = new RebaDAC();
            DataTable dt = oRebaDAC.RebaTablaADAC(oReba);
            return dt;
        }

        public DataTable RebaTablaBBC(Reba oReba)
        {
            RebaDAC oRebaDAC = new RebaDAC();
            DataTable dt = oRebaDAC.RebaTablaBDAC(oReba);
            return dt;
        }


        public DataTable RebaTablaCRdoBC(Reba oReba)
        {
            RebaDAC oRebaDAC = new RebaDAC();
            DataTable dt = oRebaDAC.RebaTablaCRdoDAC(oReba);
            return dt;
        }








    }
}
