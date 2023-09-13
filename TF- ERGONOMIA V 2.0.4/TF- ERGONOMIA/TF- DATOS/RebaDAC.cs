using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TF.ENTITIES;

namespace TF.DAC
{
    public class RebaDAC
    {
        string conectionString = ConnectionStringManager.ConectionString;



        public int InsertRebaPORTADADAC(Reba oReba)
        {
            try
            {
                string sqlSentencia = "SP_Reba_Insert";
                SqlConnection sqlCnn = new SqlConnection();
                sqlCnn.ConnectionString = conectionString;
                SqlCommand sqlCom = new SqlCommand(sqlSentencia, sqlCnn);
                sqlCom.CommandType = CommandType.StoredProcedure;
                sqlCom.Parameters.Add("@CUITReba", SqlDbType.NVarChar).Value = oReba.CUITReba;
                sqlCom.Parameters.Add("@PuestoDeTrabajoReba", SqlDbType.NVarChar).Value = oReba.PuestoDeTrabajoReba;
                sqlCom.Parameters.Add("@DniEmpleadoReba", SqlDbType.NVarChar).Value = oReba.DniEmpleadoReba;
                sqlCom.Parameters.Add("@EmpleadoReba", SqlDbType.NVarChar).Value = oReba.EmpleadoReba;
                sqlCom.Parameters.Add("@EmpresaReba", SqlDbType.NVarChar).Value = oReba.EmpresaReba;
                sqlCnn.Open();
                var res = sqlCom.ExecuteNonQuery();
                sqlCnn.Close();
                return 1;
            }
            catch (Exception ex)
            {
                throw ex;
                //Console.WriteLine("Error al cargar los datos del Empleado: " + ex.Message);
                //return 0;
            }


        }
















    }
}
