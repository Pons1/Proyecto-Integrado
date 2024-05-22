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
    public partial class FrmRegistro : Form
    {
        public FrmRegistro()
        {
            InitializeComponent();
            rbtnPreso.Checked = true;
            CargarRegistros();
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
            FrmAñadirRegistro frm = new FrmAñadirRegistro();
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
        }

        private void FrmRegistro_Load(object sender, EventArgs e)
        {
            rbtnPreso.Checked = true;
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
    }
}
