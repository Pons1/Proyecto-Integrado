using MySql.Data.MySqlClient;
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
    public partial class FrmHorario : Form
    {
        private int codigoHorarioSeleccionado;
        FrmPpal frmppal;



        public FrmHorario(FrmPpal frmppal)
        {
            InitializeComponent();
            //Cargamos la informacion del DataGridView
            CargarInfo();
            this.frmppal = frmppal;
            dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
            txtboxAct.TextChanged += TextBoxAct_TextChanged;
            frmppal.IdiomaCambiado += new FrmPpal.IdiomaCambiadoEventHandler(OnIdiomaCambiado);
            ActualizarIdioma();
        }
        private void OnIdiomaCambiado(object sender, EventArgs e)
        {
            ActualizarIdioma();
        }


        private void ActualizarIdioma()
        {
            if (frmppal.getIdioma() == "ENGLISH")
            {

                label1.Text = "Schedule";
                btnEditar.Text = "Edit";
                label2.Text = "Activity";
            }
            else if (frmppal.getIdioma() == "ESPAÑOL")
            {
                label1.Text = "Horario";
                btnEditar.Text = "Editar";
                label2.Text = "Actividad"; ;
            }
        }
        private void CargarInfo()
        {
            // Define la consulta SQL para obtener los horarios y sus descripciones.
            string query = "SELECT CodigoHorario, Horario, Descripcion FROM horarios";

            // Usa un DataTable para almacenar los datos recuperados.
            DataTable dt = new DataTable();

            // Usa un bloque try-catch para manejar posibles errores.
            try
            {
                // Abre la conexión utilizando la clase ConexionBD.
                ConexionBD.AbrirConexion();

                using (MySqlCommand cmd = new MySqlCommand(query, ConexionBD.Conexion))
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }

                // Asigna el DataTable como fuente de datos del DataGridView.
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
            finally
            {
                // Cierra la conexión utilizando la clase ConexionBD.
                ConexionBD.CerrarConexion();
            }
        }
        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                if (selectedRow.Cells["CodigoHorario"].Value != null)
                {
                    codigoHorarioSeleccionado = Convert.ToInt32(selectedRow.Cells["CodigoHorario"].Value);
                }

                if (selectedRow.Cells["Horario"].Value != null)
                {
                    TimeSpan time = (TimeSpan)selectedRow.Cells["Horario"].Value;
                    dateTimeHorario.Value = DateTime.Today.Add(time);
                }

                if (selectedRow.Cells["Descripcion"].Value != null)
                {
                    txtboxAct.Text = selectedRow.Cells["Descripcion"].Value.ToString();
                }

                dateTimeHorario.Refresh();
                txtboxAct.Refresh();
            }
        }
        private void GuardarHorario()
        {
            TimeSpan time = dateTimeHorario.Value.TimeOfDay;
            string descripcion = txtboxAct.Text;

            string query = "UPDATE horarios SET Horario = @Horario, Descripcion = @Descripcion WHERE CodigoHorario = @CodigoHorario";

            try
            {
                ConexionBD.AbrirConexion();

                using (MySqlCommand cmd = new MySqlCommand(query, ConexionBD.Conexion))
                {
                    cmd.Parameters.AddWithValue("@Horario", time);
                    cmd.Parameters.AddWithValue("@Descripcion", descripcion);
                    cmd.Parameters.AddWithValue("@CodigoHorario", codigoHorarioSeleccionado);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar los datos: " + ex.Message);
            }
            finally
            {
                ConexionBD.CerrarConexion();
            }
        }
        private void TextBoxAct_TextChanged(object sender, EventArgs e)
        {
            if (txtboxAct.Text.Length > 50)
            {
                MessageBox.Show("Resume más tu actividad. La descripción no puede tener más de 50 caracteres.", "Validación de Descripción", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtboxAct.Text = txtboxAct.Text.Substring(0, 50);
                txtboxAct.SelectionStart = txtboxAct.Text.Length; // Mueve el cursor al final del texto
            }
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            GuardarHorario();
            CargarInfo();
        }

        private void FrmHorario_Load(object sender, EventArgs e)
        {

        }
    }
}
