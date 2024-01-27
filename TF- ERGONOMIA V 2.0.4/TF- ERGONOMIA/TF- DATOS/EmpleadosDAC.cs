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

    public class EmpleadosDAC
    {

        string conectionString = ConnectionStringManager.ConectionString;

        public DataTable Empleados_GetAll()
        {
            string sqlSentencia = "SP_Empleados_GetAll";
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

        public int InsertEmpleados(Empleados oEmpl)
        {
            try
            {
                string sqlSentencia = "SP_Empleados_Insert";
                SqlConnection sqlCnn = new SqlConnection();
                sqlCnn.ConnectionString = conectionString;
                SqlCommand sqlCom = new SqlCommand(sqlSentencia, sqlCnn);
                sqlCom.CommandType = CommandType.StoredProcedure;
                sqlCom.Parameters.Add("@Nombre", SqlDbType.NVarChar).Value = oEmpl.Nombre;
                sqlCom.Parameters.Add("@Apellido", SqlDbType.NVarChar).Value = oEmpl.Apellido;
                sqlCom.Parameters.Add("@DNI", SqlDbType.NVarChar).Value = oEmpl.DNI;
                sqlCom.Parameters.Add("@Genero", SqlDbType.NVarChar).Value = oEmpl.Genero;
                //sqlCom.Parameters.Add("@AreaEmpresa", SqlDbType.NVarChar).Value = oEmpl.AreaEmpresa;
                sqlCom.Parameters.Add("@Peso", SqlDbType.Float).Value = oEmpl.Peso;
                sqlCom.Parameters.Add("@Altura", SqlDbType.Float).Value = oEmpl.Altura;
                sqlCom.Parameters.Add("@FechaNacimiento", SqlDbType.Date).Value = oEmpl.FechaNacimiento;
                sqlCom.Parameters.Add("@FechaIngreso", SqlDbType.Date).Value = oEmpl.FechaIngreso;
                sqlCom.Parameters.Add("@FechaEgreso", SqlDbType.Date).Value = DBNull.Value;
                sqlCom.Parameters.Add("@Estado", SqlDbType.NVarChar).Value = 'A';
                sqlCom.Parameters.Add("@IdEmpresa", SqlDbType.Int).Value = oEmpl.IdEmpresa;
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

        public DataTable Empleados_IdEmpresa(Empresas oemp)
        {
            string sqlSentencia = "SP_Empresas_GetIdempresa";
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

        public DataTable ConsultarEmpleadosPorDNI(Empleados oempl)
        {
            try
            {
                string sqlSentencia = "SP_Empleados_DNI";
                SqlConnection sqlCnn = new SqlConnection();
                sqlCnn.ConnectionString = conectionString;
                SqlCommand sqlCom = new SqlCommand(sqlSentencia, sqlCnn);
                sqlCom.CommandType = CommandType.StoredProcedure;
                sqlCom.Parameters.Add("@DNI", SqlDbType.NVarChar).Value = oempl.DNI;
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

        public DataTable ConsultarEmpleadosPorNombre(Empleados oempl)
        {
            try
            {
                string sqlSentencia = "SELECT Nombre, Apellido, DNI, Genero, Peso, Altura, FechaNacimiento 'Fecha de Nacimiento', FechaIngreso 'Fecha de Ingreso', Estado FROM Empleados WHERE Nombre LIKE '"+"%"+oempl.Nombre+"%"+ "' AND Estado = 'A'";
                SqlConnection sqlCnn = new SqlConnection();
                sqlCnn.ConnectionString = conectionString;
                SqlCommand sqlCom = new SqlCommand(sqlSentencia, sqlCnn);
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

        public DataTable ConsultarEmpleadosPorApellido(Empleados oempl)
        {
            try
            {
                string sqlSentencia = "SELECT Nombre, Apellido, DNI, Genero, Peso, Altura, FechaNacimiento 'Fecha de Nacimiento', FechaIngreso 'Fecha de Ingreso', Estado FROM Empleados WHERE Apellido LIKE '"+"%"+oempl.Apellido+"%"+"' AND Estado = 'A'";
                SqlConnection sqlCnn = new SqlConnection();
                sqlCnn.ConnectionString = conectionString;
                SqlCommand sqlCom = new SqlCommand(sqlSentencia, sqlCnn);
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

        public int ObtenerSoloIdEmpresa(long CUIT)
        {
            Empresas oEmpresas = new Empresas();
            string sqlSentencia = "SP_Empresas_Solo_GetId";
            SqlConnection sqlCnn = new SqlConnection();
            sqlCnn.ConnectionString = conectionString;
            SqlCommand sqlComm = new SqlCommand(sqlSentencia, sqlCnn);
            sqlComm.CommandType = CommandType.StoredProcedure;
            sqlComm.Parameters.Add("@CUIT", SqlDbType.NVarChar).Value = CUIT;
            sqlCnn.Open();
            SqlDataReader dr = sqlComm.ExecuteReader();
            while (dr.Read())
            {
                oEmpresas.IdEmpresa = dr.GetInt32(0);
            }
            sqlCnn.Close();
            int IdEmpresa = oEmpresas.IdEmpresa;
            return IdEmpresa;
        }

        public int ModificarEmpleados(Empleados oEmpl)
        {
            try
            {
                string sqlSentencia = "SP_Empleados_Update";
                SqlConnection sqlCnn = new SqlConnection();
                sqlCnn.ConnectionString = conectionString;
                SqlCommand sqlCom = new SqlCommand(sqlSentencia, sqlCnn);
                sqlCom.CommandType = CommandType.StoredProcedure;
                sqlCom.Parameters.Add("@Nombre", SqlDbType.NVarChar).Value = oEmpl.Nombre;
                sqlCom.Parameters.Add("@Apellido", SqlDbType.NVarChar).Value = oEmpl.Apellido;
                sqlCom.Parameters.Add("@DNI", SqlDbType.NVarChar).Value = oEmpl.DNI;
                sqlCom.Parameters.Add("@Genero", SqlDbType.NVarChar).Value = oEmpl.Genero;
                //sqlCom.Parameters.Add("@AreaEmpresa", SqlDbType.NVarChar).Value = oEmpl.AreaEmpresa;
                sqlCom.Parameters.Add("@Peso", SqlDbType.Float).Value = oEmpl.Peso;
                sqlCom.Parameters.Add("@Altura", SqlDbType.Float).Value = oEmpl.Altura;
                sqlCom.Parameters.Add("@FechaNacimiento", SqlDbType.Date).Value = oEmpl.FechaNacimiento;
                //sqlCom.Parameters.Add("@FechaIngreso", SqlDbType.Date).Value = oEmpl.FechaIngreso;
                //sqlCom.Parameters.Add("@FechaEgreso", SqlDbType.Date).Value = DBNull.Value;
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

        public int BajaEmpleado(Empleados oEmpl)
        {
            try
            {
                string sqlSentencia = "SP_Empleado_Delete";
                SqlConnection sqlCnn = new SqlConnection();
                sqlCnn.ConnectionString = conectionString;
                SqlCommand sqlCom = new SqlCommand(sqlSentencia, sqlCnn);
                sqlCom.CommandType = CommandType.StoredProcedure;
                sqlCom.Parameters.Add("@DNI", SqlDbType.NVarChar).Value = oEmpl.DNI;
                sqlCom.Parameters.Add("@Estado", SqlDbType.NVarChar).Value = 'B';
                sqlCom.Parameters.Add("@FechaEgreso", SqlDbType.Date).Value = DateTime.Now;

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

        public Empleados ObtenerEmpleadoid(int DNI)
        {
            Empleados oEmpleados = new Empleados();
            string sqlSentencia = "SP_Empleados_GetId";
            SqlConnection sqlCnn = new SqlConnection();
            sqlCnn.ConnectionString = conectionString;
            SqlCommand sqlComm = new SqlCommand(sqlSentencia, sqlCnn);
            sqlComm.CommandType = CommandType.StoredProcedure;
            sqlComm.Parameters.Add("@DNI", SqlDbType.NVarChar).Value = DNI;
            sqlCnn.Open();

            SqlDataReader dr = sqlComm.ExecuteReader();
            while (dr.Read())
            {
                oEmpleados.Nombre = dr.GetString(0);
                oEmpleados.Apellido = dr.GetString(1);
                oEmpleados.DNI = dr.GetString(2);
                oEmpleados.Genero = dr.GetString(4);
                //oEmpleados.PuestoDeTrabajo = dr.GetString(5);

            }
            sqlCnn.Close();
            return oEmpleados;
        }

        public bool ExisteEmpleado(String DNI)
        {
            string sqlSentencia = "SELECT COUNT(*) FROM dbo.Empleados WHERE DNI = '" + DNI + "'";
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

