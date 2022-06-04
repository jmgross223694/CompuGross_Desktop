
namespace CompuGross
{
    partial class AgregarServicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarServicio));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtRam = new System.Windows.Forms.TextBox();
            this.ddlTiposServicio = new System.Windows.Forms.ComboBox();
            this.ddlTiposEquipo = new System.Windows.Forms.ComboBox();
            this.txtPlacaMadre = new System.Windows.Forms.TextBox();
            this.txtMarcaModelo = new System.Windows.Forms.TextBox();
            this.txtMicroprocesador = new System.Windows.Forms.TextBox();
            this.txtAlmacenamiento = new System.Windows.Forms.TextBox();
            this.txtNumSerie = new System.Windows.Forms.TextBox();
            this.txtAdicionales = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtAlimentacion = new System.Windows.Forms.TextBox();
            this.txtCostoRepuestos = new System.Windows.Forms.TextBox();
            this.txtCostoManoObra = new System.Windows.Forms.TextBox();
            this.txtCostoTerceros = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblFechaRecepcion = new System.Windows.Forms.Label();
            this.lblRam = new System.Windows.Forms.Label();
            this.lblTipoServicio = new System.Windows.Forms.Label();
            this.lblTipoEquipo = new System.Windows.Forms.Label();
            this.lblPlacaMadre = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblMicroProcesador = new System.Windows.Forms.Label();
            this.lblAlmacenamiento = new System.Windows.Forms.Label();
            this.lblCdDvd = new System.Windows.Forms.Label();
            this.lblFuente = new System.Windows.Forms.Label();
            this.lblAdicionales = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblNumSerie = new System.Windows.Forms.Label();
            this.lblCostoRepuestos = new System.Windows.Forms.Label();
            this.lblManoObra = new System.Windows.Forms.Label();
            this.lblCostoTerceros = new System.Windows.Forms.Label();
            this.lblFechaDevolucion = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.txtBuscarCliente = new System.Windows.Forms.TextBox();
            this.lblBuscarCliente = new System.Windows.Forms.Label();
            this.fechaRecepcion = new System.Windows.Forms.DateTimePicker();
            this.fechaDevolucion = new System.Windows.Forms.DateTimePicker();
            this.lblAsterisco5 = new System.Windows.Forms.Label();
            this.lblAsterisco4 = new System.Windows.Forms.Label();
            this.lblAsterisco1 = new System.Windows.Forms.Label();
            this.lblAsterisco2 = new System.Windows.Forms.Label();
            this.lblAsterisco3 = new System.Windows.Forms.Label();
            this.cbFechaDevolucion = new System.Windows.Forms.CheckBox();
            this.ddlUnidadOptica = new System.Windows.Forms.ComboBox();
            this.lblCamposObligatorios = new System.Windows.Forms.Label();
            this.lblSeleccionarCliente = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCliente
            // 
            this.txtCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.txtCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCliente.Cursor = System.Windows.Forms.Cursors.No;
            this.txtCliente.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.ForeColor = System.Drawing.Color.White;
            this.txtCliente.Location = new System.Drawing.Point(63, 47);
            this.txtCliente.MaxLength = 200;
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.ReadOnly = true;
            this.txtCliente.Size = new System.Drawing.Size(198, 20);
            this.txtCliente.TabIndex = 1;
            this.txtCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCliente.TextChanged += new System.EventHandler(this.txtCliente_TextChanged);
            // 
            // txtRam
            // 
            this.txtRam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.txtRam.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRam.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRam.ForeColor = System.Drawing.Color.White;
            this.txtRam.Location = new System.Drawing.Point(358, 140);
            this.txtRam.MaxLength = 50;
            this.txtRam.Name = "txtRam";
            this.txtRam.Size = new System.Drawing.Size(150, 20);
            this.txtRam.TabIndex = 5;
            // 
            // ddlTiposServicio
            // 
            this.ddlTiposServicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.ddlTiposServicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ddlTiposServicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlTiposServicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ddlTiposServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlTiposServicio.ForeColor = System.Drawing.Color.White;
            this.ddlTiposServicio.FormattingEnabled = true;
            this.ddlTiposServicio.ItemHeight = 15;
            this.ddlTiposServicio.Items.AddRange(new object[] {
            "-"});
            this.ddlTiposServicio.Location = new System.Drawing.Point(346, 96);
            this.ddlTiposServicio.MaxDropDownItems = 10;
            this.ddlTiposServicio.Name = "ddlTiposServicio";
            this.ddlTiposServicio.Size = new System.Drawing.Size(161, 23);
            this.ddlTiposServicio.TabIndex = 3;
            // 
            // ddlTiposEquipo
            // 
            this.ddlTiposEquipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.ddlTiposEquipo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ddlTiposEquipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlTiposEquipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ddlTiposEquipo.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlTiposEquipo.ForeColor = System.Drawing.Color.White;
            this.ddlTiposEquipo.FormattingEnabled = true;
            this.ddlTiposEquipo.ItemHeight = 13;
            this.ddlTiposEquipo.Items.AddRange(new object[] {
            "-"});
            this.ddlTiposEquipo.Location = new System.Drawing.Point(12, 140);
            this.ddlTiposEquipo.MaxDropDownItems = 15;
            this.ddlTiposEquipo.Name = "ddlTiposEquipo";
            this.ddlTiposEquipo.Size = new System.Drawing.Size(146, 21);
            this.ddlTiposEquipo.TabIndex = 4;
            // 
            // txtPlacaMadre
            // 
            this.txtPlacaMadre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.txtPlacaMadre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPlacaMadre.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlacaMadre.ForeColor = System.Drawing.Color.White;
            this.txtPlacaMadre.Location = new System.Drawing.Point(358, 183);
            this.txtPlacaMadre.MaxLength = 50;
            this.txtPlacaMadre.Name = "txtPlacaMadre";
            this.txtPlacaMadre.Size = new System.Drawing.Size(150, 20);
            this.txtPlacaMadre.TabIndex = 6;
            // 
            // txtMarcaModelo
            // 
            this.txtMarcaModelo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.txtMarcaModelo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMarcaModelo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarcaModelo.ForeColor = System.Drawing.Color.White;
            this.txtMarcaModelo.Location = new System.Drawing.Point(164, 140);
            this.txtMarcaModelo.MaxLength = 50;
            this.txtMarcaModelo.Name = "txtMarcaModelo";
            this.txtMarcaModelo.Size = new System.Drawing.Size(188, 20);
            this.txtMarcaModelo.TabIndex = 7;
            // 
            // txtMicroprocesador
            // 
            this.txtMicroprocesador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.txtMicroprocesador.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMicroprocesador.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMicroprocesador.ForeColor = System.Drawing.Color.White;
            this.txtMicroprocesador.Location = new System.Drawing.Point(12, 183);
            this.txtMicroprocesador.MaxLength = 50;
            this.txtMicroprocesador.Name = "txtMicroprocesador";
            this.txtMicroprocesador.Size = new System.Drawing.Size(158, 20);
            this.txtMicroprocesador.TabIndex = 8;
            // 
            // txtAlmacenamiento
            // 
            this.txtAlmacenamiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.txtAlmacenamiento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAlmacenamiento.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlmacenamiento.ForeColor = System.Drawing.Color.White;
            this.txtAlmacenamiento.Location = new System.Drawing.Point(185, 183);
            this.txtAlmacenamiento.MaxLength = 50;
            this.txtAlmacenamiento.Name = "txtAlmacenamiento";
            this.txtAlmacenamiento.Size = new System.Drawing.Size(161, 20);
            this.txtAlmacenamiento.TabIndex = 9;
            // 
            // txtNumSerie
            // 
            this.txtNumSerie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.txtNumSerie.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumSerie.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumSerie.ForeColor = System.Drawing.Color.White;
            this.txtNumSerie.Location = new System.Drawing.Point(12, 225);
            this.txtNumSerie.MaxLength = 50;
            this.txtNumSerie.Name = "txtNumSerie";
            this.txtNumSerie.Size = new System.Drawing.Size(158, 20);
            this.txtNumSerie.TabIndex = 11;
            // 
            // txtAdicionales
            // 
            this.txtAdicionales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.txtAdicionales.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAdicionales.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdicionales.ForeColor = System.Drawing.Color.White;
            this.txtAdicionales.Location = new System.Drawing.Point(185, 225);
            this.txtAdicionales.MaxLength = 50;
            this.txtAdicionales.Name = "txtAdicionales";
            this.txtAdicionales.Size = new System.Drawing.Size(161, 20);
            this.txtAdicionales.TabIndex = 12;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescripcion.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.ForeColor = System.Drawing.Color.White;
            this.txtDescripcion.Location = new System.Drawing.Point(358, 225);
            this.txtDescripcion.MaxLength = 1000;
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(150, 118);
            this.txtDescripcion.TabIndex = 18;
            this.txtDescripcion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDescripcion_KeyDown);
            // 
            // txtAlimentacion
            // 
            this.txtAlimentacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.txtAlimentacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAlimentacion.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlimentacion.ForeColor = System.Drawing.Color.White;
            this.txtAlimentacion.Location = new System.Drawing.Point(12, 271);
            this.txtAlimentacion.MaxLength = 100;
            this.txtAlimentacion.Name = "txtAlimentacion";
            this.txtAlimentacion.Size = new System.Drawing.Size(167, 20);
            this.txtAlimentacion.TabIndex = 13;
            // 
            // txtCostoRepuestos
            // 
            this.txtCostoRepuestos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.txtCostoRepuestos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCostoRepuestos.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCostoRepuestos.ForeColor = System.Drawing.Color.White;
            this.txtCostoRepuestos.Location = new System.Drawing.Point(12, 323);
            this.txtCostoRepuestos.MaxLength = 10;
            this.txtCostoRepuestos.Name = "txtCostoRepuestos";
            this.txtCostoRepuestos.Size = new System.Drawing.Size(109, 20);
            this.txtCostoRepuestos.TabIndex = 14;
            this.txtCostoRepuestos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCostoRepuestos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCostoRepuestos_KeyPress);
            // 
            // txtCostoManoObra
            // 
            this.txtCostoManoObra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.txtCostoManoObra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCostoManoObra.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCostoManoObra.ForeColor = System.Drawing.Color.White;
            this.txtCostoManoObra.Location = new System.Drawing.Point(139, 323);
            this.txtCostoManoObra.MaxLength = 10;
            this.txtCostoManoObra.Name = "txtCostoManoObra";
            this.txtCostoManoObra.Size = new System.Drawing.Size(104, 20);
            this.txtCostoManoObra.TabIndex = 15;
            this.txtCostoManoObra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCostoManoObra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCostoManoObra_KeyPress);
            // 
            // txtCostoTerceros
            // 
            this.txtCostoTerceros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.txtCostoTerceros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCostoTerceros.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCostoTerceros.ForeColor = System.Drawing.Color.White;
            this.txtCostoTerceros.Location = new System.Drawing.Point(258, 323);
            this.txtCostoTerceros.MaxLength = 10;
            this.txtCostoTerceros.Name = "txtCostoTerceros";
            this.txtCostoTerceros.Size = new System.Drawing.Size(92, 20);
            this.txtCostoTerceros.TabIndex = 16;
            this.txtCostoTerceros.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCostoTerceros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCostoTerceros_KeyPress);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.ForeColor = System.Drawing.Color.White;
            this.lblCliente.Location = new System.Drawing.Point(60, 31);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(48, 16);
            this.lblCliente.TabIndex = 22;
            this.lblCliente.Text = "Cliente";
            // 
            // lblFechaRecepcion
            // 
            this.lblFechaRecepcion.AutoSize = true;
            this.lblFechaRecepcion.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaRecepcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaRecepcion.ForeColor = System.Drawing.Color.White;
            this.lblFechaRecepcion.Location = new System.Drawing.Point(9, 80);
            this.lblFechaRecepcion.Name = "lblFechaRecepcion";
            this.lblFechaRecepcion.Size = new System.Drawing.Size(108, 16);
            this.lblFechaRecepcion.TabIndex = 23;
            this.lblFechaRecepcion.Text = "Fecha recepción";
            // 
            // lblRam
            // 
            this.lblRam.AutoSize = true;
            this.lblRam.BackColor = System.Drawing.Color.Transparent;
            this.lblRam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRam.ForeColor = System.Drawing.Color.White;
            this.lblRam.Location = new System.Drawing.Point(355, 120);
            this.lblRam.Name = "lblRam";
            this.lblRam.Size = new System.Drawing.Size(93, 16);
            this.lblRam.TabIndex = 24;
            this.lblRam.Text = "Memoria RAM";
            // 
            // lblTipoServicio
            // 
            this.lblTipoServicio.AutoSize = true;
            this.lblTipoServicio.BackColor = System.Drawing.Color.Transparent;
            this.lblTipoServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoServicio.ForeColor = System.Drawing.Color.White;
            this.lblTipoServicio.Location = new System.Drawing.Point(343, 79);
            this.lblTipoServicio.Name = "lblTipoServicio";
            this.lblTipoServicio.Size = new System.Drawing.Size(107, 16);
            this.lblTipoServicio.TabIndex = 25;
            this.lblTipoServicio.Text = "Tipo de  servicio";
            // 
            // lblTipoEquipo
            // 
            this.lblTipoEquipo.AutoSize = true;
            this.lblTipoEquipo.BackColor = System.Drawing.Color.Transparent;
            this.lblTipoEquipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoEquipo.ForeColor = System.Drawing.Color.White;
            this.lblTipoEquipo.Location = new System.Drawing.Point(9, 120);
            this.lblTipoEquipo.Name = "lblTipoEquipo";
            this.lblTipoEquipo.Size = new System.Drawing.Size(99, 16);
            this.lblTipoEquipo.TabIndex = 26;
            this.lblTipoEquipo.Text = "Tipo de equipo";
            // 
            // lblPlacaMadre
            // 
            this.lblPlacaMadre.AutoSize = true;
            this.lblPlacaMadre.BackColor = System.Drawing.Color.Transparent;
            this.lblPlacaMadre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlacaMadre.ForeColor = System.Drawing.Color.White;
            this.lblPlacaMadre.Location = new System.Drawing.Point(355, 164);
            this.lblPlacaMadre.Name = "lblPlacaMadre";
            this.lblPlacaMadre.Size = new System.Drawing.Size(84, 16);
            this.lblPlacaMadre.TabIndex = 27;
            this.lblPlacaMadre.Text = "Placa madre";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.BackColor = System.Drawing.Color.Transparent;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.ForeColor = System.Drawing.Color.White;
            this.lblMarca.Location = new System.Drawing.Point(161, 120);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(104, 16);
            this.lblMarca.TabIndex = 28;
            this.lblMarca.Text = "Marca y modelo";
            // 
            // lblMicroProcesador
            // 
            this.lblMicroProcesador.AutoSize = true;
            this.lblMicroProcesador.BackColor = System.Drawing.Color.Transparent;
            this.lblMicroProcesador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMicroProcesador.ForeColor = System.Drawing.Color.White;
            this.lblMicroProcesador.Location = new System.Drawing.Point(9, 164);
            this.lblMicroProcesador.Name = "lblMicroProcesador";
            this.lblMicroProcesador.Size = new System.Drawing.Size(110, 16);
            this.lblMicroProcesador.TabIndex = 29;
            this.lblMicroProcesador.Text = "Microprocesador";
            // 
            // lblAlmacenamiento
            // 
            this.lblAlmacenamiento.AutoSize = true;
            this.lblAlmacenamiento.BackColor = System.Drawing.Color.Transparent;
            this.lblAlmacenamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlmacenamiento.ForeColor = System.Drawing.Color.White;
            this.lblAlmacenamiento.Location = new System.Drawing.Point(182, 164);
            this.lblAlmacenamiento.Name = "lblAlmacenamiento";
            this.lblAlmacenamiento.Size = new System.Drawing.Size(108, 16);
            this.lblAlmacenamiento.TabIndex = 30;
            this.lblAlmacenamiento.Text = "Almacenamiento";
            // 
            // lblCdDvd
            // 
            this.lblCdDvd.AutoSize = true;
            this.lblCdDvd.BackColor = System.Drawing.Color.Transparent;
            this.lblCdDvd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCdDvd.ForeColor = System.Drawing.Color.White;
            this.lblCdDvd.Location = new System.Drawing.Point(182, 252);
            this.lblCdDvd.Name = "lblCdDvd";
            this.lblCdDvd.Size = new System.Drawing.Size(91, 16);
            this.lblCdDvd.TabIndex = 31;
            this.lblCdDvd.Text = "Unidad óptica";
            // 
            // lblFuente
            // 
            this.lblFuente.AutoSize = true;
            this.lblFuente.BackColor = System.Drawing.Color.Transparent;
            this.lblFuente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuente.ForeColor = System.Drawing.Color.White;
            this.lblFuente.Location = new System.Drawing.Point(9, 252);
            this.lblFuente.Name = "lblFuente";
            this.lblFuente.Size = new System.Drawing.Size(84, 16);
            this.lblFuente.TabIndex = 32;
            this.lblFuente.Text = "Alimentación";
            // 
            // lblAdicionales
            // 
            this.lblAdicionales.AutoSize = true;
            this.lblAdicionales.BackColor = System.Drawing.Color.Transparent;
            this.lblAdicionales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdicionales.ForeColor = System.Drawing.Color.White;
            this.lblAdicionales.Location = new System.Drawing.Point(182, 205);
            this.lblAdicionales.Name = "lblAdicionales";
            this.lblAdicionales.Size = new System.Drawing.Size(78, 16);
            this.lblAdicionales.TabIndex = 33;
            this.lblAdicionales.Text = "Adicionales";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.BackColor = System.Drawing.Color.Transparent;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.Color.White;
            this.lblDescripcion.Location = new System.Drawing.Point(355, 205);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(79, 16);
            this.lblDescripcion.TabIndex = 34;
            this.lblDescripcion.Text = "Descripción";
            // 
            // lblNumSerie
            // 
            this.lblNumSerie.AutoSize = true;
            this.lblNumSerie.BackColor = System.Drawing.Color.Transparent;
            this.lblNumSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumSerie.ForeColor = System.Drawing.Color.White;
            this.lblNumSerie.Location = new System.Drawing.Point(9, 207);
            this.lblNumSerie.Name = "lblNumSerie";
            this.lblNumSerie.Size = new System.Drawing.Size(56, 16);
            this.lblNumSerie.TabIndex = 35;
            this.lblNumSerie.Text = "N° Serie";
            // 
            // lblCostoRepuestos
            // 
            this.lblCostoRepuestos.AutoSize = true;
            this.lblCostoRepuestos.BackColor = System.Drawing.Color.Transparent;
            this.lblCostoRepuestos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostoRepuestos.ForeColor = System.Drawing.Color.White;
            this.lblCostoRepuestos.Location = new System.Drawing.Point(9, 304);
            this.lblCostoRepuestos.Name = "lblCostoRepuestos";
            this.lblCostoRepuestos.Size = new System.Drawing.Size(105, 16);
            this.lblCostoRepuestos.TabIndex = 36;
            this.lblCostoRepuestos.Text = "Costo repuestos";
            // 
            // lblManoObra
            // 
            this.lblManoObra.AutoSize = true;
            this.lblManoObra.BackColor = System.Drawing.Color.Transparent;
            this.lblManoObra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManoObra.ForeColor = System.Drawing.Color.White;
            this.lblManoObra.Location = new System.Drawing.Point(136, 304);
            this.lblManoObra.Name = "lblManoObra";
            this.lblManoObra.Size = new System.Drawing.Size(91, 16);
            this.lblManoObra.TabIndex = 37;
            this.lblManoObra.Text = "Mano de obra";
            // 
            // lblCostoTerceros
            // 
            this.lblCostoTerceros.AutoSize = true;
            this.lblCostoTerceros.BackColor = System.Drawing.Color.Transparent;
            this.lblCostoTerceros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostoTerceros.ForeColor = System.Drawing.Color.White;
            this.lblCostoTerceros.Location = new System.Drawing.Point(255, 305);
            this.lblCostoTerceros.Name = "lblCostoTerceros";
            this.lblCostoTerceros.Size = new System.Drawing.Size(94, 16);
            this.lblCostoTerceros.TabIndex = 38;
            this.lblCostoTerceros.Text = "Costo terceros";
            // 
            // lblFechaDevolucion
            // 
            this.lblFechaDevolucion.AutoSize = true;
            this.lblFechaDevolucion.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaDevolucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaDevolucion.ForeColor = System.Drawing.Color.White;
            this.lblFechaDevolucion.Location = new System.Drawing.Point(161, 80);
            this.lblFechaDevolucion.Name = "lblFechaDevolucion";
            this.lblFechaDevolucion.Size = new System.Drawing.Size(114, 16);
            this.lblFechaDevolucion.TabIndex = 39;
            this.lblFechaDevolucion.Text = "Fecha devolución";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnConfirmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnConfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmar.FlatAppearance.BorderSize = 0;
            this.btnConfirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.ForeColor = System.Drawing.Color.White;
            this.btnConfirmar.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirmar.Image")));
            this.btnConfirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmar.Location = new System.Drawing.Point(370, 349);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(138, 36);
            this.btnConfirmar.TabIndex = 19;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarCliente.FlatAppearance.BorderSize = 0;
            this.btnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCliente.ForeColor = System.Drawing.Color.White;
            this.btnBuscarCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarCliente.Image")));
            this.btnBuscarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarCliente.Location = new System.Drawing.Point(12, 30);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(30, 30);
            this.btnBuscarCliente.TabIndex = 0;
            this.btnBuscarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarCliente.UseVisualStyleBackColor = false;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.AllowUserToResizeColumns = false;
            this.dgvClientes.AllowUserToResizeRows = false;
            this.dgvClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvClientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvClientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.dgvClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClientes.ColumnHeadersHeight = 30;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClientes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvClientes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvClientes.EnableHeadersVisualStyles = false;
            this.dgvClientes.GridColor = System.Drawing.SystemColors.Control;
            this.dgvClientes.Location = new System.Drawing.Point(12, 79);
            this.dgvClientes.MultiSelect = false;
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvClientes.RowHeadersVisible = false;
            this.dgvClientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvClientes.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.ShowCellErrors = false;
            this.dgvClientes.ShowCellToolTips = false;
            this.dgvClientes.ShowEditingIcon = false;
            this.dgvClientes.ShowRowErrors = false;
            this.dgvClientes.Size = new System.Drawing.Size(499, 312);
            this.dgvClientes.StandardTab = true;
            this.dgvClientes.TabIndex = 23;
            this.dgvClientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellDoubleClick);
            // 
            // txtBuscarCliente
            // 
            this.txtBuscarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.txtBuscarCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscarCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBuscarCliente.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarCliente.ForeColor = System.Drawing.Color.White;
            this.txtBuscarCliente.Location = new System.Drawing.Point(113, 39);
            this.txtBuscarCliente.MaxLength = 50;
            this.txtBuscarCliente.Name = "txtBuscarCliente";
            this.txtBuscarCliente.Size = new System.Drawing.Size(385, 20);
            this.txtBuscarCliente.TabIndex = 50;
            this.txtBuscarCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBuscarCliente.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscarCliente_KeyUp);
            // 
            // lblBuscarCliente
            // 
            this.lblBuscarCliente.AutoSize = true;
            this.lblBuscarCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblBuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarCliente.ForeColor = System.Drawing.Color.White;
            this.lblBuscarCliente.Location = new System.Drawing.Point(67, 39);
            this.lblBuscarCliente.Name = "lblBuscarCliente";
            this.lblBuscarCliente.Size = new System.Drawing.Size(50, 20);
            this.lblBuscarCliente.TabIndex = 42;
            this.lblBuscarCliente.Text = "Filtro";
            // 
            // fechaRecepcion
            // 
            this.fechaRecepcion.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaRecepcion.CalendarForeColor = System.Drawing.Color.White;
            this.fechaRecepcion.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.fechaRecepcion.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.fechaRecepcion.CalendarTitleForeColor = System.Drawing.Color.White;
            this.fechaRecepcion.CalendarTrailingForeColor = System.Drawing.Color.White;
            this.fechaRecepcion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fechaRecepcion.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaRecepcion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaRecepcion.Location = new System.Drawing.Point(12, 96);
            this.fechaRecepcion.Name = "fechaRecepcion";
            this.fechaRecepcion.Size = new System.Drawing.Size(135, 22);
            this.fechaRecepcion.TabIndex = 2;
            // 
            // fechaDevolucion
            // 
            this.fechaDevolucion.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaDevolucion.CalendarForeColor = System.Drawing.Color.White;
            this.fechaDevolucion.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.fechaDevolucion.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.fechaDevolucion.CalendarTitleForeColor = System.Drawing.Color.White;
            this.fechaDevolucion.CalendarTrailingForeColor = System.Drawing.Color.White;
            this.fechaDevolucion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fechaDevolucion.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaDevolucion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaDevolucion.Location = new System.Drawing.Point(164, 96);
            this.fechaDevolucion.Name = "fechaDevolucion";
            this.fechaDevolucion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fechaDevolucion.Size = new System.Drawing.Size(165, 22);
            this.fechaDevolucion.TabIndex = 17;
            // 
            // lblAsterisco5
            // 
            this.lblAsterisco5.AutoSize = true;
            this.lblAsterisco5.BackColor = System.Drawing.Color.Transparent;
            this.lblAsterisco5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsterisco5.ForeColor = System.Drawing.Color.LightCoral;
            this.lblAsterisco5.Location = new System.Drawing.Point(408, 203);
            this.lblAsterisco5.Name = "lblAsterisco5";
            this.lblAsterisco5.Size = new System.Drawing.Size(17, 19);
            this.lblAsterisco5.TabIndex = 46;
            this.lblAsterisco5.Text = "*";
            // 
            // lblAsterisco4
            // 
            this.lblAsterisco4.AutoSize = true;
            this.lblAsterisco4.BackColor = System.Drawing.Color.Transparent;
            this.lblAsterisco4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsterisco4.ForeColor = System.Drawing.Color.LightCoral;
            this.lblAsterisco4.Location = new System.Drawing.Point(196, 301);
            this.lblAsterisco4.Name = "lblAsterisco4";
            this.lblAsterisco4.Size = new System.Drawing.Size(17, 19);
            this.lblAsterisco4.TabIndex = 47;
            this.lblAsterisco4.Text = "*";
            // 
            // lblAsterisco1
            // 
            this.lblAsterisco1.AutoSize = true;
            this.lblAsterisco1.BackColor = System.Drawing.Color.Transparent;
            this.lblAsterisco1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsterisco1.ForeColor = System.Drawing.Color.LightCoral;
            this.lblAsterisco1.Location = new System.Drawing.Point(414, 76);
            this.lblAsterisco1.Name = "lblAsterisco1";
            this.lblAsterisco1.Size = new System.Drawing.Size(17, 19);
            this.lblAsterisco1.TabIndex = 48;
            this.lblAsterisco1.Text = "*";
            // 
            // lblAsterisco2
            // 
            this.lblAsterisco2.AutoSize = true;
            this.lblAsterisco2.BackColor = System.Drawing.Color.Transparent;
            this.lblAsterisco2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsterisco2.ForeColor = System.Drawing.Color.LightCoral;
            this.lblAsterisco2.Location = new System.Drawing.Point(76, 118);
            this.lblAsterisco2.Name = "lblAsterisco2";
            this.lblAsterisco2.Size = new System.Drawing.Size(17, 19);
            this.lblAsterisco2.TabIndex = 49;
            this.lblAsterisco2.Text = "*";
            // 
            // lblAsterisco3
            // 
            this.lblAsterisco3.AutoSize = true;
            this.lblAsterisco3.BackColor = System.Drawing.Color.Transparent;
            this.lblAsterisco3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsterisco3.ForeColor = System.Drawing.Color.LightCoral;
            this.lblAsterisco3.Location = new System.Drawing.Point(234, 117);
            this.lblAsterisco3.Name = "lblAsterisco3";
            this.lblAsterisco3.Size = new System.Drawing.Size(17, 19);
            this.lblAsterisco3.TabIndex = 50;
            this.lblAsterisco3.Text = "*";
            // 
            // cbFechaDevolucion
            // 
            this.cbFechaDevolucion.AutoSize = true;
            this.cbFechaDevolucion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbFechaDevolucion.FlatAppearance.BorderSize = 0;
            this.cbFechaDevolucion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.cbFechaDevolucion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbFechaDevolucion.ForeColor = System.Drawing.Color.White;
            this.cbFechaDevolucion.Location = new System.Drawing.Point(317, 82);
            this.cbFechaDevolucion.Name = "cbFechaDevolucion";
            this.cbFechaDevolucion.Size = new System.Drawing.Size(12, 11);
            this.cbFechaDevolucion.TabIndex = 51;
            this.cbFechaDevolucion.UseVisualStyleBackColor = true;
            this.cbFechaDevolucion.CheckedChanged += new System.EventHandler(this.cbFechaDevolucion_CheckedChanged);
            // 
            // ddlUnidadOptica
            // 
            this.ddlUnidadOptica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.ddlUnidadOptica.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ddlUnidadOptica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlUnidadOptica.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ddlUnidadOptica.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlUnidadOptica.ForeColor = System.Drawing.Color.White;
            this.ddlUnidadOptica.FormattingEnabled = true;
            this.ddlUnidadOptica.Items.AddRange(new object[] {
            "-",
            "Lectora CD",
            "Lectora CD/DVD",
            "Lectograbadora CD/DVD",
            "No tiene",
            "No aplica"});
            this.ddlUnidadOptica.Location = new System.Drawing.Point(185, 270);
            this.ddlUnidadOptica.Name = "ddlUnidadOptica";
            this.ddlUnidadOptica.Size = new System.Drawing.Size(167, 21);
            this.ddlUnidadOptica.TabIndex = 52;
            // 
            // lblCamposObligatorios
            // 
            this.lblCamposObligatorios.AutoSize = true;
            this.lblCamposObligatorios.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCamposObligatorios.ForeColor = System.Drawing.Color.LightCoral;
            this.lblCamposObligatorios.Location = new System.Drawing.Point(8, 358);
            this.lblCamposObligatorios.Name = "lblCamposObligatorios";
            this.lblCamposObligatorios.Size = new System.Drawing.Size(154, 19);
            this.lblCamposObligatorios.TabIndex = 53;
            this.lblCamposObligatorios.Text = "* Campos obligatorios";
            // 
            // lblSeleccionarCliente
            // 
            this.lblSeleccionarCliente.AutoSize = true;
            this.lblSeleccionarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.lblSeleccionarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSeleccionarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSeleccionarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccionarCliente.ForeColor = System.Drawing.Color.White;
            this.lblSeleccionarCliente.Location = new System.Drawing.Point(13, 61);
            this.lblSeleccionarCliente.Name = "lblSeleccionarCliente";
            this.lblSeleccionarCliente.Size = new System.Drawing.Size(198, 25);
            this.lblSeleccionarCliente.TabIndex = 54;
            this.lblSeleccionarCliente.Text = "Seleccionar Cliente";
            this.lblSeleccionarCliente.Visible = false;
            this.lblSeleccionarCliente.Click += new System.EventHandler(this.lblSeleccionarCliente_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(12, 6);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(499, 25);
            this.lblTitulo.TabIndex = 55;
            this.lblTitulo.Text = "NUEVO SERVICIO";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AgregarServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(529, 401);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblSeleccionarCliente);
            this.Controls.Add(this.lblCamposObligatorios);
            this.Controls.Add(this.ddlUnidadOptica);
            this.Controls.Add(this.cbFechaDevolucion);
            this.Controls.Add(this.lblAsterisco3);
            this.Controls.Add(this.lblAsterisco2);
            this.Controls.Add(this.lblAsterisco1);
            this.Controls.Add(this.lblAsterisco4);
            this.Controls.Add(this.lblAsterisco5);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.lblFechaDevolucion);
            this.Controls.Add(this.lblCostoTerceros);
            this.Controls.Add(this.lblManoObra);
            this.Controls.Add(this.lblCostoRepuestos);
            this.Controls.Add(this.lblNumSerie);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblAdicionales);
            this.Controls.Add(this.lblFuente);
            this.Controls.Add(this.lblCdDvd);
            this.Controls.Add(this.lblAlmacenamiento);
            this.Controls.Add(this.lblMicroProcesador);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblPlacaMadre);
            this.Controls.Add(this.lblTipoEquipo);
            this.Controls.Add(this.lblTipoServicio);
            this.Controls.Add(this.lblRam);
            this.Controls.Add(this.lblFechaRecepcion);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.txtCostoTerceros);
            this.Controls.Add(this.txtCostoManoObra);
            this.Controls.Add(this.txtCostoRepuestos);
            this.Controls.Add(this.txtAlimentacion);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtAdicionales);
            this.Controls.Add(this.txtNumSerie);
            this.Controls.Add(this.txtAlmacenamiento);
            this.Controls.Add(this.txtMicroprocesador);
            this.Controls.Add(this.txtMarcaModelo);
            this.Controls.Add(this.txtPlacaMadre);
            this.Controls.Add(this.ddlTiposEquipo);
            this.Controls.Add(this.ddlTiposServicio);
            this.Controls.Add(this.txtRam);
            this.Controls.Add(this.fechaRecepcion);
            this.Controls.Add(this.fechaDevolucion);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.txtBuscarCliente);
            this.Controls.Add(this.lblBuscarCliente);
            this.Controls.Add(this.txtCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AgregarServicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Orden";
            this.Load += new System.EventHandler(this.AgregarServicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtRam;
        private System.Windows.Forms.ComboBox ddlTiposServicio;
        private System.Windows.Forms.ComboBox ddlTiposEquipo;
        private System.Windows.Forms.TextBox txtPlacaMadre;
        private System.Windows.Forms.TextBox txtMarcaModelo;
        private System.Windows.Forms.TextBox txtMicroprocesador;
        private System.Windows.Forms.TextBox txtAlmacenamiento;
        private System.Windows.Forms.TextBox txtNumSerie;
        private System.Windows.Forms.TextBox txtAdicionales;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtAlimentacion;
        private System.Windows.Forms.TextBox txtCostoRepuestos;
        private System.Windows.Forms.TextBox txtCostoManoObra;
        private System.Windows.Forms.TextBox txtCostoTerceros;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblFechaRecepcion;
        private System.Windows.Forms.Label lblRam;
        private System.Windows.Forms.Label lblTipoServicio;
        private System.Windows.Forms.Label lblTipoEquipo;
        private System.Windows.Forms.Label lblPlacaMadre;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblMicroProcesador;
        private System.Windows.Forms.Label lblAlmacenamiento;
        private System.Windows.Forms.Label lblCdDvd;
        private System.Windows.Forms.Label lblFuente;
        private System.Windows.Forms.Label lblAdicionales;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblNumSerie;
        private System.Windows.Forms.Label lblCostoRepuestos;
        private System.Windows.Forms.Label lblManoObra;
        private System.Windows.Forms.Label lblCostoTerceros;
        private System.Windows.Forms.Label lblFechaDevolucion;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.TextBox txtBuscarCliente;
        private System.Windows.Forms.Label lblBuscarCliente;
        private System.Windows.Forms.DateTimePicker fechaRecepcion;
        private System.Windows.Forms.DateTimePicker fechaDevolucion;
        private System.Windows.Forms.Label lblAsterisco5;
        private System.Windows.Forms.Label lblAsterisco4;
        private System.Windows.Forms.Label lblAsterisco1;
        private System.Windows.Forms.Label lblAsterisco2;
        private System.Windows.Forms.Label lblAsterisco3;
        private System.Windows.Forms.CheckBox cbFechaDevolucion;
        private System.Windows.Forms.ComboBox ddlUnidadOptica;
        private System.Windows.Forms.Label lblCamposObligatorios;
        private System.Windows.Forms.Label lblSeleccionarCliente;
        private System.Windows.Forms.Label lblTitulo;
    }
}