using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TF.BC;
using TF.ENTITIES;

namespace TF.WIN
{
    public partial class NIOSH1 : Form
    {
        public NIOSH1()
        {
            InitializeComponent();
        }

        private void btncerrarNiosh_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardarNiosh1_Click(object sender, EventArgs e)
        {

            NioshBC oNioshBC = new NioshBC();
            Niosh oNiosh = new Niosh();

            oNiosh.cargaIdNiosh = int.Parse(txtcargaidniosh.Text);
            oNiosh.LCNiosh = int.Parse(txtLCN.Text);
            oNiosh.HMNiosh = int.Parse(txtHM.Text);
            oNiosh.VMNiosh = int.Parse(txtVM.Text);
            oNiosh.AMNiosh = int.Parse(txtAM.Text);
            oNiosh.FMNiosh = int.Parse(cboFrecuencia.Text);
            oNiosh.CMRNiosh = int.Parse(cboCM.Text);
            oNiosh.Duraciontarea = cboDuraciontarea.Text;  // VER DE PONER UN TEXTBOX CON UN VALOR NUMERO//
            oNiosh.FrecuenciaNiosh = int.Parse(cboFrecuencia.Text); //SE REPITE//
            oNiosh.CADNiosh = cboCM.Text; // SE REPITE//
            oNiosh.PesoCargaNiosh = int.Parse(txtLCN.Text);   //SE REPITE//


            var res = oNioshBC.UpdateNiosh1BC(oNiosh);
            MessageBox.Show("Carga Guardada");


            
        
            NIOSHRESULTADO ONIOSHRESULTADO = new NIOSHRESULTADO();
            ONIOSHRESULTADO.Show();

        }

        private void NIOSH1_Load(object sender, EventArgs e)
        {


            // Puntuación Duracion Tarea




        }
    }
}
