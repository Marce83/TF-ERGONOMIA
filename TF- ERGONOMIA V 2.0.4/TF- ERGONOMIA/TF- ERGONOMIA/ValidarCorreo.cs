using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TF.WIN
{
    public class ValidarCorreo
    {
        public static bool ValidarEmail(String Correo)
        {
            try
            {
                var Email = new System.Net.Mail.MailAddress(Correo);
                return Email.Address == Correo;
            }
            catch
            {
                return false;
            }
        }
    }
}
