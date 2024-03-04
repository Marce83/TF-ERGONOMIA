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
using System.Runtime.InteropServices;
using TF.WIN;
using TF.BC;
using TF.COMMON.Cache;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TF.WIN
{
    public partial class frmEstadisticaMenu : Form
    {
        public frmEstadisticaMenu()
        {
            InitializeComponent();
        }

        private void btnEstadisticageneral_Click(object sender, EventArgs e)
        {
            frmEstadisticas ofrmEstadisticas = new frmEstadisticas();
            AddOwnedForm(ofrmEstadisticas);
            ofrmEstadisticas.TopLevel = false;
            ofrmEstadisticas.Dock = DockStyle.Fill;
            this.Controls.Add(ofrmEstadisticas);
            this.Tag = ofrmEstadisticas;
            ofrmEstadisticas.BringToFront();
            ofrmEstadisticas.Show();
         }

        private void btnEstidisticaparticular_Click(object sender, EventArgs e)
        {
            frmEstadisticas2 ofrmEstadisticas2 = new frmEstadisticas2();
            AddOwnedForm(ofrmEstadisticas2);
            ofrmEstadisticas2.TopLevel = false;
            ofrmEstadisticas2.Dock = DockStyle.Fill;
            this.Controls.Add(ofrmEstadisticas2);
            this.Tag = ofrmEstadisticas2;
            ofrmEstadisticas2.BringToFront();
            ofrmEstadisticas2.Show();
          }

    }
}
