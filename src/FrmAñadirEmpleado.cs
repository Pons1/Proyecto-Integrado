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
    public partial class FrmAñadirEmpleado : Form
    {
        FrmPersonal frm = new FrmPersonal();
        public FrmAñadirEmpleado(FrmPersonal frm)
        {
           
            InitializeComponent();
            this.frm=frm;
        }
        
        private void lblCrimen_Click(object sender, EventArgs e)
        {

        }

        private void FrmAñadirEmpleado_Load(object sender, EventArgs e)
        {

            List<int> celdas = Celda.MostrarIdCeldas();
            for (int i = 0; i < celdas.Count; i++)
            {
                cmbCelda.Items.Add(celdas[i].ToString());
            }


            List<string> turnos = Empleado.MostrarTurnos();
            for (int i = 0; i < turnos.Count; i++)
            {
               cmbturno.Items.Add(turnos[i].ToString());
            }

        }

        private void cmbPuesto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPuesto.Text=="ADMINISTRACION")
            {
                lblContraseña.Visible = true;
                txtContraseña.Visible=true;
            }
            else
            {
                lblContraseña.Visible = false;
                txtContraseña.Visible = false;
                txtContraseña.Text = "";
            }
        }

        private void btn_añadir_foto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdSeleccionar = new OpenFileDialog();
            ofdSeleccionar.Filter = "Imagenes |*.jpg; *.png";
            ofdSeleccionar.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            ofdSeleccionar.Title = "Seleccionar Imagen";

            if (ofdSeleccionar.ShowDialog() == DialogResult.OK)
            {
                pcboxFoto.Image = Image.FromFile(ofdSeleccionar.FileName);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            if (Preso.DNICorrecto(txt_nifempleado.Text))
            {
                erpPersonal.Clear();
                try
                {


                    Empleado p1 = new Empleado(txt_nifempleado.Text, txt_pnombre.Text, txt_apellidos.Text,cmbPuesto.Text,cmbSexo.Text,cmbturno.Text,txtDireccion.Text
                        ,int.Parse(txtCodigopostal.Text),txtCorreo.Text,int.Parse(cmbCelda.Text),pcboxFoto.Image,int.Parse(txtTelefono.Text),txtContraseña.Text);
                    p1.AgregarEmpleado();

                    frm.Actualizardgv();
                    this.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Fallo en los datos", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            else
            {
                erpPersonal.SetError(txt_nifempleado, "Nif incorrecto");
            }
        }
    }
}
