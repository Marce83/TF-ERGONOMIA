using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TF.ENTITIES;
using System.Linq.Expressions;

namespace TF.DAC
{
    public class EmpresasDAC
    {

        string conectionString = ConnectionStringManager.ConectionString;

        public DataTable GetAll()
        {
            string sqlSentencia = "SP_Empresas_GetAll";
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

        public int Insertempresa(Empresas oemp)
        {
            try
            {
                string sqlSentencia = "SP_Empresas_Insert";
                SqlConnection sqlCnn = new SqlConnection();
                sqlCnn.ConnectionString = conectionString;
                SqlCommand sqlCom = new SqlCommand(sqlSentencia, sqlCnn);
                sqlCom.CommandType = CommandType.StoredProcedure;
                sqlCom.Parameters.Add("@CUIT", SqlDbType.NVarChar).Value = oemp.CUIT;
                sqlCom.Parameters.Add("@Nombre", SqlDbType.NVarChar).Value = oemp.Nombre;
                sqlCom.Parameters.Add("@Condicion_Fiscal", SqlDbType.NVarChar).Value = oemp.Condicion_Fiscal;
                sqlCom.Parameters.Add("@Actividad_Empresarial", SqlDbType.NVarChar).Value = oemp.Actividad_Empresarial;
                sqlCom.Parameters.Add("@Direccion", SqlDbType.NVarChar).Value = oemp.Direccion;
                sqlCom.Parameters.Add("@Localidad", SqlDbType.NVarChar).Value = oemp.Localidad;
                sqlCom.Parameters.Add("@Provincia", SqlDbType.NVarChar).Value = oemp.Provincia;
                sqlCom.Parameters.Add("@Telefono", SqlDbType.NVarChar).Value = oemp.Telefono;
                sqlCom.Parameters.Add("@Correo", SqlDbType.NVarChar).Value = oemp.Correo;
                sqlCom.Parameters.Add("@Web", SqlDbType.NVarChar).Value = oemp.Web;
                sqlCom.Parameters.Add("@FechaIngreso", SqlDbType.Date).Value = oemp.FechaIngreso;
                sqlCom.Parameters.Add("@FechaEgreso", SqlDbType.Date).Value = DBNull.Value;
                sqlCom.Parameters.Add("@Estado", SqlDbType.NVarChar).Value = 'A';
                sqlCnn.Open();
                var res = sqlCom.ExecuteNonQuery();
                sqlCnn.Close();
                return 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al agregar la Empresa: " + ex.Message);
                return 0;
            }
        }

        public DataTable ConsultarEmpresa(Empresas oemp)
        {
            try
            {
                string sqlSentencia = "SP_Empresas_GetId";
                SqlConnection sqlCnn = new SqlConnection();
                sqlCnn.ConnectionString = conectionString;
                SqlCommand sqlCom = new SqlCommand(sqlSentencia, sqlCnn);
                sqlCom.CommandType = CommandType.StoredProcedure;
                sqlCom.Parameters.Add("@CUIT", SqlDbType.NVarChar).Value = oemp.CUIT;
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
                Console.WriteLine("No existe la Empresa seleccionada: " + ex.Message);
                throw;
            }
        }

        public DataTable ConsultarNombreEmpresa(Empresas oemp)
        {
            try
            {
                string sqlSentencia = "SP_Nombre_Empresa";
                SqlConnection sqlCnn = new SqlConnection();
                sqlCnn.ConnectionString = conectionString;
                SqlCommand sqlCom = new SqlCommand(sqlSentencia, sqlCnn);
                sqlCom.CommandType = CommandType.StoredProcedure;
                sqlCom.Parameters.Add("@Nombre", SqlDbType.NVarChar).Value = oemp.Nombre;
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
                Console.WriteLine("No existe la Empresa seleccionada: " + ex.Message);
                throw;
            }
        }

        public Empresas ObtenerEmpresa(long CUIT)
        {
                Empresas oEmpresas = new Empresas();
                string sqlSentencia = "SP_Empresas_GetId";
                SqlConnection sqlCnn = new SqlConnection();
                sqlCnn.ConnectionString = conectionString;
                SqlCommand sqlComm = new SqlCommand(sqlSentencia, sqlCnn);
                sqlComm.CommandType = CommandType.StoredProcedure;
                sqlComm.Parameters.Add("@CUIT", SqlDbType.NVarChar).Value = CUIT;
                sqlCnn.Open();

                SqlDataReader dr = sqlComm.ExecuteReader();
                while (dr.Read())
                {
                    //oEmpresas.IdEmpresa = dr.GetInt32(0);
                    //oEmpresas.CUIT = dr.GetString(1);
                    //oEmpresas.Nombre = dr.GetString(2);
                    //oEmpresas.Condicion_Fiscal = dr.GetString(3);
                    //oEmpresas.Actividad_Empresarial = dr.GetString(4);
                    //oEmpresas.Direccion = dr.GetString(5);
                    //oEmpresas.Telefono = dr.GetString(6);
                    //oEmpresas.Correo = dr.GetString(7);
                    //oEmpresas.Web = dr.GetString(8);

                    oEmpresas.CUIT = dr.GetString(0);
                    oEmpresas.Nombre = dr.GetString(1);
                    oEmpresas.Condicion_Fiscal = dr.GetString(2);
                    oEmpresas.Actividad_Empresarial = dr.GetString(3);
                    oEmpresas.Direccion = dr.GetString(4);
                    oEmpresas.Localidad = dr.GetString(5);
                    oEmpresas.Provincia = dr.GetString(6);
                    oEmpresas.Telefono = dr.GetString(7);
                    oEmpresas.Correo = dr.GetString(8);
                    oEmpresas.Web = dr.GetString(9);
                }
                sqlCnn.Close();
                return oEmpresas;
    
        }
    public int ModificarEmpresa(Empresas oemp)
        {
            try
            {
                string sqlSentencia = "SP_Empresas_Update";
                SqlConnection sqlCnn = new SqlConnection();
                sqlCnn.ConnectionString = conectionString;
                SqlCommand sqlCom = new SqlCommand(sqlSentencia, sqlCnn);
                sqlCom.CommandType = CommandType.StoredProcedure;
                sqlCom.Parameters.Add("@CUIT", SqlDbType.NVarChar).Value = oemp.CUIT;
                sqlCom.Parameters.Add("@Nombre", SqlDbType.NVarChar).Value = oemp.Nombre;
                sqlCom.Parameters.Add("@Condicion_Fiscal", SqlDbType.NVarChar).Value = oemp.Condicion_Fiscal;
                sqlCom.Parameters.Add("@Actividad_Empresarial", SqlDbType.NVarChar).Value = oemp.Actividad_Empresarial;
                sqlCom.Parameters.Add("@Direccion", SqlDbType.NVarChar).Value = oemp.Direccion;
                sqlCom.Parameters.Add("@Localidad", SqlDbType.NVarChar).Value = oemp.Localidad;
                sqlCom.Parameters.Add("@Provincia", SqlDbType.NVarChar).Value = oemp.Provincia;
                sqlCom.Parameters.Add("@Telefono", SqlDbType.NVarChar).Value = oemp.Telefono;
                sqlCom.Parameters.Add("@Correo", SqlDbType.NVarChar).Value = oemp.Correo;
                sqlCom.Parameters.Add("@Web", SqlDbType.NVarChar).Value = oemp.Web;
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
        public int DeleteEmpresa(Empresas oemp)
        {
            try
            {
                string sqlSentencia = "SP_Empresas_Delete";
                SqlConnection sqlCnn = new SqlConnection();
                sqlCnn.ConnectionString = conectionString;
                SqlCommand sqlCom = new SqlCommand(sqlSentencia, sqlCnn);
                sqlCom.CommandType = CommandType.StoredProcedure;
                sqlCom.Parameters.Add("@CUIT", SqlDbType.NVarChar).Value = oemp.CUIT;
                sqlCom.Parameters.Add("@Estado", SqlDbType.NVarChar).Value = 'B';
                sqlCom.Parameters.Add("@FechaEgreso", SqlDbType.Date).Value = DateTime.Now;
                sqlCnn.Open();
                var res = sqlCom.ExecuteNonQuery();
                sqlCnn.Close();
                return 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al borrar la empresa seleccionada: " + ex.Message);
                return 0;
            }
        }

        public bool ExisteEmpresa(String CUIT)
        {
            string sqlSentencia = "SELECT COUNT(*) FROM dbo.Empresas WHERE CUIT = '"+CUIT+"'";
            SqlConnection sqlCnn = new SqlConnection();
            sqlCnn.ConnectionString = conectionString;
            SqlCommand sqlCom = new SqlCommand(sqlSentencia, sqlCnn);
            sqlCnn.Open();
            // Ejecutar el comando y obtener el resultado
            int count = Convert.ToInt32(sqlCom.ExecuteScalar());
            // Si count es mayor que 0, el usuario ya existe
            sqlCnn.Close();
            return count > 0;
        }
    }
}
