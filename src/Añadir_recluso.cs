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
    public partial class Añadir_recluso : Form
    {
        public Añadir_recluso()
        {
            InitializeComponent();
        }

        private void Añadir_recluso_Load(object sender, EventArgs e)
        {
            List<int> lista = Crimen.MostrarIdCrimenes();
            for (int i = 0;i <lista.Count; i++) 
            {
                cmbCrimen.Items.Add(lista[i].ToString());
            }

            List<int> celdas = Celda.MostrarIdCeldas();
            for (int i = 0; i < lista.Count; i++)
            {
                cmbCelda.Items.Add(lista[i].ToString());
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
    }
}
