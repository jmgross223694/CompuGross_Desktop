
namespace CompuGross
{
    partial class AgregarOrden
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarOrden));
            this.txtFechaRecepcion = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtRam = new System.Windows.Forms.TextBox();
            this.ddlTiposServicio = new System.Windows.Forms.ComboBox();
            this.ddlTiposEquipo = new System.Windows.Forms.ComboBox();
            this.txtPlacaMadre = new System.Windows.Forms.TextBox();
            this.txtMarcaModelo = new System.Windows.Forms.TextBox();
            this.txtMicroprocesador = new System.Windows.Forms.TextBox();
            this.txtAlmacenamiento = new System.Windows.Forms.TextBox();
            this.txtCdDvd = new System.Windows.Forms.TextBox();
            this.txtFuente = new System.Windows.Forms.TextBox();
            this.txtAdicionales = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtNumSerie = new System.Windows.Forms.TextBox();
            this.txtCostoRepuestos = new System.Windows.Forms.TextBox();
            this.txtCostoManoObra = new System.Windows.Forms.TextBox();
            this.txtCostoTerceros = new System.Windows.Forms.TextBox();
            this.txtFechaDevolucion = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFechaRecepcion
            // 
            this.txtFechaRecepcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaRecepcion.Location = new System.Drawing.Point(243, 91);
            this.txtFechaRecepcion.MaxLength = 10;
            this.txtFechaRecepcion.Name = "txtFechaRecepcion";
            this.txtFechaRecepcion.Size = new System.Drawing.Size(100, 22);
            this.txtFechaRecepcion.TabIndex = 2;
            // 
            // txtCliente
            // 
            this.txtCliente.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtCliente.Cursor = System.Windows.Forms.Cursors.No;
            this.txtCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.Location = new System.Drawing.Point(12, 91);
            this.txtCliente.MaxLength = 200;
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.ReadOnly = true;
            this.txtCliente.Size = new System.Drawing.Size(226, 22);
            this.txtCliente.TabIndex = 1;
            this.txtCliente.TextChanged += new System.EventHandler(this.txtCliente_TextChanged);
            // 
            // txtRam
            // 
            this.txtRam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRam.Location = new System.Drawing.Point(141, 149);
            this.txtRam.MaxLength = 4;
            this.txtRam.Name = "txtRam";
            this.txtRam.Size = new System.Drawing.Size(121, 22);
            this.txtRam.TabIndex = 5;
            // 
            // ddlTiposServicio
            // 
            this.ddlTiposServicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ddlTiposServicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlTiposServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlTiposServicio.FormattingEnabled = true;
            this.ddlTiposServicio.ItemHeight = 15;
            this.ddlTiposServicio.Location = new System.Drawing.Point(349, 91);
            this.ddlTiposServicio.Name = "ddlTiposServicio";
            this.ddlTiposServicio.Size = new System.Drawing.Size(161, 23);
            this.ddlTiposServicio.TabIndex = 3;
            // 
            // ddlTiposEquipo
            // 
            this.ddlTiposEquipo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ddlTiposEquipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlTiposEquipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlTiposEquipo.FormattingEnabled = true;
            this.ddlTiposEquipo.Location = new System.Drawing.Point(12, 149);
            this.ddlTiposEquipo.Name = "ddlTiposEquipo";
            this.ddlTiposEquipo.Size = new System.Drawing.Size(121, 23);
            this.ddlTiposEquipo.TabIndex = 4;
            // 
            // txtPlacaMadre
            // 
            this.txtPlacaMadre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlacaMadre.Location = new System.Drawing.Point(268, 149);
            this.txtPlacaMadre.MaxLength = 50;
            this.txtPlacaMadre.Name = "txtPlacaMadre";
            this.txtPlacaMadre.Size = new System.Drawing.Size(242, 22);
            this.txtPlacaMadre.TabIndex = 6;
            // 
            // txtMarcaModelo
            // 
            this.txtMarcaModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarcaModelo.Location = new System.Drawing.Point(12, 210);
            this.txtMarcaModelo.MaxLength = 50;
            this.txtMarcaModelo.Name = "txtMarcaModelo";
            this.txtMarcaModelo.Size = new System.Drawing.Size(167, 22);
            this.txtMarcaModelo.TabIndex = 7;
            // 
            // txtMicroprocesador
            // 
            this.txtMicroprocesador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMicroprocesador.Location = new System.Drawing.Point(185, 210);
            this.txtMicroprocesador.MaxLength = 50;
            this.txtMicroprocesador.Name = "txtMicroprocesador";
            this.txtMicroprocesador.Size = new System.Drawing.Size(158, 22);
            this.txtMicroprocesador.TabIndex = 8;
            // 
            // txtAlmacenamiento
            // 
            this.txtAlmacenamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlmacenamiento.Location = new System.Drawing.Point(349, 210);
            this.txtAlmacenamiento.MaxLength = 50;
            this.txtAlmacenamiento.Name = "txtAlmacenamiento";
            this.txtAlmacenamiento.Size = new System.Drawing.Size(161, 22);
            this.txtAlmacenamiento.TabIndex = 9;
            // 
            // txtCdDvd
            // 
            this.txtCdDvd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCdDvd.Location = new System.Drawing.Point(12, 274);
            this.txtCdDvd.MaxLength = 50;
            this.txtCdDvd.Name = "txtCdDvd";
            this.txtCdDvd.Size = new System.Drawing.Size(167, 22);
            this.txtCdDvd.TabIndex = 10;
            // 
            // txtFuente
            // 
            this.txtFuente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFuente.Location = new System.Drawing.Point(185, 274);
            this.txtFuente.MaxLength = 50;
            this.txtFuente.Name = "txtFuente";
            this.txtFuente.Size = new System.Drawing.Size(158, 22);
            this.txtFuente.TabIndex = 11;
            // 
            // txtAdicionales
            // 
            this.txtAdicionales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdicionales.Location = new System.Drawing.Point(349, 274);
            this.txtAdicionales.MaxLength = 50;
            this.txtAdicionales.Name = "txtAdicionales";
            this.txtAdicionales.Size = new System.Drawing.Size(161, 22);
            this.txtAdicionales.TabIndex = 12;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(343, 335);
            this.txtDescripcion.MaxLength = 1000;
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(165, 138);
            this.txtDescripcion.TabIndex = 18;
            // 
            // txtNumSerie
            // 
            this.txtNumSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumSerie.Location = new System.Drawing.Point(12, 335);
            this.txtNumSerie.MaxLength = 100;
            this.txtNumSerie.Name = "txtNumSerie";
            this.txtNumSerie.Size = new System.Drawing.Size(325, 22);
            this.txtNumSerie.TabIndex = 13;
            // 
            // txtCostoRepuestos
            // 
            this.txtCostoRepuestos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCostoRepuestos.Location = new System.Drawing.Point(12, 392);
            this.txtCostoRepuestos.MaxLength = 10;
            this.txtCostoRepuestos.Name = "txtCostoRepuestos";
            this.txtCostoRepuestos.Size = new System.Drawing.Size(158, 22);
            this.txtCostoRepuestos.TabIndex = 14;
            // 
            // txtCostoManoObra
            // 
            this.txtCostoManoObra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCostoManoObra.Location = new System.Drawing.Point(176, 392);
            this.txtCostoManoObra.MaxLength = 10;
            this.txtCostoManoObra.Name = "txtCostoManoObra";
            this.txtCostoManoObra.Size = new System.Drawing.Size(161, 22);
            this.txtCostoManoObra.TabIndex = 15;
            // 
            // txtCostoTerceros
            // 
            this.txtCostoTerceros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCostoTerceros.Location = new System.Drawing.Point(12, 451);
            this.txtCostoTerceros.MaxLength = 10;
            this.txtCostoTerceros.Name = "txtCostoTerceros";
            this.txtCostoTerceros.Size = new System.Drawing.Size(158, 22);
            this.txtCostoTerceros.TabIndex = 16;
            // 
            // txtFechaDevolucion
            // 
            this.txtFechaDevolucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaDevolucion.Location = new System.Drawing.Point(176, 451);
            this.txtFechaDevolucion.MaxLength = 10;
            this.txtFechaDevolucion.Name = "txtFechaDevolucion";
            this.txtFechaDevolucion.Size = new System.Drawing.Size(161, 22);
            this.txtFechaDevolucion.TabIndex = 17;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(9, 72);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(49, 16);
            this.lblCliente.TabIndex = 22;
            this.lblCliente.Text = "Cliente";
            // 
            // lblFechaRecepcion
            // 
            this.lblFechaRecepcion.AutoSize = true;
            this.lblFechaRecepcion.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaRecepcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaRecepcion.Location = new System.Drawing.Point(240, 74);
            this.lblFechaRecepcion.Name = "lblFechaRecepcion";
            this.lblFechaRecepcion.Size = new System.Drawing.Size(87, 13);
            this.lblFechaRecepcion.TabIndex = 23;
            this.lblFechaRecepcion.Text = "Fecha recepción";
            // 
            // lblRam
            // 
            this.lblRam.AutoSize = true;
            this.lblRam.BackColor = System.Drawing.Color.Transparent;
            this.lblRam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRam.Location = new System.Drawing.Point(138, 130);
            this.lblRam.Name = "lblRam";
            this.lblRam.Size = new System.Drawing.Size(68, 16);
            this.lblRam.TabIndex = 24;
            this.lblRam.Text = "RAM (GB)";
            // 
            // lblTipoServicio
            // 
            this.lblTipoServicio.AutoSize = true;
            this.lblTipoServicio.BackColor = System.Drawing.Color.Transparent;
            this.lblTipoServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoServicio.Location = new System.Drawing.Point(347, 74);
            this.lblTipoServicio.Name = "lblTipoServicio";
            this.lblTipoServicio.Size = new System.Drawing.Size(85, 13);
            this.lblTipoServicio.TabIndex = 25;
            this.lblTipoServicio.Text = "Tipo de  servicio";
            // 
            // lblTipoEquipo
            // 
            this.lblTipoEquipo.AutoSize = true;
            this.lblTipoEquipo.BackColor = System.Drawing.Color.Transparent;
            this.lblTipoEquipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoEquipo.Location = new System.Drawing.Point(9, 130);
            this.lblTipoEquipo.Name = "lblTipoEquipo";
            this.lblTipoEquipo.Size = new System.Drawing.Size(100, 16);
            this.lblTipoEquipo.TabIndex = 26;
            this.lblTipoEquipo.Text = "Tipo de equipo";
            // 
            // lblPlacaMadre
            // 
            this.lblPlacaMadre.AutoSize = true;
            this.lblPlacaMadre.BackColor = System.Drawing.Color.Transparent;
            this.lblPlacaMadre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlacaMadre.Location = new System.Drawing.Point(265, 130);
            this.lblPlacaMadre.Name = "lblPlacaMadre";
            this.lblPlacaMadre.Size = new System.Drawing.Size(85, 16);
            this.lblPlacaMadre.TabIndex = 27;
            this.lblPlacaMadre.Text = "Placa madre";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.BackColor = System.Drawing.Color.Transparent;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(9, 191);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(105, 16);
            this.lblMarca.TabIndex = 28;
            this.lblMarca.Text = "Marca y modelo";
            // 
            // lblMicroProcesador
            // 
            this.lblMicroProcesador.AutoSize = true;
            this.lblMicroProcesador.BackColor = System.Drawing.Color.Transparent;
            this.lblMicroProcesador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMicroProcesador.Location = new System.Drawing.Point(182, 191);
            this.lblMicroProcesador.Name = "lblMicroProcesador";
            this.lblMicroProcesador.Size = new System.Drawing.Size(111, 16);
            this.lblMicroProcesador.TabIndex = 29;
            this.lblMicroProcesador.Text = "Microprocesador";
            // 
            // lblAlmacenamiento
            // 
            this.lblAlmacenamiento.AutoSize = true;
            this.lblAlmacenamiento.BackColor = System.Drawing.Color.Transparent;
            this.lblAlmacenamiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlmacenamiento.Location = new System.Drawing.Point(346, 191);
            this.lblAlmacenamiento.Name = "lblAlmacenamiento";
            this.lblAlmacenamiento.Size = new System.Drawing.Size(109, 16);
            this.lblAlmacenamiento.TabIndex = 30;
            this.lblAlmacenamiento.Text = "Almacenamiento";
            // 
            // lblCdDvd
            // 
            this.lblCdDvd.AutoSize = true;
            this.lblCdDvd.BackColor = System.Drawing.Color.Transparent;
            this.lblCdDvd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCdDvd.Location = new System.Drawing.Point(9, 255);
            this.lblCdDvd.Name = "lblCdDvd";
            this.lblCdDvd.Size = new System.Drawing.Size(66, 16);
            this.lblCdDvd.TabIndex = 31;
            this.lblCdDvd.Text = "CD / DVD";
            // 
            // lblFuente
            // 
            this.lblFuente.AutoSize = true;
            this.lblFuente.BackColor = System.Drawing.Color.Transparent;
            this.lblFuente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuente.Location = new System.Drawing.Point(182, 255);
            this.lblFuente.Name = "lblFuente";
            this.lblFuente.Size = new System.Drawing.Size(49, 16);
            this.lblFuente.TabIndex = 32;
            this.lblFuente.Text = "Fuente";
            // 
            // lblAdicionales
            // 
            this.lblAdicionales.AutoSize = true;
            this.lblAdicionales.BackColor = System.Drawing.Color.Transparent;
            this.lblAdicionales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdicionales.Location = new System.Drawing.Point(346, 255);
            this.lblAdicionales.Name = "lblAdicionales";
            this.lblAdicionales.Size = new System.Drawing.Size(79, 16);
            this.lblAdicionales.TabIndex = 33;
            this.lblAdicionales.Text = "Adicionales";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.BackColor = System.Drawing.Color.Transparent;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(338, 316);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(80, 16);
            this.lblDescripcion.TabIndex = 34;
            this.lblDescripcion.Text = "Descripción";
            // 
            // lblNumSerie
            // 
            this.lblNumSerie.AutoSize = true;
            this.lblNumSerie.BackColor = System.Drawing.Color.Transparent;
            this.lblNumSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumSerie.Location = new System.Drawing.Point(9, 316);
            this.lblNumSerie.Name = "lblNumSerie";
            this.lblNumSerie.Size = new System.Drawing.Size(57, 16);
            this.lblNumSerie.TabIndex = 35;
            this.lblNumSerie.Text = "N° Serie";
            // 
            // lblCostoRepuestos
            // 
            this.lblCostoRepuestos.AutoSize = true;
            this.lblCostoRepuestos.BackColor = System.Drawing.Color.Transparent;
            this.lblCostoRepuestos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostoRepuestos.Location = new System.Drawing.Point(9, 373);
            this.lblCostoRepuestos.Name = "lblCostoRepuestos";
            this.lblCostoRepuestos.Size = new System.Drawing.Size(112, 16);
            this.lblCostoRepuestos.TabIndex = 36;
            this.lblCostoRepuestos.Text = "Costo Repuestos";
            // 
            // lblManoObra
            // 
            this.lblManoObra.AutoSize = true;
            this.lblManoObra.BackColor = System.Drawing.Color.Transparent;
            this.lblManoObra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManoObra.Location = new System.Drawing.Point(173, 373);
            this.lblManoObra.Name = "lblManoObra";
            this.lblManoObra.Size = new System.Drawing.Size(92, 16);
            this.lblManoObra.TabIndex = 37;
            this.lblManoObra.Text = "Mano de obra";
            // 
            // lblCostoTerceros
            // 
            this.lblCostoTerceros.AutoSize = true;
            this.lblCostoTerceros.BackColor = System.Drawing.Color.Transparent;
            this.lblCostoTerceros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostoTerceros.Location = new System.Drawing.Point(9, 432);
            this.lblCostoTerceros.Name = "lblCostoTerceros";
            this.lblCostoTerceros.Size = new System.Drawing.Size(95, 16);
            this.lblCostoTerceros.TabIndex = 38;
            this.lblCostoTerceros.Text = "Costo terceros";
            // 
            // lblFechaDevolucion
            // 
            this.lblFechaDevolucion.AutoSize = true;
            this.lblFechaDevolucion.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaDevolucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaDevolucion.Location = new System.Drawing.Point(173, 432);
            this.lblFechaDevolucion.Name = "lblFechaDevolucion";
            this.lblFechaDevolucion.Size = new System.Drawing.Size(115, 16);
            this.lblFechaDevolucion.TabIndex = 39;
            this.lblFechaDevolucion.Text = "Fecha devolución";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.YellowGreen;
            this.btnConfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnConfirmar.Location = new System.Drawing.Point(196, 499);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(138, 36);
            this.btnConfirmar.TabIndex = 19;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnBuscarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCliente.Location = new System.Drawing.Point(12, 25);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(194, 30);
            this.btnBuscarCliente.TabIndex = 0;
            this.btnBuscarCliente.Text = "Seleccionar Cliente";
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
            this.dgvClientes.BackgroundColor = System.Drawing.SystemColors.Control;
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
            this.dgvClientes.Location = new System.Drawing.Point(12, 74);
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
            this.dgvClientes.Size = new System.Drawing.Size(504, 471);
            this.dgvClientes.StandardTab = true;
            this.dgvClientes.TabIndex = 23;
            // 
            // txtBuscarCliente
            // 
            this.txtBuscarCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarCliente.Location = new System.Drawing.Point(310, 28);
            this.txtBuscarCliente.MaxLength = 50;
            this.txtBuscarCliente.Name = "txtBuscarCliente";
            this.txtBuscarCliente.Size = new System.Drawing.Size(206, 26);
            this.txtBuscarCliente.TabIndex = 22;
            this.txtBuscarCliente.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscarCliente_KeyUp);
            // 
            // lblBuscarCliente
            // 
            this.lblBuscarCliente.AutoSize = true;
            this.lblBuscarCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblBuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarCliente.Location = new System.Drawing.Point(259, 30);
            this.lblBuscarCliente.Name = "lblBuscarCliente";
            this.lblBuscarCliente.Size = new System.Drawing.Size(50, 20);
            this.lblBuscarCliente.TabIndex = 42;
            this.lblBuscarCliente.Text = "Filtro";
            // 
            // AgregarOrden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CompuGross.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(528, 557);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.lblBuscarCliente);
            this.Controls.Add(this.txtBuscarCliente);
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
            this.Controls.Add(this.txtFechaDevolucion);
            this.Controls.Add(this.txtCostoTerceros);
            this.Controls.Add(this.txtCostoManoObra);
            this.Controls.Add(this.txtCostoRepuestos);
            this.Controls.Add(this.txtNumSerie);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtAdicionales);
            this.Controls.Add(this.txtFuente);
            this.Controls.Add(this.txtCdDvd);
            this.Controls.Add(this.txtAlmacenamiento);
            this.Controls.Add(this.txtMicroprocesador);
            this.Controls.Add(this.txtMarcaModelo);
            this.Controls.Add(this.txtPlacaMadre);
            this.Controls.Add(this.ddlTiposEquipo);
            this.Controls.Add(this.ddlTiposServicio);
            this.Controls.Add(this.txtRam);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.txtFechaRecepcion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AgregarOrden";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Orden";
            this.Load += new System.EventHandler(this.AgregarOrden_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtFechaRecepcion;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtRam;
        private System.Windows.Forms.ComboBox ddlTiposServicio;
        private System.Windows.Forms.ComboBox ddlTiposEquipo;
        private System.Windows.Forms.TextBox txtPlacaMadre;
        private System.Windows.Forms.TextBox txtMarcaModelo;
        private System.Windows.Forms.TextBox txtMicroprocesador;
        private System.Windows.Forms.TextBox txtAlmacenamiento;
        private System.Windows.Forms.TextBox txtCdDvd;
        private System.Windows.Forms.TextBox txtFuente;
        private System.Windows.Forms.TextBox txtAdicionales;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtNumSerie;
        private System.Windows.Forms.TextBox txtCostoRepuestos;
        private System.Windows.Forms.TextBox txtCostoManoObra;
        private System.Windows.Forms.TextBox txtCostoTerceros;
        private System.Windows.Forms.TextBox txtFechaDevolucion;
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
    }
}