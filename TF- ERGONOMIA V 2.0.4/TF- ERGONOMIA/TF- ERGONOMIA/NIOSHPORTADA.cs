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
    public partial class NIOSHPORTADA : Form
    {
        public NIOSHPORTADA()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            
            
            
            
            
            
            
            NIOSH1 ONIOSH1 = new NIOSH1();
            ONIOSH1.Show();
            this.Close();
        }
    }
}
