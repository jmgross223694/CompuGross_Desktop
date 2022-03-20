namespace CompuGross
{
    partial class AgregarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarCliente));
            this.txtDni = new System.Windows.Forms.TextBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblNombres = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtTelefono1 = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ddlLocalidad = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTelefono2 = new System.Windows.Forms.TextBox();
            this.txtTelefono3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTel1 = new System.Windows.Forms.Label();
            this.lblTel2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.compuGrossDataSet1 = new CompuGross.CompuGrossDataSet();
            this.lblMailValido = new System.Windows.Forms.Label();
            this.lblMailInvalido = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.compuGrossDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDni
            // 
            this.txtDni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.txtDni.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDni.ForeColor = System.Drawing.Color.White;
            this.txtDni.Location = new System.Drawing.Point(132, 77);
            this.txtDni.Margin = new System.Windows.Forms.Padding(6);
            this.txtDni.MaxLength = 11;
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(466, 24);
            this.txtDni.TabIndex = 0;
            this.txtDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDni_KeyPress);
            // 
            // lblDni
            // 
            this.lblDni.BackColor = System.Drawing.Color.Transparent;
            this.lblDni.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.ForeColor = System.Drawing.Color.White;
            this.lblDni.Location = new System.Drawing.Point(16, 77);
            this.lblDni.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(109, 26);
            this.lblDni.TabIndex = 6;
            this.lblDni.Text = "CUIT / DNI";
            this.lblDni.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNombres
            // 
            this.lblNombres.BackColor = System.Drawing.Color.Transparent;
            this.lblNombres.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombres.ForeColor = System.Drawing.Color.White;
            this.lblNombres.Location = new System.Drawing.Point(16, 135);
            this.lblNombres.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(109, 42);
            this.lblNombres.TabIndex = 8;
            this.lblNombres.Text = "Apellido y Nombre";
            this.lblNombres.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNombres
            // 
            this.txtNombres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.txtNombres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombres.ForeColor = System.Drawing.Color.White;
            this.txtNombres.Location = new System.Drawing.Point(132, 142);
            this.txtNombres.Margin = new System.Windows.Forms.Padding(6);
            this.txtNombres.MaxLength = 200;
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(466, 24);
            this.txtNombres.TabIndex = 1;
            this.txtNombres.TextChanged += new System.EventHandler(this.txtNombres_TextChanged);
            this.txtNombres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombres_KeyPress);
            // 
            // lblDireccion
            // 
            this.lblDireccion.BackColor = System.Drawing.Color.Transparent;
            this.lblDireccion.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.ForeColor = System.Drawing.Color.White;
            this.lblDireccion.Location = new System.Drawing.Point(16, 209);
            this.lblDireccion.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(109, 27);
            this.lblDireccion.TabIndex = 10;
            this.lblDireccion.Text = "Dirección";
            this.lblDireccion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.ForeColor = System.Drawing.Color.White;
            this.txtDireccion.Location = new System.Drawing.Point(132, 209);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(6);
            this.txtDireccion.MaxLength = 100;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(466, 24);
            this.txtDireccion.TabIndex = 2;
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.BackColor = System.Drawing.Color.Transparent;
            this.lblLocalidad.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalidad.ForeColor = System.Drawing.Color.White;
            this.lblLocalidad.Location = new System.Drawing.Point(16, 277);
            this.lblLocalidad.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(109, 32);
            this.lblLocalidad.TabIndex = 12;
            this.lblLocalidad.Text = "Localidad";
            this.lblLocalidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTelefono
            // 
            this.lblTelefono.BackColor = System.Drawing.Color.Transparent;
            this.lblTelefono.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.ForeColor = System.Drawing.Color.White;
            this.lblTelefono.Location = new System.Drawing.Point(16, 344);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(109, 28);
            this.lblTelefono.TabIndex = 14;
            this.lblTelefono.Text = "Teléfono";
            this.lblTelefono.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTelefono1
            // 
            this.txtTelefono1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.txtTelefono1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefono1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono1.ForeColor = System.Drawing.Color.White;
            this.txtTelefono1.Location = new System.Drawing.Point(132, 345);
            this.txtTelefono1.Margin = new System.Windows.Forms.Padding(6);
            this.txtTelefono1.MaxLength = 4;
            this.txtTelefono1.Name = "txtTelefono1";
            this.txtTelefono1.Size = new System.Drawing.Size(59, 24);
            this.txtTelefono1.TabIndex = 4;
            this.txtTelefono1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTelefono1.TextChanged += new System.EventHandler(this.txtTelefono1_TextChanged);
            this.txtTelefono1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono1_KeyPress);
            // 
            // lblMail
            // 
            this.lblMail.BackColor = System.Drawing.Color.Transparent;
            this.lblMail.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMail.ForeColor = System.Drawing.Color.White;
            this.lblMail.Location = new System.Drawing.Point(16, 414);
            this.lblMail.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(109, 24);
            this.lblMail.TabIndex = 16;
            this.lblMail.Text = "Mail";
            this.lblMail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMail
            // 
            this.txtMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.txtMail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMail.ForeColor = System.Drawing.Color.White;
            this.txtMail.Location = new System.Drawing.Point(132, 414);
            this.txtMail.Margin = new System.Windows.Forms.Padding(6);
            this.txtMail.MaxLength = 100;
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(466, 24);
            this.txtMail.TabIndex = 7;
            this.txtMail.TextChanged += new System.EventHandler(this.txtMail_TextChanged);
            this.txtMail.Enter += new System.EventHandler(this.txtMail_Enter);
            this.txtMail.Leave += new System.EventHandler(this.txtMail_Leave);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.LightCoral;
            this.label8.Location = new System.Drawing.Point(110, 142);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 22);
            this.label8.TabIndex = 18;
            this.label8.Text = "*";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.LightCoral;
            this.label7.Location = new System.Drawing.Point(109, 349);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 19);
            this.label7.TabIndex = 19;
            this.label7.Text = "*";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ddlLocalidad
            // 
            this.ddlLocalidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.ddlLocalidad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ddlLocalidad.DisplayMember = "ID";
            this.ddlLocalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlLocalidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ddlLocalidad.ForeColor = System.Drawing.Color.White;
            this.ddlLocalidad.FormattingEnabled = true;
            this.ddlLocalidad.Location = new System.Drawing.Point(132, 277);
            this.ddlLocalidad.Margin = new System.Windows.Forms.Padding(6);
            this.ddlLocalidad.Name = "ddlLocalidad";
            this.ddlLocalidad.Size = new System.Drawing.Size(466, 32);
            this.ddlLocalidad.TabIndex = 3;
            this.ddlLocalidad.ValueMember = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightCoral;
            this.label1.Location = new System.Drawing.Point(29, 503);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "* Campos obligatorios";
            // 
            // txtTelefono2
            // 
            this.txtTelefono2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.txtTelefono2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefono2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono2.ForeColor = System.Drawing.Color.White;
            this.txtTelefono2.Location = new System.Drawing.Point(203, 345);
            this.txtTelefono2.Margin = new System.Windows.Forms.Padding(6);
            this.txtTelefono2.MaxLength = 6;
            this.txtTelefono2.Name = "txtTelefono2";
            this.txtTelefono2.Size = new System.Drawing.Size(184, 24);
            this.txtTelefono2.TabIndex = 5;
            this.txtTelefono2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTelefono2.TextChanged += new System.EventHandler(this.txtTelefono2_TextChanged);
            this.txtTelefono2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono2_KeyPress);
            // 
            // txtTelefono3
            // 
            this.txtTelefono3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.txtTelefono3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefono3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono3.ForeColor = System.Drawing.Color.White;
            this.txtTelefono3.Location = new System.Drawing.Point(399, 345);
            this.txtTelefono3.Margin = new System.Windows.Forms.Padding(6);
            this.txtTelefono3.MaxLength = 6;
            this.txtTelefono3.Name = "txtTelefono3";
            this.txtTelefono3.Size = new System.Drawing.Size(199, 24);
            this.txtTelefono3.TabIndex = 6;
            this.txtTelefono3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTelefono3.TextChanged += new System.EventHandler(this.txtTelefono3_TextChanged);
            this.txtTelefono3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono3_KeyPress);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(386, 347);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 21);
            this.label2.TabIndex = 25;
            this.label2.Text = "-";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(191, 347);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 21);
            this.label3.TabIndex = 26;
            this.label3.Text = "-";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTel1
            // 
            this.lblTel1.AutoSize = true;
            this.lblTel1.BackColor = System.Drawing.Color.Transparent;
            this.lblTel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTel1.ForeColor = System.Drawing.Color.White;
            this.lblTel1.Location = new System.Drawing.Point(131, 330);
            this.lblTel1.Name = "lblTel1";
            this.lblTel1.Size = new System.Drawing.Size(51, 13);
            this.lblTel1.TabIndex = 27;
            this.lblTel1.Text = "Cod.Área";
            // 
            // lblTel2
            // 
            this.lblTel2.AutoSize = true;
            this.lblTel2.BackColor = System.Drawing.Color.Transparent;
            this.lblTel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTel2.ForeColor = System.Drawing.Color.White;
            this.lblTel2.Location = new System.Drawing.Point(135, 372);
            this.lblTel2.Name = "lblTel2";
            this.lblTel2.Size = new System.Drawing.Size(35, 13);
            this.lblTel2.TabIndex = 28;
            this.lblTel2.Text = "Sin \'0\'";
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(19, 19);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(57, 13);
            this.txtId.TabIndex = 30;
            this.txtId.Visible = false;
            // 
            // compuGrossDataSet1
            // 
            this.compuGrossDataSet1.DataSetName = "CompuGrossDataSet";
            this.compuGrossDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblMailValido
            // 
            this.lblMailValido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.lblMailValido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMailValido.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblMailValido.Location = new System.Drawing.Point(129, 444);
            this.lblMailValido.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMailValido.Name = "lblMailValido";
            this.lblMailValido.Size = new System.Drawing.Size(55, 15);
            this.lblMailValido.TabIndex = 31;
            this.lblMailValido.Text = "VÁLIDO";
            this.lblMailValido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMailInvalido
            // 
            this.lblMailInvalido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.lblMailInvalido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMailInvalido.ForeColor = System.Drawing.Color.Red;
            this.lblMailInvalido.Location = new System.Drawing.Point(129, 444);
            this.lblMailInvalido.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMailInvalido.Name = "lblMailInvalido";
            this.lblMailInvalido.Size = new System.Drawing.Size(67, 15);
            this.lblMailInvalido.TabIndex = 32;
            this.lblMailInvalido.Text = "INVÁLIDO";
            this.lblMailInvalido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(221, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 30);
            this.label4.TabIndex = 34;
            this.label4.Text = "Nuevo cliente";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConfirmar.BackgroundImage")));
            this.btnConfirmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnConfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmar.FlatAppearance.BorderSize = 0;
            this.btnConfirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Location = new System.Drawing.Point(548, 469);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(50, 50);
            this.btnConfirmar.TabIndex = 35;
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // AgregarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(643, 531);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblMailValido);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblTel2);
            this.Controls.Add(this.lblTel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTelefono3);
            this.Controls.Add(this.txtTelefono2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ddlLocalidad);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.txtTelefono1);
            this.Controls.Add(this.lblLocalidad);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.lblNombres);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.lblMailInvalido);
            this.Controls.Add(this.txtMail);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "AgregarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nuevo Cliente";
            this.Load += new System.EventHandler(this.Agregar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.compuGrossDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtTelefono1;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox ddlLocalidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTelefono2;
        private System.Windows.Forms.TextBox txtTelefono3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTel1;
        private System.Windows.Forms.Label lblTel2;
        private System.Windows.Forms.TextBox txtId;
        private CompuGrossDataSet compuGrossDataSet1;
        private System.Windows.Forms.Label lblMailValido;
        private System.Windows.Forms.Label lblMailInvalido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnConfirmar;
    }
}