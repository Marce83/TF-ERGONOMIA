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
    public class RulaBC
    {


        public int InsertRulaFormPORTADABC(Rula oRula)
        {
            RulaDAC oRulaDAC = new RulaDAC();
            return oRulaDAC.InsertRulaFormPORTADADAC(oRula);
        }

        public int UpdateRula1BC(Rula oRula)
        {
            RulaDAC oRulaDAC = new RulaDAC();
            return oRulaDAC.UpdateRula1DAC(oRula);
        }

        public int UpdateRula2BC(Rula oRula)
        {
            RulaDAC oRulaDAC = new RulaDAC();
            return oRulaDAC.UpdateRula2DAC(oRula);
        }


        public int UpdateRula3BC(Rula oRula)
        {
            RulaDAC oRulaDAC = new RulaDAC();
            return oRulaDAC.UpdateRula3DAC(oRula);
        }


        public DataTable RULABC_GetAllBC()
        {
            RulaDAC oRulaDAC = new RulaDAC();
            DataTable dt = oRulaDAC.RULA_GetAll();
            return dt;
        }

        public Rula ObtenerRulaidBC(long CUIT)
        {
            RulaDAC oRulaDAC = new RulaDAC();
            return oRulaDAC.ObtenerRulaidDAC(CUIT);
        }


        public DataTable RULACONSULTARRESULTADOIDBC(Rula oRula)
        {
            RulaDAC oRulaDAC = new RulaDAC();
            DataTable dt = oRulaDAC.ConsultarRulaResultadoidDAC(oRula);
            return dt;
        }

        public DataTable RulaIdMaxBC(Rula oRrula)
        {
            RulaDAC oRulaDAC = new RulaDAC();
            DataTable dt = oRulaDAC.RulaIdMaxDAC(oRrula);
            return dt;
        }

        public DataTable RulaTablaARdoBC(Rula oRula)
        {
            RulaDAC oRulaDAC = new RulaDAC();
            DataTable dt = oRulaDAC.RulaTablaARdoDAC(oRula);
            return dt;
        }




    }
}
