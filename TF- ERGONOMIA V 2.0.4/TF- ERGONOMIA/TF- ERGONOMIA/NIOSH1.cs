using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TF.WIN
{
    public partial class NIOSH1 : Form
    {
        public NIOSH1()
        {
            InitializeComponent();
        }

        private void btncerrarReba_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardarReba1_Click(object sender, EventArgs e)
        {




            NISHRESULTADO ONISHRESULTADO = new NISHRESULTADO();
            ONISHRESULTADO.Show();

        }
    }
}
