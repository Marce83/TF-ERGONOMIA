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
                txtCUITEncontrado.Text = oFrm.EmpresaSeleccionada.CUIT.ToString();

            }
            if (oFrm.EmpresaSeleccionada != null)
            {
                txtNombreEmpresa.Text = oFrm.EmpresaSeleccionada.Nombre.ToString();
            }
        }
        private void btnBuscarresultado_Click(object sender, EventArgs e)
        {



            ContNIOSH();
            ContREBA();
            ContRULA();
            ContJSS();


        }

        public void ContNIOSH()
        {
            try
            {
                EstadisticaBC oEstadisticaBC = new EstadisticaBC();
                Niosh oNiosh = new Niosh();

                oNiosh.CUITNiosh = txtCUITEncontrado.Text;
                oNiosh.FechaCargaNiosh = FechaDesde.Value;
                oNiosh.FechaCargaNiosh2 = FechaHasta.Value;


                DataTable dt1100 = oEstadisticaBC.ContNIOSHPersonBC();

                if (dt1100.Rows.Count > 0)
                {
                    string resultado1 = dt1100.Rows[0][0].ToString();
                    txtNioshCont.Text = resultado1;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar la búsqueda: " + ex.Message);
            }

        }

        public void ContREBA()
        {
            try
            {
                EstadisticaBC oEstadisticaBC = new EstadisticaBC();
                Reba oReba = new Reba();

                oReba.CUITReba = txtCUITEncontrado.Text;
                oReba.FechaCargaReba = FechaDesde.Value;
                oReba.FechaCargaReba2 = FechaHasta.Value;

                DataTable dt1101 = oEstadisticaBC.ContREBAPersonBC();

                if (dt1101.Rows.Count > 0)
                {
                    string resultado2 = dt1101.Rows[0][0].ToString();
                    txtREBACont.Text = resultado2;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar la búsqueda: " + ex.Message);
            }
        }

        public void ContRULA()
        {
            try
            {
                EstadisticaBC oEstadisticaBC = new EstadisticaBC();
                Rula orula = new Rula();

                orula.CUIT = txtCUITEncontrado.Text;
                orula.FechaCarga = FechaDesde.Value;  // Asegúrate de que FechaDesde.Value sea un objeto DateTime válido
                orula.FechaCarga2 = FechaHasta.Value;  // Asegúrate de que FechaHasta.Value sea un objeto DateTime válido

                DataTable dt1102 = oEstadisticaBC.ContRULAPersonBC();

                if (dt1102.Rows.Count > 0)
                {
                    string resultado3 = dt1102.Rows[0][0].ToString();
                    txtRulaCont.Text = resultado3;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar la búsqueda: " + ex.Message);
            }
          }
    public void ContJSS()
        {
            try
            {
                EstadisticaBC oEstadisticaBC = new EstadisticaBC();
                jss Ojss = new jss();

                Ojss.CUITJSS = txtCUITEncontrado.Text;

                // Obtener las fechas directamente de los DateTimePicker
                Ojss.FechaCargaJss = FechaDesde.Value;
                Ojss.FechaCargaJss2 = FechaHasta.Value;

                DataTable dt1103 = oEstadisticaBC.ContJSSPersonBC();

                if (dt1103.Rows.Count > 0)
                {
                    string resultado4 = dt1103.Rows[0][0].ToString();
                    txtjsscont.Text = resultado4;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar la búsqueda: " + ex.Message);
                // Puedes agregar mensajes más descriptivos según sea necesario
            }
        }



    }
}
