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
    public class NioshDAC
    {
        string conectionString = ConnectionStringManager.ConectionString;



        public int InsertNioshPORTADADAC(Niosh oNiosh)
        {
            try
            {
                string sqlSentencia = "SP_Niosh_Insert";
                SqlConnection sqlCnn = new SqlConnection();
                sqlCnn.ConnectionString = conectionString;
                SqlCommand sqlCom = new SqlCommand(sqlSentencia, sqlCnn);
                sqlCom.CommandType = CommandType.StoredProcedure;
                sqlCom.Parameters.Add("@CUITNiosh", SqlDbType.NVarChar).Value = oNiosh.CUITNiosh;
                sqlCom.Parameters.Add("@PuestoDeTrabajoNiosh", SqlDbType.NVarChar).Value = oNiosh.PuestoDeTrabajoNiosh;
                sqlCom.Parameters.Add("@DniEmpleadoNiosh", SqlDbType.NVarChar).Value = oNiosh.DniEmpleadoNiosh;
                sqlCom.Parameters.Add("@EmpleadoNiosh", SqlDbType.NVarChar).Value = oNiosh.EmpleadoNiosh;
                sqlCom.Parameters.Add("@EmpresaNiosh", SqlDbType.NVarChar).Value = oNiosh.EmpresaNiosh;
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

        public DataTable NioshMaxIdDAC(Niosh oNiosh)
        {
            string sqlSentencia = "SP_Niosh_MaxID";
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

        public int UpdateNiosh1DAC(Niosh oNiosh)
        {
            try
            {
                string sqlSentencia = "SP_Niosh_updateNiosh1";
                SqlConnection sqlCnn = new SqlConnection();
                sqlCnn.ConnectionString = conectionString;
                SqlCommand sqlCom = new SqlCommand(sqlSentencia, sqlCnn);
                sqlCom.CommandType = CommandType.StoredProcedure;
                sqlCom.Parameters.Add("@cargaIdNiosh", SqlDbType.Int).Value = oNiosh.cargaIdNiosh;
                sqlCom.Parameters.Add("@LCNiosh", SqlDbType.Int).Value = oNiosh.LCNiosh;
                sqlCom.Parameters.Add("@HMNiosh", SqlDbType.Int).Value = oNiosh.HMNiosh;
                sqlCom.Parameters.Add("@VMNiosh", SqlDbType.Int).Value = oNiosh.VMNiosh;
                sqlCom.Parameters.Add("@AMNiosh", SqlDbType.Int).Value = oNiosh.AMNiosh;
                sqlCom.Parameters.Add("@FMNiosh", SqlDbType.Int).Value = oNiosh.FMNiosh;
                sqlCom.Parameters.Add("@CMRNiosh", SqlDbType.Int).Value = oNiosh.CMRNiosh;
                sqlCom.Parameters.Add("@Duraciontarea", SqlDbType.Int).Value = oNiosh.Duraciontarea;
                sqlCom.Parameters.Add("@FrecuenciaNiosh", SqlDbType.Int).Value = oNiosh.FrecuenciaNiosh;
                sqlCom.Parameters.Add("@CADNiosh", SqlDbType.NVarChar).Value = oNiosh.CADNiosh;
                sqlCom.Parameters.Add("@PesoCargaNiosh", SqlDbType.Int).Value = oNiosh.PesoCargaNiosh;
                sqlCnn.Open();
                var res = sqlCom.ExecuteNonQuery();
                sqlCnn.Close();
                return 1;
            }
            catch (Exception ex)
            {
                throw ex;

            }












        //}
        //public DataTable Reba_ResultadoDAC(Reba oReba)
        //{
        //    try
        //    {
        //        string sqlSentencia = "SP_Reba_Resultado";
        //        SqlConnection sqlCnn = new SqlConnection();
        //        sqlCnn.ConnectionString = conectionString;
        //        SqlCommand sqlCom = new SqlCommand(sqlSentencia, sqlCnn);
        //        sqlCom.CommandType = CommandType.StoredProcedure;
        //        sqlCom.Parameters.Add("@cargaIdReba", SqlDbType.Int).Value = oReba.cargaIdReba;
        //        sqlCnn.Open();
        //        DataSet ds = new DataSet();
        //        SqlDataAdapter DA = new SqlDataAdapter();
        //        DA.SelectCommand = sqlCom;
        //        DA.Fill(ds);
        //        sqlCnn.Close();
        //        return ds.Tables[0];
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //        //Console.WriteLine("Error al validar el DNI del Empleado: " + ex.Message);
        //        //return null;
        //    }
        //}
        //public DataTable RebaTablaADAC(Reba oReba)
        //{
        //    try
        //    {
        //        string sqlSentencia = "SP_Reba_TablaA";
        //        SqlConnection sqlCnn = new SqlConnection();
        //        sqlCnn.ConnectionString = conectionString;
        //        SqlCommand sqlCom = new SqlCommand(sqlSentencia, sqlCnn);
        //        sqlCom.CommandType = CommandType.StoredProcedure;
        //        sqlCom.Parameters.Add("@cargaIdReba", SqlDbType.NVarChar).Value = oReba.cargaIdReba;
        //        sqlCnn.Open();
        //        DataSet ds = new DataSet();
        //        SqlDataAdapter DA = new SqlDataAdapter();
        //        DA.SelectCommand = sqlCom;
        //        DA.Fill(ds);
        //        sqlCnn.Close();
        //        return ds.Tables[0];
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //        //Console.WriteLine("Error al validar el DNI del Empleado: " + ex.Message);
        //        //return null;
        //    }
        //}
        //public DataTable RebaTablaBDAC(Reba oReba)
        //{
        //    try
        //    {
        //        string sqlSentencia = "SP_Reba_TablaB";
        //        SqlConnection sqlCnn = new SqlConnection();
        //        sqlCnn.ConnectionString = conectionString;
        //        SqlCommand sqlCom = new SqlCommand(sqlSentencia, sqlCnn);
        //        sqlCom.CommandType = CommandType.StoredProcedure;
        //        sqlCom.Parameters.Add("@cargaIdReba", SqlDbType.NVarChar).Value = oReba.cargaIdReba;
        //        sqlCnn.Open();
        //        DataSet ds = new DataSet();
        //        SqlDataAdapter DA = new SqlDataAdapter();
        //        DA.SelectCommand = sqlCom;
        //        DA.Fill(ds);
        //        sqlCnn.Close();
        //        return ds.Tables[0];
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //        //Console.WriteLine("Error al validar el DNI del Empleado: " + ex.Message);
        //        //return null;
        //    }
        //}
        //public DataTable RebaTablaCRdoDAC(Reba oReba)
        //{
        //    try
        //    {
        //        string sqlSentencia = "SP_Reba_TablaC";
        //        SqlConnection sqlCnn = new SqlConnection();
        //        sqlCnn.ConnectionString = conectionString;
        //        SqlCommand sqlCom = new SqlCommand(sqlSentencia, sqlCnn);
        //        sqlCom.CommandType = CommandType.StoredProcedure;
        //        sqlCom.Parameters.Add("@ValorA", SqlDbType.Int).Value = oReba.ValorTablaAReba;
        //        sqlCom.Parameters.Add("@ValorB", SqlDbType.Int).Value = oReba.ValorTablaBReba;
        //        sqlCnn.Open();
        //        DataSet ds = new DataSet();
        //        SqlDataAdapter DA = new SqlDataAdapter();
        //        DA.SelectCommand = sqlCom;
        //        DA.Fill(ds);
        //        sqlCnn.Close();
        //        return ds.Tables[0];
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //        //Console.WriteLine("Error al validar el DNI del Empleado: " + ex.Message);
        //        //return null;
        //    }
        }
    }
}
