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
using System.Data.SqlClient;
using TF.BC;
using TF.ENTITIES;

namespace TF.WIN
{
    public partial class frmLogin : Form
    {
        UsuariosBC oUsuarioBC = new UsuariosBC();
        Usuarios oBe = new Usuarios();
       //frmMenuPrincipal frmMenu = new frmMenuPrincipal();
        public static string UsrNom;
        //MenuPrincipal oMenuP = new MenuPrincipal();

        //readonly MaterialSkin.MaterialSkinManager materialSkinManager;

        public frmLogin()
        {
            InitializeComponent();

            //materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            //materialSkinManager.EnforceBackcolorOnAllComponents = true;
            //materialSkinManager.AddFormToManage(this);
            //materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            //materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Blue500, MaterialSkin.Primary.Blue500, MaterialSkin.Primary.Amber400, MaterialSkin.Accent.Amber200, MaterialSkin.TextShade.BLACK);

        }
        private void Login_Load(object sender, EventArgs e)
        {
        }
        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && !(char.IsNumber(e.KeyChar)))
                e.Handled = true;
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            p_logueo();
        }
        private void p_logueo()
        {
            DataTable dt = new DataTable();
            oBe.Usuario = txtUsuario.Text;
            oBe.Clave = txtClave.Text;
            dt = oUsuarioBC.Login(oBe);
            var userLogin = oUsuarioBC.UserLogin(txtUsuario.Text,txtClave.Text);

            if (txtUsuario.Text != string.Empty)
            {
                if (txtClave.Text != string.Empty)
                {
                    if (dt.Rows.Count > 0 && userLogin == true)
                    {
                        MessageBox.Show("Bienvenido " + dt.Rows[0][3].ToString() + " " + dt.Rows[0][4].ToString(), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        UsrNom = dt.Rows[0][3].ToString();

                        oBe.Usuario = dt.Rows[0][1].ToString();
                        oBe.Clave = dt.Rows[0][2].ToString();
                        frmMenuPrincipal ofrmMenuPrincipal = new frmMenuPrincipal();
                        ofrmMenuPrincipal.Show();
                        this.Hide();
                        //frmMenu.ShowDialog();
                        //frmLogin ofrmLogin = new frmLogin();
                        //if (ofrmLogin.DialogResult == DialogResult.OK)
                        //    Application.Run(new frmMenuPrincipal());
                        //txtUsuario.Clear();
                        //txtClave.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Usuario o Contraseña incorrecta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtUsuario.Clear();
                        txtClave.Clear();
                        txtUsuario.Focus();
                    }
                }
                else MessageBox.Show("Debe ingresar una Contraseña", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Debe ingresar un Usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnNuevoUsuario_Click(object sender, EventArgs e)
        {
            frmNuevoUsuario oNuevoUsr = new frmNuevoUsuario();
            oNuevoUsr.Show();
            this.Hide();
            //frmMenu.Show();
            //NuevoUsr();
        }

        //private void NuevoUsr()
        //{
        //    Form formBackground = new Form();
        //    using (frmNuevoUsuario OnvoUsr = new frmNuevoUsuario())
        //    {
        //        try
        //        {
        //            formBackground.StartPosition = FormStartPosition.Manual;
        //            formBackground.FormBorderStyle = FormBorderStyle.None;
        //            formBackground.Opacity = .50d;
        //            formBackground.BackColor = Color.Black;
        //            formBackground.WindowState = FormWindowState.Maximized;
        //            formBackground.TopMost = true;
        //            formBackground.Location = this.Location;
        //            formBackground.ShowInTaskbar = false;
        //            formBackground.Show();

        //            OnvoUsr.Owner = formBackground;
        //            OnvoUsr.ShowDialog();

        //            formBackground.Dispose();
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show(ex.Message);
        //        }
        //        finally { formBackground.Dispose(); }
        //    }
        //}

        private void lblRegistrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmNuevoUsuario oNuevoUsr = new frmNuevoUsuario();
            oNuevoUsr.Show();
            this.Hide();
            //frmMenu.Show();
            //NuevoUsr();
            //this.Show();
        }

        private void lblRecuperar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRecuperarClave oRecClave = new frmRecuperarClave();
            oRecClave.Show();
        }
    }
}
