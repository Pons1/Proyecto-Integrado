using PROYECTO.Properties;
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
    public partial class FrmVerCeldacs : Form
    {
        List<Preso> presos;
        int celda;
        string modulo;
        FrmPpal frmPpal;
        public FrmVerCeldacs(List<Preso> presos, int celda, string modulo,FrmPpal frmPpal)
        {
            InitializeComponent();
            this.presos = presos;
            this.celda = celda;
            this.modulo = modulo;
            this.frmPpal = frmPpal;
            frmPpal.IdiomaCambiado += new FrmPpal.IdiomaCambiadoEventHandler(OnIdiomaCambiado);
            ActualizarIdioma();
        }
        private void OnIdiomaCambiado(object sender, EventArgs e)
        {
            ActualizarIdioma();
        }


        private void ActualizarIdioma()
        {
            if (frmPpal.getIdioma() == "ENGLISH")
            {
                lbl_nombre_celda.Text = "Module";
                lbltituloCelda.Text = "Cell";
            }
            else if (frmPpal.getIdioma() == "ESPAÑOL")
            {
                lbl_nombre_celda.Text = "Modulo";
                lbltituloCelda.Text = "Celda";
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmVerCeldacs_Load(object sender, EventArgs e)
        {
            lblNomCel.Text = celda.ToString();
            lblNomMod.Text = modulo.ToString();
            int numPresos= presos.Count();
            switch (numPresos)
            {
                case 0: pbFondo1.Visible=true;
                    pbFondo2.Visible = true;
                    pbFondo3.Visible = true;
                    pbFondo4.Visible = true;
                
                    


                    break;
                case 1:
                    pbFondo1.Visible = false;
                    pbFondo2.Visible = true;
                    pbFondo3.Visible = true;
                    pbFondo4.Visible = true;
                    pic_preso1.Image = presos[0].Foto;
                    lbl_nombre1.Text = presos[0].Nombre;
                    lbl_apellido1.Text = presos[0].Apellidos;
                    lbl_Dni1.Text = presos[0].Nif; 
                    
                    break;

                case 2:
                    pbFondo1.Visible = false;
                    pbFondo2.Visible = false;
                    pbFondo3.Visible = true;
                    pbFondo4.Visible = true;

                    pic_preso1.Image = presos[0].Foto;
                    lbl_nombre1.Text = presos[0].Nombre;
                    lbl_apellido1.Text = presos[0].Apellidos;
                    lbl_Dni1.Text = presos[0].Nif;

                    pic_preso2.Image = presos[1].Foto;
                    lbl_nombre2.Text = presos[1].Nombre;
                    lbl_apellido2.Text = presos[1].Apellidos;
                    lbl_dni2.Text = presos[1].Nif; break;
                case 3:
                    pbFondo1.Visible = false;
                    pbFondo2.Visible = false;
                    pbFondo3.Visible = false;
                    pbFondo4.Visible = true;
                    pic_preso1.Image = presos[0].Foto;
                    lbl_nombre1.Text = presos[0].Nombre;
                    lbl_apellido1.Text = presos[0].Apellidos;
                    lbl_Dni1.Text = presos[0].Nif;

                    pic_preso2.Image = presos[1].Foto;
                    lbl_nombre2.Text = presos[1].Nombre;
                    lbl_apellido2.Text = presos[1].Apellidos;
                    lbl_dni2.Text = presos[1].Nif;

                    pic_preso3.Image = presos[2].Foto;
                    lbl_nombre3.Text = presos[2].Nombre;
                    lbl_apellido3.Text = presos[2].Apellidos;
                    lbl_dni3.Text = presos[2].Nif;
                    break;
                case 4:
                    pbFondo1.Visible = false;
                    pbFondo2.Visible = false;
                    pbFondo3.Visible = false;
                    pbFondo4.Visible = false;
                    pic_preso1.Image = presos[0].Foto;
                    lbl_nombre1.Text = presos[0].Nombre;
                    lbl_apellido1.Text = presos[0].Apellidos;
                    lbl_Dni1.Text = presos[0].Nif;

                    pic_preso2.Image = presos[1].Foto;
                    lbl_nombre2.Text = presos[1].Nombre;
                    lbl_apellido2.Text = presos[1].Apellidos;
                    lbl_dni2.Text = presos[1].Nif;

                    pic_preso3.Image = presos[2].Foto;
                    lbl_nombre3.Text = presos[2].Nombre;
                    lbl_apellido3.Text = presos[2].Apellidos;
                    lbl_dni3.Text = presos[2].Nif;

                    pic_preso4.Image = presos[3].Foto;
                    lbl_nombre4.Text = presos[3].Nombre;
                    lbl_apellido4.Text = presos[3].Apellidos;
                    lbl_dni4.Text = presos[3].Nif; break;
                default :
                    pbFondo1.Visible = true;
                    pbFondo2.Visible = true;
                    pbFondo3.Visible = true;
                    pbFondo4.Visible = true; break;
            }
        }
    }
}
