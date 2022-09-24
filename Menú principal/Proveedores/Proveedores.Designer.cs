namespace CompuGross
{
    partial class Proveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Proveedores));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.navegadorProveedores = new System.Windows.Forms.WebBrowser();
            this.ddlSitiosProveedores = new System.Windows.Forms.ComboBox();
            this.lblSitiosWeb = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aBMProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAgregar = new System.Windows.Forms.ToolStripMenuItem();
            this.btnListar = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposDeProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCancelar = new System.Windows.Forms.ToolStripMenuItem();
            this.btnModificar = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSitiosProveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvProveedores = new System.Windows.Forms.DataGridView();
            this.lblFiltrar = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtSitioWeb = new System.Windows.Forms.TextBox();
            this.ddlTipoProveedor = new System.Windows.Forms.ComboBox();
            this.ddlEstado = new System.Windows.Forms.ComboBox();
            this.fechaAlta = new System.Windows.Forms.DateTimePicker();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblSitioWeb = new System.Windows.Forms.Label();
            this.lblFechaAlta = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // navegadorProveedores
            // 
            this.navegadorProveedores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.navegadorProveedores.Location = new System.Drawing.Point(1, 117);
            this.navegadorProveedores.MinimumSize = new System.Drawing.Size(20, 20);
            this.navegadorProveedores.Name = "navegadorProveedores";
            this.navegadorProveedores.ScriptErrorsSuppressed = true;
            this.navegadorProveedores.Size = new System.Drawing.Size(644, 425);
            this.navegadorProveedores.TabIndex = 2;
            this.navegadorProveedores.Url = new System.Uri("", System.UriKind.Relative);
            this.navegadorProveedores.Visible = false;
            this.navegadorProveedores.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.navegadorProveedores_DocumentCompleted);
            // 
            // ddlSitiosProveedores
            // 
            this.ddlSitiosProveedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.ddlSitiosProveedores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlSitiosProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ddlSitiosProveedores.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlSitiosProveedores.ForeColor = System.Drawing.Color.White;
            this.ddlSitiosProveedores.FormattingEnabled = true;
            this.ddlSitiosProveedores.Items.AddRange(new object[] {
            "Seleccione..."});
            this.ddlSitiosProveedores.Location = new System.Drawing.Point(6, 89);
            this.ddlSitiosProveedores.Name = "ddlSitiosProveedores";
            this.ddlSitiosProveedores.Size = new System.Drawing.Size(118, 22);
            this.ddlSitiosProveedores.TabIndex = 0;
            this.ddlSitiosProveedores.SelectedIndexChanged += new System.EventHandler(this.ddlSitiosProveedores_SelectedIndexChanged);
            // 
            // lblSitiosWeb
            // 
            this.lblSitiosWeb.AutoSize = true;
            this.lblSitiosWeb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSitiosWeb.Location = new System.Drawing.Point(3, 70);
            this.lblSitiosWeb.Name = "lblSitiosWeb";
            this.lblSitiosWeb.Size = new System.Drawing.Size(92, 16);
            this.lblSitiosWeb.TabIndex = 2;
            this.lblSitiosWeb.Text = "Ir al sitio de:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(68, 28);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(512, 42);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Proveedores";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUrl
            // 
            this.txtUrl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.txtUrl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUrl.ForeColor = System.Drawing.Color.White;
            this.txtUrl.Location = new System.Drawing.Point(141, 89);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(405, 22);
            this.txtUrl.TabIndex = 1;
            this.txtUrl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUrl_KeyDown);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aBMProveedoresToolStripMenuItem,
            this.btnCancelar,
            this.btnModificar,
            this.btnEliminar,
            this.btnSitiosProveedores});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(647, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aBMProveedoresToolStripMenuItem
            // 
            this.aBMProveedoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAgregar,
            this.btnListar,
            this.tiposDeProveedorToolStripMenuItem});
            this.aBMProveedoresToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.aBMProveedoresToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aBMProveedoresToolStripMenuItem.Image")));
            this.aBMProveedoresToolStripMenuItem.Name = "aBMProveedoresToolStripMenuItem";
            this.aBMProveedoresToolStripMenuItem.Size = new System.Drawing.Size(126, 20);
            this.aBMProveedoresToolStripMenuItem.Text = "ABMProveedores";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(175, 22);
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnListar
            // 
            this.btnListar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnListar.ForeColor = System.Drawing.Color.White;
            this.btnListar.Image = ((System.Drawing.Image)(resources.GetObject("btnListar.Image")));
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(175, 22);
            this.btnListar.Text = "Listar";
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // tiposDeProveedorToolStripMenuItem
            // 
            this.tiposDeProveedorToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.tiposDeProveedorToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.tiposDeProveedorToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("tiposDeProveedorToolStripMenuItem.Image")));
            this.tiposDeProveedorToolStripMenuItem.Name = "tiposDeProveedorToolStripMenuItem";
            this.tiposDeProveedorToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.tiposDeProveedorToolStripMenuItem.Text = "Tipos de proveedor";
            // 
            // btnCancelar
            // 
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(81, 20);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
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
            // btnSitiosProveedores
            // 
            this.btnSitiosProveedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnSitiosProveedores.ForeColor = System.Drawing.Color.White;
            this.btnSitiosProveedores.Image = ((System.Drawing.Image)(resources.GetObject("btnSitiosProveedores.Image")));
            this.btnSitiosProveedores.Name = "btnSitiosProveedores";
            this.btnSitiosProveedores.Size = new System.Drawing.Size(147, 20);
            this.btnSitiosProveedores.Text = "Sitios de Proveedores";
            this.btnSitiosProveedores.Click += new System.EventHandler(this.btnSitiosProveedores_Click);
            // 
            // dgvProveedores
            // 
            this.dgvProveedores.AllowUserToAddRows = false;
            this.dgvProveedores.AllowUserToDeleteRows = false;
            this.dgvProveedores.AllowUserToOrderColumns = true;
            this.dgvProveedores.AllowUserToResizeColumns = false;
            this.dgvProveedores.AllowUserToResizeRows = false;
            this.dgvProveedores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvProveedores.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProveedores.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(60)))), ((int)(((byte)(82)))));
            this.dgvProveedores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProveedores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProveedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProveedores.ColumnHeadersHeight = 30;
            this.dgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProveedores.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProveedores.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProveedores.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvProveedores.EnableHeadersVisualStyles = false;
            this.dgvProveedores.Location = new System.Drawing.Point(0, 117);
            this.dgvProveedores.MultiSelect = false;
            this.dgvProveedores.Name = "dgvProveedores";
            this.dgvProveedores.ReadOnly = true;
            this.dgvProveedores.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProveedores.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProveedores.RowHeadersVisible = false;
            this.dgvProveedores.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvProveedores.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProveedores.ShowCellErrors = false;
            this.dgvProveedores.ShowCellToolTips = false;
            this.dgvProveedores.ShowEditingIcon = false;
            this.dgvProveedores.ShowRowErrors = false;
            this.dgvProveedores.Size = new System.Drawing.Size(645, 425);
            this.dgvProveedores.StandardTab = true;
            this.dgvProveedores.TabIndex = 5;
            this.dgvProveedores.Visible = false;
            // 
            // lblFiltrar
            // 
            this.lblFiltrar.AutoSize = true;
            this.lblFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltrar.Location = new System.Drawing.Point(70, 91);
            this.lblFiltrar.Name = "lblFiltrar";
            this.lblFiltrar.Size = new System.Drawing.Size(52, 18);
            this.lblFiltrar.TabIndex = 6;
            this.lblFiltrar.Text = "Filtrar";
            this.lblFiltrar.Visible = false;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.White;
            this.txtNombre.Location = new System.Drawing.Point(39, 107);
            this.txtNombre.MaxLength = 200;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(191, 22);
            this.txtNombre.TabIndex = 7;
            this.txtNombre.Visible = false;
            // 
            // txtMail
            // 
            this.txtMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.txtMail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMail.ForeColor = System.Drawing.Color.White;
            this.txtMail.Location = new System.Drawing.Point(285, 107);
            this.txtMail.MaxLength = 200;
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(227, 22);
            this.txtMail.TabIndex = 8;
            this.txtMail.Visible = false;
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.ForeColor = System.Drawing.Color.White;
            this.txtTelefono.Location = new System.Drawing.Point(39, 168);
            this.txtTelefono.MaxLength = 200;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(191, 22);
            this.txtTelefono.TabIndex = 9;
            this.txtTelefono.Visible = false;
            // 
            // txtSitioWeb
            // 
            this.txtSitioWeb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.txtSitioWeb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSitioWeb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSitioWeb.ForeColor = System.Drawing.Color.White;
            this.txtSitioWeb.Location = new System.Drawing.Point(39, 228);
            this.txtSitioWeb.MaxLength = 200;
            this.txtSitioWeb.Name = "txtSitioWeb";
            this.txtSitioWeb.Size = new System.Drawing.Size(473, 22);
            this.txtSitioWeb.TabIndex = 10;
            this.txtSitioWeb.Visible = false;
            // 
            // ddlTipoProveedor
            // 
            this.ddlTipoProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.ddlTipoProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ddlTipoProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlTipoProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ddlTipoProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlTipoProveedor.ForeColor = System.Drawing.Color.White;
            this.ddlTipoProveedor.FormattingEnabled = true;
            this.ddlTipoProveedor.Items.AddRange(new object[] {
            "Seleccione..."});
            this.ddlTipoProveedor.Location = new System.Drawing.Point(285, 168);
            this.ddlTipoProveedor.Name = "ddlTipoProveedor";
            this.ddlTipoProveedor.Size = new System.Drawing.Size(227, 24);
            this.ddlTipoProveedor.TabIndex = 11;
            this.ddlTipoProveedor.Visible = false;
            // 
            // ddlEstado
            // 
            this.ddlEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.ddlEstado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ddlEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ddlEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlEstado.ForeColor = System.Drawing.Color.White;
            this.ddlEstado.FormattingEnabled = true;
            this.ddlEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.ddlEstado.Location = new System.Drawing.Point(367, 282);
            this.ddlEstado.Name = "ddlEstado";
            this.ddlEstado.Size = new System.Drawing.Size(145, 24);
            this.ddlEstado.TabIndex = 12;
            this.ddlEstado.Visible = false;
            // 
            // fechaAlta
            // 
            this.fechaAlta.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaAlta.CustomFormat = "dd - MMMM - yyyy";
            this.fechaAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaAlta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaAlta.Location = new System.Drawing.Point(39, 282);
            this.fechaAlta.Name = "fechaAlta";
            this.fechaAlta.Size = new System.Drawing.Size(294, 24);
            this.fechaAlta.TabIndex = 13;
            this.fechaAlta.Visible = false;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(38, 86);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(68, 18);
            this.lblNombre.TabIndex = 14;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.Visible = false;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.BackColor = System.Drawing.Color.Transparent;
            this.lblMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMail.Location = new System.Drawing.Point(282, 86);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(39, 18);
            this.lblMail.TabIndex = 15;
            this.lblMail.Text = "Mail";
            this.lblMail.Visible = false;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.BackColor = System.Drawing.Color.Transparent;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(36, 147);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(74, 18);
            this.lblTelefono.TabIndex = 16;
            this.lblTelefono.Text = "Teléfono";
            this.lblTelefono.Visible = false;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.BackColor = System.Drawing.Color.Transparent;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(282, 147);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(147, 18);
            this.lblTipo.TabIndex = 17;
            this.lblTipo.Text = "Tipo de Proveedor";
            this.lblTipo.Visible = false;
            // 
            // lblSitioWeb
            // 
            this.lblSitioWeb.AutoSize = true;
            this.lblSitioWeb.BackColor = System.Drawing.Color.Transparent;
            this.lblSitioWeb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSitioWeb.Location = new System.Drawing.Point(38, 207);
            this.lblSitioWeb.Name = "lblSitioWeb";
            this.lblSitioWeb.Size = new System.Drawing.Size(77, 18);
            this.lblSitioWeb.TabIndex = 18;
            this.lblSitioWeb.Text = "Sitio web";
            this.lblSitioWeb.Visible = false;
            // 
            // lblFechaAlta
            // 
            this.lblFechaAlta.AutoSize = true;
            this.lblFechaAlta.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaAlta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaAlta.Location = new System.Drawing.Point(38, 261);
            this.lblFechaAlta.Name = "lblFechaAlta";
            this.lblFechaAlta.Size = new System.Drawing.Size(110, 18);
            this.lblFechaAlta.TabIndex = 19;
            this.lblFechaAlta.Text = "Fecha de Alta";
            this.lblFechaAlta.Visible = false;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.BackColor = System.Drawing.Color.Transparent;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(364, 261);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(61, 18);
            this.lblEstado.TabIndex = 20;
            this.lblEstado.Text = "Estado";
            this.lblEstado.Visible = false;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirmar.FlatAppearance.BorderSize = 0;
            this.btnConfirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirmar.Image")));
            this.btnConfirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmar.Location = new System.Drawing.Point(195, 321);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(138, 43);
            this.btnConfirmar.TabIndex = 21;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Visible = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(60)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(647, 544);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblFechaAlta);
            this.Controls.Add(this.lblSitioWeb);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.fechaAlta);
            this.Controls.Add(this.ddlEstado);
            this.Controls.Add(this.ddlTipoProveedor);
            this.Controls.Add(this.txtSitioWeb);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblFiltrar);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblSitiosWeb);
            this.Controls.Add(this.ddlSitiosProveedores);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dgvProveedores);
            this.Controls.Add(this.navegadorProveedores);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Proveedores";
            this.Text = "Proveedores";
            this.Load += new System.EventHandler(this.Proveedores_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser navegadorProveedores;
        private System.Windows.Forms.ComboBox ddlSitiosProveedores;
        private System.Windows.Forms.Label lblSitiosWeb;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aBMProveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnAgregar;
        private System.Windows.Forms.ToolStripMenuItem btnListar;
        private System.Windows.Forms.ToolStripMenuItem btnModificar;
        private System.Windows.Forms.ToolStripMenuItem btnEliminar;
        private System.Windows.Forms.ToolStripMenuItem btnCancelar;
        private System.Windows.Forms.ToolStripMenuItem tiposDeProveedorToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvProveedores;
        private System.Windows.Forms.Label lblFiltrar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtSitioWeb;
        private System.Windows.Forms.ComboBox ddlTipoProveedor;
        private System.Windows.Forms.ComboBox ddlEstado;
        private System.Windows.Forms.DateTimePicker fechaAlta;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblSitioWeb;
        private System.Windows.Forms.Label lblFechaAlta;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.ToolStripMenuItem btnSitiosProveedores;
    }
}