using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TF.BC;
using TF.ENTITIES;
using TF.WIN;

namespace TF.WIN
{
    public partial class frmNuevoUsuario : Form
    {
        UsuariosBC oUsuarioBC = new UsuariosBC();
        Usuarios oBe = new Usuarios();
        frmMenuPrincipal frmMenu = new frmMenuPrincipal();
        frmLogin oLogin = new frmLogin();

        //readonly MaterialSkin.MaterialSkinManager materialSkinManager;


        public frmNuevoUsuario()
        {
            InitializeComponent();

            //materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            //materialSkinManager.EnforceBackcolorOnAllComponents = true;
            //materialSkinManager.AddFormToManage(this);
            //materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            //materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Blue500, MaterialSkin.Primary.Blue500, MaterialSkin.Primary.Amber400, MaterialSkin.Accent.Amber200, MaterialSkin.TextShade.BLACK);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void frmNuevoUsuario_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && !(char.IsNumber(e.KeyChar)))
                e.Handled = true;
        }
        private void txtClave_TextChanged(object sender, EventArgs e)
        {
            if (ValidarClave(txtClave.Text))
            {
                btnCargarUsuario.Enabled = true;
            }
            else
            {
                btnCargarUsuario.Enabled = false;
            }
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
        private void CargarUsuario_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Usuarios oBe = new Usuarios();
            oBe.Usuario = txtUsuario.Text;
            oBe.Clave = txtClave.Text;
            oBe.Nombre = txtNombre.Text;
            oBe.Apellido = txtApellido.Text;
            oBe.Correo = txtCorreo.Text;
            UsuariosBC oUsuariosBC = new UsuariosBC();

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
                                if (txtClave.Text != string.Empty)
                                {
                                    if (txtConfClave.Text != string.Empty)
                                    {
                                        if (txtConfClave.Text == txtClave.Text)
                                        {
                                            try
                                            {
                                                oUsuarioBC.BuscarUsr(oBe);
                                                var res = oUsuariosBC.InsertUsuario(oBe);
                                                MessageBox.Show("Usuario Ingresado con exito\nEl cargo debe ser actualizado por el Administrador", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                this.Close();
                                                oLogin.Show();
                                            }
                                            catch (Exception ex)
                                            {
                                                MessageBox.Show(ex.Message);
                                                Limpiar();
                                            }
                                        }
                                        else MessageBox.Show("No coincide con la Contraseña ingresada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    else MessageBox.Show("Debe repetir la Contraseña", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult mess = MessageBox.Show("¿Está seguro que desea salir? Se perderan los datos que no se guardaron", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (mess == DialogResult.Yes)
            {
                //this.Hide();
                //frmMenu.Show();
                oLogin.Show();
                this.Close();
            }
        }

        private void Limpiar()
        {
            txtUsuario.Text = string.Empty;
            txtClave.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtUsuario.Focus();
        }

        private bool ValidarClave (string clave)
        {
            bool May = false, Min = false, Num = false, CarEsp = false;
            for(int i = 0; i < clave.Length; i++) 
            {
                if (char.IsUpper(clave,i))
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

        private void chbVisualizarClave_CheckedChanged(object sender, EventArgs e)
        {
            if(chbVisualizarClave.Checked) 
            {
                txtClave.PasswordChar = '\0';
                txtConfClave.PasswordChar = '\0';
            }
            else
            {
                txtClave.PasswordChar = '*';
                txtConfClave.PasswordChar = '*';
            }
        }
    }
}
