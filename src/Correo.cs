using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace PROYECTO
{
    public class Correo
    {
        string mensaje;
        string miCorreo = "CentralisGrupo@outlook.es"; // Tu correo de Outlook
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
            message.Body = $@"
                <html>
                <head>
                    <style>
                        body {{
                            font-family: 'Arial', sans-serif;
                            margin: 0;
                            padding: 0;
                            background: linear-gradient(135deg, #0072ff 0%, #f5f7fa 100%);
                            color: #333;
                        }}
                        .container {{
                            width: 100%;
                            max-width: 600px;
                            margin: 20px auto;
                            background: linear-gradient(180deg, #0072ff 0%, #e0f7ff 20%, #ffffff 100%);
                            border-radius: 10px;
                            box-shadow: 0 4px 8px rgba(0, 0, 0, 0.2);
                            overflow: hidden;
                            font-family: 'Verdana', sans-serif;
                        }}
                        .header {{
                            position: relative;
                            background-image: url('https://raw.githubusercontent.com/manugamu/fotocentralis/3d1f3f57deafc47fa26b22a58df0b74f940c73e9/centralis.png');
                            background-size: contain;
                            background-repeat: no-repeat;
                            background-position: center;
                            background-attachment: fixed;
                            color: white;
                            padding: 100px 20px;
                            text-align: center;
                            font-size: 28px;
                            font-weight: bold;
                            letter-spacing: 1px;
                            text-transform: uppercase;
                        }}
                        .header:after {{
                            content: '';
                            display: block;
                            position: absolute;
                            top: 0;
                            left: 0;
                            width: 100%;
                            height: 100%;
                            background: rgba(0, 0, 0, 0.5);
                        }}
                        .message-content {{
                            padding: 20px;
                            line-height: 1.8;
                            color: #444;
                        }}
                        .message-content p {{
                            margin: 0 0 20px;
                            font-size: 16px;
                            text-align: justify;
                        }}
                        .message-content h2 {{
                            color: #0072ff;
                            font-size: 24px;
                            margin-bottom: 10px;
                            text-align: center;
                        }}
                        .footer {{
                            background: #0072ff;
                            padding: 15px;
                            text-align: center;
                            color: white;
                            font-size: 14px;
                            letter-spacing: 1px;
                        }}
                    </style>
                </head>
                <body>
                    <div class='container'>
                        <div class='header'>
                        </div>
                        <div class='message-content'>
                            <h2>Estimado Miembro de Centralis</h2>
                            <p>{this.Mensaje}</p>
                        </div>
                        <div class='footer'>
                            &copy; 2024 Centralis. Todos los derechos reservados.
                        </div>
                    </div>
                </body>
                </html>";

            SmtpClient cliente = new SmtpClient("smtp-mail.outlook.com");
            cliente.Port = 587;
            cliente.EnableSsl = true;
            cliente.UseDefaultCredentials = false;
            cliente.Credentials = new NetworkCredential(this.MiCorreo, "Delfruno111996");

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
                MessageBox.Show(ex.Message);
            }
        }
    }
}
