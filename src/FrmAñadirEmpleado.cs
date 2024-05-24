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
        FrmPpal frmPpal;
        public FrmAñadirEmpleado(FrmPersonal frm, FrmPpal frmPpal)
        {
           
            InitializeComponent();
            this.frm=frm;

            this.frmPpal=frmPpal;
            frmPpal.IdiomaCambiado += new FrmPpal.IdiomaCambiadoEventHandler(OnIdiomaCambiado);
            ActualizarIdioma();
        }
        private void OnIdiomaCambiado(object sender, EventArgs e)
        {
            ActualizarIdioma();
        }


        private void ActualizarIdioma()
        {
            if (frmPpal.getIdioma() == "ENGLISH")
            {

                lblNombre.Text = "Name:";
                lblApellidos.Text = "Surnames:";
                lblNif.Text = "Id:";
                lblTelefono.Text = "Phone Nº:";
                lblSexo.Text = "Gender:";
                cmbDireccion.Text = "Address:";
                lblCodigoPos.Text = "Postal Code:";
                lblCorreo.Text = "Email Adress";
                lblPuesto.Text = "Job:";
                lblTurno.Text = "Shift:";
                btnSalir.Text = "Exit";
                btn_añadir_foto.Text = "Add Image";
                btnAñadir.Text = "Add";
                this.Text = "Add Employee";

            }
            else if (frmPpal.getIdioma() == "ESPAÑOL")
            {
                lblNombre.Text = "Nombre:";
                lblApellidos.Text = "Apellidos:";
                lblNif.Text = "NIF:";
                lblTelefono.Text = "Telefono:";
                lblSexo.Text = "Sexo:";
                cmbDireccion.Text = "Dirección:";
                lblCodigoPos.Text = "Codigo Postal:";
                lblCorreo.Text = "Correo Electronico:";
                lblPuesto.Text = "Puesto:";
                lblTurno.Text = "Turno:";
                btnSalir.Text = "Salir";
                btn_añadir_foto.Text = "Añadir Foto";
                btnAñadir.Text = "Añadir";
                this.Text = "Añadir Empleado";


            }
        }

        private void lblCrimen_Click(object sender, EventArgs e)
        {

        }

        private void FrmAñadirEmpleado_Load(object sender, EventArgs e)
        {

            List<int> celdas = Celda.MostrarIdCeldas();
          

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
                        ,int.Parse(txtCodigopostal.Text),txtCorreo.Text,1,pcboxFoto.Image,int.Parse(txtTelefono.Text),txtContraseña.Text);
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

        private void pic_abrir_Click(object sender, EventArgs e)
        {
            panel1.Width = 215;
            pic_cerrar.Visible = true;
            pic_abrir.Visible = false;

        }

        private void pic_cerrar_Click(object sender, EventArgs e)
        {
          
            panel1.Width = 10;
            pic_cerrar.Visible = false;
            pic_abrir.Visible = true;
        }
    }
    }

