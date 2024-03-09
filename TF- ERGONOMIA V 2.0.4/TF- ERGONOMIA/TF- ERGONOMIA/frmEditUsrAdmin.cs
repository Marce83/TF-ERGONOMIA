using iTextSharp.tool.xml.html;
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
using TF.BC;
using TF.COMMON.Cache;
using TF.ENTITIES;

namespace TF.WIN
{
    public partial class frmEditUsrAdmin : Form
    {
        Usuarios oBe = new Usuarios();
        UsuariosBC oUsuarioBC = new UsuariosBC();
        public frmEditUsrAdmin()
        {
            InitializeComponent();
        }

        private void frmEditUsrAdmin_Load(object sender, EventArgs e)
        {
            Resetear();
            Limpiar();
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //panelEditor.Visible = false;
            Resetear();
            Limpiar();
        }

        //private void CargaDatosUser()
        //{
        //    //Panel de edición
        //    txtUsuario.Text = UserLoginCache.Usuario;
        //    txtNombre.Text = UserLoginCache.Nombre;
        //    txtApellido.Text = UserLoginCache.Apellido;
        //    txtClaveActual.Text = UserLoginCache.Clave;
        //    txtCorreo.Text = UserLoginCache.Correo;
        //    txtClaveNueva.Text = "";
        //    txtRepetirClave.Text = "";
        //    cboCargo.Text = UserLoginCache.Cargo;
        //    cboCargo.DropDownStyle = ComboBoxStyle.DropDownList;
        //}

        private void dgvEditarPerfil_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUsuario.Text = dgvEditarPerfil.CurrentRow.Cells[0].Value.ToString();
            txtClaveActual.Text = dgvEditarPerfil.CurrentRow.Cells[1].Value.ToString();
            txtClaveActual.ReadOnly = true;
            txtNombre.Text = dgvEditarPerfil.CurrentRow.Cells[2].Value.ToString();
            txtApellido.Text = dgvEditarPerfil.CurrentRow.Cells[3].Value.ToString();
            cboCargo.Text = dgvEditarPerfil.CurrentRow.Cells[4].Value.ToString();
            txtCorreo.Text = dgvEditarPerfil.CurrentRow.Cells[5].Value.ToString();
        }
            private void Resetear()
        {
            Listar();
            CambiarClave();
        }

        private void CambiarClave()
        {
            linkEditarClave.Text = "Cambiar";
            txtClaveNueva.Enabled = false;
            txtClaveNueva.UseSystemPasswordChar = true;
            txtClaveNueva.Text = "";
            txtRepetirClave.Enabled = false;
            txtRepetirClave.UseSystemPasswordChar = true;
            txtRepetirClave.Text = "";
        }

        private void linkEditarClave_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (linkEditarClave.Text == "Cambiar")
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

        private void Listar()
        {
            try
            {
                UsuariosBC oUsuarioBC = new UsuariosBC();
                DataTable dt = oUsuarioBC.UsuariosGetAll();
                dgvEditarPerfil.DataSource = null;
                dgvEditarPerfil.DataSource = dt;
                dgvEditarPerfil.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                dgvEditarPerfil.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Limpiar()
        {
            txtUsuario.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtCorreo.Text = string.Empty;
            txtClaveActual.Text = string.Empty;
            txtClaveNueva.Text = string.Empty;
            txtRepetirClave.Text = string.Empty;
            cboCargo.Text = string.Empty;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            oBe.Usuario = txtUsuario.Text;
            oBe.Clave = txtClaveActual.Text;
            oBe.Nombre = txtNombre.Text;
            oBe.Apellido = txtApellido.Text;
            oBe.Cargo = cboCargo.Text;
            oBe.Correo = txtCorreo.Text;
            oBe.IdUsuario = oUsuarioBC.ObtenerIdUsuario(oBe);

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
                                if (linkEditarClave.Text == "Cambiar")
                                    {
                                       var res = oUsuarioBC.EditarPerfilAdmin(oBe);
                                       MessageBox.Show(res);
                                       Listar();
                                }
                                else if (ValidarClave(txtClaveNueva.Text))
                                        {
                                          oBe.Clave = txtClaveNueva.Text;
                                          if (txtClaveNueva.Text == txtRepetirClave.Text)
                                           {
                                             var res = oUsuarioBC.EditarPerfilAdmin(oBe);
                                             MessageBox.Show(res);
                                             CambiarClave();
                                             Listar();
                                           }
                                          else
                                                MessageBox.Show("Las claves no coinciden, por favor intente de nuevo");
                                        }
                                else MessageBox.Show("La clave no cumple con los requisitos, por favor intente de nuevo");
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
    }
}
