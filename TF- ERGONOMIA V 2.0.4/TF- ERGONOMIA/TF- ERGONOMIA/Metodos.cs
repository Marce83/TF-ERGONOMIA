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
    public partial class Metodos : Form
    {
        public Metodos()
        {
            InitializeComponent();
        }

        private void btnRula_Click(object sender, EventArgs e)
        {

            RULA_PORTADA oRULA_PORTADA = new RULA_PORTADA();
            oRULA_PORTADA.Show();
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            RULARESULTADO oRULARESULTADO = new RULARESULTADO();
            oRULARESULTADO.Show();
        }
    }
}
