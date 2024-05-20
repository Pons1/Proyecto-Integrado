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
using PROYECTO;


namespace PROYECTO
{
    public partial class FrmPpal : Form
    {

        public FrmPpal()
        {
            InitializeComponent();
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
            } else
            {
                MenuVertical.Width = 188;
            }
        }

        private void pic_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
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


        private void AbrirFormulario(object formHijo)
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
            AbrirFormulario(new FrmMapa());    
        }

        private void btn_presos_Click(object sender, EventArgs e)
        {
           AbrirFormulario(new FrmPresos());
        }

        private void btn_personal_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmPersonal());
        }

        private void btn_horario_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmHorario());
        }

        private void btn_registro_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmRegistro());
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void PanelPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
