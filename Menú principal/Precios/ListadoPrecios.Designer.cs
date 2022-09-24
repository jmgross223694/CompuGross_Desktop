
namespace CompuGross
{
    partial class ListadoPrecios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListadoPrecios));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.listPrecios = new System.Windows.Forms.ListView();
            this.colID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDescripcion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPesos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDolares = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblPesos1 = new System.Windows.Forms.Label();
            this.txtPesos = new System.Windows.Forms.TextBox();
            this.lblPesos2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnAbm = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAtras = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAgregar = new System.Windows.Forms.ToolStripMenuItem();
            this.btnModificar = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvPrecios = new System.Windows.Forms.DataGridView();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtDolares = new System.Windows.Forms.TextBox();
            this.lblDolares = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrecios)).BeginInit();
            this.SuspendLayout();
            // 
            // listPrecios
            // 
            this.listPrecios.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listPrecios.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.listPrecios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listPrecios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.listPrecios.BackgroundImageTiled = true;
            this.listPrecios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listPrecios.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colID,
            this.colDescripcion,
            this.colPesos,
            this.colDolares});
            this.listPrecios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listPrecios.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listPrecios.ForeColor = System.Drawing.Color.White;
            this.listPrecios.FullRowSelect = true;
            this.listPrecios.GridLines = true;
            this.listPrecios.HideSelection = false;
            this.listPrecios.Location = new System.Drawing.Point(10, 59);
            this.listPrecios.MultiSelect = false;
            this.listPrecios.Name = "listPrecios";
            this.listPrecios.Size = new System.Drawing.Size(618, 334);
            this.listPrecios.TabIndex = 1;
            this.listPrecios.UseCompatibleStateImageBehavior = false;
            this.listPrecios.View = System.Windows.Forms.View.Details;
            this.listPrecios.Visible = false;
            this.listPrecios.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listPrecios_ColumnClick);
            // 
            // colID
            // 
            this.colID.Text = "";
            this.colID.Width = 31;
            // 
            // colDescripcion
            // 
            this.colDescripcion.Text = "Descripción";
            this.colDescripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colDescripcion.Width = 376;
            // 
            // colPesos
            // 
            this.colPesos.Text = "Pesos";
            this.colPesos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colPesos.Width = 101;
            // 
            // colDolares
            // 
            this.colDolares.Text = "Dólares";
            this.colDolares.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colDolares.Width = 105;
            // 
            // lblPesos1
            // 
            this.lblPesos1.AutoSize = true;
            this.lblPesos1.BackColor = System.Drawing.Color.Transparent;
            this.lblPesos1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesos1.Location = new System.Drawing.Point(6, 29);
            this.lblPesos1.Name = "lblPesos1";
            this.lblPesos1.Size = new System.Drawing.Size(95, 20);
            this.lblPesos1.TabIndex = 90;
            this.lblPesos1.Text = "Precio Dolar";
            this.lblPesos1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPesos
            // 
            this.txtPesos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.txtPesos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPesos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesos.ForeColor = System.Drawing.Color.White;
            this.txtPesos.Location = new System.Drawing.Point(124, 27);
            this.txtPesos.MaxLength = 6;
            this.txtPesos.Name = "txtPesos";
            this.txtPesos.Size = new System.Drawing.Size(64, 24);
            this.txtPesos.TabIndex = 0;
            this.txtPesos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPesos.TextChanged += new System.EventHandler(this.txtPesos_TextChanged);
            this.txtPesos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesos_KeyPress);
            // 
            // lblPesos2
            // 
            this.lblPesos2.AutoSize = true;
            this.lblPesos2.BackColor = System.Drawing.Color.Transparent;
            this.lblPesos2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesos2.Location = new System.Drawing.Point(104, 29);
            this.lblPesos2.Name = "lblPesos2";
            this.lblPesos2.Size = new System.Drawing.Size(18, 20);
            this.lblPesos2.TabIndex = 91;
            this.lblPesos2.Text = "$";
            this.lblPesos2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAbm,
            this.btnAtras,
            this.btnAgregar,
            this.btnModificar,
            this.btnEliminar});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(661, 24);
            this.menuStrip1.TabIndex = 92;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnAbm
            // 
            this.btnAbm.ForeColor = System.Drawing.Color.White;
            this.btnAbm.Image = ((System.Drawing.Image)(resources.GetObject("btnAbm.Image")));
            this.btnAbm.Name = "btnAbm";
            this.btnAbm.Size = new System.Drawing.Size(102, 20);
            this.btnAbm.Text = "ABM Precios";
            this.btnAbm.Click += new System.EventHandler(this.btnAbm_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.ForeColor = System.Drawing.Color.White;
            this.btnAtras.Image = ((System.Drawing.Image)(resources.GetObject("btnAtras.Image")));
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(62, 20);
            this.btnAtras.Text = "Atrás";
            this.btnAtras.Visible = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
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
            // dgvPrecios
            // 
            this.dgvPrecios.AllowUserToAddRows = false;
            this.dgvPrecios.AllowUserToDeleteRows = false;
            this.dgvPrecios.AllowUserToResizeColumns = false;
            this.dgvPrecios.AllowUserToResizeRows = false;
            this.dgvPrecios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPrecios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPrecios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPrecios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.dgvPrecios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPrecios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPrecios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPrecios.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPrecios.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPrecios.EnableHeadersVisualStyles = false;
            this.dgvPrecios.Location = new System.Drawing.Point(10, 59);
            this.dgvPrecios.MultiSelect = false;
            this.dgvPrecios.Name = "dgvPrecios";
            this.dgvPrecios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPrecios.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPrecios.RowHeadersVisible = false;
            this.dgvPrecios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvPrecios.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPrecios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrecios.ShowCellErrors = false;
            this.dgvPrecios.ShowCellToolTips = false;
            this.dgvPrecios.ShowEditingIcon = false;
            this.dgvPrecios.ShowRowErrors = false;
            this.dgvPrecios.Size = new System.Drawing.Size(576, 334);
            this.dgvPrecios.TabIndex = 1;
            this.dgvPrecios.Visible = false;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.ForeColor = System.Drawing.Color.White;
            this.txtDescripcion.Location = new System.Drawing.Point(129, 204);
            this.txtDescripcion.MaxLength = 200;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(303, 24);
            this.txtDescripcion.TabIndex = 3;
            this.txtDescripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDescripcion.Visible = false;
            this.txtDescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescripcion_KeyPress);
            // 
            // txtDolares
            // 
            this.txtDolares.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.txtDolares.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDolares.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDolares.ForeColor = System.Drawing.Color.White;
            this.txtDolares.Location = new System.Drawing.Point(246, 110);
            this.txtDolares.MaxLength = 6;
            this.txtDolares.Name = "txtDolares";
            this.txtDolares.Size = new System.Drawing.Size(67, 24);
            this.txtDolares.TabIndex = 2;
            this.txtDolares.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDolares.Visible = false;
            this.txtDolares.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDolares_KeyPress);
            // 
            // lblDolares
            // 
            this.lblDolares.AutoSize = true;
            this.lblDolares.BackColor = System.Drawing.Color.Transparent;
            this.lblDolares.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDolares.Location = new System.Drawing.Point(242, 87);
            this.lblDolares.Name = "lblDolares";
            this.lblDolares.Size = new System.Drawing.Size(112, 20);
            this.lblDolares.TabIndex = 96;
            this.lblDolares.Text = "Precio Dólares";
            this.lblDolares.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDolares.Visible = false;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.BackColor = System.Drawing.Color.Transparent;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(246, 181);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(92, 20);
            this.lblDescripcion.TabIndex = 97;
            this.lblDescripcion.Text = "Descripción";
            this.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDescripcion.Visible = false;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnConfirmar.FlatAppearance.BorderSize = 0;
            this.btnConfirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirmar.Image")));
            this.btnConfirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmar.Location = new System.Drawing.Point(227, 286);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(102, 43);
            this.btnConfirmar.TabIndex = 4;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Visible = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            this.btnConfirmar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnConfirmar_KeyPress);
            // 
            // ListadoPrecios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(661, 405);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblDolares);
            this.Controls.Add(this.txtDolares);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblPesos2);
            this.Controls.Add(this.lblPesos1);
            this.Controls.Add(this.txtPesos);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dgvPrecios);
            this.Controls.Add(this.listPrecios);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "ListadoPrecios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de precios vigentes";
            this.Load += new System.EventHandler(this.Precios_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrecios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listPrecios;
        private System.Windows.Forms.ColumnHeader colID;
        private System.Windows.Forms.ColumnHeader colPesos;
        private System.Windows.Forms.ColumnHeader colDolares;
        private System.Windows.Forms.ColumnHeader colDescripcion;
        private System.Windows.Forms.Label lblPesos1;
        private System.Windows.Forms.TextBox txtPesos;
        private System.Windows.Forms.Label lblPesos2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnAbm;
        private System.Windows.Forms.DataGridView dgvPrecios;
        private System.Windows.Forms.ToolStripMenuItem btnAtras;
        private System.Windows.Forms.ToolStripMenuItem btnAgregar;
        private System.Windows.Forms.ToolStripMenuItem btnModificar;
        private System.Windows.Forms.ToolStripMenuItem btnEliminar;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtDolares;
        private System.Windows.Forms.Label lblDolares;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Button btnConfirmar;
    }
}