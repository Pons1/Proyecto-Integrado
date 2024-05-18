namespace PROYECTO
{
    partial class FrmPpal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.btn_registro = new System.Windows.Forms.Button();
            this.btn_horario = new System.Windows.Forms.Button();
            this.btn_personal = new System.Windows.Forms.Button();
            this.btn_presos = new System.Windows.Forms.Button();
            this.btn_mapa = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.pic_normal = new System.Windows.Forms.PictureBox();
            this.pic_maximizar = new System.Windows.Forms.PictureBox();
            this.pic_minimizar = new System.Windows.Forms.PictureBox();
            this.pic_cerrar = new System.Windows.Forms.PictureBox();
            this.btn_slide = new System.Windows.Forms.PictureBox();
            this.PanelPrincipal = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_normal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_slide)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.MenuVertical.Controls.Add(this.btn_registro);
            this.MenuVertical.Controls.Add(this.btn_horario);
            this.MenuVertical.Controls.Add(this.btn_personal);
            this.MenuVertical.Controls.Add(this.btn_presos);
            this.MenuVertical.Controls.Add(this.btn_mapa);
            this.MenuVertical.Controls.Add(this.pictureBox1);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 0);
            this.MenuVertical.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(251, 650);
            this.MenuVertical.TabIndex = 0;
            // 
            // btn_registro
            // 
            this.btn_registro.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_registro.FlatAppearance.BorderSize = 0;
            this.btn_registro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(173)))));
            this.btn_registro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_registro.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registro.ForeColor = System.Drawing.Color.White;
            this.btn_registro.Image = global::PROYECTO.Properties.Resources.paper_32;
            this.btn_registro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_registro.Location = new System.Drawing.Point(0, 391);
            this.btn_registro.Margin = new System.Windows.Forms.Padding(4);
            this.btn_registro.Name = "btn_registro";
            this.btn_registro.Size = new System.Drawing.Size(251, 62);
            this.btn_registro.TabIndex = 5;
            this.btn_registro.Text = "Registros";
            this.btn_registro.UseVisualStyleBackColor = true;
            this.btn_registro.Click += new System.EventHandler(this.btn_registro_Click);
            // 
            // btn_horario
            // 
            this.btn_horario.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_horario.FlatAppearance.BorderSize = 0;
            this.btn_horario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(173)))));
            this.btn_horario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_horario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_horario.ForeColor = System.Drawing.Color.White;
            this.btn_horario.Image = global::PROYECTO.Properties.Resources.time_8_32;
            this.btn_horario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_horario.Location = new System.Drawing.Point(0, 322);
            this.btn_horario.Margin = new System.Windows.Forms.Padding(4);
            this.btn_horario.Name = "btn_horario";
            this.btn_horario.Size = new System.Drawing.Size(251, 62);
            this.btn_horario.TabIndex = 4;
            this.btn_horario.Text = "Horario";
            this.btn_horario.UseVisualStyleBackColor = true;
            this.btn_horario.Click += new System.EventHandler(this.btn_horario_Click);
            // 
            // btn_personal
            // 
            this.btn_personal.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_personal.FlatAppearance.BorderSize = 0;
            this.btn_personal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(173)))));
            this.btn_personal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_personal.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_personal.ForeColor = System.Drawing.Color.White;
            this.btn_personal.Image = global::PROYECTO.Properties.Resources.worker_32;
            this.btn_personal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_personal.Location = new System.Drawing.Point(0, 254);
            this.btn_personal.Margin = new System.Windows.Forms.Padding(4);
            this.btn_personal.Name = "btn_personal";
            this.btn_personal.Size = new System.Drawing.Size(251, 62);
            this.btn_personal.TabIndex = 3;
            this.btn_personal.Text = "Personal";
            this.btn_personal.UseVisualStyleBackColor = true;
            this.btn_personal.Click += new System.EventHandler(this.btn_personal_Click);
            // 
            // btn_presos
            // 
            this.btn_presos.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_presos.FlatAppearance.BorderSize = 0;
            this.btn_presos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(173)))));
            this.btn_presos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_presos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_presos.ForeColor = System.Drawing.Color.White;
            this.btn_presos.Image = global::PROYECTO.Properties.Resources.add_user_32;
            this.btn_presos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_presos.Location = new System.Drawing.Point(0, 185);
            this.btn_presos.Margin = new System.Windows.Forms.Padding(4);
            this.btn_presos.Name = "btn_presos";
            this.btn_presos.Size = new System.Drawing.Size(251, 62);
            this.btn_presos.TabIndex = 2;
            this.btn_presos.Text = "Presos";
            this.btn_presos.UseVisualStyleBackColor = true;
            this.btn_presos.Click += new System.EventHandler(this.btn_presos_Click);
            // 
            // btn_mapa
            // 
            this.btn_mapa.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_mapa.FlatAppearance.BorderSize = 0;
            this.btn_mapa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(173)))));
            this.btn_mapa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mapa.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mapa.ForeColor = System.Drawing.Color.White;
            this.btn_mapa.Image = global::PROYECTO.Properties.Resources.map_4_32;
            this.btn_mapa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_mapa.Location = new System.Drawing.Point(0, 116);
            this.btn_mapa.Margin = new System.Windows.Forms.Padding(4);
            this.btn_mapa.Name = "btn_mapa";
            this.btn_mapa.Size = new System.Drawing.Size(251, 62);
            this.btn_mapa.TabIndex = 1;
            this.btn_mapa.Text = "Mapa";
            this.btn_mapa.UseVisualStyleBackColor = true;
            this.btn_mapa.Click += new System.EventHandler(this.btn_mapa_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PROYECTO.Properties.Resources.Captura;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(251, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BarraTitulo.Controls.Add(this.pic_normal);
            this.BarraTitulo.Controls.Add(this.pic_maximizar);
            this.BarraTitulo.Controls.Add(this.pic_minimizar);
            this.BarraTitulo.Controls.Add(this.pic_cerrar);
            this.BarraTitulo.Controls.Add(this.btn_slide);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(251, 0);
            this.BarraTitulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(1049, 50);
            this.BarraTitulo.TabIndex = 1;
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // pic_normal
            // 
            this.pic_normal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_normal.Image = global::PROYECTO.Properties.Resources.minimizar;
            this.pic_normal.Location = new System.Drawing.Point(997, 4);
            this.pic_normal.Margin = new System.Windows.Forms.Padding(4);
            this.pic_normal.Name = "pic_normal";
            this.pic_normal.Size = new System.Drawing.Size(20, 18);
            this.pic_normal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_normal.TabIndex = 4;
            this.pic_normal.TabStop = false;
            this.pic_normal.Visible = false;
            this.pic_normal.Click += new System.EventHandler(this.pic_normal_Click);
            // 
            // pic_maximizar
            // 
            this.pic_maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_maximizar.Image = global::PROYECTO.Properties.Resources.cuadrado;
            this.pic_maximizar.Location = new System.Drawing.Point(997, 4);
            this.pic_maximizar.Margin = new System.Windows.Forms.Padding(4);
            this.pic_maximizar.Name = "pic_maximizar";
            this.pic_maximizar.Size = new System.Drawing.Size(20, 18);
            this.pic_maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_maximizar.TabIndex = 3;
            this.pic_maximizar.TabStop = false;
            this.pic_maximizar.Click += new System.EventHandler(this.pic_maximizar_Click);
            // 
            // pic_minimizar
            // 
            this.pic_minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_minimizar.Image = global::PROYECTO.Properties.Resources.minimizar_signo;
            this.pic_minimizar.Location = new System.Drawing.Point(969, 4);
            this.pic_minimizar.Margin = new System.Windows.Forms.Padding(4);
            this.pic_minimizar.Name = "pic_minimizar";
            this.pic_minimizar.Size = new System.Drawing.Size(20, 18);
            this.pic_minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_minimizar.TabIndex = 2;
            this.pic_minimizar.TabStop = false;
            this.pic_minimizar.Click += new System.EventHandler(this.pic_minimizar_Click);
            // 
            // pic_cerrar
            // 
            this.pic_cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_cerrar.Image = global::PROYECTO.Properties.Resources.cerrar;
            this.pic_cerrar.Location = new System.Drawing.Point(1025, 4);
            this.pic_cerrar.Margin = new System.Windows.Forms.Padding(4);
            this.pic_cerrar.Name = "pic_cerrar";
            this.pic_cerrar.Size = new System.Drawing.Size(20, 18);
            this.pic_cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_cerrar.TabIndex = 1;
            this.pic_cerrar.TabStop = false;
            this.pic_cerrar.Click += new System.EventHandler(this.pic_cerrar_Click);
            // 
            // btn_slide
            // 
            this.btn_slide.Image = global::PROYECTO.Properties.Resources.menu;
            this.btn_slide.Location = new System.Drawing.Point(5, 9);
            this.btn_slide.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_slide.Name = "btn_slide";
            this.btn_slide.Size = new System.Drawing.Size(35, 34);
            this.btn_slide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_slide.TabIndex = 0;
            this.btn_slide.TabStop = false;
            this.btn_slide.Click += new System.EventHandler(this.btn_slide_Click);
            // 
            // PanelPrincipal
            // 
            this.PanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelPrincipal.Location = new System.Drawing.Point(251, 50);
            this.PanelPrincipal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelPrincipal.Name = "PanelPrincipal";
            this.PanelPrincipal.Size = new System.Drawing.Size(1049, 600);
            this.PanelPrincipal.TabIndex = 2;
            this.PanelPrincipal.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelPrincipal_Paint);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // FrmPpal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.PanelPrincipal);
            this.Controls.Add(this.BarraTitulo);
            this.Controls.Add(this.MenuVertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmPpal";
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.Text = "Form1";
            this.MenuVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_normal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_slide)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.Panel PanelPrincipal;
        private System.Windows.Forms.PictureBox btn_slide;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pic_cerrar;
        private System.Windows.Forms.PictureBox pic_minimizar;
        private System.Windows.Forms.PictureBox pic_maximizar;
        private System.Windows.Forms.PictureBox pic_normal;
        private System.Windows.Forms.Button btn_mapa;
        private System.Windows.Forms.Button btn_presos;
        private System.Windows.Forms.Button btn_personal;
        private System.Windows.Forms.Button btn_horario;
        private System.Windows.Forms.Button btn_registro;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

