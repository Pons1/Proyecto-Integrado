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
    public partial class FrmAñadir_recluso : Form
    {
        FrmPresos frm;
        public FrmAñadir_recluso(FrmPresos form)
        {
             frm = form;
            InitializeComponent();
        }

        private void Añadir_recluso_Load(object sender, EventArgs e)
        {
            List<int> lista = Crimen.MostrarIdCrimenes();
            for (int i = 0; i < lista.Count; i++)
            {
                cmbCrimen.Items.Add(lista[i].ToString());
            }

            List<int> celdas = Celda.MostrarIdCeldas();
            for (int i = 0; i < celdas.Count; i++)
            {
                cmbCelda.Items.Add(celdas[i].ToString());
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_añadir_foto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdSeleccionar = new OpenFileDialog();
            ofdSeleccionar.Filter = "Imagenes |*.jpg; *.png";
            ofdSeleccionar.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            ofdSeleccionar.Title = "Seleccionar Imagen";

            if (ofdSeleccionar.ShowDialog() == DialogResult.OK)
            {
                pcboxFoto.Image = Image.FromFile(ofdSeleccionar.FileName);
            }
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            if (Preso.DNICorrecto(txt_nifPreso.Text))
            {
                erpPresos.Clear();
                try
                {


                    Preso p1 = new Preso(txt_nifPreso.Text, txt_pnombre.Text, txt_apellidos.Text, int.Parse(cmbCrimen.Text), cmbSexo.Text
                        , txtDireccion.Text, int.Parse(txtCodigopostal.Text), txtCorreo.Text, int.Parse(cmbCelda.Text),1, pcboxFoto.Image, int.Parse(txtTelefono.Text));
                    p1.AgregarPreso();

                    List<int> lista = Crimen.MostrarIdCrimenes();

                    frm.Actualizardgv();
                    this.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Fallo en los datos", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            else
            {
                erpPresos.SetError(txt_nifPreso, "Nif incorrecto");
            }
            



        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
