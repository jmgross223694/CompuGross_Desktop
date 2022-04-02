
namespace CompuGross
{
    partial class Clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clientes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.compuGrossDataSet = new CompuGross.CompuGrossDataSet();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientesTableAdapter = new CompuGross.CompuGrossDataSetTableAdapters.ClientesTableAdapter();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnMenuModificar = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCancelar = new System.Windows.Forms.ToolStripMenuItem();
            this.lblCantidadClientes = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblNombres = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.lblDirección = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.ddlLocalidades = new System.Windows.Forms.ComboBox();
            this.lblAsteriscoNombres = new System.Windows.Forms.Label();
            this.lblAsteriscoTelefono = new System.Windows.Forms.Label();
            this.lblCamposObligatorios = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.lblMailValido = new System.Windows.Forms.Label();
            this.lblMailInvalido = new System.Windows.Forms.Label();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.btnModificar = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExportar = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExcel = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.compuGrossDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // compuGrossDataSet
            // 
            this.compuGrossDataSet.DataSetName = "CompuGrossDataSet";
            this.compuGrossDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.compuGrossDataSet;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // txtFiltro
            // 
            this.txtFiltro.AcceptsReturn = true;
            this.txtFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFiltro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.txtFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltro.ForeColor = System.Drawing.Color.White;
            this.txtFiltro.Location = new System.Drawing.Point(39, 61);
            this.txtFiltro.MaxLength = 200;
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(517, 26);
            this.txtFiltro.TabIndex = 0;
            this.txtFiltro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFiltro_KeyDown);
            this.txtFiltro.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFiltro_KeyUp);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(5, 60);
            this.btnBuscar.MaximumSize = new System.Drawing.Size(25, 25);
            this.btnBuscar.MinimumSize = new System.Drawing.Size(25, 25);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(25, 25);
            this.btnBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.TabStop = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMenuModificar,
            this.btnCancelar,
            this.btnExportar});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(568, 28);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnMenuModificar
            // 
            this.btnMenuModificar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnModificar,
            this.btnEliminar});
            this.btnMenuModificar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuModificar.ForeColor = System.Drawing.Color.White;
            this.btnMenuModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnMenuModificar.Image")));
            this.btnMenuModificar.Name = "btnMenuModificar";
            this.btnMenuModificar.Size = new System.Drawing.Size(101, 24);
            this.btnMenuModificar.Text = "Modificar";
            this.btnMenuModificar.ToolTipText = "Modificar cliente";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(147, 24);
            this.btnCancelar.Text = "Cancelar edición";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.cancelarEdiciónToolStripMenuItem_Click);
            // 
            // lblCantidadClientes
            // 
            this.lblCantidadClientes.AutoSize = true;
            this.lblCantidadClientes.ForeColor = System.Drawing.Color.White;
            this.lblCantidadClientes.Location = new System.Drawing.Point(11, 93);
            this.lblCantidadClientes.Name = "lblCantidadClientes";
            this.lblCantidadClientes.Size = new System.Drawing.Size(55, 13);
            this.lblCantidadClientes.TabIndex = 11;
            this.lblCantidadClientes.Text = "Cantidad: ";
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitulo.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(12, 28);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(542, 30);
            this.lblTitulo.TabIndex = 12;
            this.lblTitulo.Text = "CLIENTES";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.ForeColor = System.Drawing.Color.White;
            this.lblDni.Location = new System.Drawing.Point(112, 91);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(76, 17);
            this.lblDni.TabIndex = 13;
            this.lblDni.Text = "cuit / dni";
            this.lblDni.Visible = false;
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombres.ForeColor = System.Drawing.Color.White;
            this.lblNombres.Location = new System.Drawing.Point(361, 90);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(141, 17);
            this.lblNombres.TabIndex = 14;
            this.lblNombres.Text = "apellido y nombre";
            this.lblNombres.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNombres.Visible = false;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMail.ForeColor = System.Drawing.Color.White;
            this.lblMail.Location = new System.Drawing.Point(401, 255);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(39, 17);
            this.lblMail.TabIndex = 16;
            this.lblMail.Text = "mail";
            this.lblMail.Visible = false;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.ForeColor = System.Drawing.Color.White;
            this.lblTelefono.Location = new System.Drawing.Point(109, 255);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(74, 17);
            this.lblTelefono.TabIndex = 17;
            this.lblTelefono.Text = "teléfono";
            this.lblTelefono.Visible = false;
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalidad.ForeColor = System.Drawing.Color.White;
            this.lblLocalidad.Location = new System.Drawing.Point(386, 167);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(81, 17);
            this.lblLocalidad.TabIndex = 18;
            this.lblLocalidad.Text = "localidad";
            this.lblLocalidad.Visible = false;
            // 
            // lblDirección
            // 
            this.lblDirección.AutoSize = true;
            this.lblDirección.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirección.ForeColor = System.Drawing.Color.White;
            this.lblDirección.Location = new System.Drawing.Point(109, 167);
            this.lblDirección.Name = "lblDirección";
            this.lblDirección.Size = new System.Drawing.Size(79, 17);
            this.lblDirección.TabIndex = 19;
            this.lblDirección.Text = "dirección";
            this.lblDirección.Visible = false;
            // 
            // txtDni
            // 
            this.txtDni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.txtDni.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDni.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDni.ForeColor = System.Drawing.Color.White;
            this.txtDni.Location = new System.Drawing.Point(12, 119);
            this.txtDni.MaxLength = 9;
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(254, 24);
            this.txtDni.TabIndex = 2;
            this.txtDni.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDni.Visible = false;
            this.txtDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDni_KeyPress);
            // 
            // txtNombres
            // 
            this.txtNombres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.txtNombres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombres.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombres.ForeColor = System.Drawing.Color.White;
            this.txtNombres.Location = new System.Drawing.Point(302, 119);
            this.txtNombres.MaxLength = 200;
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(252, 24);
            this.txtNombres.TabIndex = 3;
            this.txtNombres.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNombres.Visible = false;
            this.txtNombres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombres_KeyPress);
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDireccion.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.ForeColor = System.Drawing.Color.White;
            this.txtDireccion.Location = new System.Drawing.Point(12, 197);
            this.txtDireccion.MaxLength = 100;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(254, 24);
            this.txtDireccion.TabIndex = 4;
            this.txtDireccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDireccion.Visible = false;
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefono.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.ForeColor = System.Drawing.Color.White;
            this.txtTelefono.Location = new System.Drawing.Point(12, 285);
            this.txtTelefono.MaxLength = 50;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(254, 24);
            this.txtTelefono.TabIndex = 6;
            this.txtTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTelefono.Visible = false;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // txtMail
            // 
            this.txtMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.txtMail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtMail.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMail.ForeColor = System.Drawing.Color.White;
            this.txtMail.Location = new System.Drawing.Point(302, 285);
            this.txtMail.MaxLength = 100;
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(252, 24);
            this.txtMail.TabIndex = 7;
            this.txtMail.Visible = false;
            this.txtMail.TextChanged += new System.EventHandler(this.txtMail_TextChanged);
            this.txtMail.Enter += new System.EventHandler(this.txtMail_Enter);
            this.txtMail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMail_KeyPress);
            this.txtMail.Leave += new System.EventHandler(this.txtMail_Leave);
            // 
            // ddlLocalidades
            // 
            this.ddlLocalidades.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.ddlLocalidades.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ddlLocalidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlLocalidades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ddlLocalidades.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlLocalidades.ForeColor = System.Drawing.Color.White;
            this.ddlLocalidades.FormattingEnabled = true;
            this.ddlLocalidades.Location = new System.Drawing.Point(302, 194);
            this.ddlLocalidades.Name = "ddlLocalidades";
            this.ddlLocalidades.Size = new System.Drawing.Size(252, 27);
            this.ddlLocalidades.TabIndex = 5;
            this.ddlLocalidades.Visible = false;
            // 
            // lblAsteriscoNombres
            // 
            this.lblAsteriscoNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsteriscoNombres.ForeColor = System.Drawing.Color.LightCoral;
            this.lblAsteriscoNombres.Location = new System.Drawing.Point(350, 91);
            this.lblAsteriscoNombres.Name = "lblAsteriscoNombres";
            this.lblAsteriscoNombres.Size = new System.Drawing.Size(14, 23);
            this.lblAsteriscoNombres.TabIndex = 27;
            this.lblAsteriscoNombres.Text = "*";
            this.lblAsteriscoNombres.Visible = false;
            // 
            // lblAsteriscoTelefono
            // 
            this.lblAsteriscoTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsteriscoTelefono.ForeColor = System.Drawing.Color.LightCoral;
            this.lblAsteriscoTelefono.Location = new System.Drawing.Point(98, 255);
            this.lblAsteriscoTelefono.Name = "lblAsteriscoTelefono";
            this.lblAsteriscoTelefono.Size = new System.Drawing.Size(14, 23);
            this.lblAsteriscoTelefono.TabIndex = 28;
            this.lblAsteriscoTelefono.Text = "*";
            this.lblAsteriscoTelefono.Visible = false;
            // 
            // lblCamposObligatorios
            // 
            this.lblCamposObligatorios.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCamposObligatorios.ForeColor = System.Drawing.Color.LightCoral;
            this.lblCamposObligatorios.Location = new System.Drawing.Point(9, 355);
            this.lblCamposObligatorios.Name = "lblCamposObligatorios";
            this.lblCamposObligatorios.Size = new System.Drawing.Size(156, 23);
            this.lblCamposObligatorios.TabIndex = 29;
            this.lblCamposObligatorios.Text = "* Campos obligatorios";
            this.lblCamposObligatorios.Visible = false;
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
            this.btnConfirmar.Location = new System.Drawing.Point(429, 344);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(125, 36);
            this.btnConfirmar.TabIndex = 8;
            this.btnConfirmar.Text = "CONFIRMAR";
            this.btnConfirmar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Visible = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // lblMailValido
            // 
            this.lblMailValido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMailValido.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblMailValido.Location = new System.Drawing.Point(301, 310);
            this.lblMailValido.Name = "lblMailValido";
            this.lblMailValido.Size = new System.Drawing.Size(54, 16);
            this.lblMailValido.TabIndex = 31;
            this.lblMailValido.Text = "VÁLIDO";
            this.lblMailValido.Visible = false;
            // 
            // lblMailInvalido
            // 
            this.lblMailInvalido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMailInvalido.ForeColor = System.Drawing.Color.Red;
            this.lblMailInvalido.Location = new System.Drawing.Point(301, 310);
            this.lblMailInvalido.Name = "lblMailInvalido";
            this.lblMailInvalido.Size = new System.Drawing.Size(77, 16);
            this.lblMailInvalido.TabIndex = 32;
            this.lblMailInvalido.Text = "INVÁLIDO";
            this.lblMailInvalido.Visible = false;
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
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.dgvClientes.ColumnHeadersHeight = 30;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClientes.DefaultCellStyle = dataGridViewCellStyle23;
            this.dgvClientes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvClientes.EnableHeadersVisualStyles = false;
            this.dgvClientes.Location = new System.Drawing.Point(14, 111);
            this.dgvClientes.MultiSelect = false;
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvClientes.RowHeadersVisible = false;
            this.dgvClientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.White;
            this.dgvClientes.RowsDefaultCellStyle = dataGridViewCellStyle24;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.ShowCellErrors = false;
            this.dgvClientes.ShowCellToolTips = false;
            this.dgvClientes.ShowEditingIcon = false;
            this.dgvClientes.ShowRowErrors = false;
            this.dgvClientes.Size = new System.Drawing.Size(544, 382);
            this.dgvClientes.StandardTab = true;
            this.dgvClientes.TabIndex = 1;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(180, 24);
            this.btnModificar.Text = "Modificar";
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(180, 24);
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExcel});
            this.btnExportar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportar.ForeColor = System.Drawing.Color.White;
            this.btnExportar.Image = ((System.Drawing.Image)(resources.GetObject("btnExportar.Image")));
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(93, 24);
            this.btnExportar.Text = "Exportar";
            // 
            // btnExcel
            // 
            this.btnExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnExcel.ForeColor = System.Drawing.Color.White;
            this.btnExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.Image")));
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(180, 24);
            this.btnExcel.Text = "Excel";
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(568, 505);
            this.Controls.Add(this.lblMailValido);
            this.Controls.Add(this.lblMailInvalido);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.lblCamposObligatorios);
            this.Controls.Add(this.lblAsteriscoTelefono);
            this.Controls.Add(this.lblAsteriscoNombres);
            this.Controls.Add(this.ddlLocalidades);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.lblDirección);
            this.Controls.Add(this.lblLocalidad);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblNombres);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblCantidadClientes);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.compuGrossDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CompuGrossDataSet compuGrossDataSet;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private CompuGrossDataSetTableAdapters.ClientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.PictureBox btnBuscar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnMenuModificar;
        private System.Windows.Forms.Label lblCantidadClientes;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.Label lblDirección;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.ComboBox ddlLocalidades;
        private System.Windows.Forms.Label lblAsteriscoNombres;
        private System.Windows.Forms.Label lblAsteriscoTelefono;
        private System.Windows.Forms.Label lblCamposObligatorios;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label lblMailValido;
        private System.Windows.Forms.Label lblMailInvalido;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.ToolStripMenuItem btnCancelar;
        private System.Windows.Forms.ToolStripMenuItem btnModificar;
        private System.Windows.Forms.ToolStripMenuItem btnEliminar;
        private System.Windows.Forms.ToolStripMenuItem btnExportar;
        private System.Windows.Forms.ToolStripMenuItem btnExcel;
    }
}

