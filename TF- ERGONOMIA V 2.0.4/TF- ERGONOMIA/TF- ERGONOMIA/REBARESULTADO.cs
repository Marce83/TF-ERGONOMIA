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
    public partial class REBA_RESULTADO : Form
    {
        public REBA_RESULTADO()
        {
            InitializeComponent();
            RebaResultadoMax();



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





        public void RebaResultadoMax()
        {
            Reba oReba = new Reba();
            //oReba.cargaIdReba = Convert.ToInt32(txtcargaidrebaresultado.Text);
            RebaBC oRebaBC = new RebaBC();
            
            DataTable dt50 = oRebaBC.Reba_ResultadoBC(oReba);

            if (dt50.Rows.Count > 0)
            {
                string resultado = dt50.Rows[0][6].ToString();
                txttroncoreba.Text = resultado;
            }
            if (dt50.Rows.Count > 0)
            {
                string resultado = dt50.Rows[0][7].ToString();
                txtcuelloreba.Text = resultado;
            }
            if (dt50.Rows.Count > 0)
            {
                string resultado = dt50.Rows[0][8].ToString();
                txtpiernareba.Text = resultado;
            }
            if (dt50.Rows.Count > 0)
            {
                string resultado = dt50.Rows[0][9].ToString();
                txtcargafuerzareba.Text = resultado;
            }
            if (dt50.Rows.Count > 0)
            {
                string resultado = dt50.Rows[0][10].ToString();
                txtantebrazoreba.Text = resultado;
            }
            if (dt50.Rows.Count > 0)
            {
                string resultado = dt50.Rows[0][11].ToString();
                txtmunecareba.Text = resultado;
            }
            if (dt50.Rows.Count > 0)
            {
                string resultado = dt50.Rows[0][12].ToString();
                txtbrazoreba.Text = resultado;
            }
            if (dt50.Rows.Count > 0)
            {
                string resultado = dt50.Rows[0][13].ToString();
                txtagarrereba.Text = resultado;
            }
            if (dt50.Rows.Count > 0)
            {
                string resultado = dt50.Rows[0][14].ToString();
                txtpActividadRebaFinal.Text = resultado;
            }
           
        }










    }
}
