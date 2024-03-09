using MaterialSkin
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

namespace TF__ERGONOMIA
{
    public partial class Menu_Principal : Form
    {
  
        public Menu_Principal()
        {
            InitializeComponent();
        }

        private void cargaDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RULACARGA oRULACARGA = new RULACARGA();
            oRULACARGA.Show();
        }

       private void planillaDeVisualizacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RULARESULTADO oRULACARGA4 = new RULARESULTADO();
            oRULACARGA4.Show();
        }

       private void Form1_Load(object sender, EventArgs e)
        {
            // Crear una instancia del formulario Login
            frmLogin Ologin = new frmLogin();
            // Mostrar Login sobre Menu_Principal
            Ologin.ShowDialog();

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {

        }

        private void materialButton2_Click_1(object sender, EventArgs e)
        {
            RULACARGA oRULACARGA = new RULACARGA();
            oRULACARGA.Show();
        }

        private void HabilitarMenu ()
        {

        }
    }
}
