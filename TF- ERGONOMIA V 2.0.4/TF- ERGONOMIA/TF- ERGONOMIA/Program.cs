using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TF.ENTITIES;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
//using TF.WIN;

namespace TF.WIN
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        //public static frmMenuPrincipal FormMenu;
        //public static frmLogin FormLogin;
        //public static frmNuevoUsuario FormNvoUsr;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(FormMenu = new frmMenuPrincipal());
            Application.Run(new NIOSH1());

        }
    }
}
