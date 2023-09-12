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
    public partial class REBA1 : Form
    {
        public REBA1()
        {
            InitializeComponent();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {






            REBA_RESULTADO OREBA_RESULTADO = new REBA_RESULTADO();
            OREBA_RESULTADO.Show();
            Close();
        }
    }
}
