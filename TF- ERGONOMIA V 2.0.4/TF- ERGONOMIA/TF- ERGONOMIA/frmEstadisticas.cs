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
    public partial class frmEstadisticas : Form
    {
        public frmEstadisticas()
        {
            InitializeComponent();
        }

        private void frmEstadisticas_Load(object sender, EventArgs e)
        {
            ContEmpresas();
            ContEmpresasprov();
            ContEmpresasLoc();
            ContEmpleadosemp();
            ContEmpleados();
            ContJSS();
            ContNIOSH();
            ContREBA();
            ContRULA();

        }


        public void ContEmpresas()
        {
            EstadisticaBC oEstadisticaBC = new EstadisticaBC();
            
            //DataTable dt = oRulaBC.RULACONSULTARRESULTADOIDBC(oRula);


            DataTable dt1000 = oEstadisticaBC.ContEmpresasBC();

            if (dt1000.Rows.Count > 0)
            {
                string resultado = dt1000.Rows[0][0].ToString();
                txtempresasregistradas.Text = resultado;
            }
          
        }
        private void ContEmpresasprov()
        {
            try
            {
                EstadisticaBC oEstadisticaBC = new EstadisticaBC();
                DataTable dt1001 = oEstadisticaBC.ContEmpresasprovBC();
                dgvprovemp.DataSource = null;
                dgvprovemp.DataSource = dt1001;
                dgvprovemp.Columns[1].HeaderText = "Número";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ContEmpresasLoc()
        {
            try
            {
                EstadisticaBC oEstadisticaBC = new EstadisticaBC();
                DataTable dt1003 = oEstadisticaBC.ContEmpresasLocBC();
                dgvlocemp.DataSource = null;
                dgvlocemp.DataSource = dt1003;
                dgvlocemp.Columns[1].HeaderText = "Número";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void ContEmpleados()
        {
            EstadisticaBC oEstadisticaBC = new EstadisticaBC();

            //DataTable dt = oRulaBC.RULACONSULTARRESULTADOIDBC(oRula);


            DataTable dt1005 = oEstadisticaBC.ContEmpleadosBC();

            if (dt1005.Rows.Count > 0)
            {
                string resultado = dt1005.Rows[0][0].ToString();
                txtcontempleados.Text = resultado;
            }

        }
        private void ContEmpleadosemp()
        {
            try
            {
                EstadisticaBC oEstadisticaBC = new EstadisticaBC();
                DataTable dt1004 = oEstadisticaBC.ContEmpleadosempresaBC();
                dgvEmpleadosEmpresas.DataSource = null;
                dgvEmpleadosEmpresas.DataSource = dt1004;
                dgvEmpleadosEmpresas.Columns[0].Visible = false;
                dgvEmpleadosEmpresas.Columns[1].HeaderText = "Nombre de la empresa";
                dgvEmpleadosEmpresas.Columns[2].HeaderText = "Número";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void ContJSS()
        {
            EstadisticaBC oEstadisticaBC = new EstadisticaBC();

            //DataTable dt = oRulaBC.RULACONSULTARRESULTADOIDBC(oRula);


            DataTable dt1005 = oEstadisticaBC.ContJSSBC();

            if (dt1005.Rows.Count > 0)
            {
                string resultado = dt1005.Rows[0][0].ToString();
                txtjsscont.Text = resultado;
            }

        }
        public void ContNIOSH()
        {
            EstadisticaBC oEstadisticaBC = new EstadisticaBC();

            //DataTable dt = oRulaBC.RULACONSULTARRESULTADOIDBC(oRula);


            DataTable dt1006 = oEstadisticaBC.ContNIOSHBC();

            if (dt1006.Rows.Count > 0)
            {
                string resultado = dt1006.Rows[0][0].ToString();
                txtNioshCont.Text = resultado;
            }

        }
        public void ContREBA()
        {
            EstadisticaBC oEstadisticaBC = new EstadisticaBC();

          DataTable dt1007 = oEstadisticaBC.ContREBABC();

            if (dt1007.Rows.Count > 0)
            {
                string resultado = dt1007.Rows[0][0].ToString();
                txtREBACont.Text = resultado;
            }

        }
        public void ContRULA()
        {
            EstadisticaBC oEstadisticaBC = new EstadisticaBC();

            DataTable dt1008 = oEstadisticaBC.ContRULABC();

            if (dt1008.Rows.Count > 0)
            {
                string resultado = dt1008.Rows[0][0].ToString();
                txtRulaCont.Text = resultado;
            }

        }

    }
}
