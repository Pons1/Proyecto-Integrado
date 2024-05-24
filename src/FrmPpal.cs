using System.Globalization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace PROYECTO
{
    public partial class FrmPpal : Form
    {
        public delegate void IdiomaCambiadoEventHandler(object sender, EventArgs e);
        public event IdiomaCambiadoEventHandler IdiomaCambiado;

        static string idioma;

        public static string Idioma { get => idioma; set => idioma = value; }

        public string getIdioma() { return idioma; }

        public FrmPpal()
        {
            InitializeComponent();
            cmbSeleccionarIdioma.SelectedIndex = 0;
        }

        private void OnIdiomaCambiado()
        {
            if (IdiomaCambiado != null)
            {
                IdiomaCambiado(this, EventArgs.Empty);
            }
        }

 

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wParam, int lParam);

        private void btn_slide_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 188)
            {
                MenuVertical.Width = 55;
            }
            else
            {
                MenuVertical.Width = 188;
            }
        }

        private void pic_cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Dispose();
        }

        private void pic_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pic_maximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pic_normal.Visible = true;
            pic_maximizar.Visible = false;
        }

        private void pic_normal_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            pic_normal.Visible = false;
            pic_maximizar.Visible = true;
        }

        public void AbrirFormulario(object formHijo)
        {
            Form formulario = null;
            foreach (Control control in this.PanelPrincipal.Controls)
            {
                if (control.GetType() == formHijo.GetType())
                {
                    formulario = (Form)control;
                    break;
                }
            }

            if (formulario != null)
            {
                formulario.BringToFront();
            }
            else
            {
                if (this.PanelPrincipal.Controls.Count > 0)
                {
                    this.PanelPrincipal.Controls.RemoveAt(0);
                }

                Form fh = formHijo as Form;
                fh.TopLevel = false;
                fh.Dock = DockStyle.Fill;
                this.PanelPrincipal.Controls.Add(fh);
                this.PanelPrincipal.Tag = fh;
                fh.Show();
            }
        }

        private void btn_mapa_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmMapa(this));
        }

        private void btn_presos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmPresos(this));
        }

        private void btn_personal_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmPersonal(this));
        }

        private void btn_horario_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmHorario(this));
        }

        private void btn_registro_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmRegistro(this));
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void PanelPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmPpal_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogIn frm = new frmLogIn();
            frm.ShowDialog();
        }

        private void btnEnviarCorreo_Click(object sender, EventArgs e)
        {
            FrmCorreos correos = new FrmCorreos(this);
            correos.ShowDialog();
        }

        private void cmbSeleccionarIdioma_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbSeleccionarIdioma.SelectedIndex == 0)
            {
                btn_registro.Text = "Registros";
                btn_horario.Text = "Horarios";
                btn_mapa.Text = "Mapa";
                btn_personal.Text = "Personal";
                btn_presos.Text = "Presos";
                idioma = "ESPAÑOL";
                btnEnviarCorreo.Text = "Enviar Correo";
                btnCerrarSesion.Text = "Cerrar Sesión";
            }
            else if (cmbSeleccionarIdioma.SelectedIndex == 1)
            {
                btn_registro.Text = "Registers";
                btn_horario.Text = "Schedules";
                btn_mapa.Text = "Map";
                btn_personal.Text = "Employees";
                btn_presos.Text = "Prisoners";
                idioma = "ENGLISH";
                btnEnviarCorreo.Text = "Send Mail";
                btnCerrarSesion.Text = "Log Out";

            }

            OnIdiomaCambiado(); // Disparar el evento de cambio de idioma
        }
    }
}