using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO
{
    public partial class FrmFichaPreso : Form
    {
        private Preso p1;
        private FrmPresos form;
        FrmPpal frmPpal;

        public FrmFichaPreso(Preso p1, FrmPresos form,FrmPpal frmPpal)
        {
            InitializeComponent();
            this.p1 = p1;
            this.form = form;
            this.frmPpal = frmPpal;
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

                lblNom.Text = "Name:";
                lblApellidos.Text = "Surnames:";
                lblNif.Text = "Id:";
                lblTelefono.Text = "Phone Nº:";
                lblSexo.Text = "Gender:";
                cmbDireccion.Text = "Address:";
                lblCodigoPos.Text = "Postal Code:";
                lblCorreo.Text = "Email Adress";
                lblCelda.Text = "Cell:";
                lblCrimen.Text = "Crime:";
                btnSalir.Text = "Exit";
                btnBorrar.Text = "Delete";
                btnInsertar.Text = "Insert";
                btnEditar.Text = "Edit";
                this.Text = "Inmate Info";


            }
            else if (frmPpal.getIdioma() == "ESPAÑOL")
            {
                lblNom.Text="Nombre:";
                lblApellidos.Text = "Apellidos:";
                lblNif.Text = "DNI:";
                lblTelefono.Text = "Telefono:";
                lblSexo.Text = "Sexo:";
                cmbDireccion.Text = "Dirección:";
                lblCodigoPos.Text = "Codigo Postal:";
                lblCorreo.Text = "Correo Electronico:";
                lblCelda.Text = "Celda:";
                lblCrimen.Text = "Crimen:";
                btnSalir.Text = "Salir";
                btnBorrar.Text = "Borrar";
                btnInsertar.Text = "Insertar";
                btnEditar.Text = "Editar";
                this.Text = "Ficha Preso";

            }
        }


        private void FrmFichaPreso_Load(object sender, EventArgs e)
        {
            List<int> lista = Crimen.MostrarIdCrimenes();
            for (int i = 0; i < lista.Count; i++)
            {
                cmbCrimen.Items.Add(lista[i].ToString());
            }

            List<int> celdas = Celda.MostrarIdCeldas();
            for (int i = 0; i < celdas.Count; i++)
            {
                cmbCelda.Items.Add(celdas[i].ToString());
            }

            txt_pnombre.Text=p1.Nombre;
            txt_nifPreso.Text = p1.Nif;
            txt_apellidos.Text=p1.Apellidos;
            txtCelda.Text=p1.Celda.ToString();
            cmbCelda.Text= p1.Celda.ToString();
            txtSexo.Text=p1.Sexo.ToString();
            cmbSexo.Text = p1.Sexo.ToString();
            txtcrimen.Text=p1.Crimen.ToString();
            cmbCrimen.Text= p1.Crimen.ToString();
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
            erpFichasPresos.Clear();
            if (Preso.DNICorrecto(txt_nifPreso.Text))
            {
                if (Preso.BorrarPreso(txt_nifPreso.Text,int.Parse(cmbCelda.Text)) == -1)
                {
                    MessageBox.Show("No se ha encontrado ningún preso con dicho NIF");
                }
                else
                {
                    MessageBox.Show("Preso borrado correctamente");

                }
                form.Actualizardgv();
                this.Dispose();
            }
            else
            {
                erpFichasPresos.SetError(txt_nifPreso, "Nif incorrecto");

            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (btnInsertar.Visible == true)
            {
                btnInsertar.Visible = false;
                txtCelda.Enabled = false;
                txt_nifPreso.Enabled = false;
                txt_apellidos.Enabled = false;
                txt_pnombre.Enabled = false;
                txtcrimen.Visible = true;
                txtCodigopostal.Enabled = false;
                txtSexo.Visible = true;
                txtCelda.Visible = true;
                txtCorreo.Enabled = false;
                txtDireccion.Enabled = false;
                txtTelefono.Enabled = false;

                cmbCelda.Visible = false;
                cmbCrimen.Visible = false;
                cmbSexo.Visible = false;
                btnBorrar.Visible = true;

            }
            else
            {
                btnInsertar.Visible = true;
                txtCelda.Enabled = true;
                txt_apellidos.Enabled = true;
                txt_pnombre.Enabled = true;
                txtcrimen.Visible = false;
                txtCodigopostal.Enabled = true;
                txtSexo.Visible = false;
                txtCelda.Visible = false;
                txtCorreo.Enabled = true;
                txtDireccion.Enabled = true;
                txtTelefono.Enabled = true;

                cmbCelda.Visible = true;
                cmbCrimen.Visible = true;
                cmbSexo.Visible = true;
                btnBorrar.Visible = false;



            }
        }

        private void cmbSexo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbCrimen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            erpFichasPresos.Clear();
            if (Preso.DNICorrecto(txt_nifPreso.Text))
            {
                try
                {
                    if (Preso.EditarPreso(txt_nifPreso.Text, txt_pnombre.Text, txt_apellidos.Text, int.Parse(cmbCrimen.Text), cmbSexo.Text, txtDireccion.Text,
                   int.Parse(txtCodigopostal.Text), txtCorreo.Text, int.Parse(cmbCelda.Text), int.Parse(txtTelefono.Text)) == -1)
                    {
                        MessageBox.Show("No se ha encontrado ningún preso con dicho NIF");
                    }
                    else
                    {
                        MessageBox.Show("Preso editado correctamente");

                    }
                    form.Actualizardgv();
                    this.Dispose();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
               
            }
            else
            {
                erpFichasPresos.SetError(txt_nifPreso, "Nif incorrecto");

            }
        }
    }
}
