using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using TF.ENTITIES;
using TF.COMMON.Cache;
using TF.DAC.EmailServices;
using System.Linq.Expressions;
using System.Runtime.InteropServices;

namespace TF.DAC
{
    public class UsuariosDAC
    {
        string conectionString = ConnectionStringManager.ConectionString;
        public DataTable Login(Usuarios oBe)
        {
            try
            {
                string sqlSentencia = "SP_Login";
                SqlConnection sqlCnn = new SqlConnection();
                sqlCnn.ConnectionString = conectionString;
                SqlCommand sqlCom = new SqlCommand(sqlSentencia, sqlCnn);
                sqlCom.CommandType = CommandType.StoredProcedure;
                sqlCom.Parameters.Add("@Usuario", SqlDbType.NVarChar).Value = oBe.Usuario;
                sqlCom.Parameters.Add("@Clave", SqlDbType.NVarChar).Value = oBe.Clave;
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
                Console.WriteLine("Error en el logueo del Usuario: " + ex.Message);
                return null;
            }
        }

        public bool UserLogin(string Usuario, string Clave)
        {
            try
            {
                string sqlSentencia = "SP_Login";
                SqlConnection sqlCnn = new SqlConnection();
                sqlCnn.ConnectionString = conectionString;
                SqlCommand sqlCom = new SqlCommand(sqlSentencia, sqlCnn);
                sqlCom.CommandType = CommandType.StoredProcedure;
                sqlCom.Parameters.Add("@Usuario", SqlDbType.NVarChar).Value = Usuario;
                sqlCom.Parameters.Add("@Clave", SqlDbType.NVarChar).Value = Clave;
                sqlCnn.Open();
                SqlDataReader reader = sqlCom.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        UserLoginCache.IdUsuario = reader.GetInt32(0);
                        UserLoginCache.Usuario = reader.GetString(1);
                        UserLoginCache.Clave = reader.GetString(2);
                        UserLoginCache.Nombre = reader.GetString(3);
                        UserLoginCache.Apellido = reader.GetString(4);
                        UserLoginCache.Cargo = reader.GetString(5);
                        UserLoginCache.Correo = reader.GetString(6);
                    }
                }
                sqlCnn.Close();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al validar el Usuario: " + ex.Message);
                return false;
            }
        }

        public int InsertUsuario(Usuarios oBe)
        {
            try
            {
                string sqlSentencia = "SP_makeLogin";
                SqlConnection sqlCnn = new SqlConnection();
                sqlCnn.ConnectionString = conectionString;
                SqlCommand sqlCom = new SqlCommand(sqlSentencia, sqlCnn);
                sqlCom.CommandType = CommandType.StoredProcedure;
                sqlCom.Parameters.Add("@Usuario", SqlDbType.NVarChar).Value = oBe.Usuario;
                sqlCom.Parameters.Add("@Clave", SqlDbType.NVarChar).Value = oBe.Clave;
                sqlCom.Parameters.Add("@Nombre", SqlDbType.NVarChar).Value = oBe.Nombre;
                sqlCom.Parameters.Add("@Apellido", SqlDbType.NVarChar).Value = oBe.Apellido;
                sqlCom.Parameters.Add("@Cargo", SqlDbType.NVarChar).Value = "Usuario";
                sqlCom.Parameters.Add("@Correo", SqlDbType.NVarChar).Value = oBe.Correo;
                sqlCnn.Open();
                var res = sqlCom.ExecuteNonQuery();
                sqlCnn.Close();
                return 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar los datos del Usuario: " + ex.Message);
                return 0;
            }
        }
        
        public bool ExisteUsr(String NombreUsr)
        {
            string sqlSentencia = "SP_ExisteUsr";
            SqlConnection sqlCnn = new SqlConnection();
            sqlCnn.ConnectionString = conectionString;
            SqlCommand sqlCom = new SqlCommand(sqlSentencia, sqlCnn);
            sqlCom.CommandType = CommandType.StoredProcedure;
            sqlCnn.Open();
            sqlCom.Parameters.AddWithValue("@Usuario", NombreUsr);
            // Ejecutar el comando y obtener el resultado
            int count = Convert.ToInt32(sqlCom.ExecuteScalar());
            // Si count es mayor que 0, el usuario ya existe
            sqlCnn.Close();
            return count > 0;
        }

        public bool ExisteCorreo(String CorreoUsr)
        {
            string sqlSentencia = "SP_ExisteCorreo";
            SqlConnection sqlCnn = new SqlConnection();
            sqlCnn.ConnectionString = conectionString;
            SqlCommand sqlCom = new SqlCommand(sqlSentencia, sqlCnn);
            sqlCom.CommandType = CommandType.StoredProcedure;
            sqlCnn.Open();
            sqlCom.Parameters.AddWithValue("@Correo", CorreoUsr);
            // Ejecutar el comando y obtener el resultado
            int count = Convert.ToInt32(sqlCom.ExecuteScalar());
            // Si count es mayor que 0, el usuario ya existe
            sqlCnn.Close();
            return count > 0;

        }

        public void PermisosRoles()
        {
            if (UserLoginCache.Cargo == Cargos.Administrador)
            { }
            if (UserLoginCache.Cargo == Cargos.Recepcionista)
            { }
            if (UserLoginCache.Cargo == Cargos.Profesional)
            { }
            if (UserLoginCache.Cargo == Cargos.Contador)
            { }
            if (UserLoginCache.Cargo == Cargos.Usuario)
            { }
        }

        public string RecuperarClave(string userRequesting)
        {
            string sqlSentencia = "SELECT * FROM Usuarios WHERE Usuario = @Usuario OR\tCorreo = @Correo";
            SqlConnection sqlCnn = new SqlConnection();
            sqlCnn.ConnectionString = conectionString;
            SqlCommand sqlCom = new SqlCommand(sqlSentencia, sqlCnn);
            sqlCom.CommandType = CommandType.Text;
            sqlCnn.Open();
            sqlCom.Parameters.Add("@Usuario", SqlDbType.NVarChar).Value = userRequesting;
            sqlCom.Parameters.Add("@Correo", SqlDbType.NVarChar).Value = userRequesting;
            SqlDataReader reader = sqlCom.ExecuteReader();
            if (reader.Read() == true)
            {
                string Usuario = reader.GetString(1);
                string Clave = reader.GetString(2);
                string Correo = reader.GetString(6);

                var mailService = new EmailServices.SupportMail();
                mailService.EnvioMail(subject: "Solicitud de recuperación de contraseña",
                    body: "Hola " + Usuario + "\n Usted ha solicitado recuperar su contraseña.\n" + "Su contraseña actual es: " + Clave,
                    recipientMail: new List<string> { Correo });
                return "Hola " + Usuario + "\n Usted ha solicitado recuperar su contraseña.\n" + "Por favor revise su correo: " + Correo;
            }
            else
                return "No existe una cuenta con ese correo";
        }

        public void EditarPerfil(Usuarios oUser)
        {
           try
            {
                string sqlSentencia = "UPDATE Usuarios SET Usuario = @Usuario, Clave = @Clave, Nombre = @Nombre, Apellido = @Apellido, Cargo = @Cargo, Correo = @Correo WHERE IdUsuario = @IdUsuario";
                SqlConnection sqlCnn = new SqlConnection();
                sqlCnn.ConnectionString = conectionString;
                SqlCommand sqlCom = new SqlCommand(sqlSentencia, sqlCnn);
                sqlCom.CommandType = CommandType.Text;
                sqlCom.Parameters.Add("@IdUsuario", SqlDbType.NVarChar).Value = oUser.IdUsuario;
                sqlCom.Parameters.Add("@Usuario", SqlDbType.NVarChar).Value = oUser.Usuario;
                sqlCom.Parameters.Add("@Clave", SqlDbType.NVarChar).Value = oUser.Clave;
                sqlCom.Parameters.Add("@Nombre", SqlDbType.NVarChar).Value = oUser.Nombre;
                sqlCom.Parameters.Add("@Apellido", SqlDbType.NVarChar).Value = oUser.Apellido;
                sqlCom.Parameters.Add("@Cargo", SqlDbType.NVarChar).Value = oUser.Cargo;
                sqlCom.Parameters.Add("@Correo", SqlDbType.NVarChar).Value = oUser.Correo;

                sqlCnn.Open();
                var res = sqlCom.ExecuteNonQuery();
                sqlCnn.Close();
            }
            catch (Exception ex) { }
        }

        public DataTable UsuariosGetAll()
        {
            string sqlSentencia = "SELECT Usuario, Clave, Nombre, Apellido, Cargo, Correo FROM Usuarios";
            SqlConnection sqlCnn = new SqlConnection();
            sqlCnn.ConnectionString = conectionString;
            SqlCommand sqlComm = new SqlCommand(sqlSentencia, sqlCnn);
            sqlComm.CommandType = CommandType.Text;
            sqlCnn.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter DA = new SqlDataAdapter();
            DA.SelectCommand = sqlComm;
            DA.Fill(ds);
            sqlCnn.Close();

            return ds.Tables[0];
        }

        public int ObtenerIdUsuario(Usuarios oBe)
        {
            Usuarios oUsuarios = new Usuarios();
            string sqlSentencia = "SELECT * FROM Usuarios WHERE Usuario = @Usuario AND Nombre = @Nombre AND Apellido = @Apellido";
            SqlConnection sqlCnn = new SqlConnection();
            sqlCnn.ConnectionString = conectionString;
            SqlCommand sqlComm = new SqlCommand(sqlSentencia, sqlCnn);
            sqlComm.CommandType = CommandType.Text;
            sqlComm.Parameters.Add("@Usuario", SqlDbType.NVarChar).Value = oBe.Usuario;
            sqlComm.Parameters.Add("@Nombre", SqlDbType.NVarChar).Value = oBe.Nombre;
            sqlComm.Parameters.Add("@Apellido", SqlDbType.NVarChar).Value = oBe.Apellido;
            sqlCnn.Open();
            SqlDataReader dr = sqlComm.ExecuteReader();
            while (dr.Read())
            {
                oUsuarios.IdUsuario = dr.GetInt32(0);
            }
            sqlCnn.Close();
            int IdUsuario = oUsuarios.IdUsuario;
            return IdUsuario;
        }
    }
}
