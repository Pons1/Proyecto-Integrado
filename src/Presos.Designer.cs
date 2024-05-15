namespace PROYECTO
{
    partial class Presos
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
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_modulo = new System.Windows.Forms.ComboBox();
            this.dgvPresos = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_añadir_recluso = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPresos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_buscar
            // 
            this.txt_buscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_buscar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_buscar.Location = new System.Drawing.Point(707, 37);
            this.txt_buscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(224, 30);
            this.txt_buscar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(703, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Modulo:";
            // 
            // cmb_modulo
            // 
            this.cmb_modulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_modulo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_modulo.FormattingEnabled = true;
            this.cmb_modulo.Items.AddRange(new object[] {
            "Modulo A",
            "Modulo B",
            "Modulo C",
            "Modulo D",
            "Comedor",
            "Enfermería"});
            this.cmb_modulo.Location = new System.Drawing.Point(793, 76);
            this.cmb_modulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmb_modulo.Name = "cmb_modulo";
            this.cmb_modulo.Size = new System.Drawing.Size(137, 31);
            this.cmb_modulo.TabIndex = 4;
            // 
            // dgvPresos
            // 
            this.dgvPresos.AllowUserToDeleteRows = false;
            this.dgvPresos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPresos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPresos.Location = new System.Drawing.Point(52, 142);
            this.dgvPresos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvPresos.Name = "dgvPresos";
            this.dgvPresos.ReadOnly = true;
            this.dgvPresos.RowHeadersWidth = 51;
            this.dgvPresos.Size = new System.Drawing.Size(915, 370);
            this.dgvPresos.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::PROYECTO.Properties.Resources.search_engine_optimization;
            this.pictureBox1.Location = new System.Drawing.Point(928, 37);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btn_añadir_recluso
            // 
            this.btn_añadir_recluso.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_añadir_recluso.Image = global::PROYECTO.Properties.Resources.anadir;
            this.btn_añadir_recluso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_añadir_recluso.Location = new System.Drawing.Point(52, 37);
            this.btn_añadir_recluso.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_añadir_recluso.Name = "btn_añadir_recluso";
            this.btn_añadir_recluso.Size = new System.Drawing.Size(212, 60);
            this.btn_añadir_recluso.TabIndex = 0;
            this.btn_añadir_recluso.Text = "Añadir Recluso";
            this.btn_añadir_recluso.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_añadir_recluso.UseVisualStyleBackColor = true;
            this.btn_añadir_recluso.Click += new System.EventHandler(this.btn_añadir_recluso_Click);
            // 
            // Presos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(190)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1028, 551);
            this.Controls.Add(this.dgvPresos);
            this.Controls.Add(this.cmb_modulo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_buscar);
            this.Controls.Add(this.btn_añadir_recluso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Presos";
            this.Text = "Presos";
            this.Load += new System.EventHandler(this.Presos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPresos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_añadir_recluso;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_modulo;
        private System.Windows.Forms.DataGridView dgvPresos;
    }
}