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
                sqlCom.Parameters.Add("@FechaCargaNiosh", SqlDbType.DateTime).Value = oNiosh.FechaCargaNiosh.ToString("dd/MM/yyyy");
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
                sqlCom.Parameters.Add("@HMNioshD", SqlDbType.Float).Value = oNiosh.HMNioshD;
                sqlCom.Parameters.Add("@HMNioshI", SqlDbType.Float).Value = oNiosh.HMNioshI;
                sqlCom.Parameters.Add("@VMNioshD", SqlDbType.Float).Value = oNiosh.VMNioshD;
                sqlCom.Parameters.Add("@VMNioshI", SqlDbType.Float).Value = oNiosh.VMNioshI;
                sqlCom.Parameters.Add("@DMNioshD", SqlDbType.Float).Value = oNiosh.DMNioshD;
                sqlCom.Parameters.Add("@AMNioshD", SqlDbType.Float).Value = oNiosh.AMNioshD;
                sqlCom.Parameters.Add("@AMNioshI", SqlDbType.Float).Value = oNiosh.AMNioshI;
                sqlCom.Parameters.Add("@FMNioshD", SqlDbType.NVarChar).Value = oNiosh.FMNioshD;
                sqlCom.Parameters.Add("@FMNioshI", SqlDbType.Float).Value = oNiosh.FMNioshI;
                sqlCom.Parameters.Add("@CMRNioshD", SqlDbType.Float).Value = oNiosh.CMRNioshD;
                sqlCom.Parameters.Add("@CMRNioshI", SqlDbType.Float).Value = oNiosh.CMRNioshI;
                sqlCom.Parameters.Add("@Duraciontarea", SqlDbType.Int).Value = oNiosh.Duraciontarea;
                sqlCom.Parameters.Add("@CalidadAgarreD", SqlDbType.Int).Value = oNiosh.CalidadAgarreD;
                sqlCom.Parameters.Add("@CalidadAgarreI", SqlDbType.Int).Value = oNiosh.CalidadAgarreI;
                sqlCom.Parameters.Add("@LCNiosh", SqlDbType.Int).Value = oNiosh.LCNiosh;
                sqlCom.Parameters.Add("@FrecuenciaNiosh", SqlDbType.Int).Value = oNiosh.FrecuenciaNiosh;
                sqlCom.Parameters.Add("@DistanciaVerticalD", SqlDbType.Int).Value = oNiosh.DistanciaVerticalD;
                sqlCom.Parameters.Add("@DistanciaVerticali", SqlDbType.Int).Value = oNiosh.DistanciaVerticali;
                sqlCom.Parameters.Add("@FMNioshDnumero", SqlDbType.Float).Value = oNiosh.FMNioshDnumero;
                sqlCom.Parameters.Add("@FMNioshInumero", SqlDbType.Float).Value = oNiosh.FMNioshInumero;
                sqlCom.Parameters.Add("@CMRNioshDnumero", SqlDbType.Float).Value = oNiosh.CMRNioshDnumero;
                sqlCom.Parameters.Add("@CMRNioshInumero", SqlDbType.Float).Value = oNiosh.CMRNioshInumero;

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



        public int UpdateNiosh2DAC(Niosh oNiosh)
        {
            try
            {
                string sqlSentencia = "SP_Niosh_updateNiosh2";
                SqlConnection sqlCnn = new SqlConnection();
                sqlCnn.ConnectionString = conectionString;
                SqlCommand sqlCom = new SqlCommand(sqlSentencia, sqlCnn);
                sqlCom.CommandType = CommandType.StoredProcedure;
                sqlCom.Parameters.Add("@cargaIdNiosh", SqlDbType.Int).Value = oNiosh.cargaIdNiosh;
                sqlCom.Parameters.Add("@ILNiosh", SqlDbType.Float).Value = oNiosh.ILNiosh;
                sqlCom.Parameters.Add("@PoblacionNiosh", SqlDbType.Int).Value = oNiosh.PoblacionNiosh;
                sqlCom.Parameters.Add("@ControlNiosh", SqlDbType.Int).Value = oNiosh.ControlNiosh;
                sqlCom.Parameters.Add("@RiesgoNiosh", SqlDbType.NVarChar).Value = oNiosh.RiesgoNiosh;

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



        public DataTable NioshTablaADestinoDAC(Niosh oNiosh)
        {
            try
            {
                string sqlSentencia = "SP_Niosh_TablaADestino";
                SqlConnection sqlCnn = new SqlConnection();
                sqlCnn.ConnectionString = conectionString;
                SqlCommand sqlCom = new SqlCommand(sqlSentencia, sqlCnn);
                sqlCom.CommandType = CommandType.StoredProcedure;
                sqlCom.Parameters.Add("@FrecuenciaFM", SqlDbType.Int).Value = oNiosh.FrecuenciaFM;
                sqlCom.Parameters.Add("@DuracionFM", SqlDbType.Int).Value = oNiosh.DuracionFM;
                sqlCom.Parameters.Add("@DistanciaVerticalFM", SqlDbType.Int).Value = oNiosh.DistanciaVerticalFM;

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

        public DataTable NioshTablaAInicialDAC(Niosh oNiosh)
        {
            try
            {
                string sqlSentencia = "SP_Niosh_TablaADestino";
                SqlConnection sqlCnn = new SqlConnection();
                sqlCnn.ConnectionString = conectionString;
                SqlCommand sqlCom = new SqlCommand(sqlSentencia, sqlCnn);
                sqlCom.CommandType = CommandType.StoredProcedure;
                sqlCom.Parameters.Add("@FrecuenciaFM", SqlDbType.Int).Value = oNiosh.FrecuenciaFMi;
                sqlCom.Parameters.Add("@DuracionFM", SqlDbType.Int).Value = oNiosh.DuracionFMi;
                sqlCom.Parameters.Add("@DistanciaVerticalFM", SqlDbType.Int).Value = oNiosh.DistanciaVerticalFMi;

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

        public DataTable NioshTablaCMDestinoDAC(Niosh oNiosh)
        {
            try
            {
                string sqlSentencia = "SP_Niosh_NioshTablaCM_Destino";
                SqlConnection sqlCnn = new SqlConnection();
                sqlCnn.ConnectionString = conectionString;
                SqlCommand sqlCom = new SqlCommand(sqlSentencia, sqlCnn);
                sqlCom.CommandType = CommandType.StoredProcedure;
                sqlCom.Parameters.Add("@AgarreCM", SqlDbType.Int).Value = oNiosh.CalidadAgarreD;
                sqlCom.Parameters.Add("@DistanciaVerticalCM", SqlDbType.Int).Value = oNiosh.DistanciaVerticalFM;

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

        public DataTable NioshTablaCMInicioDAC(Niosh oNiosh)
        {
            try
            {
                string sqlSentencia = "SP_Niosh_NioshTablaCM_Inicio";
                SqlConnection sqlCnn = new SqlConnection();
                sqlCnn.ConnectionString = conectionString;
                SqlCommand sqlCom = new SqlCommand(sqlSentencia, sqlCnn);
                sqlCom.CommandType = CommandType.StoredProcedure;
                sqlCom.Parameters.Add("@AgarreCM", SqlDbType.Int).Value = oNiosh.CalidadAgarreI;
                sqlCom.Parameters.Add("@DistanciaVerticalCM", SqlDbType.Int).Value = oNiosh.DistanciaVerticalFMi;

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

        public DataTable Niosh_ResultadoDAC(Niosh oNiosh)
        {
            try
            {
                string sqlSentencia = "SP_Niosh_Resultado";
                SqlConnection sqlCnn = new SqlConnection();
                sqlCnn.ConnectionString = conectionString;
                SqlCommand sqlCom = new SqlCommand(sqlSentencia, sqlCnn);
                sqlCom.CommandType = CommandType.StoredProcedure;
                sqlCom.Parameters.Add("@cargaIdNiosh", SqlDbType.Int).Value = oNiosh.cargaIdNiosh;
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
