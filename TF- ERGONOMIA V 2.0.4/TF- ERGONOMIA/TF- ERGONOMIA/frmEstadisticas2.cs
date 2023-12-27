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
    public partial class frmEstadisticas2 : Form
    {
        public frmEstadisticas2()
        {
            InitializeComponent();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void frmEstadisticas2_Load(object sender, EventArgs e)
        {

        }
        private void btnBuscarCUIT_Click(object sender, EventArgs e)
        {
            frmBuscarEmpresa oFrm = new frmBuscarEmpresa();
            oFrm.ShowDialog();

            if (oFrm.EmpresaSeleccionada != null)
            {
                txtCUIT.Text = oFrm.EmpresaSeleccionada.CUIT.ToString();
                txtNombreEmpresa.Text = oFrm.EmpresaSeleccionada.Nombre.ToString();

            }

        }
        private void btnBuscarresultado_Click(object sender, EventArgs e)
        {
            ContNIOSH();
            ContREBA();
            ContRULA();
            ContJSS();
            ContMetodos();
            


        }
        public void ContNIOSH()
        {
            try
            {
                EstadisticaBC oEstadisticaBC = new EstadisticaBC();
                EstadisticasPersonales oEstadisticasPersonales = new EstadisticasPersonales();
                oEstadisticasPersonales.CuitNiosh = txtCUIT.Text;
                oEstadisticasPersonales.FechaCargaNiosh = FechaDesde.Text;
                oEstadisticasPersonales.FechaCarga2Niosh = FechaHasta.Text;


                DataTable dt1100 = oEstadisticaBC.ContNIOSHPersonBC(oEstadisticasPersonales);

                if (dt1100.Rows.Count > 0)
                {
                    string resultado1 = dt1100.Rows[0][0].ToString();
                    txtNioshCont.Text = resultado1;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar la búsqueda: Verifique que posea Analisis bajo este Metodo Realizadas ");
            }

        }
        public void ContREBA()
        {
            try
            {
                EstadisticaBC oEstadisticaBC = new EstadisticaBC();
                EstadisticasPersonales oEstadisticasPersonales = new EstadisticasPersonales();
                oEstadisticasPersonales.CuitReba = txtCUIT.Text;
                oEstadisticasPersonales.FechaCargaReba = FechaDesde.Text;
                oEstadisticasPersonales.FechaCarga2Reba = FechaHasta.Text;

                DataTable dt1101 = oEstadisticaBC.ContREBAPersonBC(oEstadisticasPersonales);

                if (dt1101.Rows.Count > 0)
                {
                    string resultado2 = dt1101.Rows[0][0].ToString();
                    txtREBACont.Text = resultado2;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar la búsqueda: Verifique que posea Analisis bajo este Metodo Realizadas ");
            }
        }
        public void ContRULA()
        {
            try
            {
                EstadisticaBC oEstadisticaBC = new EstadisticaBC();
                EstadisticasPersonales oEstadisticasPersonales = new EstadisticasPersonales();

                oEstadisticasPersonales.CuitRula = txtCUIT.Text;
                oEstadisticasPersonales.FechaCargaRula = FechaDesde.Text;
                oEstadisticasPersonales.FechaCarga2Rula = FechaHasta.Text;

                DataTable dt1102 = oEstadisticaBC.ContRULAPersonBC(oEstadisticasPersonales);

                if (dt1102.Rows.Count > 0)
                {
                    string resultado3 = dt1102.Rows[0][0].ToString();
                    txtRulaCont.Text = resultado3;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar la búsqueda: Verifique que posea Analisis bajo este Metodo Realizadas ");
            }
        }
        public void ContJSS()
        {
            try
            {
                EstadisticaBC oEstadisticaBC = new EstadisticaBC();
                EstadisticasPersonales oEstadisticasPersonales = new EstadisticasPersonales();
                oEstadisticasPersonales.CuitJss = txtCUIT.Text;
                oEstadisticasPersonales.FechaCargaJss = FechaDesde.Text;
                oEstadisticasPersonales.FechaCarga2Jss = FechaHasta.Text;

                DataTable dt1103 = oEstadisticaBC.ContJSSPersonBC(oEstadisticasPersonales);

                if (dt1103.Rows.Count > 0)
                {
                    string resultado4 = dt1103.Rows[0][0].ToString();
                    txtjsscont.Text = resultado4;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar la búsqueda: Verifique que posea Analisis bajo este Metodo Realizadas ");
            }
        }
        public void ContMetodos()
        {
            try
            {
                double SumaMetodosPerson = 0;

                SumaMetodosPerson = double.Parse(txtRulaCont.Text) + double.Parse(txtNioshCont.Text) + double.Parse(txtREBACont.Text) + double.Parse(txtjsscont.Text);

                TotalMetodoPerson.Text = SumaMetodosPerson.ToString();
            }
            catch (Exception ex)
            {
              
            }
        }






    }
}
