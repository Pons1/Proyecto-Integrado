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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.foto = new System.Windows.Forms.DataGridViewImageColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crimen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.info = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_añadir_recluso = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_buscar
            // 
            this.txt_buscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_buscar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_buscar.Location = new System.Drawing.Point(530, 30);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(169, 26);
            this.txt_buscar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(527, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 18);
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
            this.cmb_modulo.Location = new System.Drawing.Point(595, 62);
            this.cmb_modulo.Name = "cmb_modulo";
            this.cmb_modulo.Size = new System.Drawing.Size(104, 26);
            this.cmb_modulo.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.foto,
            this.nom,
            this.apell,
            this.crimen,
            this.modulo,
            this.celda,
            this.info});
            this.dataGridView1.Location = new System.Drawing.Point(39, 115);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(686, 301);
            this.dataGridView1.TabIndex = 7;
            // 
            // foto
            // 
            this.foto.HeaderText = "Foto";
            this.foto.Name = "foto";
            this.foto.ReadOnly = true;
            // 
            // nom
            // 
            this.nom.HeaderText = "Nombre";
            this.nom.Name = "nom";
            this.nom.ReadOnly = true;
            // 
            // apell
            // 
            this.apell.HeaderText = "Apellidos";
            this.apell.Name = "apell";
            this.apell.ReadOnly = true;
            // 
            // crimen
            // 
            this.crimen.HeaderText = "Crimen";
            this.crimen.Name = "crimen";
            this.crimen.ReadOnly = true;
            // 
            // modulo
            // 
            this.modulo.HeaderText = "Modulo";
            this.modulo.Name = "modulo";
            this.modulo.ReadOnly = true;
            // 
            // celda
            // 
            this.celda.HeaderText = "Celda";
            this.celda.Name = "celda";
            this.celda.ReadOnly = true;
            // 
            // info
            // 
            this.info.HeaderText = "Ver info";
            this.info.Name = "info";
            this.info.ReadOnly = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::PROYECTO.Properties.Resources.search_engine_optimization;
            this.pictureBox1.Location = new System.Drawing.Point(696, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btn_añadir_recluso
            // 
            this.btn_añadir_recluso.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_añadir_recluso.Image = global::PROYECTO.Properties.Resources.anadir;
            this.btn_añadir_recluso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_añadir_recluso.Location = new System.Drawing.Point(39, 30);
            this.btn_añadir_recluso.Name = "btn_añadir_recluso";
            this.btn_añadir_recluso.Size = new System.Drawing.Size(159, 49);
            this.btn_añadir_recluso.TabIndex = 0;
            this.btn_añadir_recluso.Text = "Añadir Recluso";
            this.btn_añadir_recluso.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_añadir_recluso.UseVisualStyleBackColor = true;
            this.btn_añadir_recluso.Click += new System.EventHandler(this.btn_añadir_recluso_Click);
            // 
            // Presos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(190)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(771, 448);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmb_modulo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_buscar);
            this.Controls.Add(this.btn_añadir_recluso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Presos";
            this.Text = "Presos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewImageColumn foto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn apell;
        private System.Windows.Forms.DataGridViewTextBoxColumn crimen;
        private System.Windows.Forms.DataGridViewTextBoxColumn modulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn celda;
        private System.Windows.Forms.DataGridViewButtonColumn info;
    }
}