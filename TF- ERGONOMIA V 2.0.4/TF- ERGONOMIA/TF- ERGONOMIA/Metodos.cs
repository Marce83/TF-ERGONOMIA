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
            AddOwnedForm(oRULA_PORTADA);
            oRULA_PORTADA.TopLevel = false;
            oRULA_PORTADA.Dock = DockStyle.Fill;
            this.Controls.Add(oRULA_PORTADA);
            this.Tag = oRULA_PORTADA;
            oRULA_PORTADA.BringToFront();
            oRULA_PORTADA.Show();
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            RULARESULTADO oRULARESULTADO = new RULARESULTADO();
            AddOwnedForm(oRULARESULTADO);
            oRULARESULTADO.TopLevel = false;
            oRULARESULTADO.Dock = DockStyle.Fill;
            this.Controls.Add(oRULARESULTADO);
            this.Tag = oRULARESULTADO;
            oRULARESULTADO.BringToFront();
            oRULARESULTADO.Show();
        }

        private void btnReba_Click(object sender, EventArgs e)
        {
            REBA_PORTADA OREBA_PORTADA =new REBA_PORTADA();
            AddOwnedForm(OREBA_PORTADA);
            OREBA_PORTADA.TopLevel = false;
            OREBA_PORTADA.Dock = DockStyle.Fill;
            this.Controls.Add(OREBA_PORTADA);
            this.Tag = OREBA_PORTADA;
            OREBA_PORTADA.BringToFront();
            OREBA_PORTADA.Show();
        }

        private void btnRebaResultado_Click(object sender, EventArgs e)
        {
            REBA_RESULTADO OREBA_RESULTADO = new REBA_RESULTADO();
            AddOwnedForm(OREBA_RESULTADO);
            OREBA_RESULTADO.TopLevel = false;
            OREBA_RESULTADO.Dock = DockStyle.Fill;
            this.Controls.Add(OREBA_RESULTADO);
            this.Tag = OREBA_RESULTADO;
            OREBA_RESULTADO.BringToFront();
            OREBA_RESULTADO.Show();
        }

        private void btnNiosh_Click(object sender, EventArgs e)
        {
            NIOSHPORTADA ONIOSHPORTADA = new NIOSHPORTADA();
            AddOwnedForm(ONIOSHPORTADA);
            ONIOSHPORTADA.TopLevel = false;
            ONIOSHPORTADA.Dock = DockStyle.Fill;
            this.Controls.Add(ONIOSHPORTADA);
            this.Tag = ONIOSHPORTADA;
            ONIOSHPORTADA.BringToFront();
            ONIOSHPORTADA.Show();

        }

        private void btnNioshResultado_Click(object sender, EventArgs e)
        {
            NIOSHRESULTADO ONIOSHRESULTADO = new NIOSHRESULTADO();
            AddOwnedForm(ONIOSHRESULTADO);
            ONIOSHRESULTADO.TopLevel = false;
            ONIOSHRESULTADO.Dock = DockStyle.Fill;
            this.Controls.Add(ONIOSHRESULTADO);
            this.Tag = ONIOSHRESULTADO;
            ONIOSHRESULTADO.BringToFront();
            ONIOSHRESULTADO.Show(); 
        }

        private void JSS_Click(object sender, EventArgs e)
        {
            JSSPORTADA oJSSPORTADA = new JSSPORTADA();
            AddOwnedForm(oJSSPORTADA);
            oJSSPORTADA.TopLevel = false;
            oJSSPORTADA.Dock = DockStyle.Fill;
            this.Controls.Add(oJSSPORTADA);
            this.Tag = oJSSPORTADA;
            oJSSPORTADA.BringToFront();
            oJSSPORTADA.Show();
        }

        private void JSSRESULTADO_Click(object sender, EventArgs e)
        {
            JSSRESULTADO oJSSRESULTADO = new JSSRESULTADO();
            AddOwnedForm(oJSSRESULTADO);
            oJSSRESULTADO.TopLevel = false;
            oJSSRESULTADO.Dock = DockStyle.Fill;
            this.Controls.Add(oJSSRESULTADO);
            this.Tag = oJSSRESULTADO;
            oJSSRESULTADO.BringToFront();
            oJSSRESULTADO.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmLMCPortada oFrmLMCPortada = new FrmLMCPortada();
            AddOwnedForm(oFrmLMCPortada);
            oFrmLMCPortada.TopLevel = false;
            oFrmLMCPortada.Dock = DockStyle.Fill;
            this.Controls.Add(oFrmLMCPortada);
            this.Tag = oFrmLMCPortada;
            oFrmLMCPortada.BringToFront();
            oFrmLMCPortada.Show();
        }
    }
}
