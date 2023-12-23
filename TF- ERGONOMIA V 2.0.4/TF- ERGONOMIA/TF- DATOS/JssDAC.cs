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
    public class JssDAC
    {

        string conectionString = ConnectionStringManager.ConectionString;

        public int InsertJSSPORTADADAC(jss Ojss)
        {
            try
            {
                string sqlSentencia = "SP_JSS_Insert";
                SqlConnection sqlCnn = new SqlConnection();
                sqlCnn.ConnectionString = conectionString;
                SqlCommand sqlCom = new SqlCommand(sqlSentencia, sqlCnn);
                sqlCom.CommandType = CommandType.StoredProcedure;
                sqlCom.Parameters.Add("@CUITJSS", SqlDbType.NVarChar).Value = Ojss.CUITJSS;
                sqlCom.Parameters.Add("@PuestoDeTrabajoJSS", SqlDbType.NVarChar).Value = Ojss.PuestoDeTrabajoJSS;
                sqlCom.Parameters.Add("@DniEmpleadoJSS", SqlDbType.NVarChar).Value = Ojss.DniEmpleadoJSS;
                sqlCom.Parameters.Add("@EmpleadoJSS", SqlDbType.NVarChar).Value = Ojss.EmpleadoJSS;
                sqlCom.Parameters.Add("@EmpresaJSS", SqlDbType.NVarChar).Value = Ojss.EmpresaJSS;
                sqlCom.Parameters.Add("@FechaCargaJss", SqlDbType.DateTime).Value = Ojss.FechaCargaJss;
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
        public int UpdateJSSDAC(jss Ojss)
        {
            try
            {
                string sqlSentencia = "SP_JSS_update1";
                SqlConnection sqlCnn = new SqlConnection();
                sqlCnn.ConnectionString = conectionString;
                SqlCommand sqlCom = new SqlCommand(sqlSentencia, sqlCnn);
                sqlCom.CommandType = CommandType.StoredProcedure;
                sqlCom.Parameters.Add("@cargaIdJSS", SqlDbType.Int).Value = Ojss.cargaIdJSS;
                sqlCom.Parameters.Add("@DemandaJss", SqlDbType.Int).Value = Ojss.DemandaJss;
                sqlCom.Parameters.Add("@ControlJss", SqlDbType.Int).Value = Ojss.ControlJss;
                sqlCom.Parameters.Add("@ApoyoSocialJss", SqlDbType.Int).Value = Ojss.ApoyoSocialJss;
                sqlCom.Parameters.Add("@DemandaRdo", SqlDbType.NVarChar).Value = Ojss.DemandaRdo;
                sqlCom.Parameters.Add("@ControlRdo", SqlDbType.NVarChar).Value = Ojss.ControlRdo;
                sqlCom.Parameters.Add("@ApoyoSocialRdo", SqlDbType.NVarChar).Value = Ojss.ApoyoSocialRdo;
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


        public int UpdateJSS2DAC(jss Ojss)
        {
            try
            {
                string sqlSentencia = "SP_JSS_update2";
                SqlConnection sqlCnn = new SqlConnection();
                sqlCnn.ConnectionString = conectionString;
                SqlCommand sqlCom = new SqlCommand(sqlSentencia, sqlCnn);
                sqlCom.CommandType = CommandType.StoredProcedure;
                sqlCom.Parameters.Add("@cargaIdJSS", SqlDbType.Int).Value = Ojss.cargaIdJSS;
                sqlCom.Parameters.Add("@ResultadoAnalisisJss", SqlDbType.NVarChar).Value = Ojss.ResultadoAnalisisJss;
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



        public DataTable JssMaxIDDAC(jss Ojss)
        {
            string sqlSentencia = "SP_JSS_MaxID";
            SqlConnection sqlCnn = new SqlConnection();
            sqlCnn.ConnectionString = conectionString;
            SqlCommand sqlComm = new SqlCommand(sqlSentencia, sqlCnn);
            sqlComm.CommandType = CommandType.StoredProcedure;
            sqlCnn.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter DA = new SqlDataAdapter();
            DA.SelectCommand = sqlComm;
            DA.Fill(ds);
            sqlCnn.Close();

            return ds.Tables[0];
        }
        public DataTable Jss_ResultadoDAC(jss Ojss)
        {
            try
            {
                string sqlSentencia = "SP_JSS_Resultado";
                SqlConnection sqlCnn = new SqlConnection();
                sqlCnn.ConnectionString = conectionString;
                SqlCommand sqlCom = new SqlCommand(sqlSentencia, sqlCnn);
                sqlCom.CommandType = CommandType.StoredProcedure;
                sqlCom.Parameters.Add("@cargaIdJSS", SqlDbType.Int).Value = Ojss.cargaIdJSS;
                sqlCnn.Open();
                DataSet ds = new DataSet();
                SqlDataAdapter DA = new SqlDataAdapter();
                DA.SelectCommand = sqlCom;
                DA.Fill(ds);
                sqlCnn.Close();
                return ds.Tables[0];
            }
            catch (Exception ex)
            {
                throw ex;
                //Console.WriteLine("Error al validar el DNI del Empleado: " + ex.Message);
                //return null;
            }
        }




























    }
}
