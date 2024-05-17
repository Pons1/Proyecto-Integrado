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
    public partial class FrmPresos : Form
    {
        public FrmPresos()
        {
            InitializeComponent();
        }


        private void btn_añadir_recluso_Click(object sender, EventArgs e)
        {
            FrmAñadir_recluso r1 = new FrmAñadir_recluso();
            r1.Show();
        }

        private void Presos_Load(object sender, EventArgs e)
        {
            dgvPresos.DataSource = Preso.MostrarPresos();


        }

        private void cmb_modulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvPresos.DataSource = Preso.MostrarPresosPorModulo(cmb_modulo.Text);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

            dgvPresos.DataSource = Preso.MostrarPresos();
            cmb_modulo.Text = "";
        }

        private void p_Click(object sender, EventArgs e)
        {


        }

        private void txt_buscar_TextChanged(object sender, EventArgs e)
        {
            dgvPresos.DataSource = Preso.MostrarPresosPorNombre(txt_buscar.Text);
        }

        private void dgvPresos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvPresos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvPresos.Rows[e.RowIndex];
                string id = selectedRow.Cells["NIF"].Value.ToString();
                string nombre = selectedRow.Cells["Nombre"].Value.ToString();
                string apellidos = selectedRow.Cells["Apellidos"].Value.ToString();
                int crimen = int.Parse(selectedRow.Cells["Crimen"].Value.ToString());
                string sexo = selectedRow.Cells["Sexo"].Value.ToString();
                string direccion = selectedRow.Cells["Direccion"].Value.ToString();
                int codigoPostal = int.Parse(selectedRow.Cells["codigoPostal"].Value.ToString());
                string correo = selectedRow.Cells["Correo"].Value.ToString();
                int celda = int.Parse(selectedRow.Cells["Celda"].Value.ToString());
                int tel = int.Parse(selectedRow.Cells["Telefono"].Value.ToString());


                Image img =Preso.ConsultarImagenPreso(id);

                Preso p1 =new Preso(id,nombre,apellidos,crimen,sexo,direccion,codigoPostal,correo,celda,img,tel);

                FrmFichaPreso frmFichaPreso = new FrmFichaPreso(p1);
                frmFichaPreso.Show();

            }

        }
    }
}
