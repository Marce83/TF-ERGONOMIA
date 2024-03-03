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
    public class EmpleadosBC
    {
        public DataTable EmpleadosBC_GetAll()
        {
            EmpleadosDAC oEmpleadosDAC = new EmpleadosDAC();
            DataTable dt = oEmpleadosDAC.Empleados_GetAll();
            return dt;
        }

        public int InsertEmpleadosBC(Empleados oempl)
        {
            EmpleadosDAC oEmpleadosDAC = new EmpleadosDAC();
            return oEmpleadosDAC.InsertEmpleados(oempl);
        }

        public DataTable ConsultarEmpleadosDNI(Empleados oempl)
        {
            EmpleadosDAC oEmpleadosDAC = new EmpleadosDAC();
            DataTable dt = oEmpleadosDAC.ConsultarEmpleadosPorDNI(oempl);
            return dt;
        }

        public int ObtenerSoloIdEmpresa(long CUIT)
        {
            EmpleadosDAC oEmpleadosDAC = new EmpleadosDAC();
            return oEmpleadosDAC.ObtenerSoloIdEmpresa(CUIT);
        }

        public int EmpleadosUpdate(Empleados oempl)
        {
            EmpleadosDAC oEmpleadosDAC = new EmpleadosDAC();
            return oEmpleadosDAC.ModificarEmpleados(oempl);
        }

        public int BajaEmpleado(Empleados oEmpl)
        {
            EmpleadosDAC oEmpleadosDAC = new EmpleadosDAC();
            return oEmpleadosDAC.BajaEmpleado(oEmpl);
        }

        public Empleados EmpleadosObtenerDNI(int DNI)
        {
            EmpleadosDAC oEmpleadosDAC = new EmpleadosDAC();
            return oEmpleadosDAC.ObtenerEmpleadoid(DNI);
        }

        public DataTable ConsultarEmpleadosPorNombre(Empleados oEmpl)
        {
            EmpleadosDAC oEmpleadosDAC = new EmpleadosDAC();
            return oEmpleadosDAC.ConsultarEmpleadosPorNombre(oEmpl);
        }

        public DataTable ConsultarEmpleadosPorApellido(Empleados oEmpl)
        {
            EmpleadosDAC oEmpleadosDAC = new EmpleadosDAC();
            return oEmpleadosDAC.ConsultarEmpleadosPorApellido(oEmpl);
        }

        public void BuscarEmpleado(Empleados oEmpl)
        {
            EmpleadosDAC oEmpleadosDAC = new EmpleadosDAC();
            if (oEmpleadosDAC.ExisteEmpleado(oEmpl.DNI))
            {
                throw new Exception("El empleado ya existe, por favor cargue otro.");
            }
        }
        public Empleados EmpleadosConPuestoBC(PuestoTrabajo oBe)
        {
            EmpleadosDAC oEmpleadosDAC = new EmpleadosDAC();
            return oEmpleadosDAC.EmpleadosConPuestoDAC(oBe);
        }


    }
}
