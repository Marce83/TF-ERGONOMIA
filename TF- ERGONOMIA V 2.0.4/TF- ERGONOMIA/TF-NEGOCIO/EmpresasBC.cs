using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using TF.ENTITIES;
using TF.DAC;

namespace TF.BC
{
    public class EmpresasBC
    {
        public DataTable GetAll()
        {
            EmpresasDAC oempresaDAC = new EmpresasDAC();
            DataTable dt = oempresaDAC.GetAll();
            return dt;
        }

        public Empresas ObtenerEmpresa(long CUIT)
        {
            EmpresasDAC oempresaDAC = new EmpresasDAC();
            return oempresaDAC.ObtenerEmpresa(CUIT);
        }

        public DataTable ConsultarEmpresas(Empresas oemp)
        {
            EmpresasDAC oempresaDAC = new EmpresasDAC();
            DataTable dt = oempresaDAC.ConsultarEmpresa(oemp);
            return dt;
        }

        public DataTable ConsultarNombreEmpresa(Empresas oemp)
        {
            EmpresasDAC oempresaDAC = new EmpresasDAC();
            DataTable dt = oempresaDAC.ConsultarNombreEmpresa(oemp);
            return dt;
        }

        public int Insertempresa(Empresas oemp)
        {
            EmpresasDAC oempresaDAC = new EmpresasDAC();
            return oempresaDAC.Insertempresa(oemp);
        }
        
        public int updateempresa(Empresas oemp)
        {
            EmpresasDAC oempresaDAC = new EmpresasDAC();
            return oempresaDAC.ModificarEmpresa(oemp);
        }

        public int deleteempresas(Empresas oemp)
        {
            EmpresasDAC oempresaDAC = new EmpresasDAC();
            return oempresaDAC.DeleteEmpresa(oemp);
        }

        public void BuscarEmpresa(Empresas oEmp)
        {
            EmpresasDAC oempresaDAC = new EmpresasDAC();
            if (oempresaDAC.ExisteEmpresa(oEmp.CUIT))
            {
                throw new Exception("La empresa ya existe, por favor ingrese otra.");
            }
        }
    }
}

