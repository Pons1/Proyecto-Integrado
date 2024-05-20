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
    public partial class FrmPersonal : Form
    {
        public FrmPersonal()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmPersonal_Load(object sender, EventArgs e)
        {
            dgvEmpleados.Rows.Clear();
            dgvEmpleados.DataSource = Empleado.MostrarEmpleados();
        }

        private void dgvPresos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //DataGridViewRow selectedRow = dgvEmpleados.Rows[e.RowIndex];
                //string id = selectedRow.Cells["NIF"].Value.ToString();
                //string nombre = selectedRow.Cells["Nombre"].Value.ToString();
                //string apellidos = selectedRow.Cells["Apellidos"].Value.ToString();
                //int crimen = int.Parse(selectedRow.Cells["Crimen"].Value.ToString());
                //string sexo = selectedRow.Cells["Sexo"].Value.ToString();
                //string direccion = selectedRow.Cells["Direccion"].Value.ToString();
                //int codigoPostal = int.Parse(selectedRow.Cells["codigoPostal"].Value.ToString());
                //string correo = selectedRow.Cells["Correo"].Value.ToString();
                //int celda = int.Parse(selectedRow.Cells["Celda"].Value.ToString());
                //int tel = int.Parse(selectedRow.Cells["Telefono"].Value.ToString());


                //Image img = Preso.ConsultarImagenPreso(id);

                //Preso p1 = new Preso(id, nombre, apellidos, crimen, sexo, direccion, codigoPostal, correo, celda, img, tel);

                //FrmFichaPreso frmFichaPreso = new FrmFichaPreso(p1, this);
                //frmFichaPreso.Show();

            }
        }

        private void btn_añadir_empleado_Click(object sender, EventArgs e)
        {
            FrmAñadir_empleado frm=new FrmAñadir_empleado(this);
        }

        private void dgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
