namespace PROYECTO
{
    partial class FrmFichaPreso
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblCelda = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtCodigopostal = new System.Windows.Forms.TextBox();
            this.lblCodigoPos = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.cmbDireccion = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblCrimen = new System.Windows.Forms.Label();
            this.txt_nifPreso = new System.Windows.Forms.TextBox();
            this.lblNif = new System.Windows.Forms.Label();
            this.txt_apellidos = new System.Windows.Forms.TextBox();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.txt_pnombre = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.txtcrimen = new System.Windows.Forms.TextBox();
            this.txtCelda = new System.Windows.Forms.TextBox();
            this.txtSexo = new System.Windows.Forms.TextBox();
            this.pcboxFoto = new System.Windows.Forms.PictureBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.cmbCelda = new System.Windows.Forms.ComboBox();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.cmbCrimen = new System.Windows.Forms.ComboBox();
            this.erpFichasPresos = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pcboxFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpFichasPresos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(690, 387);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(146, 57);
            this.btnSalir.TabIndex = 47;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtTelefono.Enabled = false;
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(176, 387);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(264, 34);
            this.txtTelefono.TabIndex = 45;
            this.txtTelefono.TextChanged += new System.EventHandler(this.txtTelefono_TextChanged);
            // 
            // lblTelefono
            // 
            this.lblTelefono.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(30, 392);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(125, 29);
            this.lblTelefono.TabIndex = 44;
            this.lblTelefono.Text = "Teléfono:";
            this.lblTelefono.Click += new System.EventHandler(this.lblTelefono_Click);
            // 
            // lblCelda
            // 
            this.lblCelda.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCelda.AutoSize = true;
            this.lblCelda.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelda.Location = new System.Drawing.Point(30, 217);
            this.lblCelda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCelda.Name = "lblCelda";
            this.lblCelda.Size = new System.Drawing.Size(89, 29);
            this.lblCelda.TabIndex = 42;
            this.lblCelda.Text = "Celda:";
            this.lblCelda.Click += new System.EventHandler(this.lblCelda_Click);
            // 
            // txtCorreo
            // 
            this.txtCorreo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCorreo.Enabled = false;
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(280, 340);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(264, 34);
            this.txtCorreo.TabIndex = 41;
            this.txtCorreo.TextChanged += new System.EventHandler(this.txtCorreo_TextChanged);
            // 
            // lblCorreo
            // 
            this.lblCorreo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.Location = new System.Drawing.Point(29, 345);
            this.lblCorreo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(240, 29);
            this.lblCorreo.TabIndex = 40;
            this.lblCorreo.Text = "Correo Electronico:";
            this.lblCorreo.Click += new System.EventHandler(this.lblCorreo_Click);
            // 
            // txtCodigopostal
            // 
            this.txtCodigopostal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCodigopostal.Enabled = false;
            this.txtCodigopostal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigopostal.Location = new System.Drawing.Point(223, 298);
            this.txtCodigopostal.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigopostal.Name = "txtCodigopostal";
            this.txtCodigopostal.Size = new System.Drawing.Size(264, 34);
            this.txtCodigopostal.TabIndex = 39;
            this.txtCodigopostal.TextChanged += new System.EventHandler(this.txtCodigopostal_TextChanged);
            // 
            // lblCodigoPos
            // 
            this.lblCodigoPos.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCodigoPos.AutoSize = true;
            this.lblCodigoPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoPos.Location = new System.Drawing.Point(30, 303);
            this.lblCodigoPos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigoPos.Name = "lblCodigoPos";
            this.lblCodigoPos.Size = new System.Drawing.Size(185, 29);
            this.lblCodigoPos.TabIndex = 38;
            this.lblCodigoPos.Text = "Codigo Postal:";
            this.lblCodigoPos.Click += new System.EventHandler(this.lblCodigoPos_Click);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtDireccion.Enabled = false;
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(170, 256);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(264, 34);
            this.txtDireccion.TabIndex = 37;
            this.txtDireccion.TextChanged += new System.EventHandler(this.txtDireccion_TextChanged);
            // 
            // cmbDireccion
            // 
            this.cmbDireccion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbDireccion.AutoSize = true;
            this.cmbDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDireccion.Location = new System.Drawing.Point(30, 262);
            this.cmbDireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cmbDireccion.Name = "cmbDireccion";
            this.cmbDireccion.Size = new System.Drawing.Size(131, 29);
            this.cmbDireccion.TabIndex = 36;
            this.cmbDireccion.Text = "Direccion:";
            this.cmbDireccion.Click += new System.EventHandler(this.cmbDireccion_Click);
            // 
            // lblSexo
            // 
            this.lblSexo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.Location = new System.Drawing.Point(346, 171);
            this.lblSexo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(79, 29);
            this.lblSexo.TabIndex = 34;
            this.lblSexo.Text = "Sexo:";
            this.lblSexo.Click += new System.EventHandler(this.lblSexo_Click);
            // 
            // lblCrimen
            // 
            this.lblCrimen.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCrimen.AutoSize = true;
            this.lblCrimen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrimen.Location = new System.Drawing.Point(30, 171);
            this.lblCrimen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCrimen.Name = "lblCrimen";
            this.lblCrimen.Size = new System.Drawing.Size(104, 29);
            this.lblCrimen.TabIndex = 32;
            this.lblCrimen.Text = "Crimen:";
            this.lblCrimen.Click += new System.EventHandler(this.lblCrimen_Click);
            // 
            // txt_nifPreso
            // 
            this.txt_nifPreso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_nifPreso.Enabled = false;
            this.txt_nifPreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nifPreso.Location = new System.Drawing.Point(400, 66);
            this.txt_nifPreso.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nifPreso.MaxLength = 9;
            this.txt_nifPreso.Name = "txt_nifPreso";
            this.txt_nifPreso.Size = new System.Drawing.Size(188, 34);
            this.txt_nifPreso.TabIndex = 31;
            this.txt_nifPreso.TextChanged += new System.EventHandler(this.txt_nifPreso_TextChanged);
            // 
            // lblNif
            // 
            this.lblNif.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNif.AutoSize = true;
            this.lblNif.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNif.Location = new System.Drawing.Point(313, 71);
            this.lblNif.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNif.Name = "lblNif";
            this.lblNif.Size = new System.Drawing.Size(64, 29);
            this.lblNif.TabIndex = 30;
            this.lblNif.Text = "DNI:";
            this.lblNif.Click += new System.EventHandler(this.lblNif_Click);
            // 
            // txt_apellidos
            // 
            this.txt_apellidos.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_apellidos.Enabled = false;
            this.txt_apellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_apellidos.Location = new System.Drawing.Point(176, 110);
            this.txt_apellidos.Margin = new System.Windows.Forms.Padding(4);
            this.txt_apellidos.Name = "txt_apellidos";
            this.txt_apellidos.Size = new System.Drawing.Size(264, 34);
            this.txt_apellidos.TabIndex = 29;
            this.txt_apellidos.TextChanged += new System.EventHandler(this.txt_apellidos_TextChanged);
            // 
            // lblApellidos
            // 
            this.lblApellidos.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidos.Location = new System.Drawing.Point(34, 115);
            this.lblApellidos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(130, 29);
            this.lblApellidos.TabIndex = 28;
            this.lblApellidos.Text = "Apellidos:";
            this.lblApellidos.Click += new System.EventHandler(this.lblApellidos_Click);
            // 
            // txt_pnombre
            // 
            this.txt_pnombre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_pnombre.Enabled = false;
            this.txt_pnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pnombre.Location = new System.Drawing.Point(158, 68);
            this.txt_pnombre.Margin = new System.Windows.Forms.Padding(4);
            this.txt_pnombre.Name = "txt_pnombre";
            this.txt_pnombre.Size = new System.Drawing.Size(132, 34);
            this.txt_pnombre.TabIndex = 27;
            this.txt_pnombre.TextChanged += new System.EventHandler(this.txt_pnombre_TextChanged);
            // 
            // lblNom
            // 
            this.lblNom.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(36, 71);
            this.lblNom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(114, 29);
            this.lblNom.TabIndex = 26;
            this.lblNom.Text = "Nombre:";
            this.lblNom.Click += new System.EventHandler(this.lblNom_Click);
            // 
            // txtcrimen
            // 
            this.txtcrimen.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtcrimen.Enabled = false;
            this.txtcrimen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcrimen.Location = new System.Drawing.Point(158, 174);
            this.txtcrimen.Margin = new System.Windows.Forms.Padding(4);
            this.txtcrimen.Name = "txtcrimen";
            this.txtcrimen.ReadOnly = true;
            this.txtcrimen.Size = new System.Drawing.Size(163, 34);
            this.txtcrimen.TabIndex = 48;
            this.txtcrimen.TextChanged += new System.EventHandler(this.txtcrimen_TextChanged);
            // 
            // txtCelda
            // 
            this.txtCelda.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCelda.Enabled = false;
            this.txtCelda.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelda.Location = new System.Drawing.Point(158, 212);
            this.txtCelda.Margin = new System.Windows.Forms.Padding(4);
            this.txtCelda.Name = "txtCelda";
            this.txtCelda.ReadOnly = true;
            this.txtCelda.Size = new System.Drawing.Size(163, 34);
            this.txtCelda.TabIndex = 49;
            this.txtCelda.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtSexo
            // 
            this.txtSexo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSexo.Enabled = false;
            this.txtSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSexo.Location = new System.Drawing.Point(432, 174);
            this.txtSexo.Margin = new System.Windows.Forms.Padding(4);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.ReadOnly = true;
            this.txtSexo.Size = new System.Drawing.Size(132, 34);
            this.txtSexo.TabIndex = 50;
            this.txtSexo.TextChanged += new System.EventHandler(this.txtSexo_TextChanged);
            // 
            // pcboxFoto
            // 
            this.pcboxFoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pcboxFoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pcboxFoto.Image = global::PROYECTO.Properties.Resources.def;
            this.pcboxFoto.Location = new System.Drawing.Point(596, 32);
            this.pcboxFoto.Margin = new System.Windows.Forms.Padding(4);
            this.pcboxFoto.Name = "pcboxFoto";
            this.pcboxFoto.Size = new System.Drawing.Size(213, 214);
            this.pcboxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcboxFoto.TabIndex = 24;
            this.pcboxFoto.TabStop = false;
            this.pcboxFoto.Click += new System.EventHandler(this.pcboxFoto_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBorrar.Font = new System.Drawing.Font("Century Gothic", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Location = new System.Drawing.Point(690, 317);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(146, 57);
            this.btnBorrar.TabIndex = 51;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(690, 254);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(146, 57);
            this.btnEditar.TabIndex = 52;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInsertar.Font = new System.Drawing.Font("Century Gothic", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertar.Location = new System.Drawing.Point(520, 254);
            this.btnInsertar.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(146, 57);
            this.btnInsertar.TabIndex = 54;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Visible = false;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // cmbCelda
            // 
            this.cmbCelda.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbCelda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCelda.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCelda.FormattingEnabled = true;
            this.cmbCelda.Location = new System.Drawing.Point(158, 209);
            this.cmbCelda.Name = "cmbCelda";
            this.cmbCelda.Size = new System.Drawing.Size(132, 37);
            this.cmbCelda.TabIndex = 57;
            this.cmbCelda.Visible = false;
            // 
            // cmbSexo
            // 
            this.cmbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Items.AddRange(new object[] {
            "Hombre",
            "Mujer",
            "Otro"});
            this.cmbSexo.Location = new System.Drawing.Point(432, 163);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(132, 37);
            this.cmbSexo.TabIndex = 56;
            this.cmbSexo.Visible = false;
            this.cmbSexo.SelectedIndexChanged += new System.EventHandler(this.cmbSexo_SelectedIndexChanged);
            // 
            // cmbCrimen
            // 
            this.cmbCrimen.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbCrimen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCrimen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCrimen.FormattingEnabled = true;
            this.cmbCrimen.Location = new System.Drawing.Point(158, 163);
            this.cmbCrimen.Name = "cmbCrimen";
            this.cmbCrimen.Size = new System.Drawing.Size(132, 37);
            this.cmbCrimen.TabIndex = 55;
            this.cmbCrimen.Visible = false;
            this.cmbCrimen.SelectedIndexChanged += new System.EventHandler(this.cmbCrimen_SelectedIndexChanged);
            // 
            // erpFichasPresos
            // 
            this.erpFichasPresos.ContainerControl = this;
            // 
            // FrmFichaPreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 500);
            this.Controls.Add(this.cmbCelda);
            this.Controls.Add(this.cmbSexo);
            this.Controls.Add(this.cmbCrimen);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.txtSexo);
            this.Controls.Add(this.txtCelda);
            this.Controls.Add(this.txtcrimen);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblCelda);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.txtCodigopostal);
            this.Controls.Add(this.lblCodigoPos);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.cmbDireccion);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblCrimen);
            this.Controls.Add(this.txt_nifPreso);
            this.Controls.Add(this.lblNif);
            this.Controls.Add(this.txt_apellidos);
            this.Controls.Add(this.lblApellidos);
            this.Controls.Add(this.txt_pnombre);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.pcboxFoto);
            this.Name = "FrmFichaPreso";
            this.Text = "Ficha Preso";
            this.Load += new System.EventHandler(this.FrmFichaPreso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcboxFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpFichasPresos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblCelda;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtCodigopostal;
        private System.Windows.Forms.Label lblCodigoPos;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label cmbDireccion;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblCrimen;
        private System.Windows.Forms.TextBox txt_nifPreso;
        private System.Windows.Forms.Label lblNif;
        private System.Windows.Forms.TextBox txt_apellidos;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.TextBox txt_pnombre;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.PictureBox pcboxFoto;
        private System.Windows.Forms.TextBox txtcrimen;
        private System.Windows.Forms.TextBox txtCelda;
        private System.Windows.Forms.TextBox txtSexo;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.ComboBox cmbCelda;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.ComboBox cmbCrimen;
        private System.Windows.Forms.ErrorProvider erpFichasPresos;
    }
}