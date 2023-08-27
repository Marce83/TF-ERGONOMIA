using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using TF.ENTITIES;
using TF.DAC;
using TF.COMMON.Cache;

namespace TF.BC
{
    public class UsuariosBC
    {
        UsuariosDAC oUsuariosDAC = new UsuariosDAC();

        public DataTable Login(Usuarios oBe)
        {
            DataTable dt = oUsuariosDAC.Login(oBe);
            return dt;
        }

        public DataTable UsuariosGetAll()
        {
            DataTable dt = oUsuariosDAC.UsuariosGetAll();
            return dt;
        }

        public int ObtenerIdUsuario(Usuarios oBe)
        {
            return oUsuariosDAC.ObtenerIdUsuario(oBe);
        }

        public int InsertUsuario(Usuarios oBe)
        {
            return oUsuariosDAC.InsertUsuario(oBe);
        }

        public void BuscarUsr(Usuarios oBe)
        {
            if(oUsuariosDAC.ExisteUsr(oBe.Usuario)) 
            {
                throw new Exception("El usuario ya existe, por favor ingrese otro.");
            }
        }

        public void BuscarCorreo(Usuarios oBe)
        {
            if (oUsuariosDAC.ExisteUsr(oBe.Correo))
            {
                throw new Exception("El Correo ya existe, por favor ingrese otro.");
            }
        }

        public bool UserLogin(string Usuario, string Clave)
        {
            return oUsuariosDAC.UserLogin(Usuario, Clave);
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
            return oUsuariosDAC.RecuperarClave(userRequesting);
        }

        public string EditarPerfil(Usuarios oBe)
        {
            try
            {
                oUsuariosDAC.EditarPerfil(oBe);
                UserLogin(oBe.Usuario, oBe.Clave);
                return "Tu perfil se ha actualizado correctamente";
            }
            catch (Exception ex)
            { return "El usuario ya se encuentra registrado, por favor probar con otro" + ex;
            }
        }

        public string EditarPerfilAdmin(Usuarios oBe)
        {
            try
            {
                oUsuariosDAC.EditarPerfil(oBe);
                //UserLogin(oBe.Usuario, oBe.Clave);
                return "Tu perfil se ha actualizado correctamente";
            }
            catch (Exception ex)
            {
                return "El usuario ya se encuentra registrado, por favor probar con otro" + ex;
            }
        }
    }
}
