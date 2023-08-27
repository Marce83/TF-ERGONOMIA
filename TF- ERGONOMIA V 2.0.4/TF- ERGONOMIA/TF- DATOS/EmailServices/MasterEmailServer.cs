﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace TF.DAC.EmailServices
{
    public abstract class MasterEmailServer
    {
        private SmtpClient smtpClient;
        protected string senderMail { get; set; }
        protected string password { get; set; }
        protected string host { get; set; }
        protected int port { get; set; }
        protected bool ssl { get; set; }

        protected void InicializarSmtpClient()
        {
            smtpClient = new SmtpClient();
            smtpClient.Credentials = new NetworkCredential(senderMail, password);
            smtpClient.Host = host;
            smtpClient.Port = port;
            smtpClient.EnableSsl = ssl;
        }

        public void EnvioMail(string subject, string body, List<string> recipientMail)
        {
            var mailMessage = new MailMessage();
            try
            { 
                mailMessage.From = new MailAddress(senderMail);
                foreach(string mail in recipientMail) 
                {
                    mailMessage.To.Add(mail);
                }
                mailMessage.Subject = subject;
                mailMessage.Body = body;
                mailMessage.Priority = MailPriority.Normal;
                smtpClient.Send(mailMessage);
                
            }
            catch (Exception ex) { }
            finally 
            { 
                mailMessage.Dispose();
                smtpClient.Dispose();
            }
        }
    }
}
