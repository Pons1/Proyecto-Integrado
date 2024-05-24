namespace PROYECTO
{
    partial class FrmCorreos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCorreos));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtAsunto = new System.Windows.Forms.TextBox();
            this.lblAsunto = new System.Windows.Forms.Label();
            this.lblPara = new System.Windows.Forms.Label();
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnEnviarCorreo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkAdministracion = new System.Windows.Forms.CheckBox();
            this.chkEnfermeria = new System.Windows.Forms.CheckBox();
            this.chkCocina = new System.Windows.Forms.CheckBox();
            this.chkVigilancia = new System.Windows.Forms.CheckBox();
            this.chkLimpieza = new System.Windows.Forms.CheckBox();
            this.dgvCorreos = new System.Windows.Forms.DataGridView();
            this.dgvNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvApellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCorreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCorreosSeleccionados = new System.Windows.Forms.DataGridView();
            this.dgvCorreos2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCorreos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCorreosSeleccionados)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtAsunto
            // 
            this.txtAsunto.Location = new System.Drawing.Point(128, 43);
            this.txtAsunto.Name = "txtAsunto";
            this.txtAsunto.Size = new System.Drawing.Size(487, 22);
            this.txtAsunto.TabIndex = 1;
            // 
            // lblAsunto
            // 
            this.lblAsunto.AutoSize = true;
            this.lblAsunto.Location = new System.Drawing.Point(61, 46);
            this.lblAsunto.Name = "lblAsunto";
            this.lblAsunto.Size = new System.Drawing.Size(51, 16);
            this.lblAsunto.TabIndex = 2;
            this.lblAsunto.Text = "Asunto:";
            // 
            // lblPara
            // 
            this.lblPara.AutoSize = true;
            this.lblPara.Location = new System.Drawing.Point(73, 107);
            this.lblPara.Name = "lblPara";
            this.lblPara.Size = new System.Drawing.Size(39, 16);
            this.lblPara.TabIndex = 3;
            this.lblPara.Text = "Para:";
            // 
            // txtMensaje
            // 
            this.txtMensaje.Location = new System.Drawing.Point(128, 288);
            this.txtMensaje.Multiline = true;
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Size = new System.Drawing.Size(487, 145);
            this.txtMensaje.TabIndex = 4;
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(50, 288);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(62, 16);
            this.lblMensaje.TabIndex = 5;
            this.lblMensaje.Text = "Mensaje:";
            // 
            // btnEnviarCorreo
            // 
            this.btnEnviarCorreo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEnviarCorreo.BackgroundImage")));
            this.btnEnviarCorreo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEnviarCorreo.Location = new System.Drawing.Point(321, 462);
            this.btnEnviarCorreo.Name = "btnEnviarCorreo";
            this.btnEnviarCorreo.Size = new System.Drawing.Size(82, 70);
            this.btnEnviarCorreo.TabIndex = 6;
            this.btnEnviarCorreo.UseVisualStyleBackColor = true;
            this.btnEnviarCorreo.Click += new System.EventHandler(this.btnEnviarCorreo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkAdministracion);
            this.groupBox1.Controls.Add(this.chkEnfermeria);
            this.groupBox1.Controls.Add(this.chkCocina);
            this.groupBox1.Controls.Add(this.chkVigilancia);
            this.groupBox1.Controls.Add(this.chkLimpieza);
            this.groupBox1.Location = new System.Drawing.Point(458, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(157, 163);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // chkAdministracion
            // 
            this.chkAdministracion.AutoSize = true;
            this.chkAdministracion.Location = new System.Drawing.Point(6, 105);
            this.chkAdministracion.Name = "chkAdministracion";
            this.chkAdministracion.Size = new System.Drawing.Size(144, 20);
            this.chkAdministracion.TabIndex = 5;
            this.chkAdministracion.Text = "ADMINISTRACION";
            this.chkAdministracion.UseVisualStyleBackColor = true;
            // 
            // chkEnfermeria
            // 
            this.chkEnfermeria.AutoSize = true;
            this.chkEnfermeria.Location = new System.Drawing.Point(6, 134);
            this.chkEnfermeria.Name = "chkEnfermeria";
            this.chkEnfermeria.Size = new System.Drawing.Size(117, 20);
            this.chkEnfermeria.TabIndex = 3;
            this.chkEnfermeria.Text = "ENFERMERIA";
            this.chkEnfermeria.UseVisualStyleBackColor = true;
            // 
            // chkCocina
            // 
            this.chkCocina.AutoSize = true;
            this.chkCocina.Location = new System.Drawing.Point(6, 76);
            this.chkCocina.Name = "chkCocina";
            this.chkCocina.Size = new System.Drawing.Size(79, 20);
            this.chkCocina.TabIndex = 4;
            this.chkCocina.Text = "COCINA";
            this.chkCocina.UseVisualStyleBackColor = true;
            // 
            // chkVigilancia
            // 
            this.chkVigilancia.AutoSize = true;
            this.chkVigilancia.Location = new System.Drawing.Point(6, 21);
            this.chkVigilancia.Name = "chkVigilancia";
            this.chkVigilancia.Size = new System.Drawing.Size(101, 20);
            this.chkVigilancia.TabIndex = 1;
            this.chkVigilancia.Text = "VIGILANCIA";
            this.chkVigilancia.UseVisualStyleBackColor = true;
            // 
            // chkLimpieza
            // 
            this.chkLimpieza.AutoSize = true;
            this.chkLimpieza.Location = new System.Drawing.Point(6, 49);
            this.chkLimpieza.Name = "chkLimpieza";
            this.chkLimpieza.Size = new System.Drawing.Size(88, 20);
            this.chkLimpieza.TabIndex = 0;
            this.chkLimpieza.Text = "LIMPIEZA";
            this.chkLimpieza.UseVisualStyleBackColor = true;
            // 
            // dgvCorreos
            // 
            this.dgvCorreos.AllowUserToAddRows = false;
            this.dgvCorreos.AllowUserToDeleteRows = false;
            this.dgvCorreos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCorreos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCorreos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvNombre,
            this.dgvApellidos,
            this.dgvNif,
            this.dgvPuesto,
            this.dgvCorreo});
            this.dgvCorreos.Location = new System.Drawing.Point(656, 46);
            this.dgvCorreos.Name = "dgvCorreos";
            this.dgvCorreos.ReadOnly = true;
            this.dgvCorreos.RowHeadersWidth = 51;
            this.dgvCorreos.RowTemplate.Height = 24;
            this.dgvCorreos.Size = new System.Drawing.Size(630, 448);
            this.dgvCorreos.TabIndex = 8;
            // 
            // dgvNombre
            // 
            this.dgvNombre.HeaderText = "Nombre";
            this.dgvNombre.MinimumWidth = 6;
            this.dgvNombre.Name = "dgvNombre";
            this.dgvNombre.ReadOnly = true;
            this.dgvNombre.Width = 85;
            // 
            // dgvApellidos
            // 
            this.dgvApellidos.HeaderText = "Apellidos";
            this.dgvApellidos.MinimumWidth = 6;
            this.dgvApellidos.Name = "dgvApellidos";
            this.dgvApellidos.ReadOnly = true;
            this.dgvApellidos.Width = 93;
            // 
            // dgvNif
            // 
            this.dgvNif.HeaderText = "Nif";
            this.dgvNif.MinimumWidth = 6;
            this.dgvNif.Name = "dgvNif";
            this.dgvNif.ReadOnly = true;
            this.dgvNif.Width = 52;
            // 
            // dgvPuesto
            // 
            this.dgvPuesto.HeaderText = "Puesto";
            this.dgvPuesto.MinimumWidth = 6;
            this.dgvPuesto.Name = "dgvPuesto";
            this.dgvPuesto.ReadOnly = true;
            this.dgvPuesto.Width = 78;
            // 
            // dgvCorreo
            // 
            this.dgvCorreo.HeaderText = "Correo";
            this.dgvCorreo.MinimumWidth = 6;
            this.dgvCorreo.Name = "dgvCorreo";
            this.dgvCorreo.ReadOnly = true;
            this.dgvCorreo.Width = 77;
            // 
            // dgvCorreosSeleccionados
            // 
            this.dgvCorreosSeleccionados.AllowUserToAddRows = false;
            this.dgvCorreosSeleccionados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCorreosSeleccionados.ColumnHeadersHeight = 29;
            this.dgvCorreosSeleccionados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvCorreos2});
            this.dgvCorreosSeleccionados.Location = new System.Drawing.Point(128, 107);
            this.dgvCorreosSeleccionados.Name = "dgvCorreosSeleccionados";
            this.dgvCorreosSeleccionados.ReadOnly = true;
            this.dgvCorreosSeleccionados.RowHeadersWidth = 51;
            this.dgvCorreosSeleccionados.RowTemplate.Height = 24;
            this.dgvCorreosSeleccionados.Size = new System.Drawing.Size(302, 156);
            this.dgvCorreosSeleccionados.TabIndex = 9;
            // 
            // dgvCorreos2
            // 
            this.dgvCorreos2.HeaderText = "Correos Seleccionados";
            this.dgvCorreos2.MinimumWidth = 6;
            this.dgvCorreos2.Name = "dgvCorreos2";
            this.dgvCorreos2.ReadOnly = true;
            // 
            // FrmCorreos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1420, 562);
            this.Controls.Add(this.dgvCorreosSeleccionados);
            this.Controls.Add(this.dgvCorreos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnEnviarCorreo);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.txtMensaje);
            this.Controls.Add(this.lblPara);
            this.Controls.Add(this.lblAsunto);
            this.Controls.Add(this.txtAsunto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCorreos";
            this.Text = "FrmCorreos";
            this.Load += new System.EventHandler(this.FrmCorreos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCorreos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCorreosSeleccionados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtAsunto;
        private System.Windows.Forms.Label lblAsunto;
        private System.Windows.Forms.Label lblPara;
        private System.Windows.Forms.TextBox txtMensaje;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Button btnEnviarCorreo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkAdministracion;
        private System.Windows.Forms.CheckBox chkEnfermeria;
        private System.Windows.Forms.CheckBox chkCocina;
        private System.Windows.Forms.CheckBox chkVigilancia;
        private System.Windows.Forms.CheckBox chkLimpieza;
        private System.Windows.Forms.DataGridView dgvCorreos;
        private System.Windows.Forms.DataGridView dgvCorreosSeleccionados;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvApellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNif;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCorreo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCorreos2;
    }
}