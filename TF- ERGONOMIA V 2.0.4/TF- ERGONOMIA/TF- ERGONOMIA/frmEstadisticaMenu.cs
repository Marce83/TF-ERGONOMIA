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
            ofrmEstadisticas.Show();
        }

        private void btnEstidisticaparticular_Click(object sender, EventArgs e)
        {
            frmEstadisticas2 ofrmEstadisticas2 = new frmEstadisticas2();
            ofrmEstadisticas2.Show();
        }

    }
}
