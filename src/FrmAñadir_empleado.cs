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
    public partial class FrmAñadir_empleado : Form
    {
        FrmPersonal frmPersonal;

        public FrmAñadir_empleado(FrmPersonal frmPersonal)
        {
                this.frmPersonal = frmPersonal;
        }
        public FrmAñadir_empleado()
        {
            InitializeComponent();
        }

        private void FrmAñadir_empleado_Load(object sender, EventArgs e)
        {

        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {

        }
    }
}
