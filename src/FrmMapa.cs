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
    public partial class FrmMapa : Form
    {


        public FrmMapa()
        {
            InitializeComponent();
            temporizador = new Timer();
            temporizador.Interval = 1000; // Intervalo en milisegundos (por ejemplo, cada 5 segundos)
            temporizador.Tick += temporizador_Tick;
            temporizador.Start();
        }

        Puertas p1 = new Puertas(1);
        Puertas p2 = new Puertas(2);
        Puertas p3 = new Puertas(3);
        Puertas p4 = new Puertas(4);
        Puertas p5 = new Puertas(5);
        Puertas p6 = new Puertas(6);
        Puertas p7 = new Puertas(7); 
        Puertas p8 = new Puertas(8); 
        Puertas p9 = new Puertas(9);
        Puertas p10 = new Puertas(10);
        Puertas p11 = new Puertas(11);
        Puertas p12 = new Puertas(12);
        Puertas p13 = new Puertas(13);

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

        private void temporizador_Tick(object sender, EventArgs e)
        {
            if (p1.ComprobarEstado(p1))
            {
                btn_p1.BackColor = Color.Red;
            }
            else
            {
                btn_p1.BackColor = Color.Green;
            }

            if (p2.ComprobarEstado(p2))
            {
                btn_p2.BackColor = Color.Red;
            }
            else
            {
                btn_p2.BackColor = Color.Green;
            }

            if (p3.ComprobarEstado(p3))
            {
                btn_p3.BackColor = Color.Red;
            }
            else
            {
                btn_p3.BackColor = Color.Green;
            }

            if (p4.ComprobarEstado(p4))
            {
                btn_p4.BackColor = Color.Red;
            }
            else
            {
                btn_p3.BackColor = Color.Green;
            }

            if (p4.ComprobarEstado(p4))
            {
                btn_p4.BackColor = Color.Red;
            }
            else
            {
                btn_p4.BackColor = Color.Green;
            }

            if (p5.ComprobarEstado(p5))
            {
                btn_p5.BackColor = Color.Red;
            }
            else
            {
                btn_p5.BackColor = Color.Green;
            }

            if (p6.ComprobarEstado(p6))
            {
                btn_p6.BackColor = Color.Red;
            }
            else
            {
                btn_p6.BackColor = Color.Green;
            }

            if (p7.ComprobarEstado(p7))
            {
                btn_p7.BackColor = Color.Red;
            }
            else
            {
                btn_p7.BackColor = Color.Green;
            }

            if (p8.ComprobarEstado(p8))
            {
                btn_p8.BackColor = Color.Red;
            }
            else
            {
                btn_p8.BackColor = Color.Green;
            }

            if (p9.ComprobarEstado(p9))
            {
                btn_p9.BackColor = Color.Red;
            }
            else
            {
                btn_p9.BackColor = Color.Green;
            }

            if (p10.ComprobarEstado(p10))
            {
                btn_p10.BackColor = Color.Red;
            }
            else
            {
                btn_p10.BackColor = Color.Green;
            }

            if (p11.ComprobarEstado(p11))
            {
                btn_p11.BackColor = Color.Red;
            }
            else
            {
                btn_p11.BackColor = Color.Green;
            }

            if (p12.ComprobarEstado(p12))
            {
                btn_p12.BackColor = Color.Red;
            }
            else
            {
                btn_p12.BackColor = Color.Green;
            }

            if (p13.ComprobarEstado(p13))
            {
                btn_p13.BackColor = Color.Red;
            }
            else
            {
                btn_p13.BackColor = Color.Green;
            }
        }
    }
}
