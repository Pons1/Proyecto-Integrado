using MySql.Data.MySqlClient;
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
    public partial class FrmRegistro : Form
    {
        FrmPpal frmPpal;


        public FrmRegistro(FrmPpal frmPpal)
        {
            InitializeComponent();
            ConfigurarEstiloDataGridView(dataGridView1);
            ConfigurarEstiloDataGridView(dataGridView2);

            rbtnPreso.Checked = true;
            CargarRegistros();
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

                btn_añadir_registro.Text = "Add Register";
                lblFiltrarPorTexto.Text = "Filter by text:";
                lblFiltrarPorFecha.Text = "Filter by date:";
                btnRefrescar.Text = "Refresh";
                rbtnEmpleado.Text = "Employee";
                rbtnPreso.Text = "Inmate";

            }
            else if (frmPpal.getIdioma() == "ESPAÑOL")
            {

                btn_añadir_registro.Text = "Añadir Registro";
                lblFiltrarPorTexto.Text = "Filtrar Por Texto:";
                lblFiltrarPorFecha.Text = "Filtrar Por Fecha";
                btnRefrescar.Text = "Refrescar";
                rbtnEmpleado.Text = "Empleado";
                rbtnPreso.Text = "Prisionero";
            }
        }



        private void ConfigurarEstiloDataGridView(DataGridView dgv)
        {
            Color colorCelda = ColorTranslator.FromHtml("#D6BB78");
            Color colorCelda2 = ColorTranslator.FromHtml("#5c330a");

            dgv.DefaultCellStyle.BackColor = colorCelda;
            dgv.DefaultCellStyle.ForeColor = Color.Black;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = colorCelda2;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.RowHeadersVisible = false;
            dgv.RowTemplate.Height = 40;
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 12);
            dgv.DefaultCellStyle.Padding = new Padding(5);
            dgv.GridColor = Color.Black;
            dgv.EnableHeadersVisualStyles = false;
        }
        private void CargarRegistros()
        {
            try
            {
                DataTable dtRegistrosPresos = Registros.ObtenerRegistrosPresos();
                dataGridView1.DataSource = dtRegistrosPresos;

                DataTable dtRegistrosEmpleados = Registros.ObtenerRegistrosEmpleados();
                dataGridView2.DataSource = dtRegistrosEmpleados;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los registros: " + ex.Message);
            }
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_añadir_registro_Click(object sender, EventArgs e)
        {
            FrmAñadirRegistro frm = new FrmAñadirRegistro(this.frmPpal);
            frm.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (rbtnEmpleado.Checked)
            {
                dataGridView2.DataSource = Registros.BuscarRegistrosEmpleadosTexto(txtBusquedaPorTexto.Text);
            }
            else if (rbtnPreso.Checked)
            {
                dataGridView1.DataSource = Registros.BuscarRegistrosPresosTexto(txtBusquedaPorTexto.Text);
            }
        }



        private void dtpFechaInicio_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpFechaFin_ValueChanged(object sender, EventArgs e)
        {
            dtpFechaInicio.MaxDate = dtpFechaFin.Value;

        }

        private void pcbLupa_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fechaInicio = dtpFechaInicio.Value.Date;
                DateTime fechaFin = dtpFechaFin.Value.Date;
                DateTime fechaActual = DateTime.Now.Date;

                // Validar que la fecha de inicio no sea posterior a la actual
                if (fechaInicio > fechaActual)
                {
                    MessageBox.Show("La fecha de inicio no puede ser posterior a la fecha actual.");
                    return;
                }

                // Validar que la fecha de fin no sea inferior a la fecha de inicio
                if (fechaFin < fechaInicio)
                {
                    MessageBox.Show("La fecha de fin no puede ser inferior a la fecha de inicio.");
                    return;
                }

                // Validar que la fecha de fin no sea posterior a la fecha actual
                if (fechaFin > fechaActual)
                {
                    MessageBox.Show("La fecha de fin no puede ser posterior a la fecha actual.");
                    return;
                }

                if (rbtnPreso.Checked)
                {
                    DataTable dtRegistros = Registros.ObtenerRegistrosPresos(fechaInicio, fechaFin);
                    dataGridView1.DataSource = dtRegistros;
                }

                if (rbtnEmpleado.Checked)
                {
                    DataTable dtRegistros = Registros.ObtenerRegistrosEmpleados(fechaInicio, fechaFin);
                    dataGridView2.DataSource = dtRegistros;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los registros: " + ex.Message);
            }
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            CargarRegistros();
            dtpFechaInicio.Text=DateTime.Now.Date.ToString();
            dtpFechaFin.Text = DateTime.Now.Date.ToString();

        }

        private void FrmRegistro_Load(object sender, EventArgs e)
        {
            rbtnPreso.Checked = true;


            dtpFechaFin.MaxDate= DateTime.Now;
            dtpFechaInicio.MaxDate = dtpFechaFin.Value;




        }

        private void rbtnPreso_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.Show();
            dataGridView2.Hide();
        }

        private void rbtnEmpleado_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.Hide();
            dataGridView2.Show();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
