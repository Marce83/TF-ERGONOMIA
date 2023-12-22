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
                sqlCom.Parameters.Add("@FechaCargaReba", SqlDbType.DateTime).Value = oReba.FechaCargaReba;
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

        public DataTable RebaMaxIdDAC(Reba oReba)
        {
            string sqlSentencia = "SP_Reba_MaxID";
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

        public int UpdateReba1DAC(Reba oReba)
        {
            try
            {
                string sqlSentencia = "SP_Reba_updateReba1";
                SqlConnection sqlCnn = new SqlConnection();
                sqlCnn.ConnectionString = conectionString;
                SqlCommand sqlCom = new SqlCommand(sqlSentencia, sqlCnn);
                sqlCom.CommandType = CommandType.StoredProcedure;
                sqlCom.Parameters.Add("@cargaIdReba", SqlDbType.Int).Value = oReba.cargaIdReba;
                sqlCom.Parameters.Add("@BrazoReba", SqlDbType.Int).Value = oReba.BrazoReba;
                sqlCom.Parameters.Add("@AgarreReba", SqlDbType.Int).Value = oReba.AgarreReba;
                sqlCom.Parameters.Add("@ActividadReba", SqlDbType.Int).Value = oReba.ActividadReba;
                sqlCom.Parameters.Add("@TroncoReba", SqlDbType.Int).Value = oReba.TroncoReba;
                sqlCom.Parameters.Add("@CuelloReba", SqlDbType.Int).Value = oReba.CuelloReba;
                sqlCom.Parameters.Add("@PiernaReba", SqlDbType.Int).Value = oReba.PiernasReba;
                sqlCom.Parameters.Add("@CargaFuerzaAReba", SqlDbType.Int).Value = oReba.CargafuerzaReba;
                sqlCom.Parameters.Add("@AntebrazoReba", SqlDbType.Int).Value = oReba.AntebrazoReba;
                sqlCom.Parameters.Add("@MunecaReba", SqlDbType.Int).Value = oReba.MunecaReba;
               

                sqlCnn.Open();
                var res = sqlCom.ExecuteNonQuery();
                sqlCnn.Close();
                return 1;

            }
            catch (Exception ex)
            {
                throw ex;

            }

        }
           public int UpdateReba2DAC(Reba oReba)
           {
                try
                {
                    string sqlSentencia = "SP_Reba_updateReba2";
                    SqlConnection sqlCnn = new SqlConnection();
                    sqlCnn.ConnectionString = conectionString;
                    SqlCommand sqlCom = new SqlCommand(sqlSentencia, sqlCnn);
                    sqlCom.CommandType = CommandType.StoredProcedure;
                    sqlCom.Parameters.Add("@cargaIdReba", SqlDbType.Int).Value = oReba.cargaIdReba;
                    sqlCom.Parameters.Add("@ResultadoAnalisisReba", SqlDbType.Int).Value = oReba.ResultadoAnalisisReba;
                    sqlCom.Parameters.Add("@NivelAccion", SqlDbType.Int).Value = oReba.NivelAccion;
                    sqlCom.Parameters.Add("@NivelRiesgo", SqlDbType.NVarChar).Value = oReba.NivelRiesgo;
                    sqlCnn.Open();
                    var res = sqlCom.ExecuteNonQuery();
                    sqlCnn.Close();
                    return 1;
    }
                catch (Exception ex)
                {
                    throw ex;

                }


           }





        public DataTable Reba_ResultadoDAC(Reba oReba)
        {
            try
            {
                string sqlSentencia = "SP_Reba_Resultado";
                SqlConnection sqlCnn = new SqlConnection();
                sqlCnn.ConnectionString = conectionString;
                SqlCommand sqlCom = new SqlCommand(sqlSentencia, sqlCnn);
                sqlCom.CommandType = CommandType.StoredProcedure;
                sqlCom.Parameters.Add("@cargaIdReba", SqlDbType.Int).Value = oReba.cargaIdReba;
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
        public DataTable RebaTablaADAC(Reba oReba)
        {
            try
            {
                string sqlSentencia = "SP_Reba_TablaA";
                SqlConnection sqlCnn = new SqlConnection();
                sqlCnn.ConnectionString = conectionString;
                SqlCommand sqlCom = new SqlCommand(sqlSentencia, sqlCnn);
                sqlCom.CommandType = CommandType.StoredProcedure;
                sqlCom.Parameters.Add("@cargaIdReba", SqlDbType.NVarChar).Value = oReba.cargaIdReba;
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
        public DataTable RebaTablaBDAC(Reba oReba)
        {
            try
            {
                string sqlSentencia = "SP_Reba_TablaB";
                SqlConnection sqlCnn = new SqlConnection();
                sqlCnn.ConnectionString = conectionString;
                SqlCommand sqlCom = new SqlCommand(sqlSentencia, sqlCnn);
                sqlCom.CommandType = CommandType.StoredProcedure;
                sqlCom.Parameters.Add("@cargaIdReba", SqlDbType.NVarChar).Value = oReba.cargaIdReba;
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
        public DataTable RebaTablaCRdoDAC(Reba oReba)
        {
            try
            {
                string sqlSentencia = "SP_Reba_TablaC";
                SqlConnection sqlCnn = new SqlConnection();
                sqlCnn.ConnectionString = conectionString;
                SqlCommand sqlCom = new SqlCommand(sqlSentencia, sqlCnn);
                sqlCom.CommandType = CommandType.StoredProcedure;
                sqlCom.Parameters.Add("@ValorA", SqlDbType.Int).Value = oReba.ValorTablaAReba;
                sqlCom.Parameters.Add("@ValorB", SqlDbType.Int).Value = oReba.ValorTablaBReba;
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
