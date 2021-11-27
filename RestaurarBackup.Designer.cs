
namespace CompuGross
{
    partial class RestaurarBackup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RestaurarBackup));
            this.dgvContenidoExcel = new System.Windows.Forms.DataGridView();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.txtArchivo = new System.Windows.Forms.TextBox();
            this.lblArchivo = new System.Windows.Forms.Label();
            this.cbTabla = new System.Windows.Forms.ComboBox();
            this.lblTabla = new System.Windows.Forms.Label();
            this.btnMostrarArchivo = new System.Windows.Forms.Button();
            this.btnCargarArchivo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContenidoExcel)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvContenidoExcel
            // 
            this.dgvContenidoExcel.AllowUserToAddRows = false;
            this.dgvContenidoExcel.AllowUserToDeleteRows = false;
            this.dgvContenidoExcel.AllowUserToResizeColumns = false;
            this.dgvContenidoExcel.AllowUserToResizeRows = false;
            this.dgvContenidoExcel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvContenidoExcel.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvContenidoExcel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvContenidoExcel.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvContenidoExcel.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvContenidoExcel.ColumnHeadersHeight = 30;
            this.dgvContenidoExcel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvContenidoExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvContenidoExcel.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvContenidoExcel.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvContenidoExcel.EnableHeadersVisualStyles = false;
            this.dgvContenidoExcel.Location = new System.Drawing.Point(3, 119);
            this.dgvContenidoExcel.MultiSelect = false;
            this.dgvContenidoExcel.Name = "dgvContenidoExcel";
            this.dgvContenidoExcel.ReadOnly = true;
            this.dgvContenidoExcel.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvContenidoExcel.RowHeadersVisible = false;
            this.dgvContenidoExcel.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvContenidoExcel.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvContenidoExcel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContenidoExcel.ShowCellErrors = false;
            this.dgvContenidoExcel.ShowCellToolTips = false;
            this.dgvContenidoExcel.ShowEditingIcon = false;
            this.dgvContenidoExcel.ShowRowErrors = false;
            this.dgvContenidoExcel.Size = new System.Drawing.Size(631, 547);
            this.dgvContenidoExcel.StandardTab = true;
            this.dgvContenidoExcel.TabIndex = 5;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.BackColor = System.Drawing.Color.Transparent;
            this.btnSeleccionar.BackgroundImage = global::CompuGross.Properties.Resources.buscar;
            this.btnSeleccionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSeleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionar.Location = new System.Drawing.Point(3, 12);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(42, 38);
            this.btnSeleccionar.TabIndex = 0;
            this.btnSeleccionar.UseVisualStyleBackColor = false;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // txtArchivo
            // 
            this.txtArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArchivo.Location = new System.Drawing.Point(51, 28);
            this.txtArchivo.Name = "txtArchivo";
            this.txtArchivo.ReadOnly = true;
            this.txtArchivo.Size = new System.Drawing.Size(456, 22);
            this.txtArchivo.TabIndex = 1;
            // 
            // lblArchivo
            // 
            this.lblArchivo.AutoSize = true;
            this.lblArchivo.BackColor = System.Drawing.Color.Transparent;
            this.lblArchivo.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblArchivo.Location = new System.Drawing.Point(48, 12);
            this.lblArchivo.Name = "lblArchivo";
            this.lblArchivo.Size = new System.Drawing.Size(112, 13);
            this.lblArchivo.TabIndex = 3;
            this.lblArchivo.Text = "Archivo seleccionado:";
            // 
            // cbTabla
            // 
            this.cbTabla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTabla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTabla.FormattingEnabled = true;
            this.cbTabla.Items.AddRange(new object[] {
            "-",
            "Clientes",
            "OrdenesTrabajo",
            "ListaPrecios",
            "Localidades",
            "TiposServicio",
            "TiposEquipo",
            "Usuarios"});
            this.cbTabla.Location = new System.Drawing.Point(513, 28);
            this.cbTabla.Name = "cbTabla";
            this.cbTabla.Size = new System.Drawing.Size(121, 23);
            this.cbTabla.TabIndex = 2;
            // 
            // lblTabla
            // 
            this.lblTabla.AutoSize = true;
            this.lblTabla.Location = new System.Drawing.Point(510, 12);
            this.lblTabla.Name = "lblTabla";
            this.lblTabla.Size = new System.Drawing.Size(103, 13);
            this.lblTabla.TabIndex = 5;
            this.lblTabla.Text = "Tabla seleccionada:";
            // 
            // btnMostrarArchivo
            // 
            this.btnMostrarArchivo.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnMostrarArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMostrarArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarArchivo.Location = new System.Drawing.Point(86, 62);
            this.btnMostrarArchivo.Name = "btnMostrarArchivo";
            this.btnMostrarArchivo.Size = new System.Drawing.Size(169, 40);
            this.btnMostrarArchivo.TabIndex = 3;
            this.btnMostrarArchivo.Text = "Mostrar archivo";
            this.btnMostrarArchivo.UseVisualStyleBackColor = false;
            this.btnMostrarArchivo.Click += new System.EventHandler(this.btnMostrarArchivo_Click);
            // 
            // btnCargarArchivo
            // 
            this.btnCargarArchivo.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCargarArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCargarArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarArchivo.Location = new System.Drawing.Point(347, 62);
            this.btnCargarArchivo.Name = "btnCargarArchivo";
            this.btnCargarArchivo.Size = new System.Drawing.Size(169, 40);
            this.btnCargarArchivo.TabIndex = 4;
            this.btnCargarArchivo.Text = "Cargar en BD";
            this.btnCargarArchivo.UseVisualStyleBackColor = false;
            this.btnCargarArchivo.Click += new System.EventHandler(this.btnCargarArchivo_Click);
            // 
            // RestaurarBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CompuGross.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(637, 669);
            this.Controls.Add(this.btnCargarArchivo);
            this.Controls.Add(this.btnMostrarArchivo);
            this.Controls.Add(this.lblTabla);
            this.Controls.Add(this.cbTabla);
            this.Controls.Add(this.lblArchivo);
            this.Controls.Add(this.txtArchivo);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.dgvContenidoExcel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RestaurarBackup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Backup";
            ((System.ComponentModel.ISupportInitialize)(this.dgvContenidoExcel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvContenidoExcel;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.TextBox txtArchivo;
        private System.Windows.Forms.Label lblArchivo;
        private System.Windows.Forms.ComboBox cbTabla;
        private System.Windows.Forms.Label lblTabla;
        private System.Windows.Forms.Button btnMostrarArchivo;
        private System.Windows.Forms.Button btnCargarArchivo;
    }
}