﻿using iTextSharp.tool.xml.css.parser.state;
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
    public partial class RULA_PORTADA : Form
    {
        public RULA_PORTADA()
        {
            InitializeComponent();
            dtpRula.Value = DateTime.Now;
        }

        public Empleados EmpleadoSeleccionado { get; set; }
        public static int IdEmpresa { get; set; }

        private void RULA_PORTADA_Load(object sender, EventArgs e)
        {
            DatosCompartidos.Empresa = txtCUITEncontrado.Text;
            DatosCompartidos.DniEmpleado = txtDniEmpleadoRula.Text;
            DatosCompartidos.PuestoRula = txtpuestotrabajoencontrado.Text;

            //Restaurar la info por mas que cambiemos de pagina
            txtCUITEncontrado.Text = DatosCompartidos.Empresa;
            txtDniEmpleadoRula.Text = DatosCompartidos.DniEmpleado;
            txtpuestotrabajoencontrado.Text = DatosCompartidos.PuestoRula;
        }

        private void btnBuscarCUIT_Click(object sender, EventArgs e)
        {
            frmBuscarEmpresa oFrm = new frmBuscarEmpresa();
            oFrm.ShowDialog();
            EmpleadosBC oEmpleadosBC = new EmpleadosBC();

            if (oFrm.EmpresaSeleccionada != null)
            {
                txtCUITEncontrado.Text = oFrm.EmpresaSeleccionada.CUIT.ToString();
                txtNombreEmpresaRula.Text = oFrm.EmpresaSeleccionada.Nombre.ToString();
                long CUIT = Convert.ToInt64(txtCUITEncontrado.Text);
                var BuscarId = oEmpleadosBC.ObtenerSoloIdEmpresa(CUIT);
                IdEmpresa = Convert.ToInt32(BuscarId);
            }
        }

        private void btnBuscarEmpleados_Click(object sender, EventArgs e)
        {
            if (txtCUITEncontrado.Text == string.Empty)
                MessageBox.Show("Tiene que Ingresar una Empresa antes");
            else
            {
                try
                {
                    frmBuscarEmpleados2 oFrm = new frmBuscarEmpleados2();
                    oFrm.ShowDialog();

                    if (oFrm.EmpleadoSeleccionado2 != null)
                    {
                        txtDniEmpleadoRula.Text = oFrm.EmpleadoSeleccionado2.DNI.ToString();
                        txtNombreEmpleadoRula.Text = oFrm.EmpleadoSeleccionado2.Nombre.ToString() + " " + oFrm.EmpleadoSeleccionado2.Apellido.ToString();
                        txtpuestotrabajoencontrado.Text = oFrm.EmpleadoSeleccionado2.NombrePuesto.ToString();
                    }

                    //FrmVistaPuestoEmpleado oFrm = new FrmVistaPuestoEmpleado();
                    //oFrm.ShowDialog();

                    //if (oFrm.PersonaSeleccionada != null)
                    //{
                    //    txtDniEmpleadoRula.Text = oFrm.PersonaSeleccionada.DNI.ToString();
                    //    txtNombreEmpleadoRula.Text = oFrm.PersonaSeleccionada.NombreEmpleado.ToString();
                    //    txtpuestotrabajoencontrado.Text = oFrm.PersonaSeleccionada.NombrePuesto.ToString();
                    //}
                }
                catch { }
            }
        }

        private void btnBuscarpuesto_Click(object sender, EventArgs e)
        {
            //Empleados oempl = new Empleados();
            //oempl.DNI = txtDniEmpleadoRula.Text;


            //EmpleadosBC oEmpleadosBC = new EmpleadosBC();
            //DataTable dt = oEmpleadosBC.ConsultarPuesto(oempl);

            //if (dt.Rows.Count > 0)
            //{
            //    string resultado = dt.Rows[0][0].ToString();
            //    txtpuestotrabajoencontrado.Text = resultado;
            //}
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if(txtDniEmpleadoRula.Text != string.Empty)
            {
                Rula orula = new Rula();
                RulaBC oRulaBC = new RulaBC();
                orula.CUIT = txtCUITEncontrado.Text;
                orula.DniEmpleadoRula = txtDniEmpleadoRula.Text;
                orula.EmpleadoRula = txtNombreEmpleadoRula.Text;
                orula.EmpresaRula = txtNombreEmpresaRula.Text;
                orula.PuestoDeTrabajo = txtpuestotrabajoencontrado.Text;
                orula.FechaCarga = /*DateTime.Parse(*/dtpRula.Text;
                var res = oRulaBC.InsertRulaFormPORTADABC(orula);
                //MessageBox.Show("Analisis Rula creado con éxito");
                Limpiar();
                // Pasar el ID de carga al siguiente formulario
                RULA1 ORULA1 = new RULA1();
                AddOwnedForm(ORULA1);
                ORULA1.TopLevel = false;
                ORULA1.Dock = DockStyle.Fill;
                this.Controls.Add(ORULA1);
                this.Tag = ORULA1;
                ORULA1.BringToFront();
                ORULA1.Show();

                //this.Close();
            }
            else
                MessageBox.Show("Debe ingresar datos de Empresa, Empleado y Puesto previamente");
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Limpiar()
        {
            txtCUITEncontrado.Text = string.Empty;
            txtNombreEmpresaRula.Text = string.Empty;
            txtDniEmpleadoRula.Text = string.Empty;
            txtNombreEmpleadoRula.Text = string.Empty;
            txtpuestotrabajoencontrado.Text = string.Empty;
            dtpRula.Text = string.Empty;
        }

        private void linkLimpiar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Limpiar();
        }
    }
}
