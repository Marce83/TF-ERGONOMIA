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
        public int UpdateRula1BC(Reba oReba)
        {
            RebaDAC oRebaDAC = new RebaDAC();
            return oRebaDAC.UpdateReba1DAC(oReba);
        }







    }
}
