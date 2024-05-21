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
        public void MostrarEmpleados()
        {
            dgvEmpleados.Rows.Clear();
            dgvEmpleados.DataSource = Empleado.MostrarEmpleados();
        }
        private void FrmPersonal_Load(object sender, EventArgs e)
        {
            cmb_modulo.Text = "TODOS";

            dgvEmpleados.DataSource = Empleado.MostrarEmpleados();
            ((DataGridViewImageColumn)dgvEmpleados.Columns[dgvEmpleados.Columns.Count - 1]).ImageLayout = DataGridViewImageCellLayout.Stretch;

        }
        public void Actualizardgv()
        {
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
            FrmAñadirEmpleado form = new FrmAñadirEmpleado(this);
            form.ShowDialog();
        }

        private void dgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            dgvEmpleados.DataSource = Empleado.MostrarEmpleadosPorNombre(txt_buscar.Text);

        }

        private void cmb_modulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_modulo.Text == "TODOS")
            {
                dgvEmpleados.DataSource = Empleado.MostrarEmpleados();
            }
            else
            {
                dgvEmpleados.DataSource = Empleado.MostrarEmpleadosPorPuesto(cmb_modulo.Text);

            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dgvEmpleados.DataSource = Empleado.MostrarEmpleados();
            cmb_modulo.Text = "TODOS";
            txt_buscar.Clear();
        }

        private void dgvEmpleados_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvEmpleados.Rows[e.RowIndex];
                string id = selectedRow.Cells["NIF"].Value.ToString();
                string nombre = selectedRow.Cells["Nombre"].Value.ToString();
                string apellidos = selectedRow.Cells["Apellidos"].Value.ToString();
                string puesto = selectedRow.Cells["Puesto"].Value.ToString();
                string sexo = selectedRow.Cells["Sexo"].Value.ToString();
                string turno = selectedRow.Cells["Turno"].Value.ToString();

                string direccion = selectedRow.Cells["Direccion"].Value.ToString();
                int presente = int.Parse(selectedRow.Cells["Presente"].Value.ToString());

                int codigoPostal = int.Parse(selectedRow.Cells["codigoPostal"].Value.ToString());
                string correo = selectedRow.Cells["Correo"].Value.ToString();
                int tel = int.Parse(selectedRow.Cells["Telefono"].Value.ToString());


                Image img = Empleado.ConsultarImagenEmpl(id);

                Empleado p1 = new Empleado(id, nombre, apellidos, puesto, sexo, turno, direccion, codigoPostal, correo, presente, img, tel,"");

                FrmFichaEmpleado frmFichaEmpleado = new FrmFichaEmpleado(p1, this);
                frmFichaEmpleado.Show();

            }
        }
    }
}
