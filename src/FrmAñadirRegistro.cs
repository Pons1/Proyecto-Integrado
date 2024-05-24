using System;
using System.Windows.Forms;

namespace PROYECTO
{
    public partial class FrmAñadirRegistro : Form
    {
        FrmPpal frmPpal;
        public FrmAñadirRegistro(FrmPpal frmPpal)
        {
            InitializeComponent();
            mtxtNif.TextChanged += mtxtNif_TextChanged;
            rbtnEmpleado.CheckedChanged += rbtnEmpleado_CheckedChanged;
            rbtnPreso.CheckedChanged += rbtnPreso_CheckedChanged;
            comboBox1.SelectedIndex = 0;

            // Desuscribir el evento para evitar duplicados
            btnCrearRegistro.Click -= btnCrearRegistro_Click;
            // Suscribir el evento
            btnCrearRegistro.Click += btnCrearRegistro_Click;
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

                lblNif.Text = "Id:";
                lblRegistro.Text = "Register:";
                lblMotivo.Text = "Motive:";
                 btnCrearRegistro.Text = "Create register";
                rbtnEmpleado.Text = "Employee";
                rbtnPreso.Text = "Inmate";
                this.Text = "Add Register";

            }
            else if (frmPpal.getIdioma() == "ESPAÑOL")
            {

                lblNif.Text = "Id:";
                lblRegistro.Text = "Register:";
                lblMotivo.Text = "Motive:";
                btnCrearRegistro.Text = "Create register";
                rbtnEmpleado.Text = "Empleado";
                rbtnPreso.Text = "Prisionero";
                this.Text = "Añadir Registro";

            }
        }

        private void FrmAñadirRegistro_Load(object sender, EventArgs e)
        {
            rbtnEmpleado.Checked = true;
            lblMotivo.Hide();
            txtMotivo.Hide();
        }

        private void mtxtNif_TextChanged(object sender, EventArgs e)
        {
            string texto = mtxtNif.Text;
            mtxtNif.Text = texto.ToUpper();
            mtxtNif.SelectionStart = mtxtNif.Text.Length;
        }

        private void rbtnEmpleado_CheckedChanged(object sender, EventArgs e)
        {
            lblMotivo.Hide();
            txtMotivo.Hide();
        }

        private void rbtnPreso_CheckedChanged(object sender, EventArgs e)
        {
            lblMotivo.Show();
            txtMotivo.Show();
        }

        private void btnCrearRegistro_Click(object sender, EventArgs e)
        {
            string tipoRegistro = comboBox1.Text;
            string nif = mtxtNif.Text.Replace("-", "");

            if (rbtnPreso.Checked)
            {
                if (comboBox1.Text == "SALIDA")
                {
                    if (nif.Length == 9 && !String.IsNullOrEmpty(comboBox1.Text) && !String.IsNullOrEmpty(txtMotivo.Text))
                    {
                        if (Preso.DNICorrecto(nif))
                        {
                            if (Preso.PresoRegistrado(nif) && !Preso.EstaBorrado(nif))
                            {
                                if (Preso.EstaPresente(nif))
                                {
                                    AgregarRegistroPreso(comboBox1.Text, nif, txtMotivo.Text);
                                    Preso.MarcarPresente(nif);
                                }
                                else
                                {
                                    MessageBox.Show("El ultimo registro del preso " + nif + " es de salida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }

                            }
                            else
                            {
                                MessageBox.Show("No existe el preso " + nif + " en la base de datos");
                            }
                        }
                        else
                        {
                            MessageBox.Show("El " + nif + " introducido no es correcto");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Revise y rellene todos los campos del formulario de registro");
                    }
                }
                else if(comboBox1.Text == "ENTRADA")
                {
                    if(nif.Length==9 && !String.IsNullOrEmpty(comboBox1.Text) && !String.IsNullOrEmpty(txtMotivo.Text))
                    {
                        if (Preso.DNICorrecto(nif))
                        {
                            if (Preso.PresoRegistrado(nif) && !Preso.EstaBorrado(nif))
                            {
                                if (!Preso.EstaPresente(nif))
                                {
                                    AgregarRegistroPreso(comboBox1.Text, nif, txtMotivo.Text);
                                    Preso.MarcarPresente(nif);
                                }
                                else
                                {
                                    MessageBox.Show("El ultimo registro del Preso " + nif + " es de Entrada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }

                            }
                            else
                            {
                                MessageBox.Show("No existe el Preso " + nif + " en la base de datos");
                            }
                        }
                        else
                        {
                            MessageBox.Show("El nif introducido no es correcto");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Revise y rellene todos los campos del formulario de registro");
                    }
                        
                }

            }
            else if (rbtnEmpleado.Checked)
            {
                if (comboBox1.Text == "SALIDA")
                {
                    if (nif.Length == 9 && !String.IsNullOrEmpty(comboBox1.Text))
                    {
                        if (Empleado.DNICorrecto(nif))
                        {
                            if (Empleado.EmpleadoRegistrado(nif) && !Empleado.EstaBorrado(nif))
                            {
                                if (Empleado.VerificarPresencia(nif))
                                {
                                    AgregarRegistroEmpleado(comboBox1.Text, nif);
                                    Empleado.MarcarPresente(nif);
                                }
                                else
                                {
                                    MessageBox.Show("El ultimo registro del Empleado " + nif + " es de salida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }

                            }
                            else
                            {
                                MessageBox.Show("No existe el Empleado " + nif + " en la base de datos");
                            }
                        }
                        else
                        {
                            MessageBox.Show("El nif introducido no es correcto");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Revise y rellene todos los campos del formulario de registro");
                    }
                }
                else if (comboBox1.Text == "ENTRADA")
                {
                    if (nif.Length == 9 && !String.IsNullOrEmpty(comboBox1.Text))
                    {
                        if (Empleado.DNICorrecto(nif))
                        {
                            if (Empleado.EmpleadoRegistrado(nif) && !Empleado.EstaBorrado(nif))
                            {
                                if (!Empleado.VerificarPresencia(nif))
                                {
                                    AgregarRegistroEmpleado(comboBox1.Text, nif);
                                    Empleado.MarcarPresente(nif);
                                }
                                else
                                {
                                    MessageBox.Show("El ultimo registro del Empleado " + nif + " es de Entrada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }

                            }
                            else
                            {
                                MessageBox.Show("No existe el Empleado " + nif + " en la base de datos");
                            }
                        }
                        else
                        {
                            MessageBox.Show("El nif introducido no es correcto");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Revise y rellene todos los campos del formulario de registro");
                    }
                }
            }
        }

        private void AgregarRegistroPreso(string tipoRegistro, string nif, string motivo)
        {
            try
            {
                int resultado = Registros.AgregarRegistroPreso(tipoRegistro, nif, motivo);
                if (resultado > 0)
                {
                    MessageBox.Show("Registro de preso agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al agregar el registro de preso.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AgregarRegistroEmpleado(string tipoRegistro, string nif)
        {
            try
            {
                int resultado = Registros.AgregarRegistroEmpleado(tipoRegistro, nif);
                if (resultado > 0)
                {
                    MessageBox.Show("Registro de empleado agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al agregar el registro de empleado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
