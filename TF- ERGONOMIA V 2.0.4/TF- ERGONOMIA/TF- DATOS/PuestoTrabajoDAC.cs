using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using TF.ENTITIES;

namespace TF.DAC
{

    public class PuestoTrabajoDAC
    {

        string conectionString = ConnectionStringManager.ConectionString;



        public int InsertPuestoTrabajoDAC(PuestoTrabajo oPuestoTrabajo)
        {
            try
            {
                string sqlSentencia = "SP_PuestoTrabajo_Insert";
                SqlConnection sqlCnn = new SqlConnection();
                sqlCnn.ConnectionString = conectionString;
                SqlCommand sqlCom = new SqlCommand(sqlSentencia, sqlCnn);
                sqlCom.CommandType = CommandType.StoredProcedure;
                sqlCom.Parameters.Add("@NombrePuesto", SqlDbType.NVarChar).Value = oPuestoTrabajo.NombrePuesto;
                sqlCom.Parameters.Add("@AreaEmpresa", SqlDbType.NVarChar).Value = oPuestoTrabajo.AreaEmpresa;
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

        public DataTable GetAll()
        {
            string sqlSentencia = "SP_PuestoTrabajo_GetAll";
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


        public int InsertPuestoEmpleadoDAC(PuestoTrabajo oPuestoTrabajo)
        {
            try
            {
                string sqlSentencia = "SP_PuestoEmpleado_Insert";
                SqlConnection sqlCnn = new SqlConnection();
                sqlCnn.ConnectionString = conectionString;
                SqlCommand sqlCom = new SqlCommand(sqlSentencia, sqlCnn);
                sqlCom.CommandType = CommandType.StoredProcedure;
                sqlCom.Parameters.Add("@IdEmpleado", SqlDbType.NVarChar).Value = oPuestoTrabajo.IdEmpleado;
                sqlCom.Parameters.Add("@IdPuesto", SqlDbType.NVarChar).Value = oPuestoTrabajo.IdPuesto;
                sqlCom.Parameters.Add("@FechaIngreso", SqlDbType.DateTime).Value = oPuestoTrabajo.FechaIngreso.ToString("dd/MM/yyyy");
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


        public int UpdatePuestoEmpleadoDAC(PuestoTrabajo oPuestoTrabajo)
        {
            try
            {
                string sqlSentencia = "SP_PuestoEmpleado_Update";
                SqlConnection sqlCnn = new SqlConnection();
                sqlCnn.ConnectionString = conectionString;
                SqlCommand sqlCom = new SqlCommand(sqlSentencia, sqlCnn);
                sqlCom.CommandType = CommandType.StoredProcedure;
                sqlCom.Parameters.Add("@IdEmpleado", SqlDbType.NVarChar).Value = oPuestoTrabajo.IdEmpleado;
                sqlCom.Parameters.Add("@FechaEgreso", SqlDbType.DateTime).Value = oPuestoTrabajo.FechaEgreso.ToString("dd/MM/yyyy");
                sqlCnn.Open();
                var res = sqlCom.ExecuteNonQuery();
                sqlCnn.Close();
                return 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cargar los datos de la Empresa: " + ex.Message);
                return 0;
            }
        }

        public DataTable GetAllSiNoDAC(PuestoTrabajo oPuestoTrabajo)
        {
            string sqlSentencia = "SP_PuestoEmpleado_GetAll_SiNo";
            SqlConnection sqlCnn = new SqlConnection();
            sqlCnn.ConnectionString = conectionString;
            SqlCommand sqlComm = new SqlCommand(sqlSentencia, sqlCnn);
            sqlComm.CommandType = CommandType.StoredProcedure;
            sqlComm.Parameters.Add("@IdEmpleado", SqlDbType.NVarChar).Value = oPuestoTrabajo.IdEmpleado;
            sqlComm.Parameters.Add("@IdPuesto", SqlDbType.NVarChar).Value = oPuestoTrabajo.IdPuesto;
            sqlCnn.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter DA = new SqlDataAdapter();
            DA.SelectCommand = sqlComm;
            DA.Fill(ds);
            sqlCnn.Close();

            return ds.Tables[0];
        }


        public PuestoTrabajo ObtenerPuestoidDAC(int IdPuesto)
        {
            PuestoTrabajo oPuestoTrabajo = new PuestoTrabajo();
            string sqlSentencia = "SP_PuestoTrabajo_GetId";
            SqlConnection sqlCnn = new SqlConnection();
            sqlCnn.ConnectionString = conectionString;
            SqlCommand sqlComm = new SqlCommand(sqlSentencia, sqlCnn);
            sqlComm.CommandType = CommandType.StoredProcedure;
            sqlComm.Parameters.Add("@IdPuesto", SqlDbType.Int).Value = IdPuesto;
            sqlCnn.Open();

            SqlDataReader dr = sqlComm.ExecuteReader();
            while (dr.Read())
            {
                oPuestoTrabajo.IdPuesto = dr.GetInt32(0);
                oPuestoTrabajo.NombrePuesto = dr.GetString(1);
                oPuestoTrabajo.AreaEmpresa = dr.GetString(2);
            }
            sqlCnn.Close();
            return oPuestoTrabajo;
        }



        public DataTable GetAllVistaPuestoDAC()
        {
            string sqlSentencia = "SP_PuestoEmpleado_VerVista";
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


        public PuestoTrabajo GetNombreEmpleadoDAC(string NombreEmpleado)
        {
            PuestoTrabajo oPuestoTrabajo = new PuestoTrabajo();
            string sqlSentencia = "SP_VistaPuesto_GetNombreEmpleado";
            SqlConnection sqlCnn = new SqlConnection();
            sqlCnn.ConnectionString = conectionString;
            SqlCommand sqlComm = new SqlCommand(sqlSentencia, sqlCnn);
            sqlComm.CommandType = CommandType.StoredProcedure;
            sqlCnn.Open();

            SqlDataReader dr = sqlComm.ExecuteReader();
            while (dr.Read())
            {
                oPuestoTrabajo.NombreEmpleado = dr.GetString(0);
                oPuestoTrabajo.NombrePuesto = dr.GetString(1);
                oPuestoTrabajo.DNI = dr.GetString(2);
            }
            sqlCnn.Close();
            return oPuestoTrabajo;
        }

        public DataTable PuestoEmpleadoVerRecienteDAC(PuestoTrabajo oPuestoTrabajo)
        {
            string sqlSentencia = "SP_PuestoEmpleado_VerReciente";
            SqlConnection sqlCnn = new SqlConnection();
            sqlCnn.ConnectionString = conectionString;
            SqlCommand sqlComm = new SqlCommand(sqlSentencia, sqlCnn);
            sqlComm.CommandType = CommandType.StoredProcedure;
            sqlComm.Parameters.Add("@FechaIngreso", SqlDbType.DateTime).Value = oPuestoTrabajo.FechaIngreso.ToString("dd/MM/yyyy");
            sqlComm.Parameters.Add("@FechaIngreso2", SqlDbType.DateTime).Value = oPuestoTrabajo.FechaIngreso2.ToString("dd/MM/yyyy");
            sqlComm.Parameters.Add("@NombreEmpleado", SqlDbType.NVarChar).Value = oPuestoTrabajo.NombreEmpleado;
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
