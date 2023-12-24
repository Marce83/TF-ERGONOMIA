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
    public class EstadisticaDAC
    {

        string conectionString = ConnectionStringManager.ConectionString;

        public DataTable ContEmpresasDAC()
        {
            string sqlSentencia = "SP_STAT_ContEmpresas";
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
        public DataTable ContEmpresasprovDAC()
        {
            string sqlSentencia = "SP_STAT_ContEmpresasprov";
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
        public DataTable ContEmpresasLocDAC()
        {
            string sqlSentencia = "SP_STAT_ContEmpresasLoc";
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
        public DataTable ContEmpleadosDAC()
        {
            string sqlSentencia = "SP_STAT_ContEmpleados";
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
        public DataTable ContEmpleadosempresaDAC()
        {
            string sqlSentencia = "SP_STAT_ContEmpleadosEmpresas";
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
        public DataTable ContJSSDAC()
        {
            string sqlSentencia = "SP_STAT_JSSCont";
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
        public DataTable ContNIOSHDAC()
        {
            string sqlSentencia = "SP_STAT_NIOSHCont";
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
        public DataTable ContREBADAC()
        {
            string sqlSentencia = "SP_STAT_REBACont";
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

        public DataTable ContRULADAC()
        {
            string sqlSentencia = "SP_STAT_RULACont";
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


        public DataTable ContNIOSHPersonDAC()
        {

            Niosh oNiosh = new Niosh();
            string sqlSentencia = "SP_STAT_NIOSHContPerson";
            SqlConnection sqlCnn = new SqlConnection();
            sqlCnn.ConnectionString = conectionString;
            SqlCommand sqlComm = new SqlCommand(sqlSentencia, sqlCnn);
            sqlComm.CommandType = CommandType.StoredProcedure;
            sqlComm.Parameters.Add("@CUITNiosh", SqlDbType.NVarChar).Value = oNiosh.CUITNiosh;
            sqlComm.Parameters.Add("@FechaCargaNiosh", SqlDbType.DateTime).Value = oNiosh.FechaCargaNiosh.ToString("dd/MM/yyyy");
            sqlComm.Parameters.Add("@FechaCargaNiosh2", SqlDbType.DateTime).Value = oNiosh.FechaCargaNiosh2.ToString("dd/MM/yyyy");
            sqlCnn.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter DA = new SqlDataAdapter();
            DA.SelectCommand = sqlComm;
            DA.Fill(ds);
            sqlCnn.Close();
            return ds.Tables[0];
        }


        public DataTable ContREBAPersonDAC()
        {

            Reba oReba = new Reba();
            string sqlSentencia = "SP_STAT_REBAContPerson";
            SqlConnection sqlCnn = new SqlConnection();
            sqlCnn.ConnectionString = conectionString;
            SqlCommand sqlComm = new SqlCommand(sqlSentencia, sqlCnn);
            sqlComm.CommandType = CommandType.StoredProcedure;
            sqlComm.Parameters.Add("@CUITReba", SqlDbType.NVarChar).Value = oReba.CUITReba;
            sqlComm.Parameters.Add("@FechaCargaReba", SqlDbType.DateTime).Value = oReba.FechaCargaReba.ToString("dd/MM/yyyy");
            sqlComm.Parameters.Add("@FechaCargaReba2", SqlDbType.DateTime).Value = oReba.FechaCargaReba2.ToString("dd/MM/yyyy");
            sqlCnn.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter DA = new SqlDataAdapter();
            DA.SelectCommand = sqlComm;
            DA.Fill(ds);
            sqlCnn.Close();
            return ds.Tables[0];
        }

        public DataTable ContRULAPersonDAC()
        {
            Rula orula = new Rula();
            string sqlSentencia = "SP_STAT_RULAContPerson";
            SqlConnection sqlCnn = new SqlConnection();
            sqlCnn.ConnectionString = conectionString;
            SqlCommand sqlComm = new SqlCommand(sqlSentencia, sqlCnn);
            sqlComm.CommandType = CommandType.StoredProcedure;
            sqlComm.Parameters.Add("@CUIT", SqlDbType.NVarChar).Value = orula.CUIT;
            sqlComm.Parameters.Add("@FechaCarga", SqlDbType.Date).Value = orula.FechaCarga.ToString("yyyy-MM-dd");
            sqlComm.Parameters.Add("@FechaCarga2", SqlDbType.Date).Value = orula.FechaCarga2.ToString("yyyy-MM-dd");
            sqlCnn.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter DA = new SqlDataAdapter();
            DA.SelectCommand = sqlComm;
            DA.Fill(ds);
            sqlCnn.Close();
            return ds.Tables[0];
        }




        public DataTable ContJSSPersonDAC()
        {

            jss Ojss = new jss();
            string sqlSentencia = "SP_STAT_JSSContPerson";
            SqlConnection sqlCnn = new SqlConnection();
            sqlCnn.ConnectionString = conectionString;
            SqlCommand sqlComm = new SqlCommand(sqlSentencia, sqlCnn);
            sqlComm.CommandType = CommandType.StoredProcedure;
            sqlComm.Parameters.Add("@CUITJSS", SqlDbType.NVarChar).Value = Ojss.CUITJSS;
            sqlComm.Parameters.Add("@FechaCargaJss", SqlDbType.DateTime).Value = Ojss.FechaCargaJss.ToString("dd/MM/yyyy");
            sqlComm.Parameters.Add("@FechaCargaJss2", SqlDbType.DateTime).Value = Ojss.FechaCargaJss2.ToString("dd/MM/yyyy");
            sqlCnn.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter DA = new SqlDataAdapter();
            DA.SelectCommand = sqlComm;
            DA.Fill(ds);
            sqlCnn.Close();
            return ds.Tables[0];
        }




















    }
}
