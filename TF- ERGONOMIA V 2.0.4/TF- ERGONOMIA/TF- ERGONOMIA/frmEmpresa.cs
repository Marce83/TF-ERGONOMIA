using iTextSharp.tool.xml.html;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TF.BC;
using TF.COMMON.Cache;
using TF.ENTITIES;
using TF.WIN;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace TF.WIN
{
    public partial class frmEmpresa : Form
    {
        public frmEmpresa()
        {
            InitializeComponent();
        }
        private void CargaEmpresa_Load(object sender, EventArgs e)
        {
            RolesCargo();
            Listar();
            Limpiar();
        }

        private void txtCUIT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                e.Handled = true;
        }

        private void txtcuitconsultacuit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                e.Handled = true;
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
                e.Handled = true;
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && txtTelefono.MaxLength == 10)
                e.Handled = true;
            //else MessageBox.Show("Debe ingresar 10 digitos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            Empresas oemp = new Empresas();
            EmpresasBC oempresaBC = new EmpresasBC();

            if (txtCUIT.Text != string.Empty)
            {
                if (txtCUIT.Text.Length == 11)
                {
                    if (txtNombreEmpresa.Text != string.Empty)
                    {
                        if (cboCondFiscal.Text != string.Empty)
                        {
                            if (txtActEmpr.Text != string.Empty)
                            {
                                if (txtDireccion.Text != string.Empty)
                                {
                                    if (cboLocalidad.Text != string.Empty)
                                    {
                                        if (cboProvincia.Text != string.Empty)
                                        {
                                            if (txtTelefono.Text != string.Empty)
                                            {
                                                if (txtTelefono.Text.Length == 10)
                                                {
                                                    if (txtWeb.Text != string.Empty)
                                                     {
                                                        if (txtCorreo.Text != string.Empty)
                                                        {
                                                            if (ValidarCorreo.ValidarEmail(txtCorreo.Text))
                                                            {
                                                                 try
                                                                 {
                                                                    oemp.CUIT = txtCUIT.Text;
                                                                    oemp.Nombre = txtNombreEmpresa.Text;
                                                                    oemp.Condicion_Fiscal = cboCondFiscal.Text;
                                                                    oemp.Actividad_Empresarial = txtActEmpr.Text;
                                                                    oemp.Direccion = txtDireccion.Text;
                                                                    oemp.Localidad = cboLocalidad.Text;
                                                                    oemp.Provincia = cboProvincia.Text;
                                                                    oemp.Telefono = txtTelefono.Text;
                                                                    oemp.Correo = txtCorreo.Text;
                                                                    oemp.Web = txtWeb.Text;
                                                                    var res = oempresaBC.Insertempresa(oemp);
                                                                    MessageBox.Show("Empresa cargada exitosamente");
                                                                    Limpiar();
                                                                    Listar();
                                                                  }
                                                                catch (Exception ex)
                                                                 {
                                                                    MessageBox.Show(ex.Message);
                                                                    Limpiar();
                                                                 }
                                                            }
                                                    else MessageBox.Show("El formato del Correo es inválido", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                }
                                                else MessageBox.Show("Debe ingresar el correo electrónico", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            }
                                            else MessageBox.Show("Debe ingresar el Sitio Web de la Empresa", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                        else MessageBox.Show("Debe ingresar 10 digitos en el Teléfono", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                         }
                                                   else MessageBox.Show("Debe ingresar el número de teléfono", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                 }
                                             else MessageBox.Show("Debe ingresar la Provincia", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                           }
                                       else MessageBox.Show("Debe ingresar la Localidad", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                  else MessageBox.Show("Debe ingresar la dirección", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            else MessageBox.Show("Debe ingresar la Actividad Empresarial", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else MessageBox.Show("Debe ingresar la Condición Fiscal", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else MessageBox.Show("Debe ingresar la Razón Social", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);                
                }
                else MessageBox.Show("Debe ingresar 11 digitos en el CUIT", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Debe ingresar el número de CUIT", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void Listar()
        {
            try
            {
                EmpresasBC oEmpresasBC = new EmpresasBC();
                DataTable dt = oEmpresasBC.GetAll();
                dgvCargaEmpresas.DataSource = null;
                dgvCargaEmpresas.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Limpiar()
        {
            txtCUIT.Text = string.Empty;
            txtCUIT.ReadOnly = false;
            txtCUIT.Focus();
            txtNombreEmpresa.Text = string.Empty;
            cboCondFiscal.SelectedIndex = 0;
            txtActEmpr.SelectedIndex = 0;
            txtDireccion.Text = string.Empty;
            //cboLocalidad.SelectedIndex = 0;
            //cboProvincia.SelectedIndex = 0;
            txtTelefono.Text = string.Empty;
            txtCorreo.Text = string.Empty;
            txtWeb.Text = string.Empty;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Empresas oemp = new Empresas();
            oemp.CUIT = txtcuitconsultacuit.Text;

            EmpresasBC oEmpresasBC = new EmpresasBC();
            DataTable dt = oEmpresasBC.ConsultarEmpresas(oemp);

            dgvCargaEmpresas.DataSource = null;
            dgvCargaEmpresas.DataSource = dt;
            dgvCargaEmpresas.Columns[0].Visible = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("¿Está seguro que desea modificar esta Empresa?", "Realizar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resp == DialogResult.Yes)
            {
                try
                {
                    Empresas oemp = new Empresas();
                    oemp.CUIT = txtCUIT.Text;
                    oemp.Nombre = txtNombreEmpresa.Text;
                    oemp.Condicion_Fiscal = cboCondFiscal.Text;
                    oemp.Actividad_Empresarial = txtActEmpr.Text;
                    oemp.Direccion = txtDireccion.Text;
                    oemp.Localidad = cboLocalidad.Text;
                    oemp.Provincia = cboProvincia.Text;
                    oemp.Telefono = txtTelefono.Text;
                    oemp.Correo = txtCorreo.Text;
                    oemp.Web = txtWeb.Text;

                    EmpresasBC oempresaBC = new EmpresasBC();
                    var res = oempresaBC.updateempresa(oemp);
                    MessageBox.Show(" Empresa Modificada con exito");

                    Listar();
                    Limpiar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dgvCargaEmpresas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                txtCUIT.Text = dgvCargaEmpresas.CurrentRow.Cells[0].Value.ToString();
                txtCUIT.ReadOnly = true;
                txtNombreEmpresa.Text = dgvCargaEmpresas.CurrentRow.Cells[1].Value.ToString();
                cboCondFiscal.Text = dgvCargaEmpresas.CurrentRow.Cells[2].Value.ToString();
                txtActEmpr.Text = dgvCargaEmpresas.CurrentRow.Cells[3].Value.ToString();
                txtDireccion.Text = dgvCargaEmpresas.CurrentRow.Cells[4].Value.ToString();
                cboLocalidad.Text = dgvCargaEmpresas.CurrentRow.Cells[5].Value.ToString();
                cboProvincia.Text = dgvCargaEmpresas.CurrentRow.Cells[6].Value.ToString();
                txtTelefono.Text = dgvCargaEmpresas.CurrentRow.Cells[7].Value.ToString();
                txtCorreo.Text = dgvCargaEmpresas.CurrentRow.Cells[8].Value.ToString();
                txtWeb.Text = dgvCargaEmpresas.CurrentRow.Cells[9].Value.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("¿Está seguro que deseas eliminar esta Empresa?", "Realizado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resp == DialogResult.Yes)
            {
                try
                {

                    DataTable dt = new DataTable();
                    Empresas oemp = new Empresas();
                    EmpresasBC oempresaBC = new EmpresasBC();
                    oemp.CUIT = txtCUIT.Text;

                    var res = oempresaBC.deleteempresas(oemp);
                    MessageBox.Show("Empresa Eliminada");
                    Listar();
                    Limpiar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();

        }

        private void btnBuscartodo_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void RolesCargo()
        {
            if (UserLoginCache.Cargo == Cargos.Recepcionista)
            {
                btnCargar.Enabled = false;
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
            }
            if (UserLoginCache.Cargo == Cargos.Profesional)
            {
                btnEliminar.Enabled = false;
            }
            if (UserLoginCache.Cargo == Cargos.Contador)
            {
                btnEliminar.Enabled = false;
            }
        }

        private void cboProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Ciudades Buenos Aires
            DataTable CiudadBsAs = new DataTable();
            CiudadBsAs.Columns.Add("Ciudad");
            DataRow RowLP = CiudadBsAs.NewRow();
            RowLP["Ciudad"] = "La Plata";
            CiudadBsAs.Rows.Add(RowLP);
            DataRow RowMdP = CiudadBsAs.NewRow();
            RowMdP["Ciudad"] = "Mar del Plata";
            CiudadBsAs.Rows.Add(RowMdP);
            DataRow RowBB = CiudadBsAs.NewRow();
            RowBB["Ciudad"] = "Bahía Blanca";
            CiudadBsAs.Rows.Add(RowBB);
            DataRow RowLZ = CiudadBsAs.NewRow();
            RowLZ["Ciudad"] = "Lomas de Zamora";
            CiudadBsAs.Rows.Add(RowLZ);
            DataRow RowQu = CiudadBsAs.NewRow();
            RowQu["Ciudad"] = "Quilmes";
            CiudadBsAs.Rows.Add(RowQu);
            DataRow RowAv = CiudadBsAs.NewRow();
            RowAv["Ciudad"] = "Avellaneda";
            CiudadBsAs.Rows.Add(RowAv);
            DataRow RowLa = CiudadBsAs.NewRow();
            RowLa["Ciudad"] = "Lanús";
            CiudadBsAs.Rows.Add(RowLa);
            DataRow RowSI = CiudadBsAs.NewRow();
            RowSI["Ciudad"] = "San Isidro";
            CiudadBsAs.Rows.Add(RowSI);
            DataRow RowTa = CiudadBsAs.NewRow();
            RowTa["Ciudad"] = "Tandil";
            CiudadBsAs.Rows.Add(RowTa);
            DataRow RowOl = CiudadBsAs.NewRow();
            RowOl["Ciudad"] = "Olavarría";
            CiudadBsAs.Rows.Add(RowOl);
            DataRow RowSNA = CiudadBsAs.NewRow();
            RowSNA["Ciudad"] = "San Nicolás de los Arroyos";
            CiudadBsAs.Rows.Add(RowSNA);
            DataRow RowPe = CiudadBsAs.NewRow();
            RowPe["Ciudad"] = "Pergamino";
            CiudadBsAs.Rows.Add(RowPe);
            DataRow RowMe = CiudadBsAs.NewRow();
            RowMe["Ciudad"] = "Mercedes";
            CiudadBsAs.Rows.Add(RowMe);
            DataRow RowZa = CiudadBsAs.NewRow();
            RowZa["Ciudad"] = "Zarate";
            CiudadBsAs.Rows.Add(RowZa);
            DataRow RowJu = CiudadBsAs.NewRow();
            RowJu["Ciudad"] = "Junín";
            CiudadBsAs.Rows.Add(RowJu);
            DataRow RowNe = CiudadBsAs.NewRow();
            RowNe["Ciudad"] = "Necochea";
            CiudadBsAs.Rows.Add(RowNe);
            DataRow RowAz = CiudadBsAs.NewRow();
            RowAz["Ciudad"] = "Azul";
            CiudadBsAs.Rows.Add(RowAz);
            DataRow RowCam = CiudadBsAs.NewRow();
            RowCam["Ciudad"] = "Campana";
            CiudadBsAs.Rows.Add(RowCam);
            DataRow RowMor = CiudadBsAs.NewRow();
            RowMor["Ciudad"] = "Morón";
            CiudadBsAs.Rows.Add(RowMor);
            DataRow RowItu = CiudadBsAs.NewRow();
            RowItu["Ciudad"] = "Ituzaingó";
            CiudadBsAs.Rows.Add(RowItu);

            if (cboProvincia.SelectedIndex == 1)
            {
                cboLocalidad.DataSource = CiudadBsAs;
                cboLocalidad.DisplayMember = "Ciudad";
            }


                


        }
    }
}