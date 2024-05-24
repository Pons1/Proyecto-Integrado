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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFichaPreso));
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
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSalir.Location = new System.Drawing.Point(537, 394);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(208, 46);
            this.btnSalir.TabIndex = 47;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefono.Enabled = false;
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtTelefono.Location = new System.Drawing.Point(449, 103);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(134, 23);
            this.txtTelefono.TabIndex = 45;
            this.txtTelefono.TextChanged += new System.EventHandler(this.txtTelefono_TextChanged);
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTelefono.Location = new System.Drawing.Point(445, 79);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(87, 20);
            this.lblTelefono.TabIndex = 44;
            this.lblTelefono.Text = "Teléfono:";
            this.lblTelefono.Click += new System.EventHandler(this.lblTelefono_Click);
            // 
            // lblCelda
            // 
            this.lblCelda.AutoSize = true;
            this.lblCelda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelda.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCelda.Location = new System.Drawing.Point(578, 305);
            this.lblCelda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCelda.Name = "lblCelda";
            this.lblCelda.Size = new System.Drawing.Size(63, 20);
            this.lblCelda.TabIndex = 42;
            this.lblCelda.Text = "Celda:";
            this.lblCelda.Click += new System.EventHandler(this.lblCelda_Click);
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
            this.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCorreo.Enabled = false;
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtCorreo.Location = new System.Drawing.Point(261, 173);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(291, 23);
            this.txtCorreo.TabIndex = 41;
            this.txtCorreo.TextChanged += new System.EventHandler(this.txtCorreo_TextChanged);
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCorreo.Location = new System.Drawing.Point(258, 149);
            this.lblCorreo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(173, 20);
            this.lblCorreo.TabIndex = 40;
            this.lblCorreo.Text = "Correo Electronico:";
            this.lblCorreo.Click += new System.EventHandler(this.lblCorreo_Click);
            // 
            // txtCodigopostal
            // 
            this.txtCodigopostal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
            this.txtCodigopostal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodigopostal.Enabled = false;
            this.txtCodigopostal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigopostal.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtCodigopostal.Location = new System.Drawing.Point(575, 173);
            this.txtCodigopostal.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigopostal.Name = "txtCodigopostal";
            this.txtCodigopostal.Size = new System.Drawing.Size(170, 23);
            this.txtCodigopostal.TabIndex = 39;
            this.txtCodigopostal.TextChanged += new System.EventHandler(this.txtCodigopostal_TextChanged);
            // 
            // lblCodigoPos
            // 
            this.lblCodigoPos.AutoSize = true;
            this.lblCodigoPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoPos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCodigoPos.Location = new System.Drawing.Point(571, 149);
            this.lblCodigoPos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigoPos.Name = "lblCodigoPos";
            this.lblCodigoPos.Size = new System.Drawing.Size(132, 20);
            this.lblCodigoPos.TabIndex = 38;
            this.lblCodigoPos.Text = "Codigo Postal:";
            this.lblCodigoPos.Click += new System.EventHandler(this.lblCodigoPos_Click);
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDireccion.Enabled = false;
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtDireccion.Location = new System.Drawing.Point(262, 254);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(483, 23);
            this.txtDireccion.TabIndex = 37;
            this.txtDireccion.TextChanged += new System.EventHandler(this.txtDireccion_TextChanged);
            // 
            // cmbDireccion
            // 
            this.cmbDireccion.AutoSize = true;
            this.cmbDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDireccion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cmbDireccion.Location = new System.Drawing.Point(258, 226);
            this.cmbDireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cmbDireccion.Name = "cmbDireccion";
            this.cmbDireccion.Size = new System.Drawing.Size(96, 20);
            this.cmbDireccion.TabIndex = 36;
            this.cmbDireccion.Text = "Direccion:";
            this.cmbDireccion.Click += new System.EventHandler(this.cmbDireccion_Click);
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSexo.Location = new System.Drawing.Point(595, 79);
            this.lblSexo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(56, 20);
            this.lblSexo.TabIndex = 34;
            this.lblSexo.Text = "Sexo:";
            this.lblSexo.Click += new System.EventHandler(this.lblSexo_Click);
            // 
            // lblCrimen
            // 
            this.lblCrimen.AutoSize = true;
            this.lblCrimen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrimen.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCrimen.Location = new System.Drawing.Point(258, 305);
            this.lblCrimen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCrimen.Name = "lblCrimen";
            this.lblCrimen.Size = new System.Drawing.Size(75, 20);
            this.lblCrimen.TabIndex = 32;
            this.lblCrimen.Text = "Crimen:";
            this.lblCrimen.Click += new System.EventHandler(this.lblCrimen_Click);
            // 
            // txt_nifPreso
            // 
            this.txt_nifPreso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
            this.txt_nifPreso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_nifPreso.Enabled = false;
            this.txt_nifPreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nifPreso.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_nifPreso.Location = new System.Drawing.Point(261, 103);
            this.txt_nifPreso.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nifPreso.MaxLength = 9;
            this.txt_nifPreso.Name = "txt_nifPreso";
            this.txt_nifPreso.Size = new System.Drawing.Size(170, 23);
            this.txt_nifPreso.TabIndex = 31;
            this.txt_nifPreso.TextChanged += new System.EventHandler(this.txt_nifPreso_TextChanged);
            // 
            // lblNif
            // 
            this.lblNif.AutoSize = true;
            this.lblNif.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNif.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNif.Location = new System.Drawing.Point(257, 79);
            this.lblNif.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNif.Name = "lblNif";
            this.lblNif.Size = new System.Drawing.Size(47, 20);
            this.lblNif.TabIndex = 30;
            this.lblNif.Text = "DNI:";
            this.lblNif.Click += new System.EventHandler(this.lblNif_Click);
            // 
            // txt_apellidos
            // 
            this.txt_apellidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
            this.txt_apellidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_apellidos.Enabled = false;
            this.txt_apellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_apellidos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_apellidos.Location = new System.Drawing.Point(449, 37);
            this.txt_apellidos.Margin = new System.Windows.Forms.Padding(4);
            this.txt_apellidos.Name = "txt_apellidos";
            this.txt_apellidos.Size = new System.Drawing.Size(296, 23);
            this.txt_apellidos.TabIndex = 29;
            this.txt_apellidos.TextChanged += new System.EventHandler(this.txt_apellidos_TextChanged);
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblApellidos.Location = new System.Drawing.Point(445, 13);
            this.lblApellidos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(92, 20);
            this.lblApellidos.TabIndex = 28;
            this.lblApellidos.Text = "Apellidos:";
            this.lblApellidos.Click += new System.EventHandler(this.lblApellidos_Click);
            // 
            // txt_pnombre
            // 
            this.txt_pnombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
            this.txt_pnombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_pnombre.Enabled = false;
            this.txt_pnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pnombre.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_pnombre.Location = new System.Drawing.Point(261, 37);
            this.txt_pnombre.Margin = new System.Windows.Forms.Padding(4);
            this.txt_pnombre.Name = "txt_pnombre";
            this.txt_pnombre.Size = new System.Drawing.Size(159, 23);
            this.txt_pnombre.TabIndex = 27;
            this.txt_pnombre.TextChanged += new System.EventHandler(this.txt_pnombre_TextChanged);
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNom.Location = new System.Drawing.Point(257, 13);
            this.lblNom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(80, 20);
            this.lblNom.TabIndex = 26;
            this.lblNom.Text = "Nombre:";
            this.lblNom.Click += new System.EventHandler(this.lblNom_Click);
            // 
            // txtcrimen
            // 
            this.txtcrimen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
            this.txtcrimen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcrimen.Enabled = false;
            this.txtcrimen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcrimen.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtcrimen.Location = new System.Drawing.Point(261, 331);
            this.txtcrimen.Margin = new System.Windows.Forms.Padding(4);
            this.txtcrimen.Name = "txtcrimen";
            this.txtcrimen.ReadOnly = true;
            this.txtcrimen.Size = new System.Drawing.Size(313, 23);
            this.txtcrimen.TabIndex = 48;
            this.txtcrimen.TextChanged += new System.EventHandler(this.txtcrimen_TextChanged);
            // 
            // txtCelda
            // 
            this.txtCelda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
            this.txtCelda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCelda.Enabled = false;
            this.txtCelda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelda.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtCelda.Location = new System.Drawing.Point(582, 331);
            this.txtCelda.Margin = new System.Windows.Forms.Padding(4);
            this.txtCelda.Name = "txtCelda";
            this.txtCelda.ReadOnly = true;
            this.txtCelda.Size = new System.Drawing.Size(163, 23);
            this.txtCelda.TabIndex = 49;
            this.txtCelda.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtSexo
            // 
            this.txtSexo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
            this.txtSexo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSexo.Enabled = false;
            this.txtSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSexo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtSexo.Location = new System.Drawing.Point(599, 103);
            this.txtSexo.Margin = new System.Windows.Forms.Padding(4);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.ReadOnly = true;
            this.txtSexo.Size = new System.Drawing.Size(85, 23);
            this.txtSexo.TabIndex = 50;
            this.txtSexo.TextChanged += new System.EventHandler(this.txtSexo_TextChanged);
            // 
            // pcboxFoto
            // 
            this.pcboxFoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pcboxFoto.Image = global::PROYECTO.Properties.Resources.def;
            this.pcboxFoto.Location = new System.Drawing.Point(13, 13);
            this.pcboxFoto.Margin = new System.Windows.Forms.Padding(4);
            this.pcboxFoto.Name = "pcboxFoto";
            this.pcboxFoto.Size = new System.Drawing.Size(213, 233);
            this.pcboxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcboxFoto.TabIndex = 24;
            this.pcboxFoto.TabStop = false;
            this.pcboxFoto.Click += new System.EventHandler(this.pcboxFoto_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.IndianRed;
            this.btnBorrar.FlatAppearance.BorderSize = 0;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBorrar.Location = new System.Drawing.Point(281, 394);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(208, 46);
            this.btnBorrar.TabIndex = 51;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEditar.Location = new System.Drawing.Point(18, 394);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(208, 46);
            this.btnEditar.TabIndex = 52;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(121)))), ((int)(((byte)(82)))));
            this.btnInsertar.FlatAppearance.BorderSize = 0;
            this.btnInsertar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnInsertar.Location = new System.Drawing.Point(18, 331);
            this.btnInsertar.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(208, 46);
            this.btnInsertar.TabIndex = 54;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = false;
            this.btnInsertar.Visible = false;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // cmbCelda
            // 
            this.cmbCelda.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbCelda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
            this.cmbCelda.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCelda.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cmbCelda.FormattingEnabled = true;
            this.cmbCelda.Location = new System.Drawing.Point(581, 331);
            this.cmbCelda.Name = "cmbCelda";
            this.cmbCelda.Size = new System.Drawing.Size(163, 37);
            this.cmbCelda.TabIndex = 57;
            this.cmbCelda.Visible = false;
            // 
            // cmbSexo
            // 
            this.cmbSexo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
            this.cmbSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSexo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Items.AddRange(new object[] {
            "Hombre"});
            this.cmbSexo.Location = new System.Drawing.Point(599, 102);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(132, 37);
            this.cmbSexo.TabIndex = 56;
            this.cmbSexo.Visible = false;
            this.cmbSexo.SelectedIndexChanged += new System.EventHandler(this.cmbSexo_SelectedIndexChanged);
            // 
            // cmbCrimen
            // 
            this.cmbCrimen.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbCrimen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
            this.cmbCrimen.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCrimen.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cmbCrimen.FormattingEnabled = true;
            this.cmbCrimen.Location = new System.Drawing.Point(261, 331);
            this.cmbCrimen.Name = "cmbCrimen";
            this.cmbCrimen.Size = new System.Drawing.Size(312, 37);
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
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(54)))), ((int)(((byte)(94)))));
            this.ClientSize = new System.Drawing.Size(801, 459);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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