using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TF.ENTITIES;

namespace TF.WIN
{
    public partial class REBA_RESULTADO : Form
    {
        public REBA_RESULTADO()
        {
            InitializeComponent();

            

        }

        private void btnpagant_Click(object sender, EventArgs e)
        {
            REBA1 OREBA1 = new REBA1();
            OREBA1.Show();
            Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
