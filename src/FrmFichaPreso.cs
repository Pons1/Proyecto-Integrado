using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO
{
    public partial class FrmFichaPreso : Form
    {
        private Preso p1;

        public FrmFichaPreso(Preso p1)
        {
            InitializeComponent();
            this.p1 = p1;
        }

        private void FrmFichaPreso_Load(object sender, EventArgs e)
        {
            txt_pnombre.Text=p1.Nombre;
            txt_nifPreso.Text = p1.Nif;
            txt_apellidos.Text=p1.Apellidos;
            txtCelda.Text=p1.Celda.ToString();
            txtSexo.Text=p1.Sexo.ToString();
            txtcrimen.Text=p1.Crimen.ToString();
            txtDireccion.Text=p1.Direccion.ToString();
            txtCodigopostal.Text=p1.CodigoPostal.ToString();
            txtCorreo.Text=p1.Correo.ToString();
            txtTelefono.Text=p1.Telefono.ToString();
            pcboxFoto.Image = p1.Foto;


        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSexo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcrimen_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTelefono_Click(object sender, EventArgs e)
        {

        }

        private void lblCelda_Click(object sender, EventArgs e)
        {

        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCorreo_Click(object sender, EventArgs e)
        {

        }

        private void txtCodigopostal_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCodigoPos_Click(object sender, EventArgs e)
        {

        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbDireccion_Click(object sender, EventArgs e)
        {

        }

        private void lblSexo_Click(object sender, EventArgs e)
        {

        }

        private void lblCrimen_Click(object sender, EventArgs e)
        {

        }

        private void txt_nifPreso_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNif_Click(object sender, EventArgs e)
        {

        }

        private void txt_apellidos_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblApellidos_Click(object sender, EventArgs e)
        {

        }

        private void txt_pnombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNom_Click(object sender, EventArgs e)
        {

        }

        private void pcboxFoto_Click(object sender, EventArgs e)
        {

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            Preso.BorrarPreso(txt_nifPreso.Text);
            this.Dispose();
        }
    }
}
