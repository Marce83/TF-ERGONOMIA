using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TF.DAC;

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

    }
}
