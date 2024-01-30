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
    public class EstadisticaBC
    {

        public DataTable ContEmpresasBC()
        {
            EstadisticaDAC oEstadisticaDAC = new EstadisticaDAC();
            DataTable dt = oEstadisticaDAC.ContEmpresasDAC();
            return dt;
        }
        public DataTable ContEmpresasprovBC()
        {
            EstadisticaDAC oEstadisticaDAC = new EstadisticaDAC();
            DataTable dt = oEstadisticaDAC.ContEmpresasprovDAC();
            return dt;
        }
        public DataTable ContEmpresasLocBC()
        {
            EstadisticaDAC oEstadisticaDAC = new EstadisticaDAC();
            DataTable dt = oEstadisticaDAC.ContEmpresasLocDAC();
            return dt;
        }
        public DataTable ContEmpleadosBC()
        {
            EstadisticaDAC oEstadisticaDAC = new EstadisticaDAC();
            DataTable dt = oEstadisticaDAC.ContEmpleadosDAC();
            return dt;
        }
        public DataTable ContEmpleadosempresaBC()
        {
            EstadisticaDAC oEstadisticaDAC = new EstadisticaDAC();
            DataTable dt = oEstadisticaDAC.ContEmpleadosempresaDAC();
            return dt;
        }
        public DataTable ContJSSBC()
        {
            EstadisticaDAC oEstadisticaDAC = new EstadisticaDAC();
            DataTable dt = oEstadisticaDAC.ContJSSDAC();
            return dt;
        }
        public DataTable ContNIOSHBC()
        {
            EstadisticaDAC oEstadisticaDAC = new EstadisticaDAC();
            DataTable dt = oEstadisticaDAC.ContNIOSHDAC();
            return dt;
        }
        public DataTable ContREBABC()
        {
            EstadisticaDAC oEstadisticaDAC = new EstadisticaDAC();
            DataTable dt = oEstadisticaDAC.ContREBADAC();
            return dt;
        }
        public DataTable ContRULABC()
        {
            EstadisticaDAC oEstadisticaDAC = new EstadisticaDAC();
            DataTable dt = oEstadisticaDAC.ContRULADAC();
            return dt;
        }
        public DataTable ContNIOSHPersonBC(EstadisticasPersonales oEstadisticasPersonales)
        {
            EstadisticaDAC oEstadisticaDAC = new EstadisticaDAC();
            DataTable dt = oEstadisticaDAC.ContNIOSHPersonDAC(oEstadisticasPersonales);
            return dt;
        }
        public DataTable ContREBAPersonBC(EstadisticasPersonales oEstadisticasPersonales)
        {
            EstadisticaDAC oEstadisticaDAC = new EstadisticaDAC();
            DataTable dt = oEstadisticaDAC.ContREBAPersonDAC(oEstadisticasPersonales);
            return dt;
        }
        public DataTable ContRULAPersonBC(EstadisticasPersonales oEstadisticasPersonales)
        {
            EstadisticaDAC oEstadisticaDAC = new EstadisticaDAC();
            DataTable dt = oEstadisticaDAC.ContRULAPersonDAC(oEstadisticasPersonales);
            return dt;
        }
        public DataTable ContJSSPersonBC(EstadisticasPersonales oEstadisticasPersonales)
        {
            EstadisticaDAC oEstadisticaDAC = new EstadisticaDAC();
            DataTable dt = oEstadisticaDAC.ContJSSPersonDAC(oEstadisticasPersonales);
            return dt;
        }
        public DataTable PastelRulaPersonBC(EstadisticasPersonales oEstadisticasPersonales)
        {
            EstadisticaDAC oEstadisticaDAC = new EstadisticaDAC();
            DataTable dt = oEstadisticaDAC.PastelRulaPersonDAC(oEstadisticasPersonales);
            return dt;
        }
        public DataTable HistoRulaPersonBC(EstadisticasPersonales oEstadisticasPersonales)
        {
            EstadisticaDAC oEstadisticaDAC = new EstadisticaDAC();
            DataTable dt = oEstadisticaDAC.HistoRulaPersonDAC(oEstadisticasPersonales);
            return dt;
        }
        public DataTable PastelRebaPersonBC(EstadisticasPersonales oEstadisticasPersonales)
        {
            EstadisticaDAC oEstadisticaDAC = new EstadisticaDAC();
            DataTable dt = oEstadisticaDAC.PastelRebaPersonDAC(oEstadisticasPersonales);
            return dt;
        }
        public DataTable HistoRebaPersonBC(EstadisticasPersonales oEstadisticasPersonales)
        {
            EstadisticaDAC oEstadisticaDAC = new EstadisticaDAC();
            DataTable dt = oEstadisticaDAC.HistoRebaPersonDAC(oEstadisticasPersonales);
            return dt;
        }
        public DataTable PastelNioshPersonBC(EstadisticasPersonales oEstadisticasPersonales)
        {
            EstadisticaDAC oEstadisticaDAC = new EstadisticaDAC();
            DataTable dt = oEstadisticaDAC.PastelNioshPersonDAC(oEstadisticasPersonales);
            return dt;
        }
        public DataTable HistoNioshPersonBC(EstadisticasPersonales oEstadisticasPersonales)
        {
            EstadisticaDAC oEstadisticaDAC = new EstadisticaDAC();
            DataTable dt = oEstadisticaDAC.HistoNioshPersonDAC(oEstadisticasPersonales);
            return dt;
        }
        public DataTable PasteljssPersonBC(EstadisticasPersonales oEstadisticasPersonales)
        {
            EstadisticaDAC oEstadisticaDAC = new EstadisticaDAC();
            DataTable dt = oEstadisticaDAC.PasteljssPersonDAC(oEstadisticasPersonales);
            return dt;
        }
        public DataTable HistoJSSPersonBC(EstadisticasPersonales oEstadisticasPersonales)
        {
            EstadisticaDAC oEstadisticaDAC = new EstadisticaDAC();
            DataTable dt = oEstadisticaDAC.HistoJSSPersonDAC(oEstadisticasPersonales);
            return dt;
        }

        public DataTable ContPersonxEmpBC(EstadisticasPersonales oEstadisticasPersonales)
        {
            EstadisticaDAC oEstadisticaDAC = new EstadisticaDAC();
            DataTable dt = oEstadisticaDAC.ContPersonxEmpDAC(oEstadisticasPersonales);
            return dt;
        }
    }
}
