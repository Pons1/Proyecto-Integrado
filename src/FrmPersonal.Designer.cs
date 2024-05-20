namespace PROYECTO
{
    partial class FrmPersonal
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.dgvPresos = new System.Windows.Forms.DataGridView();
            this.cmb_modulo = new System.Windows.Forms.ComboBox();
            this.lblmod = new System.Windows.Forms.Label();
            this.pcbLupa = new System.Windows.Forms.PictureBox();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.btn_añadir_recluso = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPresos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLupa)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 462);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(513, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "*Doble click sobre la liena para ver la ficha personal/editar/borrar de cada empl" +
    "eado";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(604, 25);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(90, 23);
            this.lblNombre.TabIndex = 18;
            this.lblNombre.Text = "Nombre:";
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(766, 491);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(171, 42);
            this.btnReset.TabIndex = 17;
            this.btnReset.Text = "Actualizar";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // dgvPresos
            // 
            this.dgvPresos.AllowUserToDeleteRows = false;
            this.dgvPresos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPresos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPresos.Location = new System.Drawing.Point(48, 111);
            this.dgvPresos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPresos.Name = "dgvPresos";
            this.dgvPresos.ReadOnly = true;
            this.dgvPresos.RowHeadersWidth = 51;
            this.dgvPresos.Size = new System.Drawing.Size(915, 347);
            this.dgvPresos.TabIndex = 16;
            // 
            // cmb_modulo
            // 
            this.cmb_modulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_modulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_modulo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_modulo.FormattingEnabled = true;
            this.cmb_modulo.Location = new System.Drawing.Point(790, 61);
            this.cmb_modulo.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_modulo.Name = "cmb_modulo";
            this.cmb_modulo.Size = new System.Drawing.Size(137, 31);
            this.cmb_modulo.TabIndex = 15;
            // 
            // lblmod
            // 
            this.lblmod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblmod.AutoSize = true;
            this.lblmod.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmod.Location = new System.Drawing.Point(700, 65);
            this.lblmod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmod.Name = "lblmod";
            this.lblmod.Size = new System.Drawing.Size(85, 23);
            this.lblmod.TabIndex = 14;
            this.lblmod.Text = "Módulo:";
            // 
            // pcbLupa
            // 
            this.pcbLupa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pcbLupa.Image = global::PROYECTO.Properties.Resources.search_engine_optimization;
            this.pcbLupa.Location = new System.Drawing.Point(945, 22);
            this.pcbLupa.Margin = new System.Windows.Forms.Padding(4);
            this.pcbLupa.Name = "pcbLupa";
            this.pcbLupa.Size = new System.Drawing.Size(39, 32);
            this.pcbLupa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbLupa.TabIndex = 13;
            this.pcbLupa.TabStop = false;
            // 
            // txt_buscar
            // 
            this.txt_buscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_buscar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_buscar.Location = new System.Drawing.Point(704, 22);
            this.txt_buscar.Margin = new System.Windows.Forms.Padding(4);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(224, 30);
            this.txt_buscar.TabIndex = 12;
            // 
            // btn_añadir_recluso
            // 
            this.btn_añadir_recluso.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_añadir_recluso.Image = global::PROYECTO.Properties.Resources.anadir;
            this.btn_añadir_recluso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_añadir_recluso.Location = new System.Drawing.Point(77, 28);
            this.btn_añadir_recluso.Margin = new System.Windows.Forms.Padding(4);
            this.btn_añadir_recluso.Name = "btn_añadir_recluso";
            this.btn_añadir_recluso.Size = new System.Drawing.Size(218, 60);
            this.btn_añadir_recluso.TabIndex = 11;
            this.btn_añadir_recluso.Text = "Añadir Recluso";
            this.btn_añadir_recluso.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_añadir_recluso.UseVisualStyleBackColor = true;
            // 
            // FrmPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(190)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1028, 551);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.dgvPresos);
            this.Controls.Add(this.cmb_modulo);
            this.Controls.Add(this.lblmod);
            this.Controls.Add(this.pcbLupa);
            this.Controls.Add(this.txt_buscar);
            this.Controls.Add(this.btn_añadir_recluso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPersonal";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPresos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLupa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DataGridView dgvPresos;
        private System.Windows.Forms.ComboBox cmb_modulo;
        private System.Windows.Forms.Label lblmod;
        private System.Windows.Forms.PictureBox pcbLupa;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.Button btn_añadir_recluso;
    }
}