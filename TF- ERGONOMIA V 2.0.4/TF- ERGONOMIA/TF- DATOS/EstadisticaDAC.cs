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
        public DataTable ContNIOSHPersonDAC(EstadisticasPersonales oEstadisticasPersonales)
        {
            string sqlSentencia = "SP_STAT_NIOSHContPerson";
            SqlConnection sqlCnn = new SqlConnection();
            sqlCnn.ConnectionString = conectionString;
            SqlCommand sqlComm = new SqlCommand(sqlSentencia, sqlCnn);
            sqlComm.CommandType = CommandType.StoredProcedure;
            sqlComm.Parameters.Add("@CUITNiosh", SqlDbType.NVarChar).Value = oEstadisticasPersonales.CuitNiosh;
            sqlComm.Parameters.Add("@FechaCargaNiosh", SqlDbType.DateTime).Value = oEstadisticasPersonales.FechaCargaNiosh;
            sqlComm.Parameters.Add("@FechaCargaNiosh2", SqlDbType.DateTime).Value = oEstadisticasPersonales.FechaCarga2Niosh;
            sqlCnn.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter DA = new SqlDataAdapter();
            DA.SelectCommand = sqlComm;
            DA.Fill(ds);
            sqlCnn.Close();
            return ds.Tables[0];
        }
        public DataTable ContREBAPersonDAC(EstadisticasPersonales oEstadisticasPersonales)
        {
            string sqlSentencia = "SP_STAT_REBAContPerson";
            SqlConnection sqlCnn = new SqlConnection();
            sqlCnn.ConnectionString = conectionString;
            SqlCommand sqlComm = new SqlCommand(sqlSentencia, sqlCnn);
            sqlComm.CommandType = CommandType.StoredProcedure;
            sqlComm.Parameters.Add("@CUITReba", SqlDbType.NVarChar).Value = oEstadisticasPersonales.CuitReba;
            sqlComm.Parameters.Add("@FechaCargaReba", SqlDbType.DateTime).Value = oEstadisticasPersonales.FechaCargaReba;
            sqlComm.Parameters.Add("@FechaCargaReba2", SqlDbType.DateTime).Value = oEstadisticasPersonales.FechaCarga2Reba;
            sqlCnn.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter DA = new SqlDataAdapter();
            DA.SelectCommand = sqlComm;
            DA.Fill(ds);
            sqlCnn.Close();
            return ds.Tables[0];
        }
        public DataTable ContRULAPersonDAC(EstadisticasPersonales oEstadisticasPersonales)
        {
            string sqlSentencia = "SP_STAT_RULAContPerson";
            SqlConnection sqlCnn = new SqlConnection();
            sqlCnn.ConnectionString = conectionString;
            SqlCommand sqlComm = new SqlCommand(sqlSentencia, sqlCnn);
            sqlComm.CommandType = CommandType.StoredProcedure;
            sqlComm.Parameters.Add("@CUIT", SqlDbType.NVarChar).Value = oEstadisticasPersonales.CuitRula;
            sqlComm.Parameters.Add("@FechaCarga", SqlDbType.Date).Value = oEstadisticasPersonales.FechaCargaRula/*.ToString("yyyy-MM-dd")*/;
            sqlComm.Parameters.Add("@FechaCarga2", SqlDbType.Date).Value = oEstadisticasPersonales.FechaCarga2Rula/*.ToString("yyyy-MM-dd")*/;

            sqlCnn.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter DA = new SqlDataAdapter();
            DA.SelectCommand = sqlComm;
            DA.Fill(ds);
            sqlCnn.Close();

            return ds.Tables[0];
        }
        public DataTable ContJSSPersonDAC(EstadisticasPersonales oEstadisticasPersonales)
        {
            string sqlSentencia = "SP_STAT_JSSContPerson";
            SqlConnection sqlCnn = new SqlConnection();
            sqlCnn.ConnectionString = conectionString;
            SqlCommand sqlComm = new SqlCommand(sqlSentencia, sqlCnn);
            sqlComm.CommandType = CommandType.StoredProcedure;
            sqlComm.Parameters.Add("@CUITJSS", SqlDbType.NVarChar).Value = oEstadisticasPersonales.CuitJss;
            sqlComm.Parameters.Add("@FechaCargaJss", SqlDbType.DateTime).Value = oEstadisticasPersonales.FechaCargaJss;
            sqlComm.Parameters.Add("@FechaCargaJss2", SqlDbType.DateTime).Value = oEstadisticasPersonales.FechaCarga2Jss;
            sqlCnn.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter DA = new SqlDataAdapter();
            DA.SelectCommand = sqlComm;
            DA.Fill(ds);
            sqlCnn.Close();
            return ds.Tables[0];
        }
        public DataTable PastelRulaPersonDAC(EstadisticasPersonales oEstadisticasPersonales)
        {
            string sqlSentencia = "SP_STAT_PastelRulaPerson2";
            SqlConnection sqlCnn = new SqlConnection();
            sqlCnn.ConnectionString = conectionString;
            SqlCommand sqlComm = new SqlCommand(sqlSentencia, sqlCnn);
            sqlComm.CommandType = CommandType.StoredProcedure;
            sqlComm.Parameters.Add("@CUIT", SqlDbType.NVarChar).Value = oEstadisticasPersonales.CuitRula;
            sqlComm.Parameters.Add("@FechaCarga", SqlDbType.DateTime).Value = oEstadisticasPersonales.FechaCargaRula;
            sqlComm.Parameters.Add("@FechaCarga2", SqlDbType.DateTime).Value = oEstadisticasPersonales.FechaCarga2Rula;
            sqlCnn.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter DA = new SqlDataAdapter();
            DA.SelectCommand = sqlComm;
            DA.Fill(ds);
            sqlCnn.Close();

            return ds.Tables[0];
        }
        public DataTable HistoRulaPersonDAC(EstadisticasPersonales oEstadisticasPersonales)
        {
            string sqlSentencia = "SP_STAT_HistoRulaPerson";
            SqlConnection sqlCnn = new SqlConnection();
            sqlCnn.ConnectionString = conectionString;
            SqlCommand sqlComm = new SqlCommand(sqlSentencia, sqlCnn);
            sqlComm.CommandType = CommandType.StoredProcedure;
            sqlComm.Parameters.Add("@CUIT", SqlDbType.NVarChar).Value = oEstadisticasPersonales.CuitRula;
            sqlComm.Parameters.Add("@FechaCarga", SqlDbType.DateTime).Value = oEstadisticasPersonales.FechaCargaRula;
            sqlComm.Parameters.Add("@FechaCarga2", SqlDbType.DateTime).Value = oEstadisticasPersonales.FechaCarga2Rula;
            sqlCnn.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter DA = new SqlDataAdapter();
            DA.SelectCommand = sqlComm;
            DA.Fill(ds);
            sqlCnn.Close();

            return ds.Tables[0];
        }
        public DataTable PastelRebaPersonDAC(EstadisticasPersonales oEstadisticasPersonales)
        {
            string sqlSentencia = "SP_STAT_PastelRebaPerson";
            SqlConnection sqlCnn = new SqlConnection();
            sqlCnn.ConnectionString = conectionString;
            SqlCommand sqlComm = new SqlCommand(sqlSentencia, sqlCnn);
            sqlComm.CommandType = CommandType.StoredProcedure;
            sqlComm.Parameters.Add("@CUITReba", SqlDbType.NVarChar).Value = oEstadisticasPersonales.CuitReba;
            sqlComm.Parameters.Add("@FechaCargaReba", SqlDbType.DateTime).Value = oEstadisticasPersonales.FechaCargaReba;
            sqlComm.Parameters.Add("@FechaCargaReba2", SqlDbType.DateTime).Value = oEstadisticasPersonales.FechaCarga2Reba;
            sqlCnn.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter DA = new SqlDataAdapter();
            DA.SelectCommand = sqlComm;
            DA.Fill(ds);
            sqlCnn.Close();

            return ds.Tables[0];
        }
        public DataTable HistoRebaPersonDAC(EstadisticasPersonales oEstadisticasPersonales)
        {
            string sqlSentencia = "SP_STAT_HistoRebaPerson";
            SqlConnection sqlCnn = new SqlConnection();
            sqlCnn.ConnectionString = conectionString;
            SqlCommand sqlComm = new SqlCommand(sqlSentencia, sqlCnn);
            sqlComm.CommandType = CommandType.StoredProcedure;
            sqlComm.Parameters.Add("@CUITReba", SqlDbType.NVarChar).Value = oEstadisticasPersonales.CuitReba;
            sqlComm.Parameters.Add("@FechaCargaReba", SqlDbType.DateTime).Value = oEstadisticasPersonales.FechaCargaReba;
            sqlComm.Parameters.Add("@FechaCargaReba2", SqlDbType.DateTime).Value = oEstadisticasPersonales.FechaCarga2Reba;
            sqlCnn.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter DA = new SqlDataAdapter();
            DA.SelectCommand = sqlComm;
            DA.Fill(ds);
            sqlCnn.Close();

            return ds.Tables[0];
        }
        public DataTable PastelNioshPersonDAC(EstadisticasPersonales oEstadisticasPersonales)
        {
            string sqlSentencia = "SP_STAT_PastelNioshPerson";
            SqlConnection sqlCnn = new SqlConnection();
            sqlCnn.ConnectionString = conectionString;
            SqlCommand sqlComm = new SqlCommand(sqlSentencia, sqlCnn);
            sqlComm.CommandType = CommandType.StoredProcedure;
            sqlComm.Parameters.Add("@CUITNiosh", SqlDbType.NVarChar).Value = oEstadisticasPersonales.CuitNiosh;
            sqlComm.Parameters.Add("@FechaCargaNiosh", SqlDbType.DateTime).Value = oEstadisticasPersonales.FechaCargaNiosh;
            sqlComm.Parameters.Add("@FechaCargaNiosh2", SqlDbType.DateTime).Value = oEstadisticasPersonales.FechaCarga2Niosh;
            sqlCnn.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter DA = new SqlDataAdapter();
            DA.SelectCommand = sqlComm;
            DA.Fill(ds);
            sqlCnn.Close();

            return ds.Tables[0];
        }
        public DataTable HistoNioshPersonDAC(EstadisticasPersonales oEstadisticasPersonales)
        {
            string sqlSentencia = "SP_STAT_HistoNioshPerson";
            SqlConnection sqlCnn = new SqlConnection();
            sqlCnn.ConnectionString = conectionString;
            SqlCommand sqlComm = new SqlCommand(sqlSentencia, sqlCnn);
            sqlComm.CommandType = CommandType.StoredProcedure;
            sqlComm.Parameters.Add("@CUITNiosh", SqlDbType.NVarChar).Value = oEstadisticasPersonales.CuitNiosh;
            sqlComm.Parameters.Add("@FechaCargaNiosh", SqlDbType.DateTime).Value = oEstadisticasPersonales.FechaCargaNiosh;
            sqlComm.Parameters.Add("@FechaCargaNiosh2", SqlDbType.DateTime).Value = oEstadisticasPersonales.FechaCarga2Niosh;
            sqlCnn.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter DA = new SqlDataAdapter();
            DA.SelectCommand = sqlComm;
            DA.Fill(ds);
            sqlCnn.Close();

            return ds.Tables[0];
        }
        public DataTable PasteljssPersonDAC(EstadisticasPersonales oEstadisticasPersonales)
        {
            string sqlSentencia = "SP_STAT_PastelJSSPerson";
            SqlConnection sqlCnn = new SqlConnection();
            sqlCnn.ConnectionString = conectionString;
            SqlCommand sqlComm = new SqlCommand(sqlSentencia, sqlCnn);
            sqlComm.CommandType = CommandType.StoredProcedure;
            sqlComm.Parameters.Add("@CUITJSS", SqlDbType.NVarChar).Value = oEstadisticasPersonales.CuitJss;
            sqlComm.Parameters.Add("@FechaCargaJss", SqlDbType.DateTime).Value = oEstadisticasPersonales.FechaCargaJss;
            sqlComm.Parameters.Add("@FechaCargaJss2", SqlDbType.DateTime).Value = oEstadisticasPersonales.FechaCarga2Jss;
            sqlCnn.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter DA = new SqlDataAdapter();
            DA.SelectCommand = sqlComm;
            DA.Fill(ds);
            sqlCnn.Close();

            return ds.Tables[0];
        }
        public DataTable HistoJSSPersonDAC(EstadisticasPersonales oEstadisticasPersonales)
        {
            string sqlSentencia = "SP_STAT_HistoJSSPerson";
            SqlConnection sqlCnn = new SqlConnection();
            sqlCnn.ConnectionString = conectionString;
            SqlCommand sqlComm = new SqlCommand(sqlSentencia, sqlCnn);
            sqlComm.CommandType = CommandType.StoredProcedure;
            sqlComm.Parameters.Add("@CUITJSS", SqlDbType.NVarChar).Value = oEstadisticasPersonales.CuitJss;
            sqlComm.Parameters.Add("@FechaCargaJss", SqlDbType.DateTime).Value = oEstadisticasPersonales.FechaCargaJss;
            sqlComm.Parameters.Add("@FechaCargaJss2", SqlDbType.DateTime).Value = oEstadisticasPersonales.FechaCarga2Jss;
            sqlCnn.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter DA = new SqlDataAdapter();
            DA.SelectCommand = sqlComm;
            DA.Fill(ds);
            sqlCnn.Close();

            return ds.Tables[0];
        }

        public DataTable ContPersonxEmpDAC(EstadisticasPersonales oEstadisticasPersonales)
        {
            string sqlSentencia = "SP_STAT_ContEmpleadosPerson";
            SqlConnection sqlCnn = new SqlConnection();
            sqlCnn.ConnectionString = conectionString;
            SqlCommand sqlComm = new SqlCommand(sqlSentencia, sqlCnn);
            sqlComm.CommandType = CommandType.StoredProcedure;
            sqlComm.Parameters.Add("@CUIT", SqlDbType.NVarChar).Value = oEstadisticasPersonales.Cuit;
            sqlComm.Parameters.Add("@FechaIngreso", SqlDbType.DateTime).Value = oEstadisticasPersonales.FechaIngreso;
            sqlComm.Parameters.Add("@FechaIngreso2", SqlDbType.DateTime).Value = oEstadisticasPersonales.FechaIngreso2;
            sqlCnn.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter DA = new SqlDataAdapter();
            DA.SelectCommand = sqlComm;
            DA.Fill(ds);
            sqlCnn.Close();
            return ds.Tables[0];
        }

        public DataTable ContEmpresasPublPrivaDAC()
        {
            string sqlSentencia = "SP_STAT_EmpresaPubPriv";
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


        public DataTable ContEmpleadosSexoDAC()
        {
            string sqlSentencia = "SP_STAT_MujerVaronEmp";
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

        public DataTable PuestoRulaPersonDAC(EstadisticasPersonales oEstadisticasPersonales)
        {
            string sqlSentencia = "SP_STAT_PuestoRULAPerson";
            SqlConnection sqlCnn = new SqlConnection();
            sqlCnn.ConnectionString = conectionString;
            SqlCommand sqlComm = new SqlCommand(sqlSentencia, sqlCnn);
            sqlComm.CommandType = CommandType.StoredProcedure;
            sqlComm.Parameters.Add("@CUIT", SqlDbType.NVarChar).Value = oEstadisticasPersonales.CuitRula;
            sqlComm.Parameters.Add("@FechaCarga", SqlDbType.DateTime).Value = oEstadisticasPersonales.FechaCargaRula;
            sqlComm.Parameters.Add("@FechaCarga2", SqlDbType.DateTime).Value = oEstadisticasPersonales.FechaCarga2Rula;
            sqlCnn.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter DA = new SqlDataAdapter();
            DA.SelectCommand = sqlComm;
            DA.Fill(ds);
            sqlCnn.Close();

            return ds.Tables[0];
        }

        public DataTable PuestoRebaPersonDAC(EstadisticasPersonales oEstadisticasPersonales)
        {
            string sqlSentencia = "SP_STAT_PuestoRebaPerson";
            SqlConnection sqlCnn = new SqlConnection();
            sqlCnn.ConnectionString = conectionString;
            SqlCommand sqlComm = new SqlCommand(sqlSentencia, sqlCnn);
            sqlComm.CommandType = CommandType.StoredProcedure;
            sqlComm.Parameters.Add("@CUITReba", SqlDbType.NVarChar).Value = oEstadisticasPersonales.CuitReba;
            sqlComm.Parameters.Add("@FechaCargaReba", SqlDbType.DateTime).Value = oEstadisticasPersonales.FechaCargaReba;
            sqlComm.Parameters.Add("@FechaCargaReba2", SqlDbType.DateTime).Value = oEstadisticasPersonales.FechaCarga2Reba;
            sqlCnn.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter DA = new SqlDataAdapter();
            DA.SelectCommand = sqlComm;
            DA.Fill(ds);
            sqlCnn.Close();

            return ds.Tables[0];
        }
        public DataTable PuestoJSSPersonDAC(EstadisticasPersonales oEstadisticasPersonales)
        {
            string sqlSentencia = "SP_STAT_PuestoJSSPerson";
            SqlConnection sqlCnn = new SqlConnection();
            sqlCnn.ConnectionString = conectionString;
            SqlCommand sqlComm = new SqlCommand(sqlSentencia, sqlCnn);
            sqlComm.CommandType = CommandType.StoredProcedure;
            sqlComm.Parameters.Add("@CUITJSS", SqlDbType.NVarChar).Value = oEstadisticasPersonales.CuitJss;
            sqlComm.Parameters.Add("@FechaCargaJss", SqlDbType.DateTime).Value = oEstadisticasPersonales.FechaCargaJss;
            sqlComm.Parameters.Add("@FechaCargaJss2", SqlDbType.DateTime).Value = oEstadisticasPersonales.FechaCarga2Jss;
            sqlCnn.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter DA = new SqlDataAdapter();
            DA.SelectCommand = sqlComm;
            DA.Fill(ds);
            sqlCnn.Close();

            return ds.Tables[0];
        }
        public DataTable PuestoNioshPersonDAC(EstadisticasPersonales oEstadisticasPersonales)
        {
            string sqlSentencia = "SP_STAT_PuestoNioshPerson";
            SqlConnection sqlCnn = new SqlConnection();
            sqlCnn.ConnectionString = conectionString;
            SqlCommand sqlComm = new SqlCommand(sqlSentencia, sqlCnn);
            sqlComm.CommandType = CommandType.StoredProcedure;
            sqlComm.Parameters.Add("@CUITNiosh", SqlDbType.NVarChar).Value = oEstadisticasPersonales.CuitNiosh;
            sqlComm.Parameters.Add("@FechaCargaNiosh", SqlDbType.DateTime).Value = oEstadisticasPersonales.FechaCargaNiosh;
            sqlComm.Parameters.Add("@FechaCargaNiosh2", SqlDbType.DateTime).Value = oEstadisticasPersonales.FechaCarga2Niosh;
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
