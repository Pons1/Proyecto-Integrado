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
        FrmPpal frmPpal;
        public FrmPresos(FrmPpal frmPpal)
        {
            InitializeComponent();
            dgvPresos.RowHeadersVisible = false;

            this.frmPpal = frmPpal;
            frmPpal.IdiomaCambiado += new FrmPpal.IdiomaCambiadoEventHandler(OnIdiomaCambiado);
            ActualizarIdioma();
            dgvPresos.RowTemplate.Height = 50;
            Color colorCelda = ColorTranslator.FromHtml("#F3B36C");

            dgvPresos.DefaultCellStyle.BackColor = colorCelda;



        }
        private void OnIdiomaCambiado(object sender, EventArgs e)
        {
            ActualizarIdioma();
        }


        private void ActualizarIdioma()
        {
            if (frmPpal.getIdioma() == "ENGLISH")
            {

                label1.Text = "*Double click on the line to see the personal file/edit/delete of each prisoner";
                btnReset.Text = "Refresh";
                lblmod.Text = "Module ";
                lblNombre.Text = "Name";
                btn_añadir_recluso.Text = "Add Prisioner";
            }
            else if (frmPpal.getIdioma() == "ESPAÑOL")
            {
                label1.Text = "*Doble click sobre la liena para ver la ficha personal/editar/borrar de cada preso";
                btnReset.Text = "Actualizar";
                lblmod.Text = "Modulo:";
                lblNombre.Text = "Nombre:";
                btn_añadir_recluso.Text = "Añadir Recluso";
            }
        }

        public void Actualizardgv()
        {
            dgvPresos.DataSource = Preso.MostrarPresos();
            cmb_modulo.Text = "Todos";
        }

        private void btn_añadir_recluso_Click(object sender, EventArgs e)
        {
            FrmAñadir_recluso r1 = new FrmAñadir_recluso(this,this.frmPpal);
            r1.Show();
        }

        private void Presos_Load(object sender, EventArgs e)
        {
            dgvPresos.DataSource = Preso.MostrarPresos();
            ((DataGridViewImageColumn)dgvPresos.Columns[dgvPresos.Columns.Count-1]).ImageLayout=DataGridViewImageCellLayout.Stretch;
            List<string> lista = Preso.MostrarModulos();
            for (int i = 0; i < lista.Count; i++)
            {
                cmb_modulo.Items.Add(lista[i].ToString());
            }
            cmb_modulo.Items.Add("Todos");
            cmb_modulo.Text= "Todos";


        }

        private void cmb_modulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_modulo.Text=="Todos")
            {
                dgvPresos.DataSource = Preso.MostrarPresos();
            }
            else
            {
                dgvPresos.DataSource = Preso.MostrarPresosPorModulo(cmb_modulo.Text);

            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

            dgvPresos.DataSource = Preso.MostrarPresos();
            cmb_modulo.Text = "Todos";
            txt_buscar.Clear();

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

                Preso p1 =new Preso(id,nombre,apellidos,crimen,sexo,direccion,codigoPostal,correo,celda,0,img,tel);

                FrmFichaPreso frmFichaPreso = new FrmFichaPreso(p1,this,this.frmPpal);
                frmFichaPreso.Show();

            }

        }
    }
}
