using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using TF.WIN;
using TF.BC;
using TF.COMMON.Cache;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TF.WIN
{
    public partial class frmMenuPrincipal : Form
    {
        private Timer timer;
        public frmMenuPrincipal()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 1000; // Intervalo de actualización en milisegundos (1 segundo en este ejemplo)
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("¿Desea salir de la aplicación?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resp == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void AbrirFormHija(object formHija)
        {
            if(this.PanelConector.Controls.Count > 0) 
            {
                this.PanelConector.Controls.RemoveAt(0);
            }
            Form fh = formHija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelConector.Controls.Add(fh);
            fh.Show();
        }

        private void btnempresa_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new frmEmpresa());
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new frmEmpleados());
        }

        private void btnMetodo_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new Metodos());
        }

        private void btnInformes_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new frmInformes());
        }

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new frmEstadisticas());
        }

        private void linkPerfil_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(UserLoginCache.Cargo == "Administrador")
                AbrirFormHija(new frmEditUsrAdmin());
            else
                AbrirFormHija(new frmPerfilUsuarios());
        }

        private void btnMetodoRula_Click(object sender, EventArgs e)
        {
            RULA_PORTADA oRULA_PORTADA = new RULA_PORTADA();
            oRULA_PORTADA.Show();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            LoadUserData();
            RolesCargo();
            //Crear una instancia del formulario Login
            //Login Ologin = new Login();
            // Mostrar Login sobre Menu_Principal
            //Ologin.ShowDialog();
           //this.Show();
            //LoginP();
        }

        //private void LoginP()
        //{
        //    Form formBackground = new Form();
        //    using (frmLogin fLogin = new frmLogin())
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

        //            fLogin.Owner = formBackground;
        //            fLogin.ShowDialog();

        //            formBackground.Dispose();
        //        } 
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show(ex.Message);
        //        }
        //        finally { formBackground.Dispose(); }
        //    }
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 240)
            {
                MenuVertical.Width = 80;
            }
            else
                MenuVertical.Width = 240;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Actualizar el contenido del control Label con la hora del sistema en tiempo real
            labelHora.Text = DateTime.Now.ToString("HH:mm:ss - dd/MM/yyyy");
        }

        private void cerrarsesion_Click(object sender, EventArgs e)
        {
            DialogResult mess = MessageBox.Show("¿Está seguro que desea cerrar la sesión?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (mess == DialogResult.Yes)
            {
                frmLogin ofrmLogin = new frmLogin();
                ofrmLogin.Show();
                Close();
            }
        }
        
        private void LoadUserData()
        {
            lblUsrLog.Text = UserLoginCache.Nombre +' '+ UserLoginCache.Apellido;
            lblUsrCar.Text = UserLoginCache.Cargo;
        }

        private void RolesCargo()
        {
            if (UserLoginCache.Cargo == Cargos.Usuario)
            {
                btnEmpresa.Enabled = false;
                btnEmpleados.Enabled = false;
                btnMetodo.Enabled = false;
                btnInformes.Enabled = false;
                btnEstadisticas.Enabled = false;
            }
            if (UserLoginCache.Cargo == Cargos.Recepcionista)
            {
                btnMetodo.Enabled = false;
                btnEstadisticas.Enabled = false;
            }
            if (UserLoginCache.Cargo == Cargos.Contador)
            {
                btnMetodo.Enabled = false;
            }
        }
    }
}
