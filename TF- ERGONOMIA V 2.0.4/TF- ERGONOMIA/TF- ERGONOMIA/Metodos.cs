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

        private void btnReba_Click(object sender, EventArgs e)
        {
            REBA_PORTADA OREBA_PORTADA =new REBA_PORTADA();
            OREBA_PORTADA.Show();
        }

        private void btnRebaResultado_Click(object sender, EventArgs e)
        {
            REBA_RESULTADO OREBA_RESULTADO = new REBA_RESULTADO();
            OREBA_RESULTADO.Show();
        }

        private void btnNiosh_Click(object sender, EventArgs e)
        {
            NIOSHPORTADA ONIOSHPORTADA = new NIOSHPORTADA();
            ONIOSHPORTADA.Show();

        }

        private void btnNioshResultado_Click(object sender, EventArgs e)
        {
            NIOSHRESULTADO ONIOSHRESULTADO = new NIOSHRESULTADO();
            ONIOSHRESULTADO.Show(); 
        }
    }
}
