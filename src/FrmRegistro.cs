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
    }
}
