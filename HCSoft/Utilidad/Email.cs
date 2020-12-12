using System;
using System.Net.Mail;
using System.Collections;

namespace HCSoft.Util
{
    public class Email
    {

        string smtp = "";
        int port = 0;
        string usuario = "";
        string password = "";
        string email = "";


        public Email()
        {

            this.smtp = System.Configuration.ConfigurationSettings.AppSettings["smtp"];
            this.port = Int32.Parse(System.Configuration.ConfigurationSettings.AppSettings["smtp_puerto"]);
            this.usuario = System.Configuration.ConfigurationSettings.AppSettings["smtp_usuario"];
            this.password = System.Configuration.ConfigurationSettings.AppSettings["smtp_password"];
            this.email = System.Configuration.ConfigurationSettings.AppSettings["smtp_email"];


        }

        public Email(string smtp, int port, string usuario, string password, string email)
        {
            this.smtp = smtp;
            this.port = port;
            this.usuario = usuario;
            this.password = password;
            this.email = email;
        }

        public bool EnviaEmail(string titulo, string mensaje, ArrayList destinatarios)
        {
            try
            {
                MailMessage objemail = new MailMessage();
                SmtpClient cliente = new SmtpClient();
                cliente.Port = port;
                cliente.Host = smtp;
                cliente.DeliveryMethod = SmtpDeliveryMethod.Network;
                cliente.UseDefaultCredentials = true;
                cliente.EnableSsl = true;

                objemail.From = new MailAddress(this.email);

                foreach (string destinatario in destinatarios)
                {
                    objemail.To.Add(new MailAddress(destinatario));
                }

                objemail.IsBodyHtml = true;

                cliente.Credentials = new System.Net.NetworkCredential(this.usuario, this.password);
                objemail.Subject = titulo;

                string cuerpomensaje = mensaje;

                objemail.Body = cuerpomensaje;

                cliente.Send(objemail);
                return true;
            }
            catch (Exception)
            {

                throw;
            }

        }
        public bool EnviaEmail(string titulo, string mensaje, string destinatario)
        {
            try
            {
                ArrayList arreglo = new ArrayList();
                arreglo.Add(destinatario);
                return  EnviaEmail(titulo, mensaje, arreglo);
            }
            catch (Exception)
            {

                throw;
            }        
        }
    }
}
