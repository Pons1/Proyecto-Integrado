namespace PROYECTO
{
    partial class FrmAñadir_recluso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAñadir_recluso));
            this.btn_añadir_foto = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txt_pnombre = new System.Windows.Forms.TextBox();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.txt_apellidos = new System.Windows.Forms.TextBox();
            this.lblNif = new System.Windows.Forms.Label();
            this.txt_nifPreso = new System.Windows.Forms.TextBox();
            this.lblCrimen = new System.Windows.Forms.Label();
            this.cmbCrimen = new System.Windows.Forms.ComboBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.cmbDireccion = new System.Windows.Forms.Label();
            this.txtCodigopostal = new System.Windows.Forms.TextBox();
            this.lblCodigoPos = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.cmbCelda = new System.Windows.Forms.ComboBox();
            this.lblCelda = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.erpPresos = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnSalir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pcboxFoto = new System.Windows.Forms.PictureBox();
            this.pic_abrir = new System.Windows.Forms.PictureBox();
            this.pic_cerrar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.erpPresos)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcboxFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_abrir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_cerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_añadir_foto
            // 
            this.btn_añadir_foto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_añadir_foto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.btn_añadir_foto.FlatAppearance.BorderSize = 0;
            this.btn_añadir_foto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_añadir_foto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_añadir_foto.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_añadir_foto.Location = new System.Drawing.Point(69, 249);
            this.btn_añadir_foto.Margin = new System.Windows.Forms.Padding(4);
            this.btn_añadir_foto.Name = "btn_añadir_foto";
            this.btn_añadir_foto.Size = new System.Drawing.Size(136, 30);
            this.btn_añadir_foto.TabIndex = 1;
            this.btn_añadir_foto.Text = "Insertar Foto";
            this.btn_añadir_foto.UseVisualStyleBackColor = false;
            this.btn_añadir_foto.Click += new System.EventHandler(this.btn_añadir_foto_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNombre.Location = new System.Drawing.Point(32, 26);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(80, 20);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            // 
            // txt_pnombre
            // 
            this.txt_pnombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
            this.txt_pnombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_pnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pnombre.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_pnombre.Location = new System.Drawing.Point(35, 49);
            this.txt_pnombre.Margin = new System.Windows.Forms.Padding(4);
            this.txt_pnombre.Name = "txt_pnombre";
            this.txt_pnombre.Size = new System.Drawing.Size(237, 23);
            this.txt_pnombre.TabIndex = 3;
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblApellidos.Location = new System.Drawing.Point(287, 26);
            this.lblApellidos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(92, 20);
            this.lblApellidos.TabIndex = 4;
            this.lblApellidos.Text = "Apellidos:";
            // 
            // txt_apellidos
            // 
            this.txt_apellidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
            this.txt_apellidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_apellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_apellidos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_apellidos.Location = new System.Drawing.Point(291, 52);
            this.txt_apellidos.Margin = new System.Windows.Forms.Padding(4);
            this.txt_apellidos.Name = "txt_apellidos";
            this.txt_apellidos.Size = new System.Drawing.Size(380, 23);
            this.txt_apellidos.TabIndex = 5;
            // 
            // lblNif
            // 
            this.lblNif.AutoSize = true;
            this.lblNif.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNif.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNif.Location = new System.Drawing.Point(31, 105);
            this.lblNif.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNif.Name = "lblNif";
            this.lblNif.Size = new System.Drawing.Size(41, 18);
            this.lblNif.TabIndex = 6;
            this.lblNif.Text = "DNI:";
            // 
            // txt_nifPreso
            // 
            this.txt_nifPreso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
            this.txt_nifPreso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nifPreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nifPreso.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_nifPreso.Location = new System.Drawing.Point(35, 127);
            this.txt_nifPreso.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nifPreso.MaxLength = 9;
            this.txt_nifPreso.Name = "txt_nifPreso";
            this.txt_nifPreso.Size = new System.Drawing.Size(156, 23);
            this.txt_nifPreso.TabIndex = 7;
            // 
            // lblCrimen
            // 
            this.lblCrimen.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCrimen.AutoSize = true;
            this.lblCrimen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrimen.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCrimen.Location = new System.Drawing.Point(215, 341);
            this.lblCrimen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCrimen.Name = "lblCrimen";
            this.lblCrimen.Size = new System.Drawing.Size(67, 18);
            this.lblCrimen.TabIndex = 8;
            this.lblCrimen.Text = "Crimen:";
            // 
            // cmbCrimen
            // 
            this.cmbCrimen.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbCrimen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
            this.cmbCrimen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCrimen.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cmbCrimen.FormattingEnabled = true;
            this.cmbCrimen.Location = new System.Drawing.Point(201, 379);
            this.cmbCrimen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCrimen.Name = "cmbCrimen";
            this.cmbCrimen.Size = new System.Drawing.Size(468, 37);
            this.cmbCrimen.TabIndex = 9;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSexo.Location = new System.Drawing.Point(508, 105);
            this.lblSexo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(51, 18);
            this.lblSexo.TabIndex = 10;
            this.lblSexo.Text = "Sexo:";
            // 
            // cmbSexo
            // 
            this.cmbSexo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
            this.cmbSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSexo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Items.AddRange(new object[] {
            "Hombre"});
            this.cmbSexo.Location = new System.Drawing.Point(512, 126);
            this.cmbSexo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(132, 37);
            this.cmbSexo.TabIndex = 11;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtDireccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtDireccion.Location = new System.Drawing.Point(35, 213);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(636, 23);
            this.txtDireccion.TabIndex = 13;
            // 
            // cmbDireccion
            // 
            this.cmbDireccion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbDireccion.AutoSize = true;
            this.cmbDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDireccion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cmbDireccion.Location = new System.Drawing.Point(32, 183);
            this.cmbDireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cmbDireccion.Name = "cmbDireccion";
            this.cmbDireccion.Size = new System.Drawing.Size(85, 18);
            this.cmbDireccion.TabIndex = 12;
            this.cmbDireccion.Text = "Direccion:";
            // 
            // txtCodigopostal
            // 
            this.txtCodigopostal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCodigopostal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
            this.txtCodigopostal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodigopostal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigopostal.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtCodigopostal.Location = new System.Drawing.Point(36, 288);
            this.txtCodigopostal.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigopostal.MaxLength = 5;
            this.txtCodigopostal.Name = "txtCodigopostal";
            this.txtCodigopostal.Size = new System.Drawing.Size(131, 23);
            this.txtCodigopostal.TabIndex = 15;
            // 
            // lblCodigoPos
            // 
            this.lblCodigoPos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCodigoPos.AutoSize = true;
            this.lblCodigoPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoPos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCodigoPos.Location = new System.Drawing.Point(32, 260);
            this.lblCodigoPos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigoPos.Name = "lblCodigoPos";
            this.lblCodigoPos.Size = new System.Drawing.Size(120, 18);
            this.lblCodigoPos.TabIndex = 14;
            this.lblCodigoPos.Text = "Codigo Postal:";
            this.lblCodigoPos.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblCorreo
            // 
            this.lblCorreo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCorreo.Location = new System.Drawing.Point(197, 260);
            this.lblCorreo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(157, 18);
            this.lblCorreo.TabIndex = 16;
            this.lblCorreo.Text = "Correo Electronico:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCorreo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
            this.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtCorreo.Location = new System.Drawing.Point(201, 288);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(469, 23);
            this.txtCorreo.TabIndex = 17;
            // 
            // cmbCelda
            // 
            this.cmbCelda.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbCelda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
            this.cmbCelda.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCelda.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cmbCelda.FormattingEnabled = true;
            this.cmbCelda.Location = new System.Drawing.Point(32, 379);
            this.cmbCelda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCelda.Name = "cmbCelda";
            this.cmbCelda.Size = new System.Drawing.Size(132, 37);
            this.cmbCelda.TabIndex = 19;
            // 
            // lblCelda
            // 
            this.lblCelda.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCelda.AutoSize = true;
            this.lblCelda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelda.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCelda.Location = new System.Drawing.Point(32, 351);
            this.lblCelda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCelda.Name = "lblCelda";
            this.lblCelda.Size = new System.Drawing.Size(56, 18);
            this.lblCelda.TabIndex = 18;
            this.lblCelda.Text = "Celda:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTelefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtTelefono.Location = new System.Drawing.Point(219, 127);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(265, 23);
            this.txtTelefono.TabIndex = 21;
            // 
            // lblTelefono
            // 
            this.lblTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTelefono.Location = new System.Drawing.Point(215, 105);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(79, 18);
            this.lblTelefono.TabIndex = 20;
            this.lblTelefono.Text = "Teléfono:";
            // 
            // btnAñadir
            // 
            this.btnAñadir.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAñadir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(121)))), ((int)(((byte)(82)))));
            this.btnAñadir.FlatAppearance.BorderSize = 0;
            this.btnAñadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAñadir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAñadir.Location = new System.Drawing.Point(32, 341);
            this.btnAñadir.Margin = new System.Windows.Forms.Padding(4);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(208, 46);
            this.btnAñadir.TabIndex = 22;
            this.btnAñadir.Text = "Añadir";
            this.btnAñadir.UseVisualStyleBackColor = false;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // erpPresos
            // 
            this.erpPresos.ContainerControl = this;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSalir.Location = new System.Drawing.Point(32, 414);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(208, 46);
            this.btnSalir.TabIndex = 23;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(82)))), ((int)(((byte)(124)))));
            this.panel1.Controls.Add(this.pcboxFoto);
            this.panel1.Controls.Add(this.btn_añadir_foto);
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.btnAñadir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(732, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(13, 487);
            this.panel1.TabIndex = 24;
            // 
            // pcboxFoto
            // 
            this.pcboxFoto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pcboxFoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pcboxFoto.Image = global::PROYECTO.Properties.Resources.def;
            this.pcboxFoto.Location = new System.Drawing.Point(32, 26);
            this.pcboxFoto.Margin = new System.Windows.Forms.Padding(4);
            this.pcboxFoto.Name = "pcboxFoto";
            this.pcboxFoto.Size = new System.Drawing.Size(223, 214);
            this.pcboxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcboxFoto.TabIndex = 0;
            this.pcboxFoto.TabStop = false;
            // 
            // pic_abrir
            // 
            this.pic_abrir.Image = global::PROYECTO.Properties.Resources.arrow_88_32;
            this.pic_abrir.Location = new System.Drawing.Point(701, 197);
            this.pic_abrir.Margin = new System.Windows.Forms.Padding(4);
            this.pic_abrir.Name = "pic_abrir";
            this.pic_abrir.Size = new System.Drawing.Size(23, 65);
            this.pic_abrir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_abrir.TabIndex = 26;
            this.pic_abrir.TabStop = false;
            this.pic_abrir.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pic_cerrar
            // 
            this.pic_cerrar.Image = global::PROYECTO.Properties.Resources.arrow_25_24;
            this.pic_cerrar.Location = new System.Drawing.Point(435, 213);
            this.pic_cerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pic_cerrar.Name = "pic_cerrar";
            this.pic_cerrar.Size = new System.Drawing.Size(24, 44);
            this.pic_cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_cerrar.TabIndex = 25;
            this.pic_cerrar.TabStop = false;
            this.pic_cerrar.Visible = false;
            this.pic_cerrar.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FrmAñadir_recluso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(54)))), ((int)(((byte)(94)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(745, 487);
            this.Controls.Add(this.pic_abrir);
            this.Controls.Add(this.pic_cerrar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.cmbCelda);
            this.Controls.Add(this.lblCelda);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.txtCodigopostal);
            this.Controls.Add(this.lblCodigoPos);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.cmbDireccion);
            this.Controls.Add(this.cmbSexo);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.cmbCrimen);
            this.Controls.Add(this.lblCrimen);
            this.Controls.Add(this.txt_nifPreso);
            this.Controls.Add(this.lblNif);
            this.Controls.Add(this.txt_apellidos);
            this.Controls.Add(this.lblApellidos);
            this.Controls.Add(this.txt_pnombre);
            this.Controls.Add(this.lblNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAñadir_recluso";
            this.Text = "Añadir_recluso";
            this.Load += new System.EventHandler(this.Añadir_recluso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.erpPresos)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcboxFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_abrir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_cerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcboxFoto;
        private System.Windows.Forms.Button btn_añadir_foto;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txt_pnombre;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.TextBox txt_apellidos;
        private System.Windows.Forms.Label lblNif;
        private System.Windows.Forms.TextBox txt_nifPreso;
        private System.Windows.Forms.Label lblCrimen;
        private System.Windows.Forms.ComboBox cmbCrimen;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label cmbDireccion;
        private System.Windows.Forms.TextBox txtCodigopostal;
        private System.Windows.Forms.Label lblCodigoPos;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.ComboBox cmbCelda;
        private System.Windows.Forms.Label lblCelda;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.ErrorProvider erpPresos;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pic_cerrar;
        private System.Windows.Forms.PictureBox pic_abrir;
    }
}