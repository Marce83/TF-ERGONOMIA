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
    public partial class frmRecuperarClave : Form
    {
        public frmRecuperarClave()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
         {
            UsuariosBC oUsuarioBC = new UsuariosBC();
            var Res = oUsuarioBC.RecuperarClave(txtPedidoUsr.Text);
            lblResultado.Text = Res;
        }
    }
}
