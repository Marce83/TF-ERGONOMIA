using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TF.COMMON.Cache;
using TF.BC;
using TF.ENTITIES;

namespace TF.WIN
{
    public partial class frmPerfilUsuarios : Form
    {
        Usuarios oBe = new Usuarios();
        UsuariosBC oUsuarioBC = new UsuariosBC();

        public frmPerfilUsuarios()
        {
            InitializeComponent();
        }

        private void frmPerfilUsuarios_Load(object sender, EventArgs e)
        {
            RolesCargo();
            CargaDatosUser();
            CambiarClave();
        }


        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && !(char.IsNumber(e.KeyChar)))
                e.Handled = true;
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
                e.Handled = true;
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
                e.Handled = true;
        }

        private void CargaDatosUser ()
        {
            //Vista
            lblUsuario.Text = UserLoginCache.Usuario;
            lblNombre.Text = UserLoginCache.Nombre;
            lblApellido.Text = UserLoginCache.Apellido;
            lblCorreo.Text = UserLoginCache.Correo;
            lblCargo.Text = UserLoginCache.Cargo;

            //Panel de edición
            txtUsuario.Text = UserLoginCache.Usuario;
            txtNombre.Text = UserLoginCache.Nombre;
            txtApellido.Text = UserLoginCache.Apellido;
            txtClaveActual.Text = UserLoginCache.Clave;
            txtCorreo.Text = UserLoginCache.Correo;
            txtClaveNueva.Text = "";
            txtRepetirClave.Text = "";
            cboCargo.Text = UserLoginCache.Cargo;
            //cboCargo.SelectedIndex = 0;
            cboCargo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void CambiarClave()
        {
            linkEditarClave.Text = "Cambiar";
            txtClaveNueva.Enabled = false;
            txtClaveNueva.UseSystemPasswordChar = true;
            txtRepetirClave.Enabled = false;
            txtRepetirClave.UseSystemPasswordChar = true;
        }

        private void linkEditarPerfil_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelEditor.Visible = true;
            CargaDatosUser();
        }
       
        private void Resetear()
        {
            //panelEditor.Visible = true;
            CargaDatosUser();
            CambiarClave();
        }

        private void linkEditarClave_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(linkEditarClave.Text == "Cambiar")
            {
                linkEditarClave.Text = "Cancelar";
                txtClaveNueva.Enabled = true;
                txtClaveNueva.Text = "";
                txtRepetirClave.Enabled = true;
                txtRepetirClave.Text = "";
            }
            else if (linkEditarClave.Text == "Cancelar")
            {
                Resetear();
            }
        }

        private bool ValidarClave(string clave)
        {
            bool May = false, Min = false, Num = false, CarEsp = false;
            for (int i = 0; i < clave.Length; i++)
            {
                if (char.IsUpper(clave, i))
                    May = true;
                else if (char.IsLower(clave, i))
                    Min = true;
                else if (char.IsDigit(clave, i))
                    Num = true;
                else
                    CarEsp = true;
            }
            if (May && Min && Num && CarEsp && clave.Length >= 8)
                return true;
            else return false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            oBe.IdUsuario = UserLoginCache.IdUsuario;
            oBe.Usuario = txtUsuario.Text;
            oBe.Clave = txtClaveActual.Text;
            oBe.Nombre = txtNombre.Text;
            oBe.Apellido = txtApellido.Text;
            oBe.Cargo = cboCargo.Text;
            oBe.Correo = txtCorreo.Text;
            oBe.Cargo = lblCargo.Text;

            if (txtUsuario.Text != string.Empty)
            {
                if (txtNombre.Text != string.Empty)
                {
                    if (txtApellido.Text != string.Empty)
                    {
                        if (txtCorreo.Text != string.Empty)
                        {
                            if (ValidarCorreo.ValidarEmail(txtCorreo.Text))
                            {
                                if (txtClaveActual.Text != string.Empty)
                                {
                                    if (txtClaveActual.Text == UserLoginCache.Clave)
                                    {
                                        if(linkEditarClave.Text == "Cambiar")
                                        {
                                            var res = oUsuarioBC.EditarPerfil(oBe);
                                            MessageBox.Show(res);
                                            Resetear();
                                            panelEditor.Visible = false;
                                        }
                                        
                                        else if (ValidarClave(txtClaveNueva.Text))
                                        {
                                            oBe.Clave = txtClaveNueva.Text;
                                            if (txtClaveNueva.Text == txtRepetirClave.Text)
                                            {
                                                var res = oUsuarioBC.EditarPerfil(oBe);
                                                MessageBox.Show(res);
                                                Resetear();
                                                panelEditor.Visible = false;
                                            }
                                            else
                                                MessageBox.Show("Las claves no coinciden, por favor intente de nuevo");
                                        }
                                        else
                                            MessageBox.Show("La clave no cumple con los requisitos, por favor intente de nuevo");
                                    }
                                    else
                                        MessageBox.Show("Clave actual incorrecta, por favor intente de nuevo");
                                }
                                else MessageBox.Show("Debe ingresar una Contraseña", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else MessageBox.Show("El formato del Correo es inválido", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else MessageBox.Show("Debe ingresar el correo electrónico", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else MessageBox.Show("Debe ingresar el apellido del usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else MessageBox.Show("Debe ingresar el nombre del usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Debe ingresar un nombre de Usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            panelEditor.Visible=false;
            Resetear();
        }

        private void RolesCargo()
        {
            if (UserLoginCache.Cargo != Cargos.Administrador)
            {
                lblEditarCargo.Visible = false;
                cboCargo.Visible = false;
                cboCargo.Enabled = false;
            }
        }
    }
}
