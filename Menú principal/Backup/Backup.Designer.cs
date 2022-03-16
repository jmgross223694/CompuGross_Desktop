
namespace CompuGross
{
    partial class Backup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Backup));
            this.btnHacerBackup = new System.Windows.Forms.Button();
            this.btnRestaurarBackup = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pbRealizarBackup = new System.Windows.Forms.PictureBox();
            this.pbRestaurarBackup = new System.Windows.Forms.PictureBox();
            this.btnElegirArchivo = new System.Windows.Forms.PictureBox();
            this.btnSeleccionarCarpeta = new System.Windows.Forms.PictureBox();
            this.txtArchivoSeleccionado = new System.Windows.Forms.TextBox();
            this.ddlTablas = new System.Windows.Forms.ComboBox();
            this.lblSeleccionarTabla = new System.Windows.Forms.Label();
            this.btnMostrarArchivo = new System.Windows.Forms.Button();
            this.btnCargarArchivo = new System.Windows.Forms.Button();
            this.dgvArchivo = new System.Windows.Forms.DataGridView();
            this.btnVolver = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbRealizarBackup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRestaurarBackup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnElegirArchivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSeleccionarCarpeta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArchivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVolver)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHacerBackup
            // 
            this.btnHacerBackup.BackColor = System.Drawing.Color.Transparent;
            this.btnHacerBackup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHacerBackup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHacerBackup.FlatAppearance.BorderSize = 0;
            this.btnHacerBackup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnHacerBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHacerBackup.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHacerBackup.ForeColor = System.Drawing.Color.White;
            this.btnHacerBackup.Location = new System.Drawing.Point(286, 186);
            this.btnHacerBackup.Name = "btnHacerBackup";
            this.btnHacerBackup.Size = new System.Drawing.Size(118, 50);
            this.btnHacerBackup.TabIndex = 0;
            this.btnHacerBackup.Text = "Realizar";
            this.btnHacerBackup.UseVisualStyleBackColor = false;
            this.btnHacerBackup.Click += new System.EventHandler(this.btnHacerBackup_Click);
            // 
            // btnRestaurarBackup
            // 
            this.btnRestaurarBackup.BackColor = System.Drawing.Color.Transparent;
            this.btnRestaurarBackup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRestaurarBackup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurarBackup.FlatAppearance.BorderSize = 0;
            this.btnRestaurarBackup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnRestaurarBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestaurarBackup.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestaurarBackup.ForeColor = System.Drawing.Color.White;
            this.btnRestaurarBackup.Location = new System.Drawing.Point(279, 293);
            this.btnRestaurarBackup.Name = "btnRestaurarBackup";
            this.btnRestaurarBackup.Size = new System.Drawing.Size(128, 50);
            this.btnRestaurarBackup.TabIndex = 1;
            this.btnRestaurarBackup.Text = "Restaurar";
            this.btnRestaurarBackup.UseVisualStyleBackColor = false;
            this.btnRestaurarBackup.Click += new System.EventHandler(this.btnRestaurarBackup_Click);
            // 
            // txtPath
            // 
            this.txtPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.txtPath.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPath.Cursor = System.Windows.Forms.Cursors.No;
            this.txtPath.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPath.ForeColor = System.Drawing.Color.White;
            this.txtPath.Location = new System.Drawing.Point(226, 130);
            this.txtPath.Multiline = true;
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(201, 50);
            this.txtPath.TabIndex = 2;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Showcard Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(154, 36);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(315, 36);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "COPIA DE SEGURIDAD";
            // 
            // pbRealizarBackup
            // 
            this.pbRealizarBackup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbRealizarBackup.Cursor = System.Windows.Forms.Cursors.No;
            this.pbRealizarBackup.Image = ((System.Drawing.Image)(resources.GetObject("pbRealizarBackup.Image")));
            this.pbRealizarBackup.Location = new System.Drawing.Point(222, 186);
            this.pbRealizarBackup.Name = "pbRealizarBackup";
            this.pbRealizarBackup.Size = new System.Drawing.Size(58, 50);
            this.pbRealizarBackup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRealizarBackup.TabIndex = 6;
            this.pbRealizarBackup.TabStop = false;
            // 
            // pbRestaurarBackup
            // 
            this.pbRestaurarBackup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbRestaurarBackup.Cursor = System.Windows.Forms.Cursors.No;
            this.pbRestaurarBackup.Image = ((System.Drawing.Image)(resources.GetObject("pbRestaurarBackup.Image")));
            this.pbRestaurarBackup.Location = new System.Drawing.Point(222, 293);
            this.pbRestaurarBackup.Name = "pbRestaurarBackup";
            this.pbRestaurarBackup.Size = new System.Drawing.Size(58, 50);
            this.pbRestaurarBackup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRestaurarBackup.TabIndex = 7;
            this.pbRestaurarBackup.TabStop = false;
            // 
            // btnElegirArchivo
            // 
            this.btnElegirArchivo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnElegirArchivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnElegirArchivo.Image = ((System.Drawing.Image)(resources.GetObject("btnElegirArchivo.Image")));
            this.btnElegirArchivo.Location = new System.Drawing.Point(23, 103);
            this.btnElegirArchivo.Name = "btnElegirArchivo";
            this.btnElegirArchivo.Size = new System.Drawing.Size(51, 50);
            this.btnElegirArchivo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnElegirArchivo.TabIndex = 8;
            this.btnElegirArchivo.TabStop = false;
            this.btnElegirArchivo.Visible = false;
            this.btnElegirArchivo.Click += new System.EventHandler(this.btnElegirArchivo_Click);
            // 
            // btnSeleccionarCarpeta
            // 
            this.btnSeleccionarCarpeta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSeleccionarCarpeta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeleccionarCarpeta.Image = ((System.Drawing.Image)(resources.GetObject("btnSeleccionarCarpeta.Image")));
            this.btnSeleccionarCarpeta.Location = new System.Drawing.Point(169, 130);
            this.btnSeleccionarCarpeta.Name = "btnSeleccionarCarpeta";
            this.btnSeleccionarCarpeta.Size = new System.Drawing.Size(51, 50);
            this.btnSeleccionarCarpeta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSeleccionarCarpeta.TabIndex = 9;
            this.btnSeleccionarCarpeta.TabStop = false;
            this.btnSeleccionarCarpeta.Click += new System.EventHandler(this.btnSeleccionarCarpeta_Click);
            // 
            // txtArchivoSeleccionado
            // 
            this.txtArchivoSeleccionado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.txtArchivoSeleccionado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtArchivoSeleccionado.Cursor = System.Windows.Forms.Cursors.No;
            this.txtArchivoSeleccionado.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArchivoSeleccionado.ForeColor = System.Drawing.Color.White;
            this.txtArchivoSeleccionado.Location = new System.Drawing.Point(80, 103);
            this.txtArchivoSeleccionado.Multiline = true;
            this.txtArchivoSeleccionado.Name = "txtArchivoSeleccionado";
            this.txtArchivoSeleccionado.ReadOnly = true;
            this.txtArchivoSeleccionado.Size = new System.Drawing.Size(234, 50);
            this.txtArchivoSeleccionado.TabIndex = 10;
            this.txtArchivoSeleccionado.Visible = false;
            // 
            // ddlTablas
            // 
            this.ddlTablas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.ddlTablas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ddlTablas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlTablas.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddlTablas.ForeColor = System.Drawing.Color.White;
            this.ddlTablas.FormattingEnabled = true;
            this.ddlTablas.Items.AddRange(new object[] {
            "-",
            "Activado",
            "Clientes",
            "credencialesMail",
            "Licencias",
            "ListaPrecios",
            "Localidades",
            "OrdenesTrabajo",
            "TiposEquipo",
            "TiposServicio",
            "TiposUsuario",
            "UsuarioLogueado",
            "Usuarios"});
            this.ddlTablas.Location = new System.Drawing.Point(438, 132);
            this.ddlTablas.Name = "ddlTablas";
            this.ddlTablas.Size = new System.Drawing.Size(145, 21);
            this.ddlTablas.TabIndex = 11;
            this.ddlTablas.Visible = false;
            // 
            // lblSeleccionarTabla
            // 
            this.lblSeleccionarTabla.AutoSize = true;
            this.lblSeleccionarTabla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccionarTabla.ForeColor = System.Drawing.Color.White;
            this.lblSeleccionarTabla.Location = new System.Drawing.Point(452, 103);
            this.lblSeleccionarTabla.Name = "lblSeleccionarTabla";
            this.lblSeleccionarTabla.Size = new System.Drawing.Size(119, 16);
            this.lblSeleccionarTabla.TabIndex = 12;
            this.lblSeleccionarTabla.Text = "Seleccionar Tabla";
            this.lblSeleccionarTabla.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSeleccionarTabla.Visible = false;
            // 
            // btnMostrarArchivo
            // 
            this.btnMostrarArchivo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMostrarArchivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMostrarArchivo.FlatAppearance.BorderSize = 0;
            this.btnMostrarArchivo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnMostrarArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarArchivo.ForeColor = System.Drawing.Color.White;
            this.btnMostrarArchivo.Location = new System.Drawing.Point(320, 98);
            this.btnMostrarArchivo.Name = "btnMostrarArchivo";
            this.btnMostrarArchivo.Size = new System.Drawing.Size(112, 23);
            this.btnMostrarArchivo.TabIndex = 13;
            this.btnMostrarArchivo.Text = "Mostrar archivo";
            this.btnMostrarArchivo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMostrarArchivo.UseVisualStyleBackColor = true;
            this.btnMostrarArchivo.Visible = false;
            this.btnMostrarArchivo.Click += new System.EventHandler(this.btnMostrarArchivo_Click);
            // 
            // btnCargarArchivo
            // 
            this.btnCargarArchivo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCargarArchivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCargarArchivo.FlatAppearance.BorderSize = 0;
            this.btnCargarArchivo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnCargarArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargarArchivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarArchivo.ForeColor = System.Drawing.Color.White;
            this.btnCargarArchivo.Location = new System.Drawing.Point(320, 133);
            this.btnCargarArchivo.Name = "btnCargarArchivo";
            this.btnCargarArchivo.Size = new System.Drawing.Size(112, 23);
            this.btnCargarArchivo.TabIndex = 14;
            this.btnCargarArchivo.Text = "Cargar en BD";
            this.btnCargarArchivo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCargarArchivo.UseVisualStyleBackColor = true;
            this.btnCargarArchivo.Visible = false;
            this.btnCargarArchivo.Click += new System.EventHandler(this.btnCargarArchivo_Click);
            // 
            // dgvArchivo
            // 
            this.dgvArchivo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.dgvArchivo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArchivo.Location = new System.Drawing.Point(23, 169);
            this.dgvArchivo.Name = "dgvArchivo";
            this.dgvArchivo.Size = new System.Drawing.Size(560, 364);
            this.dgvArchivo.TabIndex = 15;
            this.dgvArchivo.Visible = false;
            // 
            // btnVolver
            // 
            this.btnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.Image = ((System.Drawing.Image)(resources.GetObject("btnVolver.Image")));
            this.btnVolver.Location = new System.Drawing.Point(546, 36);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(37, 36);
            this.btnVolver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnVolver.TabIndex = 16;
            this.btnVolver.TabStop = false;
            this.btnVolver.Visible = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // Backup
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(626, 549);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnSeleccionarCarpeta);
            this.Controls.Add(this.pbRestaurarBackup);
            this.Controls.Add(this.pbRealizarBackup);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.btnRestaurarBackup);
            this.Controls.Add(this.btnHacerBackup);
            this.Controls.Add(this.dgvArchivo);
            this.Controls.Add(this.txtArchivoSeleccionado);
            this.Controls.Add(this.btnCargarArchivo);
            this.Controls.Add(this.btnMostrarArchivo);
            this.Controls.Add(this.lblSeleccionarTabla);
            this.Controls.Add(this.ddlTablas);
            this.Controls.Add(this.btnElegirArchivo);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Backup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Backup";
            ((System.ComponentModel.ISupportInitialize)(this.pbRealizarBackup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRestaurarBackup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnElegirArchivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSeleccionarCarpeta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArchivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVolver)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHacerBackup;
        private System.Windows.Forms.Button btnRestaurarBackup;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pbRealizarBackup;
        private System.Windows.Forms.PictureBox pbRestaurarBackup;
        private System.Windows.Forms.PictureBox btnElegirArchivo;
        private System.Windows.Forms.PictureBox btnSeleccionarCarpeta;
        private System.Windows.Forms.TextBox txtArchivoSeleccionado;
        private System.Windows.Forms.ComboBox ddlTablas;
        private System.Windows.Forms.Label lblSeleccionarTabla;
        private System.Windows.Forms.Button btnMostrarArchivo;
        private System.Windows.Forms.Button btnCargarArchivo;
        private System.Windows.Forms.DataGridView dgvArchivo;
        private System.Windows.Forms.PictureBox btnVolver;
    }
}