using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TF.DAC.EmailServices
{
    class SupportMail: MasterEmailServer
    {
        public SupportMail() 
        {
            senderMail = "soporteergoassist@gmail.com";
            password = "sntkmfvjvhokjuul";
            host = "smtp.gmail.com";
            port = 587;
            ssl = true;
            InicializarSmtpClient();
        }
    }
}
