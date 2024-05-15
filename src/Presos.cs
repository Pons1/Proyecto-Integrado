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
    public partial class Presos : Form
    {
        public Presos()
        {
            InitializeComponent();
        }


        private void btn_añadir_recluso_Click(object sender, EventArgs e)
        {
            Añadir_recluso r1 = new Añadir_recluso();
            r1.Show();
        }

        private void Presos_Load(object sender, EventArgs e)
        {
            dgvPresos.DataSource = Preso.MostrarPresos();
               
        }
    }
}
