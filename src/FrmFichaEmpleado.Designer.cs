namespace PROYECTO
{
    partial class FrmFichaEmpleado
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
            this.cmbTurno = new System.Windows.Forms.ComboBox();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.cmbPuesto = new System.Windows.Forms.ComboBox();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.txtSexo = new System.Windows.Forms.TextBox();
            this.txtTurno = new System.Windows.Forms.TextBox();
            this.txtpuesto = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblTurno = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtCodigopostal = new System.Windows.Forms.TextBox();
            this.lblCodigoPos = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.cmbDireccion = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblPuesto = new System.Windows.Forms.Label();
            this.txt_nif = new System.Windows.Forms.TextBox();
            this.lblNif = new System.Windows.Forms.Label();
            this.txt_apellidos = new System.Windows.Forms.TextBox();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.txt_pnombre = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.pcboxFoto = new System.Windows.Forms.PictureBox();
            this.erpEmpl = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pcboxFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpEmpl)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbTurno
            // 
            this.cmbTurno.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTurno.FormattingEnabled = true;
            this.cmbTurno.Location = new System.Drawing.Point(126, 196);
            this.cmbTurno.Name = "cmbTurno";
            this.cmbTurno.Size = new System.Drawing.Size(132, 37);
            this.cmbTurno.TabIndex = 85;
            this.cmbTurno.Visible = false;
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
            this.cmbSexo.Location = new System.Drawing.Point(400, 150);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(132, 37);
            this.cmbSexo.TabIndex = 84;
            this.cmbSexo.Visible = false;
            this.cmbSexo.SelectedIndexChanged += new System.EventHandler(this.cmbSexo_SelectedIndexChanged);
            // 
            // cmbPuesto
            // 
            this.cmbPuesto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbPuesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPuesto.FormattingEnabled = true;
            this.cmbPuesto.Items.AddRange(new object[] {
            "VIGILANCIA",
            "LIMPIEZA",
            "ADMINISTRACION",
            "COCINA",
            "ENFERMERIA"});
            this.cmbPuesto.Location = new System.Drawing.Point(126, 154);
            this.cmbPuesto.Name = "cmbPuesto";
            this.cmbPuesto.Size = new System.Drawing.Size(132, 37);
            this.cmbPuesto.TabIndex = 83;
            this.cmbPuesto.Visible = false;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInsertar.Font = new System.Drawing.Font("Century Gothic", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertar.Location = new System.Drawing.Point(488, 241);
            this.btnInsertar.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(146, 57);
            this.btnInsertar.TabIndex = 82;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Visible = false;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(658, 241);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(146, 57);
            this.btnEditar.TabIndex = 81;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBorrar.Font = new System.Drawing.Font("Century Gothic", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Location = new System.Drawing.Point(658, 304);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(146, 57);
            this.btnBorrar.TabIndex = 80;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // txtSexo
            // 
            this.txtSexo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSexo.Enabled = false;
            this.txtSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSexo.Location = new System.Drawing.Point(400, 161);
            this.txtSexo.Margin = new System.Windows.Forms.Padding(4);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.ReadOnly = true;
            this.txtSexo.Size = new System.Drawing.Size(132, 34);
            this.txtSexo.TabIndex = 79;
            // 
            // txtTurno
            // 
            this.txtTurno.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtTurno.Enabled = false;
            this.txtTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTurno.Location = new System.Drawing.Point(126, 199);
            this.txtTurno.Margin = new System.Windows.Forms.Padding(4);
            this.txtTurno.Name = "txtTurno";
            this.txtTurno.ReadOnly = true;
            this.txtTurno.Size = new System.Drawing.Size(163, 34);
            this.txtTurno.TabIndex = 78;
            // 
            // txtpuesto
            // 
            this.txtpuesto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtpuesto.Enabled = false;
            this.txtpuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpuesto.Location = new System.Drawing.Point(126, 161);
            this.txtpuesto.Margin = new System.Windows.Forms.Padding(4);
            this.txtpuesto.Name = "txtpuesto";
            this.txtpuesto.ReadOnly = true;
            this.txtpuesto.Size = new System.Drawing.Size(163, 34);
            this.txtpuesto.TabIndex = 77;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(658, 374);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(146, 57);
            this.btnSalir.TabIndex = 76;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtTelefono.Enabled = false;
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(144, 374);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(264, 34);
            this.txtTelefono.TabIndex = 75;
            // 
            // lblTelefono
            // 
            this.lblTelefono.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(-2, 379);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(125, 29);
            this.lblTelefono.TabIndex = 74;
            this.lblTelefono.Text = "Teléfono:";
            // 
            // lblTurno
            // 
            this.lblTurno.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTurno.AutoSize = true;
            this.lblTurno.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurno.Location = new System.Drawing.Point(-2, 204);
            this.lblTurno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(89, 29);
            this.lblTurno.TabIndex = 73;
            this.lblTurno.Text = "Turno:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCorreo.Enabled = false;
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(248, 327);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(264, 34);
            this.txtCorreo.TabIndex = 72;
            // 
            // lblCorreo
            // 
            this.lblCorreo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.Location = new System.Drawing.Point(-3, 332);
            this.lblCorreo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(240, 29);
            this.lblCorreo.TabIndex = 71;
            this.lblCorreo.Text = "Correo Electronico:";
            // 
            // txtCodigopostal
            // 
            this.txtCodigopostal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCodigopostal.Enabled = false;
            this.txtCodigopostal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigopostal.Location = new System.Drawing.Point(191, 285);
            this.txtCodigopostal.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigopostal.Name = "txtCodigopostal";
            this.txtCodigopostal.Size = new System.Drawing.Size(264, 34);
            this.txtCodigopostal.TabIndex = 70;
            // 
            // lblCodigoPos
            // 
            this.lblCodigoPos.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCodigoPos.AutoSize = true;
            this.lblCodigoPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoPos.Location = new System.Drawing.Point(-2, 290);
            this.lblCodigoPos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigoPos.Name = "lblCodigoPos";
            this.lblCodigoPos.Size = new System.Drawing.Size(185, 29);
            this.lblCodigoPos.TabIndex = 69;
            this.lblCodigoPos.Text = "Codigo Postal:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtDireccion.Enabled = false;
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(138, 243);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(264, 34);
            this.txtDireccion.TabIndex = 68;
            // 
            // cmbDireccion
            // 
            this.cmbDireccion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbDireccion.AutoSize = true;
            this.cmbDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDireccion.Location = new System.Drawing.Point(-2, 249);
            this.cmbDireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cmbDireccion.Name = "cmbDireccion";
            this.cmbDireccion.Size = new System.Drawing.Size(131, 29);
            this.cmbDireccion.TabIndex = 67;
            this.cmbDireccion.Text = "Direccion:";
            // 
            // lblSexo
            // 
            this.lblSexo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.Location = new System.Drawing.Point(314, 158);
            this.lblSexo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(79, 29);
            this.lblSexo.TabIndex = 66;
            this.lblSexo.Text = "Sexo:";
            // 
            // lblPuesto
            // 
            this.lblPuesto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPuesto.AutoSize = true;
            this.lblPuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuesto.Location = new System.Drawing.Point(-2, 158);
            this.lblPuesto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPuesto.Name = "lblPuesto";
            this.lblPuesto.Size = new System.Drawing.Size(101, 29);
            this.lblPuesto.TabIndex = 65;
            this.lblPuesto.Text = "Puesto:";
            // 
            // txt_nif
            // 
            this.txt_nif.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_nif.Enabled = false;
            this.txt_nif.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nif.Location = new System.Drawing.Point(368, 53);
            this.txt_nif.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nif.MaxLength = 9;
            this.txt_nif.Name = "txt_nif";
            this.txt_nif.Size = new System.Drawing.Size(188, 34);
            this.txt_nif.TabIndex = 64;
            // 
            // lblNif
            // 
            this.lblNif.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNif.AutoSize = true;
            this.lblNif.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNif.Location = new System.Drawing.Point(281, 58);
            this.lblNif.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNif.Name = "lblNif";
            this.lblNif.Size = new System.Drawing.Size(64, 29);
            this.lblNif.TabIndex = 63;
            this.lblNif.Text = "DNI:";
            // 
            // txt_apellidos
            // 
            this.txt_apellidos.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_apellidos.Enabled = false;
            this.txt_apellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_apellidos.Location = new System.Drawing.Point(144, 97);
            this.txt_apellidos.Margin = new System.Windows.Forms.Padding(4);
            this.txt_apellidos.Name = "txt_apellidos";
            this.txt_apellidos.Size = new System.Drawing.Size(264, 34);
            this.txt_apellidos.TabIndex = 62;
            // 
            // lblApellidos
            // 
            this.lblApellidos.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidos.Location = new System.Drawing.Point(2, 102);
            this.lblApellidos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(130, 29);
            this.lblApellidos.TabIndex = 61;
            this.lblApellidos.Text = "Apellidos:";
            // 
            // txt_pnombre
            // 
            this.txt_pnombre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_pnombre.Enabled = false;
            this.txt_pnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pnombre.Location = new System.Drawing.Point(126, 55);
            this.txt_pnombre.Margin = new System.Windows.Forms.Padding(4);
            this.txt_pnombre.Name = "txt_pnombre";
            this.txt_pnombre.Size = new System.Drawing.Size(132, 34);
            this.txt_pnombre.TabIndex = 60;
            // 
            // lblNom
            // 
            this.lblNom.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(4, 58);
            this.lblNom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(114, 29);
            this.lblNom.TabIndex = 59;
            this.lblNom.Text = "Nombre:";
            // 
            // pcboxFoto
            // 
            this.pcboxFoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pcboxFoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pcboxFoto.Image = global::PROYECTO.Properties.Resources.def;
            this.pcboxFoto.Location = new System.Drawing.Point(564, 19);
            this.pcboxFoto.Margin = new System.Windows.Forms.Padding(4);
            this.pcboxFoto.Name = "pcboxFoto";
            this.pcboxFoto.Size = new System.Drawing.Size(213, 214);
            this.pcboxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcboxFoto.TabIndex = 58;
            this.pcboxFoto.TabStop = false;
            // 
            // erpEmpl
            // 
            this.erpEmpl.ContainerControl = this;
            // 
            // FrmFichaEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbTurno);
            this.Controls.Add(this.cmbSexo);
            this.Controls.Add(this.cmbPuesto);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.txtSexo);
            this.Controls.Add(this.txtTurno);
            this.Controls.Add(this.txtpuesto);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblTurno);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.txtCodigopostal);
            this.Controls.Add(this.lblCodigoPos);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.cmbDireccion);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblPuesto);
            this.Controls.Add(this.txt_nif);
            this.Controls.Add(this.lblNif);
            this.Controls.Add(this.txt_apellidos);
            this.Controls.Add(this.lblApellidos);
            this.Controls.Add(this.txt_pnombre);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.pcboxFoto);
            this.Name = "FrmFichaEmpleado";
            this.Text = "FichaEmpleado";
            this.Load += new System.EventHandler(this.FrmFichaEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcboxFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpEmpl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTurno;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.ComboBox cmbPuesto;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.TextBox txtSexo;
        private System.Windows.Forms.TextBox txtTurno;
        private System.Windows.Forms.TextBox txtpuesto;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtCodigopostal;
        private System.Windows.Forms.Label lblCodigoPos;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label cmbDireccion;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblPuesto;
        private System.Windows.Forms.TextBox txt_nif;
        private System.Windows.Forms.Label lblNif;
        private System.Windows.Forms.TextBox txt_apellidos;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.TextBox txt_pnombre;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.PictureBox pcboxFoto;
        private System.Windows.Forms.ErrorProvider erpEmpl;
    }
}