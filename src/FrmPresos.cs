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
    }
}
