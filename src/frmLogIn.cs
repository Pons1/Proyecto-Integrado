﻿using System;
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
    public partial class frmLogIn : Form
    {
        public frmLogIn()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (Empleado.ComprobarRegistro(txtUsuario.Text,txtContraseña.Text) )
            {
                
                FrmPpal frmPpal = new FrmPpal();
                frmPpal.ShowDialog();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Usuario/Contraseña incorrecto");
                txtContraseña.Clear();
                txtUsuario.Clear();

            }
        }
    }
}
