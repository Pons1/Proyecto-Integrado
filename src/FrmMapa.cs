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
            temporizador.Interval = 500; // Intervalo en milisegundos (por ejemplo, cada 5 segundos)
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

        Celda c1 = new Celda(1,"A");
        Celda c2 = new Celda(2, "A");
        Celda c3 = new Celda(3, "A");
        Celda c4 = new Celda(4, "A");
        Celda c5 = new Celda(5, "A");
        Celda c6 = new Celda(6, "A");
        Celda c7 = new Celda(7, "A");
        Celda c8 = new Celda(8, "A");
        Celda c9 = new Celda(9, "A");
        Celda c10 = new Celda(10, "A");
        Celda c11 = new Celda(11, "A");
        Celda c12 = new Celda(12, "A");
        Celda c13 = new Celda(13, "A");
        Celda c14 = new Celda(14, "A");

        Celda c15 = new Celda(15, "B");
        Celda c16 = new Celda(16, "B");
        Celda c17 = new Celda(17, "B");
        Celda c18 = new Celda(18, "B");
        Celda c19 = new Celda(19, "B");
        Celda c20 = new Celda(20, "B");
        Celda c21 = new Celda(21, "B");
        Celda c22 = new Celda(22, "B");
        Celda c23 = new Celda(23, "B");
        Celda c24 = new Celda(24, "B");
        Celda c25 = new Celda(25, "B");
        Celda c26 = new Celda(26, "B");
        Celda c27 = new Celda(27, "B");
        Celda c28 = new Celda(28, "B");

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

        private void btn_p1_Click_1(object sender, EventArgs e)
        {
            if (p1.ComprobarEstado(p1))
            {
                DialogResult resultado = MessageBox.Show("¿Seguro que quieres abrir la puerta?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    p1.AbrirPuerta(1);
                }
                
            }
            else
            {
                p1.CerrarPuerta(1);
            }
        }

        private void btn_p2_Click_1(object sender, EventArgs e)
        {
            if (p2.ComprobarEstado(p2))
            {
                DialogResult resultado = MessageBox.Show("¿Seguro que quieres abrir la puerta?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    p1.AbrirPuerta(2);
                }

            }
            else
            {
                p1.CerrarPuerta(2);
            }
        }

        private void btn_p3_Click_1(object sender, EventArgs e)
        {
            if (p3.ComprobarEstado(p3))
            {
                DialogResult resultado = MessageBox.Show("¿Seguro que quieres abrir la puerta?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    p3.AbrirPuerta(3);
                }

            }
            else
            {
                p3.CerrarPuerta(3);
            }
        }

        private void btn_p4_Click(object sender, EventArgs e)
        {
            if (p4.ComprobarEstado(p4))
            {
                DialogResult resultado = MessageBox.Show("¿Seguro que quieres abrir la puerta?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    p4.AbrirPuerta(4);
                }

            }
            else
            {
                p4.CerrarPuerta(4);
            }
        }

        private void btn_p5_Click(object sender, EventArgs e)
        {
            if (p5.ComprobarEstado(p5))
            {
                DialogResult resultado = MessageBox.Show("¿Seguro que quieres abrir la puerta?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    p5.AbrirPuerta(5);
                }

            }
            else
            {
                p5.CerrarPuerta(5);
            }
        }

        private void btn_p6_Click(object sender, EventArgs e)
        {
            if (p6.ComprobarEstado(p6))
            {
                DialogResult resultado = MessageBox.Show("¿Seguro que quieres abrir la puerta?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    p6.AbrirPuerta(6);
                }

            }
            else
            {
                p6.CerrarPuerta(6);
            }
        }

        private void btn_p7_Click(object sender, EventArgs e)
        {
            if (p7.ComprobarEstado(p7))
            {
                DialogResult resultado = MessageBox.Show("¿Seguro que quieres abrir la puerta?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    p7.AbrirPuerta(7);
                }

            }
            else
            {
                p7.CerrarPuerta(7);
            }
        }

        private void btn_p8_Click(object sender, EventArgs e)
        {
            if (p8.ComprobarEstado(p8))
            {
                DialogResult resultado = MessageBox.Show("¿Seguro que quieres abrir la puerta?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    p8.AbrirPuerta(8);
                }

            }
            else
            {
                p8.CerrarPuerta(8);
            }
        }

        private void btn_p9_Click(object sender, EventArgs e)
        {
            if (p9.ComprobarEstado(p9))
            {
                DialogResult resultado = MessageBox.Show("¿Seguro que quieres abrir la puerta?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    p9.AbrirPuerta(9);
                }

            }
            else
            {
                p9.CerrarPuerta(9);
            }
        }

        private void btn_p10_Click(object sender, EventArgs e)
        {
            if (p10.ComprobarEstado(p10))
            {
                DialogResult resultado = MessageBox.Show("¿Seguro que quieres abrir la puerta?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    p10.AbrirPuerta(10);
                }

            }
            else
            {
                p10.CerrarPuerta(10);
            }
        }

        private void btn_p11_Click(object sender, EventArgs e)
        {
            if (p11.ComprobarEstado(p11))
            {
                DialogResult resultado = MessageBox.Show("¿Seguro que quieres abrir la puerta?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    p11.AbrirPuerta(11);
                }

            }
            else
            {
                p11.CerrarPuerta(11);
            }
        }

        private void btn_p12_Click(object sender, EventArgs e)
        {
            if (p12.ComprobarEstado(p12))
            {
                DialogResult resultado = MessageBox.Show("¿Seguro que quieres abrir la puerta?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    p12.AbrirPuerta(12);
                }

            }
            else
            {
                p12.CerrarPuerta(12);
            }
        }

        private void btn_p13_Click(object sender, EventArgs e)
        {
            if (p13.ComprobarEstado(p13))
            {
                DialogResult resultado = MessageBox.Show("¿Seguro que quieres abrir la puerta?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    p13.AbrirPuerta(13);
                }

            }
            else
            {
                p13.CerrarPuerta(13);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Se trata de una emergencia, desea abrir todas las puertas?", "¡Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            // Verificar la respuesta del usuario
            if (result == DialogResult.Yes)
            {
                p1.CerrarPuerta(1);
                p2.CerrarPuerta(2);
                p3.CerrarPuerta(3);
                p4.CerrarPuerta(4);
                p5.CerrarPuerta(5);
                p6.CerrarPuerta(6);
                p7.CerrarPuerta(7);
                p8.CerrarPuerta(8);
                p9.CerrarPuerta(9);
                p10.CerrarPuerta(10);
                p11.CerrarPuerta(11);
                p12.CerrarPuerta(12);
                p13.CerrarPuerta(13);
            }
            
        }

        private void btn_c1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
