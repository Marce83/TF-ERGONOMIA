﻿using System;
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
    public partial class JSSPORTADA : Form
    {
        public JSSPORTADA()
        {
            InitializeComponent();
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
                txtNombreEmpresaNiosh.Text = oFrm.EmpresaSeleccionada.Nombre.ToString();
            }
        }

        private void btnBuscarEmpleados_Click(object sender, EventArgs e)
        {

            frmBuscarEmpleados oFrm = new frmBuscarEmpleados();
            oFrm.ShowDialog();

            if (oFrm.EmpleadoSeleccionado != null)
            {
                txtDniEmpleadoNiosh.Text = oFrm.EmpleadoSeleccionado.DNI.ToString();
                txtNombreEmpleadoNiosh.Text = oFrm.EmpleadoSeleccionado.Nombre.ToString() + " " + oFrm.EmpleadoSeleccionado.Apellido.ToString();
                txtpuestotrabajoencontrado.Text = oFrm.EmpleadoSeleccionado.NombrePuesto.ToString();
            }


            //FrmVistaPuestoEmpleado oFrm = new FrmVistaPuestoEmpleado();
            //oFrm.ShowDialog();

            //if (oFrm.PersonaSeleccionada != null)
            //{
            //    txtDniEmpleadoNiosh.Text = oFrm.PersonaSeleccionada.DNI.ToString();
            //    txtNombreEmpleadoNiosh.Text = oFrm.PersonaSeleccionada.NombreEmpleado.ToString();
            //    txtpuestotrabajoencontrado.Text = oFrm.PersonaSeleccionada.NombrePuesto.ToString();


            //}

            //if (oFrm.EmpleadoSeleccionado != null)
            //{
            //    //txtNombreEmpleadoNiosh.Text = oFrm.EmpleadoSeleccionado.Apellido.ToString() + " " + oFrm.EmpleadoSeleccionado.Nombre.ToString();

            //}
        }

        private void btnBuscarpuesto_Click(object sender, EventArgs e)
        {
           
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            jss Ojss = new jss();
            JssBC oJssBC = new JssBC();
            Ojss.CUITJSS = txtCUITEncontrado.Text;
            Ojss.PuestoDeTrabajoJSS = txtpuestotrabajoencontrado.Text;
            Ojss.DniEmpleadoJSS = txtDniEmpleadoNiosh.Text;
            Ojss.EmpleadoJSS = txtNombreEmpleadoNiosh.Text;
            Ojss.EmpresaJSS = txtNombreEmpresaNiosh.Text;
            Ojss.FechaCargaJss = DateTime.Parse(dtpJss.Text);
            var res = oJssBC.InserJssPORTADABC(Ojss);
            MessageBox.Show("Análisis JSS creado con éxito");

            // Pasar el ID de carga al siguiente formulario

            this.Close();
            JSS OJSS = new JSS();
            OJSS.Show();
            this.Close();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
