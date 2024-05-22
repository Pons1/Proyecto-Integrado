using System;

namespace PROYECTO
{
    partial class FrmRegistro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_añadir_registro = new System.Windows.Forms.Button();
            this.lblFiltrarPorTexto = new System.Windows.Forms.Label();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.txtBusquedaPorTexto = new System.Windows.Forms.TextBox();
            this.lblFiltrarPorFecha = new System.Windows.Forms.Label();
            this.pcbLupa = new System.Windows.Forms.PictureBox();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.grbSeleccionRegistro = new System.Windows.Forms.GroupBox();
            this.rbtnEmpleado = new System.Windows.Forms.RadioButton();
            this.rbtnPreso = new System.Windows.Forms.RadioButton();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLupa)).BeginInit();
            this.grbSeleccionRegistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_añadir_registro
            // 
            this.btn_añadir_registro.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_añadir_registro.Image = global::PROYECTO.Properties.Resources.anadir;
            this.btn_añadir_registro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_añadir_registro.Location = new System.Drawing.Point(36, 28);
            this.btn_añadir_registro.Margin = new System.Windows.Forms.Padding(4);
            this.btn_añadir_registro.Name = "btn_añadir_registro";
            this.btn_añadir_registro.Size = new System.Drawing.Size(208, 60);
            this.btn_añadir_registro.TabIndex = 2;
            this.btn_añadir_registro.Text = "Añadir Registro";
            this.btn_añadir_registro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_añadir_registro.UseVisualStyleBackColor = true;
            this.btn_añadir_registro.Click += new System.EventHandler(this.btn_añadir_registro_Click);
            // 
            // lblFiltrarPorTexto
            // 
            this.lblFiltrarPorTexto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFiltrarPorTexto.AutoSize = true;
            this.lblFiltrarPorTexto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltrarPorTexto.Location = new System.Drawing.Point(234, 40);
            this.lblFiltrarPorTexto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiltrarPorTexto.Name = "lblFiltrarPorTexto";
            this.lblFiltrarPorTexto.Size = new System.Drawing.Size(153, 23);
            this.lblFiltrarPorTexto.TabIndex = 5;
            this.lblFiltrarPorTexto.Text = "Filtrar por texto:";
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFechaInicio.CalendarFont = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaInicio.CustomFormat = "";
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicio.Location = new System.Drawing.Point(824, 28);
            this.dtpFechaInicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(127, 22);
            this.dtpFechaInicio.TabIndex = 6;
            this.dtpFechaInicio.ValueChanged += new System.EventHandler(this.dtpFechaInicio_ValueChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 108);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(915, 370);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFechaFin.CalendarFont = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaFin.CustomFormat = "";
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFin.Location = new System.Drawing.Point(824, 66);
            this.dtpFechaFin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFechaFin.MaxDate = new System.DateTime(2024, 5, 21, 0, 0, 0, 0);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(127, 22);
            this.dtpFechaFin.TabIndex = 8;
            this.dtpFechaFin.Value = new System.DateTime(2024, 5, 21, 0, 0, 0, 0);
            this.dtpFechaFin.ValueChanged += new System.EventHandler(this.dtpFechaFin_ValueChanged);
            // 
            // txtBusquedaPorTexto
            // 
            this.txtBusquedaPorTexto.Location = new System.Drawing.Point(446, 40);
            this.txtBusquedaPorTexto.Name = "txtBusquedaPorTexto";
            this.txtBusquedaPorTexto.Size = new System.Drawing.Size(166, 22);
            this.txtBusquedaPorTexto.TabIndex = 9;
            this.txtBusquedaPorTexto.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblFiltrarPorFecha
            // 
            this.lblFiltrarPorFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFiltrarPorFecha.AutoSize = true;
            this.lblFiltrarPorFecha.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltrarPorFecha.Location = new System.Drawing.Point(642, 41);
            this.lblFiltrarPorFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiltrarPorFecha.Name = "lblFiltrarPorFecha";
            this.lblFiltrarPorFecha.Size = new System.Drawing.Size(159, 23);
            this.lblFiltrarPorFecha.TabIndex = 10;
            this.lblFiltrarPorFecha.Text = "Filtrar por fecha:";
            // 
            // pcbLupa
            // 
            this.pcbLupa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pcbLupa.Image = global::PROYECTO.Properties.Resources.search_engine_optimization;
            this.pcbLupa.Location = new System.Drawing.Point(958, 40);
            this.pcbLupa.Margin = new System.Windows.Forms.Padding(4);
            this.pcbLupa.Name = "pcbLupa";
            this.pcbLupa.Size = new System.Drawing.Size(39, 32);
            this.pcbLupa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbLupa.TabIndex = 14;
            this.pcbLupa.TabStop = false;
            this.pcbLupa.Click += new System.EventHandler(this.pcbLupa_Click);
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Location = new System.Drawing.Point(273, 78);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(93, 23);
            this.btnRefrescar.TabIndex = 15;
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // grbSeleccionRegistro
            // 
            this.grbSeleccionRegistro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grbSeleccionRegistro.Controls.Add(this.rbtnEmpleado);
            this.grbSeleccionRegistro.Controls.Add(this.rbtnPreso);
            this.grbSeleccionRegistro.Location = new System.Drawing.Point(446, 68);
            this.grbSeleccionRegistro.Name = "grbSeleccionRegistro";
            this.grbSeleccionRegistro.Size = new System.Drawing.Size(175, 34);
            this.grbSeleccionRegistro.TabIndex = 18;
            this.grbSeleccionRegistro.TabStop = false;
            // 
            // rbtnEmpleado
            // 
            this.rbtnEmpleado.AutoSize = true;
            this.rbtnEmpleado.Location = new System.Drawing.Point(5, 11);
            this.rbtnEmpleado.Name = "rbtnEmpleado";
            this.rbtnEmpleado.Size = new System.Drawing.Size(91, 20);
            this.rbtnEmpleado.TabIndex = 1;
            this.rbtnEmpleado.Text = "Empleado";
            this.rbtnEmpleado.UseVisualStyleBackColor = true;
            this.rbtnEmpleado.CheckedChanged += new System.EventHandler(this.rbtnEmpleado_CheckedChanged);
            // 
            // rbtnPreso
            // 
            this.rbtnPreso.AutoSize = true;
            this.rbtnPreso.Location = new System.Drawing.Point(105, 11);
            this.rbtnPreso.Name = "rbtnPreso";
            this.rbtnPreso.Size = new System.Drawing.Size(64, 20);
            this.rbtnPreso.TabIndex = 0;
            this.rbtnPreso.Text = "Preso";
            this.rbtnPreso.UseVisualStyleBackColor = true;
            this.rbtnPreso.CheckedChanged += new System.EventHandler(this.rbtnPreso_CheckedChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(36, 108);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(915, 370);
            this.dataGridView2.TabIndex = 19;
            // 
            // FrmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(190)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1011, 505);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.grbSeleccionRegistro);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.pcbLupa);
            this.Controls.Add(this.lblFiltrarPorFecha);
            this.Controls.Add(this.txtBusquedaPorTexto);
            this.Controls.Add(this.dtpFechaFin);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.lblFiltrarPorTexto);
            this.Controls.Add(this.btn_añadir_registro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmRegistro";
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.FrmRegistro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLupa)).EndInit();
            this.grbSeleccionRegistro.ResumeLayout(false);
            this.grbSeleccionRegistro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

      

        #endregion

        private System.Windows.Forms.Button btn_añadir_registro;
        private System.Windows.Forms.Label lblFiltrarPorTexto;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.TextBox txtBusquedaPorTexto;
        private System.Windows.Forms.Label lblFiltrarPorFecha;
        private System.Windows.Forms.PictureBox pcbLupa;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.GroupBox grbSeleccionRegistro;
        private System.Windows.Forms.RadioButton rbtnEmpleado;
        private System.Windows.Forms.RadioButton rbtnPreso;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}