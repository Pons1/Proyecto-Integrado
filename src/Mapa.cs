using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Design;

namespace PROYECTO
{
    public partial class Mapa : Form
    {
        Puertas puerta = new Puertas();
        ConexionBD con = new ConexionBD();

        public Mapa()
        {
            InitializeComponent();
            try
            {
                if (con.AbrirConexion())
                {
                    if(puerta.ComprobarPuerta(111, con.Conexion))
                    {
                        btn_bloqA.BackColor = Color.Red;                    
                    }
                    else
                    {
                        btn_bloqA.BackColor = Color.Green;
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
            }
            finally
            {
                con.CerrarConexion();
            }
        }



        private void btn_p2_Click(object sender, EventArgs e)
        {
            
            
        }

        private void btn_p1_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_p3_Click(object sender, EventArgs e)
        {
            
        }

        private void Mapa_Load(object sender, EventArgs e)
        {

        }
    }
}
