namespace PROYECTO
{
    partial class FrmAñadirRegistro
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
            this.lblNif = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblRegistro = new System.Windows.Forms.Label();
            this.mtxtNif = new System.Windows.Forms.MaskedTextBox();
            this.grbSeleccionRegistro = new System.Windows.Forms.GroupBox();
            this.rbtnEmpleado = new System.Windows.Forms.RadioButton();
            this.rbtnPreso = new System.Windows.Forms.RadioButton();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.lblMotivo = new System.Windows.Forms.Label();
            this.btnCrearRegistro = new System.Windows.Forms.Button();
            this.grbSeleccionRegistro.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNif
            // 
            this.lblNif.AutoSize = true;
            this.lblNif.Location = new System.Drawing.Point(283, 131);
            this.lblNif.Name = "lblNif";
            this.lblNif.Size = new System.Drawing.Size(31, 16);
            this.lblNif.TabIndex = 2;
            this.lblNif.Text = "NIF:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ENTRADA",
            "SALIDA"});
            this.comboBox1.Location = new System.Drawing.Point(320, 172);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(197, 24);
            this.comboBox1.TabIndex = 3;
            // 
            // lblRegistro
            // 
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.Location = new System.Drawing.Point(253, 175);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(61, 16);
            this.lblRegistro.TabIndex = 4;
            this.lblRegistro.Text = "Registro:";
            // 
            // mtxtNif
            // 
            this.mtxtNif.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.mtxtNif.Location = new System.Drawing.Point(320, 125);
            this.mtxtNif.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mtxtNif.Mask = "00000000-L";
            this.mtxtNif.Name = "mtxtNif";
            this.mtxtNif.Size = new System.Drawing.Size(197, 30);
            this.mtxtNif.TabIndex = 12;
            this.mtxtNif.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grbSeleccionRegistro
            // 
            this.grbSeleccionRegistro.Controls.Add(this.rbtnEmpleado);
            this.grbSeleccionRegistro.Controls.Add(this.rbtnPreso);
            this.grbSeleccionRegistro.Location = new System.Drawing.Point(265, 27);
            this.grbSeleccionRegistro.Name = "grbSeleccionRegistro";
            this.grbSeleccionRegistro.Size = new System.Drawing.Size(265, 60);
            this.grbSeleccionRegistro.TabIndex = 13;
            this.grbSeleccionRegistro.TabStop = false;
            // 
            // rbtnEmpleado
            // 
            this.rbtnEmpleado.AutoSize = true;
            this.rbtnEmpleado.Location = new System.Drawing.Point(36, 24);
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
            this.rbtnPreso.Location = new System.Drawing.Point(150, 24);
            this.rbtnPreso.Name = "rbtnPreso";
            this.rbtnPreso.Size = new System.Drawing.Size(64, 20);
            this.rbtnPreso.TabIndex = 0;
            this.rbtnPreso.TabStop = true;
            this.rbtnPreso.Text = "Preso";
            this.rbtnPreso.UseVisualStyleBackColor = true;
            this.rbtnPreso.CheckedChanged += new System.EventHandler(this.rbtnPreso_CheckedChanged);
            // 
            // txtMotivo
            // 
            this.txtMotivo.Location = new System.Drawing.Point(320, 211);
            this.txtMotivo.Multiline = true;
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(197, 130);
            this.txtMotivo.TabIndex = 14;
            // 
            // lblMotivo
            // 
            this.lblMotivo.AutoSize = true;
            this.lblMotivo.Location = new System.Drawing.Point(264, 213);
            this.lblMotivo.Name = "lblMotivo";
            this.lblMotivo.Size = new System.Drawing.Size(50, 16);
            this.lblMotivo.TabIndex = 15;
            this.lblMotivo.Text = "Motivo:";
            // 
            // btnCrearRegistro
            // 
            this.btnCrearRegistro.Location = new System.Drawing.Point(632, 366);
            this.btnCrearRegistro.Name = "btnCrearRegistro";
            this.btnCrearRegistro.Size = new System.Drawing.Size(129, 44);
            this.btnCrearRegistro.TabIndex = 16;
            this.btnCrearRegistro.Text = "Crear Registro";
            this.btnCrearRegistro.UseVisualStyleBackColor = true;
            this.btnCrearRegistro.Click += new System.EventHandler(this.btnCrearRegistro_Click);
            // 
            // FrmAñadirRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCrearRegistro);
            this.Controls.Add(this.lblMotivo);
            this.Controls.Add(this.txtMotivo);
            this.Controls.Add(this.grbSeleccionRegistro);
            this.Controls.Add(this.mtxtNif);
            this.Controls.Add(this.lblRegistro);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblNif);
            this.Name = "FrmAñadirRegistro";
            this.Text = "FrmAñadirRegistro";
            this.Load += new System.EventHandler(this.FrmAñadirRegistro_Load);
            this.grbSeleccionRegistro.ResumeLayout(false);
            this.grbSeleccionRegistro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNif;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblRegistro;
        private System.Windows.Forms.MaskedTextBox mtxtNif;
        private System.Windows.Forms.GroupBox grbSeleccionRegistro;
        private System.Windows.Forms.RadioButton rbtnEmpleado;
        private System.Windows.Forms.RadioButton rbtnPreso;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.Label lblMotivo;
        private System.Windows.Forms.Button btnCrearRegistro;
    }
}