using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO
{
    public partial class frmLogIn : Form
    {
        public frmLogIn()
        {
            InitializeComponent();
            mtxtNif.TextChanged += mtxtNif_TextChanged;
            string nif = mtxtNif.Text.Replace("-", "");
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wParam, int lParam);

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string nif = mtxtNif.Text.Replace("-", "");
            if (Empleado.ComprobarRegistro(nif,txtContraseña.Text))
            {
                
                FrmPpal frmPpal = new FrmPpal();
                frmPpal.Show();
            
                frmPpal.AbrirFormulario(new FrmMapa(frmPpal));
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario/Contraseña incorrecto");
                string body = "Se ha detectado un intento de inicio de sesion con el nombre o nif: <span Style=\"color: red;\">" + nif+ "</span>";
                Correo alerta = new Correo("CentralisGrupo@outlook.es", "Intento Inicio De Sesion", body);
                alerta.EnviarCorreo(false);
                txtContraseña.Clear();
                mtxtNif.Clear();
                
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();

            this.Close();
        }

        private void TitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void linklbl_paginaweb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "https://centralisweb.000webhostapp.com/"; // Reemplaza esto con la URL que quieras abrir

            // Abre la URL con la aplicación predeterminada del sistema (navegador web)
            try
            {
                Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo abrir la URL: " + ex.Message);
            }
        }

        private void frmLogIn_Load(object sender, EventArgs e)
        {

        }



        private void mtxtNif_TextChanged(object sender, EventArgs e)
        {
            // Obtener el texto del MaskedTextBox
            string texto = mtxtNif.Text;
            // Convertir el texto a mayúsculas
            texto = texto.ToUpper();
            // Establecer el texto convertido de nuevo en el MaskedTextBox
            mtxtNif.Text = texto;
            // Mover el cursor al final del texto
            mtxtNif.SelectionStart = mtxtNif.Text.Length;
        }
    }
}
