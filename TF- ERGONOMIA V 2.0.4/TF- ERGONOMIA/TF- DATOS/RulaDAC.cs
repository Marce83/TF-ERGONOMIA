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
    public class RulaDAC
    {

        string conectionString = ConnectionStringManager.ConectionString;


        public int InsertRulaFormPORTADADAC(Rula oRula)
        {
            try
            {
                string sqlSentencia = "SP_Rula_Insert";
                SqlConnection sqlCnn = new SqlConnection();
                sqlCnn.ConnectionString = conectionString;
                SqlCommand sqlCom = new SqlCommand(sqlSentencia, sqlCnn);
                sqlCom.CommandType = CommandType.StoredProcedure;
                sqlCom.Parameters.Add("@CUIT", SqlDbType.NVarChar).Value = oRula.CUIT;
                sqlCom.Parameters.Add("@DniEmpleadoRula", SqlDbType.NVarChar).Value = oRula.DniEmpleadoRula;
                sqlCom.Parameters.Add("@EmpleadoRula", SqlDbType.NVarChar).Value = oRula.EmpleadoRula;
                sqlCom.Parameters.Add("@EmpresaRula", SqlDbType.NVarChar).Value = oRula.EmpresaRula;
                sqlCom.Parameters.Add("@PuestoDeTrabajo", SqlDbType.NVarChar).Value = oRula.PuestoDeTrabajo;
                sqlCom.Parameters.Add("@FechaCarga", SqlDbType.Date).Value = oRula.FechaCarga/*.ToString("yyyy-MM-dd")*/;
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

        public int UpdateRula1DAC(Rula oRula)
        {
            try
            {
                string sqlSentencia = "SP_Rula_updateRula1";
                SqlConnection sqlCnn = new SqlConnection();
                sqlCnn.ConnectionString = conectionString;
                SqlCommand sqlCom = new SqlCommand(sqlSentencia, sqlCnn);
                sqlCom.CommandType = CommandType.StoredProcedure;
                sqlCom.Parameters.Add("@cargaId", SqlDbType.Int).Value = oRula.cargaId;
                sqlCom.Parameters.Add("@Brazo", SqlDbType.Int).Value = oRula.Brazo;
                sqlCom.Parameters.Add("@Antebrazo", SqlDbType.Int).Value = oRula.Antebrazo;
                sqlCom.Parameters.Add("@Muneca", SqlDbType.Int).Value = oRula.Muneca;
                sqlCom.Parameters.Add("@Giro", SqlDbType.Int).Value = oRula.Giro;
                sqlCom.Parameters.Add("@Actividadmusculara", SqlDbType.Int).Value = oRula.Actividadmusculara;
                sqlCom.Parameters.Add("@Cargafuerzaa", SqlDbType.Int).Value = oRula.Cargafuerzaa;
                sqlCom.Parameters.Add("@Cuellob", SqlDbType.Int).Value = oRula.Cuellob;
                sqlCom.Parameters.Add("@Tronco", SqlDbType.Int).Value = oRula.Tronco;
                sqlCom.Parameters.Add("@Piernas", SqlDbType.Int).Value = oRula.Piernas;
                sqlCom.Parameters.Add("@Actividadmuscularb", SqlDbType.Int).Value = oRula.Actividadmuscularb;
                sqlCom.Parameters.Add("@Cargafuerzab", SqlDbType.Int).Value = oRula.Cargafuerzab;
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
        public int UpdateRula2DAC(Rula oRula)
        {
            try
            {
                string sqlSentencia = "SP_Rula_updateRula2";
                SqlConnection sqlCnn = new SqlConnection();
                sqlCnn.ConnectionString = conectionString;
                SqlCommand sqlCom = new SqlCommand(sqlSentencia, sqlCnn);
                sqlCom.CommandType = CommandType.StoredProcedure;
                sqlCom.Parameters.Add("@cargaId", SqlDbType.Int).Value = oRula.cargaId;
                sqlCom.Parameters.Add("@ResultadoAnalisisRula", SqlDbType.NVarChar).Value = oRula.ResultadoAnalisisRula;
                sqlCom.Parameters.Add("@NivelRiesgo", SqlDbType.Int).Value = oRula.niveldeRiesgo;
                sqlCnn.Open();
                var res = sqlCom.ExecuteNonQuery();
                sqlCnn.Close();
                return 1;
            }
            catch (Exception ex)
            {
                throw ex;

                //Console.WriteLine("Error al validar el DNI del Empleado: " + ex.Message);
                //return null;
            }

        }

        //public int UpdateRula3DAC(Rula oRula)
        //{
        //    try
        //    {
        //        string sqlSentencia = "SP_Rula_updateRula3";
        //        SqlConnection sqlCnn = new SqlConnection();
        //        sqlCnn.ConnectionString = conectionString;
        //        SqlCommand sqlCom = new SqlCommand(sqlSentencia, sqlCnn);
        //        sqlCom.CommandType = CommandType.StoredProcedure;
        //        sqlCom.Parameters.Add("@cargaId", SqlDbType.Int).Value = oRula.cargaId;
        //        sqlCom.Parameters.Add("@Tronco", SqlDbType.Int).Value = oRula.Tronco;
        //        sqlCom.Parameters.Add("@Piernas", SqlDbType.Int).Value = oRula.Piernas;
        //        sqlCom.Parameters.Add("@Actividadmuscularb", SqlDbType.Int).Value = oRula.Actividadmuscularb;
        //        sqlCom.Parameters.Add("@Cargafuerzab", SqlDbType.Int).Value = oRula.Cargafuerzab;
        //        sqlCnn.Open();
        //        var res = sqlCom.ExecuteNonQuery();
        //        sqlCnn.Close();
        //        return 1;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //        //Console.WriteLine("Error al validar el DNI del Empleado: " + ex.Message);
        //        //return null;
        //    }

        //}

        public DataTable ConsultarRulaResultadoidDAC(Rula oRula)
        {
            try
            {
                string sqlSentencia = "SP_Rula_Resultado";
                SqlConnection sqlCnn = new SqlConnection();
                sqlCnn.ConnectionString = conectionString;
                SqlCommand sqlCom = new SqlCommand(sqlSentencia, sqlCnn);
                sqlCom.CommandType = CommandType.StoredProcedure;
                sqlCom.Parameters.Add("@cargaId", SqlDbType.NVarChar).Value = oRula.cargaId;
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


        public DataTable RULA_GetAll()
        {
            string sqlSentencia = "SP_RULA_GetAll";
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


        public Rula ObtenerRulaidDAC(long CUIT)
        {
            Rula oRula = new Rula();
            string sqlSentencia = "SP_RULA_SoloId";
            SqlConnection sqlCnn = new SqlConnection();
            sqlCnn.ConnectionString = conectionString;
            SqlCommand sqlComm = new SqlCommand(sqlSentencia, sqlCnn);
            sqlComm.CommandType = CommandType.StoredProcedure;
            sqlComm.Parameters.Add("@CUIT", SqlDbType.NVarChar).Value = CUIT;
            sqlCnn.Open();

            SqlDataReader dr = sqlComm.ExecuteReader();
            while (dr.Read())
            {
                oRula.cargaId = dr.GetInt32(0);
                oRula.CUIT = dr.GetString(1);
                oRula.PuestoDeTrabajo = dr.GetString(2);
            }
            sqlCnn.Close();
            int cargaId = oRula.cargaId;
            return oRula;

        }

        public int RulaDeleteDAC()
        {
            try
            {
                string sqlSentencia = "SP_Rula_Eliminar";
                SqlConnection sqlCnn = new SqlConnection();
                sqlCnn.ConnectionString = conectionString;
                SqlCommand sqlCom = new SqlCommand(sqlSentencia, sqlCnn);
                sqlCom.CommandType = CommandType.StoredProcedure;
                //sqlCom.Parameters.Add("@CUIT", SqlDbType.NVarChar).Value = CUIT;
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

        public DataTable RulaIdMaxDAC(Rula oRula)
        {
            string sqlSentencia = "SP_Rula_maxidrulacarga";
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

        public DataTable RulaTablaARdoDAC(Rula oRula)
        {
            try
            {
                string sqlSentencia = "SP_Rula_ResultadoTablaA";
                SqlConnection sqlCnn = new SqlConnection();
                sqlCnn.ConnectionString = conectionString;
                SqlCommand sqlCom = new SqlCommand(sqlSentencia, sqlCnn);
                sqlCom.CommandType = CommandType.StoredProcedure;
                sqlCom.Parameters.Add("@cargaId", SqlDbType.NVarChar).Value = oRula.cargaId;
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

        public DataTable RulaTablaBRdoDAC(Rula oRula)
        {
            try
            {
                string sqlSentencia = "SP_Rula_ResultadoTablaB";
                SqlConnection sqlCnn = new SqlConnection();
                sqlCnn.ConnectionString = conectionString;
                SqlCommand sqlCom = new SqlCommand(sqlSentencia, sqlCnn);
                sqlCom.CommandType = CommandType.StoredProcedure;
                sqlCom.Parameters.Add("@cargaId", SqlDbType.NVarChar).Value = oRula.cargaId;
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

        public DataTable RulaTablaCRdoDAC(Rula oRula)
        {
            try
            {
                string sqlSentencia = "SP_Rula_ResultadoTablaC";
                SqlConnection sqlCnn = new SqlConnection();
                sqlCnn.ConnectionString = conectionString;
                SqlCommand sqlCom = new SqlCommand(sqlSentencia, sqlCnn);
                sqlCom.CommandType = CommandType.StoredProcedure;
                sqlCom.Parameters.Add("@ValorTablaA", SqlDbType.Int).Value = oRula.ValorTablaA;
                sqlCom.Parameters.Add("@ValorTablaB", SqlDbType.Int).Value = oRula.ValorTablaB;
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
