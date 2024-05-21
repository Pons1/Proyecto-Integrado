using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace PROYECTO
{
    public class Correo
    {
        string mensaje;
        string miCorreo = "manugamu@gmail.com";
        string displayName = "Centralis";
        string destinatario;
        string asunto;

        public string Mensaje { get => mensaje; set => mensaje = value; }
        public string MiCorreo { get => miCorreo; set => miCorreo = value; }
        public string DisplayName { get => displayName; set => displayName = value; }


        public Correo(string destinatario, string asunto, string mensaje)
        {
            this.destinatario = destinatario;
            this.asunto = asunto;
            this.mensaje = mensaje;
        }


        public void EnviarCorreo(bool avisar)
        {
            MailAddress addressFrom = new MailAddress(this.MiCorreo, this.DisplayName);
            MailAddress addressTo = new MailAddress(this.destinatario);
            MailMessage message = new MailMessage(addressFrom, addressTo);

            message.Subject = this.asunto;
            message.IsBodyHtml = true;
            // Asegúrate de que el mensaje esté en negrita usando HTML
            message.Body = $"<b>{this.Mensaje}</b>";

            SmtpClient cliente = new SmtpClient("smtp.gmail.com");
            cliente.Port = 587;
            cliente.EnableSsl = true;
            cliente.UseDefaultCredentials = false;
            cliente.Credentials = new NetworkCredential(this.MiCorreo, "vorz mhrb avqc htuk");

            try
            {
                cliente.Send(message);
                if (avisar)
                {
                    MessageBox.Show("Correo enviado con éxito");
                }
            }
            catch (Exception ex)
            {
                if (avisar)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
