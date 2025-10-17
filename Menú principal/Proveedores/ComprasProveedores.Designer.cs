namespace CompuGross.Menú_principal.Proveedores
{
    partial class ComprasProveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComprasProveedores));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnAgregar = new System.Windows.Forms.ToolStripMenuItem();
            this.btnListar = new System.Windows.Forms.ToolStripMenuItem();
            this.btnModificar = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvComprasProveedores = new System.Windows.Forms.DataGridView();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtCodigoVerificacionArticulo = new System.Windows.Forms.TextBox();
            this.txtNumeroSerieArticulo = new System.Windows.Forms.TextBox();
            this.txtCodigoArticulo = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.lblCodigoArticulo = new System.Windows.Forms.Label();
            this.lblDescripcionArticulo = new System.Windows.Forms.Label();
            this.lblNumSerieArticulo = new System.Windows.Forms.Label();
            this.lblCodigoVerificacionArticulo = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.cbDevolucion = new System.Windows.Forms.ComboBox();
            this.txtDescripcionArticulo = new System.Windows.Forms.TextBox();
            this.lblDevolucion = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.btnSeleccionarProveedor = new System.Windows.Forms.PictureBox();
            this.btnSeleccionarCliente = new System.Windows.Forms.PictureBox();
            this.txtMontoAbonado = new System.Windows.Forms.TextBox();
            this.lblMontoAbonado = new System.Windows.Forms.Label();
            this.txtIdCompra = new System.Windows.Forms.TextBox();
            this.calendarFechaCompra = new System.Windows.Forms.DateTimePicker();
            this.lblFechaCompra = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComprasProveedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSeleccionarProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSeleccionarCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAgregar,
            this.btnListar,
            this.btnModificar,
            this.btnEliminar});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(647, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnAgregar
            // 
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(77, 20);
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Visible = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnListar
            // 
            this.btnListar.ForeColor = System.Drawing.Color.White;
            this.btnListar.Image = ((System.Drawing.Image)(resources.GetObject("btnListar.Image")));
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(63, 20);
            this.btnListar.Text = "Listar";
            this.btnListar.Visible = false;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(86, 20);
            this.btnModificar.Text = "Modificar";
            this.btnModificar.Visible = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(78, 20);
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Visible = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dgvComprasProveedores
            // 
            this.dgvComprasProveedores.AllowUserToAddRows = false;
            this.dgvComprasProveedores.AllowUserToDeleteRows = false;
            this.dgvComprasProveedores.AllowUserToResizeColumns = false;
            this.dgvComprasProveedores.AllowUserToResizeRows = false;
            this.dgvComprasProveedores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvComprasProveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvComprasProveedores.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvComprasProveedores.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.dgvComprasProveedores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvComprasProveedores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvComprasProveedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvComprasProveedores.ColumnHeadersHeight = 30;
            this.dgvComprasProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvComprasProveedores.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvComprasProveedores.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvComprasProveedores.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvComprasProveedores.EnableHeadersVisualStyles = false;
            this.dgvComprasProveedores.Location = new System.Drawing.Point(0, 81);
            this.dgvComprasProveedores.MultiSelect = false;
            this.dgvComprasProveedores.Name = "dgvComprasProveedores";
            this.dgvComprasProveedores.ReadOnly = true;
            this.dgvComprasProveedores.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvComprasProveedores.RowHeadersVisible = false;
            this.dgvComprasProveedores.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvComprasProveedores.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvComprasProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvComprasProveedores.ShowCellErrors = false;
            this.dgvComprasProveedores.ShowCellToolTips = false;
            this.dgvComprasProveedores.ShowEditingIcon = false;
            this.dgvComprasProveedores.ShowRowErrors = false;
            this.dgvComprasProveedores.Size = new System.Drawing.Size(647, 276);
            this.dgvComprasProveedores.StandardTab = true;
            this.dgvComprasProveedores.TabIndex = 6;
            this.dgvComprasProveedores.Visible = false;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitle.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(133, 37);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(365, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "COMPRAS PROVEEDORES";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCodigoVerificacionArticulo
            // 
            this.txtCodigoVerificacionArticulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.txtCodigoVerificacionArticulo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodigoVerificacionArticulo.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoVerificacionArticulo.ForeColor = System.Drawing.Color.White;
            this.txtCodigoVerificacionArticulo.Location = new System.Drawing.Point(243, 222);
            this.txtCodigoVerificacionArticulo.MaxLength = 20;
            this.txtCodigoVerificacionArticulo.Name = "txtCodigoVerificacionArticulo";
            this.txtCodigoVerificacionArticulo.Size = new System.Drawing.Size(187, 24);
            this.txtCodigoVerificacionArticulo.TabIndex = 6;
            this.txtCodigoVerificacionArticulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCodigoVerificacionArticulo.Visible = false;
            // 
            // txtNumeroSerieArticulo
            // 
            this.txtNumeroSerieArticulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.txtNumeroSerieArticulo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumeroSerieArticulo.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroSerieArticulo.ForeColor = System.Drawing.Color.White;
            this.txtNumeroSerieArticulo.Location = new System.Drawing.Point(36, 222);
            this.txtNumeroSerieArticulo.MaxLength = 20;
            this.txtNumeroSerieArticulo.Name = "txtNumeroSerieArticulo";
            this.txtNumeroSerieArticulo.Size = new System.Drawing.Size(186, 24);
            this.txtNumeroSerieArticulo.TabIndex = 5;
            this.txtNumeroSerieArticulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNumeroSerieArticulo.Visible = false;
            // 
            // txtCodigoArticulo
            // 
            this.txtCodigoArticulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.txtCodigoArticulo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodigoArticulo.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoArticulo.ForeColor = System.Drawing.Color.White;
            this.txtCodigoArticulo.Location = new System.Drawing.Point(33, 165);
            this.txtCodigoArticulo.MaxLength = 20;
            this.txtCodigoArticulo.Name = "txtCodigoArticulo";
            this.txtCodigoArticulo.Size = new System.Drawing.Size(189, 24);
            this.txtCodigoArticulo.TabIndex = 3;
            this.txtCodigoArticulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCodigoArticulo.Visible = false;
            // 
            // txtCliente
            // 
            this.txtCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.txtCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCliente.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.ForeColor = System.Drawing.Color.White;
            this.txtCliente.Location = new System.Drawing.Point(243, 111);
            this.txtCliente.MaxLength = 50;
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(187, 24);
            this.txtCliente.TabIndex = 2;
            this.txtCliente.Visible = false;
            this.txtCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCliente_KeyDown);
            // 
            // txtProveedor
            // 
            this.txtProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.txtProveedor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProveedor.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProveedor.ForeColor = System.Drawing.Color.White;
            this.txtProveedor.Location = new System.Drawing.Point(33, 110);
            this.txtProveedor.MaxLength = 50;
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Size = new System.Drawing.Size(189, 24);
            this.txtProveedor.TabIndex = 1;
            this.txtProveedor.Visible = false;
            this.txtProveedor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProveedor_KeyDown);
            // 
            // lblCodigoArticulo
            // 
            this.lblCodigoArticulo.AutoSize = true;
            this.lblCodigoArticulo.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoArticulo.ForeColor = System.Drawing.Color.White;
            this.lblCodigoArticulo.Location = new System.Drawing.Point(59, 144);
            this.lblCodigoArticulo.Name = "lblCodigoArticulo";
            this.lblCodigoArticulo.Size = new System.Drawing.Size(129, 17);
            this.lblCodigoArticulo.TabIndex = 31;
            this.lblCodigoArticulo.Text = "Código Artículo";
            this.lblCodigoArticulo.Visible = false;
            // 
            // lblDescripcionArticulo
            // 
            this.lblDescripcionArticulo.AutoSize = true;
            this.lblDescripcionArticulo.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionArticulo.ForeColor = System.Drawing.Color.White;
            this.lblDescripcionArticulo.Location = new System.Drawing.Point(256, 144);
            this.lblDescripcionArticulo.Name = "lblDescripcionArticulo";
            this.lblDescripcionArticulo.Size = new System.Drawing.Size(164, 17);
            this.lblDescripcionArticulo.TabIndex = 30;
            this.lblDescripcionArticulo.Text = "Descripción Artículo";
            this.lblDescripcionArticulo.Visible = false;
            // 
            // lblNumSerieArticulo
            // 
            this.lblNumSerieArticulo.AutoSize = true;
            this.lblNumSerieArticulo.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumSerieArticulo.ForeColor = System.Drawing.Color.White;
            this.lblNumSerieArticulo.Location = new System.Drawing.Point(52, 202);
            this.lblNumSerieArticulo.Name = "lblNumSerieArticulo";
            this.lblNumSerieArticulo.Size = new System.Drawing.Size(149, 17);
            this.lblNumSerieArticulo.TabIndex = 29;
            this.lblNumSerieArticulo.Text = "Núm. Serie Artículo";
            this.lblNumSerieArticulo.Visible = false;
            // 
            // lblCodigoVerificacionArticulo
            // 
            this.lblCodigoVerificacionArticulo.AutoSize = true;
            this.lblCodigoVerificacionArticulo.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoVerificacionArticulo.ForeColor = System.Drawing.Color.White;
            this.lblCodigoVerificacionArticulo.Location = new System.Drawing.Point(262, 202);
            this.lblCodigoVerificacionArticulo.Name = "lblCodigoVerificacionArticulo";
            this.lblCodigoVerificacionArticulo.Size = new System.Drawing.Size(152, 17);
            this.lblCodigoVerificacionArticulo.TabIndex = 28;
            this.lblCodigoVerificacionArticulo.Text = "Cód. Verif. Artículo";
            this.lblCodigoVerificacionArticulo.Visible = false;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.ForeColor = System.Drawing.Color.White;
            this.lblCliente.Location = new System.Drawing.Point(308, 87);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(60, 17);
            this.lblCliente.TabIndex = 27;
            this.lblCliente.Text = "Cliente";
            this.lblCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCliente.Visible = false;
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProveedor.ForeColor = System.Drawing.Color.White;
            this.lblProveedor.Location = new System.Drawing.Point(86, 87);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(87, 17);
            this.lblProveedor.TabIndex = 26;
            this.lblProveedor.Text = "Proveedor";
            this.lblProveedor.Visible = false;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.AutoSize = true;
            this.btnConfirmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnConfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmar.FlatAppearance.BorderSize = 0;
            this.btnConfirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.ForeColor = System.Drawing.Color.White;
            this.btnConfirmar.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirmar.Image")));
            this.btnConfirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmar.Location = new System.Drawing.Point(305, 312);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(125, 36);
            this.btnConfirmar.TabIndex = 11;
            this.btnConfirmar.Text = "CONFIRMAR";
            this.btnConfirmar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Visible = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // cbDevolucion
            // 
            this.cbDevolucion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.cbDevolucion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbDevolucion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDevolucion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbDevolucion.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDevolucion.ForeColor = System.Drawing.Color.White;
            this.cbDevolucion.FormattingEnabled = true;
            this.cbDevolucion.Items.AddRange(new object[] {
            "No",
            "Si"});
            this.cbDevolucion.Location = new System.Drawing.Point(246, 275);
            this.cbDevolucion.Name = "cbDevolucion";
            this.cbDevolucion.Size = new System.Drawing.Size(79, 27);
            this.cbDevolucion.TabIndex = 8;
            this.cbDevolucion.Visible = false;
            // 
            // txtDescripcionArticulo
            // 
            this.txtDescripcionArticulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.txtDescripcionArticulo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescripcionArticulo.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionArticulo.ForeColor = System.Drawing.Color.White;
            this.txtDescripcionArticulo.Location = new System.Drawing.Point(243, 165);
            this.txtDescripcionArticulo.MaxLength = 400;
            this.txtDescripcionArticulo.Name = "txtDescripcionArticulo";
            this.txtDescripcionArticulo.Size = new System.Drawing.Size(187, 24);
            this.txtDescripcionArticulo.TabIndex = 4;
            this.txtDescripcionArticulo.Visible = false;
            // 
            // lblDevolucion
            // 
            this.lblDevolucion.AutoSize = true;
            this.lblDevolucion.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDevolucion.ForeColor = System.Drawing.Color.White;
            this.lblDevolucion.Location = new System.Drawing.Point(240, 253);
            this.lblDevolucion.Name = "lblDevolucion";
            this.lblDevolucion.Size = new System.Drawing.Size(92, 17);
            this.lblDevolucion.TabIndex = 36;
            this.lblDevolucion.Text = "Devolución";
            this.lblDevolucion.Visible = false;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.White;
            this.lblEstado.Location = new System.Drawing.Point(361, 253);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(59, 17);
            this.lblEstado.TabIndex = 38;
            this.lblEstado.Text = "Estado";
            this.lblEstado.Visible = false;
            // 
            // cbEstado
            // 
            this.cbEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.cbEstado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbEstado.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstado.ForeColor = System.Drawing.Color.White;
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cbEstado.Location = new System.Drawing.Point(348, 275);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(84, 27);
            this.cbEstado.TabIndex = 9;
            this.cbEstado.Visible = false;
            // 
            // btnSeleccionarProveedor
            // 
            this.btnSeleccionarProveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSeleccionarProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeleccionarProveedor.Image = ((System.Drawing.Image)(resources.GetObject("btnSeleccionarProveedor.Image")));
            this.btnSeleccionarProveedor.Location = new System.Drawing.Point(55, 85);
            this.btnSeleccionarProveedor.MaximumSize = new System.Drawing.Size(25, 25);
            this.btnSeleccionarProveedor.MinimumSize = new System.Drawing.Size(25, 25);
            this.btnSeleccionarProveedor.Name = "btnSeleccionarProveedor";
            this.btnSeleccionarProveedor.Size = new System.Drawing.Size(25, 25);
            this.btnSeleccionarProveedor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSeleccionarProveedor.TabIndex = 39;
            this.btnSeleccionarProveedor.TabStop = false;
            this.btnSeleccionarProveedor.Visible = false;
            this.btnSeleccionarProveedor.Click += new System.EventHandler(this.btnSeleccionarProveedor_Click);
            // 
            // btnSeleccionarCliente
            // 
            this.btnSeleccionarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSeleccionarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeleccionarCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnSeleccionarCliente.Image")));
            this.btnSeleccionarCliente.Location = new System.Drawing.Point(277, 85);
            this.btnSeleccionarCliente.MaximumSize = new System.Drawing.Size(25, 25);
            this.btnSeleccionarCliente.MinimumSize = new System.Drawing.Size(25, 25);
            this.btnSeleccionarCliente.Name = "btnSeleccionarCliente";
            this.btnSeleccionarCliente.Size = new System.Drawing.Size(25, 25);
            this.btnSeleccionarCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSeleccionarCliente.TabIndex = 40;
            this.btnSeleccionarCliente.TabStop = false;
            this.btnSeleccionarCliente.Visible = false;
            this.btnSeleccionarCliente.Click += new System.EventHandler(this.btnSeleccionarCliente_Click);
            // 
            // txtMontoAbonado
            // 
            this.txtMontoAbonado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.txtMontoAbonado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMontoAbonado.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoAbonado.ForeColor = System.Drawing.Color.White;
            this.txtMontoAbonado.Location = new System.Drawing.Point(36, 277);
            this.txtMontoAbonado.MaxLength = 20;
            this.txtMontoAbonado.Name = "txtMontoAbonado";
            this.txtMontoAbonado.Size = new System.Drawing.Size(187, 24);
            this.txtMontoAbonado.TabIndex = 7;
            this.txtMontoAbonado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMontoAbonado.Visible = false;
            // 
            // lblMontoAbonado
            // 
            this.lblMontoAbonado.AutoSize = true;
            this.lblMontoAbonado.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoAbonado.ForeColor = System.Drawing.Color.White;
            this.lblMontoAbonado.Location = new System.Drawing.Point(86, 257);
            this.lblMontoAbonado.Name = "lblMontoAbonado";
            this.lblMontoAbonado.Size = new System.Drawing.Size(81, 17);
            this.lblMontoAbonado.TabIndex = 42;
            this.lblMontoAbonado.Text = "$ Abonado";
            this.lblMontoAbonado.Visible = false;
            // 
            // txtIdCompra
            // 
            this.txtIdCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.txtIdCompra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdCompra.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdCompra.ForeColor = System.Drawing.Color.White;
            this.txtIdCompra.Location = new System.Drawing.Point(12, 37);
            this.txtIdCompra.MaxLength = 50;
            this.txtIdCompra.Name = "txtIdCompra";
            this.txtIdCompra.Size = new System.Drawing.Size(115, 24);
            this.txtIdCompra.TabIndex = 43;
            this.txtIdCompra.Visible = false;
            // 
            // calendarFechaCompra
            // 
            this.calendarFechaCompra.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calendarFechaCompra.CalendarForeColor = System.Drawing.Color.White;
            this.calendarFechaCompra.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.calendarFechaCompra.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.calendarFechaCompra.CalendarTitleForeColor = System.Drawing.Color.White;
            this.calendarFechaCompra.CalendarTrailingForeColor = System.Drawing.Color.White;
            this.calendarFechaCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calendarFechaCompra.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calendarFechaCompra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.calendarFechaCompra.Location = new System.Drawing.Point(37, 326);
            this.calendarFechaCompra.MinDate = new System.DateTime(2017, 1, 1, 0, 0, 0, 0);
            this.calendarFechaCompra.Name = "calendarFechaCompra";
            this.calendarFechaCompra.Size = new System.Drawing.Size(186, 22);
            this.calendarFechaCompra.TabIndex = 10;
            this.calendarFechaCompra.Visible = false;
            // 
            // lblFechaCompra
            // 
            this.lblFechaCompra.AutoSize = true;
            this.lblFechaCompra.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaCompra.ForeColor = System.Drawing.Color.White;
            this.lblFechaCompra.Location = new System.Drawing.Point(74, 306);
            this.lblFechaCompra.Name = "lblFechaCompra";
            this.lblFechaCompra.Size = new System.Drawing.Size(106, 17);
            this.lblFechaCompra.TabIndex = 45;
            this.lblFechaCompra.Text = "Fecha Compra";
            this.lblFechaCompra.Visible = false;
            // 
            // ComprasProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(60)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(647, 544);
            this.Controls.Add(this.lblFechaCompra);
            this.Controls.Add(this.calendarFechaCompra);
            this.Controls.Add(this.txtIdCompra);
            this.Controls.Add(this.txtMontoAbonado);
            this.Controls.Add(this.lblMontoAbonado);
            this.Controls.Add(this.btnSeleccionarCliente);
            this.Controls.Add(this.btnSeleccionarProveedor);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.lblDevolucion);
            this.Controls.Add(this.txtDescripcionArticulo);
            this.Controls.Add(this.cbDevolucion);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.txtCodigoVerificacionArticulo);
            this.Controls.Add(this.txtNumeroSerieArticulo);
            this.Controls.Add(this.txtCodigoArticulo);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.txtProveedor);
            this.Controls.Add(this.lblCodigoArticulo);
            this.Controls.Add(this.lblDescripcionArticulo);
            this.Controls.Add(this.lblNumSerieArticulo);
            this.Controls.Add(this.lblCodigoVerificacionArticulo);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblProveedor);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dgvComprasProveedores);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ComprasProveedores";
            this.Text = "ComprasProveedores";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComprasProveedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSeleccionarProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSeleccionarCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnAgregar;
        private System.Windows.Forms.ToolStripMenuItem btnListar;
        private System.Windows.Forms.ToolStripMenuItem btnModificar;
        private System.Windows.Forms.ToolStripMenuItem btnEliminar;
        private System.Windows.Forms.DataGridView dgvComprasProveedores;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtCodigoVerificacionArticulo;
        private System.Windows.Forms.TextBox txtNumeroSerieArticulo;
        private System.Windows.Forms.TextBox txtCodigoArticulo;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtProveedor;
        private System.Windows.Forms.Label lblCodigoArticulo;
        private System.Windows.Forms.Label lblDescripcionArticulo;
        private System.Windows.Forms.Label lblNumSerieArticulo;
        private System.Windows.Forms.Label lblCodigoVerificacionArticulo;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.ComboBox cbDevolucion;
        private System.Windows.Forms.TextBox txtDescripcionArticulo;
        private System.Windows.Forms.Label lblDevolucion;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.PictureBox btnSeleccionarProveedor;
        private System.Windows.Forms.PictureBox btnSeleccionarCliente;
        private System.Windows.Forms.TextBox txtMontoAbonado;
        private System.Windows.Forms.Label lblMontoAbonado;
        private System.Windows.Forms.TextBox txtIdCompra;
        private System.Windows.Forms.DateTimePicker calendarFechaCompra;
        private System.Windows.Forms.Label lblFechaCompra;
    }
}