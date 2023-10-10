﻿using System;
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
                sqlCom.Parameters.Add("@cargaIdNiosh", SqlDbType.Float).Value = oNiosh.cargaIdNiosh;
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
                sqlCom.Parameters.Add("@Duraciontarea", SqlDbType.Float).Value = oNiosh.Duraciontarea;
                sqlCom.Parameters.Add("@CalidadAgarreD", SqlDbType.NVarChar).Value = oNiosh.CalidadAgarreD;
                sqlCom.Parameters.Add("@CalidadAgarreI", SqlDbType.NVarChar).Value = oNiosh.CalidadAgarreI;
                sqlCom.Parameters.Add("@LCNiosh", SqlDbType.NVarChar).Value = oNiosh.LCNiosh;
                sqlCom.Parameters.Add("@FrecuenciaNiosh", SqlDbType.NVarChar).Value = oNiosh.FrecuenciaNiosh;
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
                sqlCom.Parameters.Add("@cargaidniosh", SqlDbType.NVarChar).Value = oNiosh.cargaIdNiosh;
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
