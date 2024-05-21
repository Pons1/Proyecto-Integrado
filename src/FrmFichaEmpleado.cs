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
    public partial class FrmFichaEmpleado : Form
    {
        Empleado p1;
        FrmPersonal form;
        public FrmFichaEmpleado(Empleado p1,FrmPersonal form)
        {
            InitializeComponent();
            this.p1 = p1;
            this.form = form;
        }

        private void FrmFichaEmpleado_Load(object sender, EventArgs e)
        {
            List<string> lista = Empleado.MostrarTurnos();
            for (int i = 0; i < lista.Count; i++)
            {
                cmbTurno.Items.Add(lista[i].ToString());
            }


            txt_pnombre.Text = p1.Nombre;
            txt_nif.Text = p1.Nif;
            txt_apellidos.Text = p1.Apellidos;
            txtTurno.Text = p1.Turno.ToString();
            cmbTurno.Text = p1.Turno.ToString();
            txtSexo.Text = p1.Sexo.ToString();
            cmbSexo.Text = p1.Sexo.ToString();
            txtpuesto.Text = p1.Puesto.ToString();
            cmbPuesto.Text = p1.Puesto.ToString();
            txtDireccion.Text = p1.Direccion.ToString();
            txtCodigopostal.Text = p1.CodigoPostal.ToString();
            txtCorreo.Text = p1.Correo.ToString();
            txtTelefono.Text = p1.Telefono.ToString();
            pcboxFoto.Image = p1.Foto;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            erpEmpl.Clear();
            if (Preso.DNICorrecto(txt_nif.Text))
            {
                if (Empleado.BorrarEmpleado(txt_nif.Text) == -1)
                {
                    MessageBox.Show("No se ha encontrado ningún empleado con dicho NIF");
                }
                else
                {
                    MessageBox.Show("Empleado borrado correctamente");

                }
                form.Actualizardgv();
                this.Dispose();
            }
            else
            {
                erpEmpl.SetError(txt_nif, "Nif incorrecto");

            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (btnInsertar.Visible == true)
            {
                btnInsertar.Visible = false;
                txt_nif.Enabled = false;
                txt_apellidos.Enabled = false;
                txt_pnombre.Enabled = false;
                txtTurno.Visible = true;
                txtCodigopostal.Enabled = false;
                txtSexo.Visible = true;
                txtpuesto.Visible = true;
                txtCorreo.Enabled = false;
                txtDireccion.Enabled = false;
                txtTelefono.Enabled = false;

                cmbPuesto.Visible = false;
                cmbTurno.Visible = false;
                cmbSexo.Visible = false;
                btnBorrar.Visible = true;

            }
            else
            {
                btnInsertar.Visible = true;
                txt_apellidos.Enabled = true;
                txt_pnombre.Enabled = true;
                txtpuesto.Visible = false;
                txtCodigopostal.Enabled = true;
                txtSexo.Visible = false;
                txtTurno.Visible = false;
                txtCorreo.Enabled = true;
                txtDireccion.Enabled = true;
                txtTelefono.Enabled = true;

                cmbTurno.Visible = true;
                cmbPuesto.Visible = true;
                cmbSexo.Visible = true;
                btnBorrar.Visible = false;



            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            erpEmpl.Clear();
            if (Preso.DNICorrecto(txt_nif.Text))
            {
                try
                {
                    if (Empleado.EditarEmpleado(txt_nif.Text,txt_pnombre.Text,txt_apellidos.Text,cmbPuesto.Text,cmbSexo.Text,cmbTurno.Text,txtDireccion.Text,int.Parse(txtCodigopostal.Text),txtCorreo.Text,int.Parse(txtTelefono.Text)) == -1)
                    {
                        MessageBox.Show("No se ha encontrado ningún empleado con dicho NIF");
                    }
                    else
                    {
                        MessageBox.Show("Empleado editado correctamente");

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
                erpEmpl.SetError(txt_nif, "Nif incorrecto");
            }
        }

        private void cmbSexo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
