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
            CargarRegistros();
        }




      private void CargarRegistros()
        {
            try
            {
                DataTable dtRegistros = Registros.ObtenerRegistrosConPresos();
                dataGridView1.DataSource = dtRegistros;
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

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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

                DataTable dtRegistros = Registros.ObtenerRegistros(fechaInicio, fechaFin);
                dataGridView1.DataSource = dtRegistros;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los registros: " + ex.Message);
            }
        }

    }
}
