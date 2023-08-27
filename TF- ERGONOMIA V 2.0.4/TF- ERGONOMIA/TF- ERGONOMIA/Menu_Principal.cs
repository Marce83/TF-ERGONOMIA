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
    public partial class Menu_Principal : MaterialForm
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;


        public Menu_Principal()
        {
            InitializeComponent();

            materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Blue500, MaterialSkin.Primary.Blue500, MaterialSkin.Primary.Amber400, MaterialSkin.Accent.Amber200, MaterialSkin.TextShade.BLACK);

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
