namespace PROYECTO
{
    partial class FrmMapa
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
            this.btn_bloqB = new System.Windows.Forms.Button();
            this.btn_bloqA = new System.Windows.Forms.Button();
            this.btn_p3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_cafeteria = new System.Windows.Forms.Button();
            this.btn_entrada = new System.Windows.Forms.Button();
            this.brn_biblioteca = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_bloqB
            // 
            this.btn_bloqB.BackColor = System.Drawing.Color.White;
            this.btn_bloqB.Location = new System.Drawing.Point(552, 218);
            this.btn_bloqB.Name = "btn_bloqB";
            this.btn_bloqB.Size = new System.Drawing.Size(20, 20);
            this.btn_bloqB.TabIndex = 2;
            this.btn_bloqB.UseVisualStyleBackColor = false;
            this.btn_bloqB.Click += new System.EventHandler(this.btn_p2_Click);
            // 
            // btn_bloqA
            // 
            this.btn_bloqA.BackColor = System.Drawing.Color.White;
            this.btn_bloqA.Location = new System.Drawing.Point(159, 218);
            this.btn_bloqA.Name = "btn_bloqA";
            this.btn_bloqA.Size = new System.Drawing.Size(20, 20);
            this.btn_bloqA.TabIndex = 4;
            this.btn_bloqA.UseVisualStyleBackColor = false;
            this.btn_bloqA.Click += new System.EventHandler(this.btn_p1_Click);
            // 
            // btn_p3
            // 
            this.btn_p3.BackColor = System.Drawing.Color.White;
            this.btn_p3.Location = new System.Drawing.Point(405, 306);
            this.btn_p3.Name = "btn_p3";
            this.btn_p3.Size = new System.Drawing.Size(20, 20);
            this.btn_p3.TabIndex = 5;
            this.btn_p3.UseVisualStyleBackColor = false;
            this.btn_p3.Click += new System.EventHandler(this.btn_p3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PROYECTO.Properties.Resources.prision;
            this.pictureBox1.Location = new System.Drawing.Point(61, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(641, 493);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_cafeteria
            // 
            this.btn_cafeteria.BackColor = System.Drawing.Color.White;
            this.btn_cafeteria.Location = new System.Drawing.Point(316, 223);
            this.btn_cafeteria.Name = "btn_cafeteria";
            this.btn_cafeteria.Size = new System.Drawing.Size(20, 20);
            this.btn_cafeteria.TabIndex = 6;
            this.btn_cafeteria.UseVisualStyleBackColor = false;
            // 
            // btn_entrada
            // 
            this.btn_entrada.BackColor = System.Drawing.Color.White;
            this.btn_entrada.Location = new System.Drawing.Point(405, 430);
            this.btn_entrada.Name = "btn_entrada";
            this.btn_entrada.Size = new System.Drawing.Size(20, 20);
            this.btn_entrada.TabIndex = 7;
            this.btn_entrada.UseVisualStyleBackColor = false;
            // 
            // brn_biblioteca
            // 
            this.brn_biblioteca.BackColor = System.Drawing.Color.White;
            this.brn_biblioteca.Location = new System.Drawing.Point(392, 262);
            this.brn_biblioteca.Name = "brn_biblioteca";
            this.brn_biblioteca.Size = new System.Drawing.Size(20, 20);
            this.brn_biblioteca.TabIndex = 8;
            this.brn_biblioteca.UseVisualStyleBackColor = false;
            // 
            // Mapa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(787, 487);
            this.Controls.Add(this.brn_biblioteca);
            this.Controls.Add(this.btn_entrada);
            this.Controls.Add(this.btn_cafeteria);
            this.Controls.Add(this.btn_p3);
            this.Controls.Add(this.btn_bloqA);
            this.Controls.Add(this.btn_bloqB);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Mapa";
            this.Text = "Mapa";
            this.Load += new System.EventHandler(this.Mapa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_bloqB;
        private System.Windows.Forms.Button btn_bloqA;
        private System.Windows.Forms.Button btn_p3;
        private System.Windows.Forms.Button btn_cafeteria;
        private System.Windows.Forms.Button btn_entrada;
        private System.Windows.Forms.Button brn_biblioteca;
    }
}