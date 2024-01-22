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
    public partial class FrmBuscarPuestoTrabajo : Form
    {
        public FrmBuscarPuestoTrabajo()
        {
            InitializeComponent();
            Listar();

        }

        public PuestoTrabajo PuestoSeleccionada { get; set; }

        private void Listar()
        {
         try
          {
                PuestoTrabajoBC oPuestoTrabajoBC = new PuestoTrabajoBC();
                PuestoTrabajo oPuestoTrabajo = new PuestoTrabajo();
                DataTable dt = oPuestoTrabajoBC.GetAll();
                    dgvResultadoPuesto.DataSource = null;
                    dgvResultadoPuesto.DataSource = dt;
          }
          catch (Exception ex)
          {
                    MessageBox.Show(ex.Message);
          }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            if (dgvResultadoPuesto.SelectedRows.Count == 1) // si selecciona un fila
            {
                int IdPuesto = Convert.ToInt32(dgvResultadoPuesto.CurrentRow.Cells[1].Value);
                PuestoTrabajoBC oPuestoTrabajoBC = new PuestoTrabajoBC();
                PuestoSeleccionada = oPuestoTrabajoBC.ObtenerPuestoidBC(IdPuesto);
                this.Close();
            }
            else
            {
                MessageBox.Show("Aun no ha seleccionado Ningun Puesto de Trabajo");
            }
        }
    }
}
