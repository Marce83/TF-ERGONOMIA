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
    public class PuestoTrabajoBC
    {

        public int InsertPuestoTrabajoBC(PuestoTrabajo oPuestoTrabajo)
        {
            PuestoTrabajoDAC oPuestoTrabajoDAC = new PuestoTrabajoDAC();
            return oPuestoTrabajoDAC.InsertPuestoTrabajoDAC(oPuestoTrabajo);
        }

        public DataTable GetAll()
        {
            PuestoTrabajoDAC oPuestoTrabajoDAC = new PuestoTrabajoDAC();
            DataTable dt = oPuestoTrabajoDAC.GetAll();
            return dt;
        }

        public int InsertPuestoEmpleadoBC(PuestoTrabajo oPuestoTrabajo)
        {
            PuestoTrabajoDAC oPuestoTrabajoDAC = new PuestoTrabajoDAC();
            return oPuestoTrabajoDAC.InsertPuestoEmpleadoDAC(oPuestoTrabajo);
        }

        public int UpdatePuestoEmpleadoBC(PuestoTrabajo oPuestoTrabajo)
        {
            PuestoTrabajoDAC oPuestoTrabajoDAC = new PuestoTrabajoDAC();
            return oPuestoTrabajoDAC.UpdatePuestoEmpleadoDAC(oPuestoTrabajo);
        }



        public DataTable GetAllSiNoBC(PuestoTrabajo oPuestoTrabajo)
        {
            PuestoTrabajoDAC oPuestoTrabajoDAC = new PuestoTrabajoDAC();
            DataTable dt = oPuestoTrabajoDAC.GetAllSiNoDAC(oPuestoTrabajo);
            return dt;
        }

        public PuestoTrabajo ObtenerPuestoidBC(int IdPuesto)
        {
            PuestoTrabajoDAC oPuestoTrabajoDAC = new PuestoTrabajoDAC();
            return oPuestoTrabajoDAC.ObtenerPuestoidDAC(IdPuesto);
        }





    }
}
