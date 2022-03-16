
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
            this.txtDolarOficial = new System.Windows.Forms.TextBox();
            this.txtDolarInformal = new System.Windows.Forms.TextBox();
            this.lblDolarOficial = new System.Windows.Forms.Label();
            this.lblDolarInformal = new System.Windows.Forms.Label();
            this.rBtnDolarOficial = new System.Windows.Forms.RadioButton();
            this.rBtnDolarInformal = new System.Windows.Forms.RadioButton();
            this.listPrecios = new System.Windows.Forms.ListView();
            this.colID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDescripcion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPesos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDolares = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAtras = new System.Windows.Forms.Button();
            this.lblDolar = new System.Windows.Forms.Label();
            this.txtDolar = new System.Windows.Forms.TextBox();
            this.lblDolar2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDolarOficial
            // 
            this.txtDolarOficial.Location = new System.Drawing.Point(723, 91);
            this.txtDolarOficial.MaxLength = 6;
            this.txtDolarOficial.Name = "txtDolarOficial";
            this.txtDolarOficial.Size = new System.Drawing.Size(64, 20);
            this.txtDolarOficial.TabIndex = 3;
            this.txtDolarOficial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDolarOficial.TextChanged += new System.EventHandler(this.txtDolarOficial_TextChanged);
            this.txtDolarOficial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDolarOficial_KeyPress);
            // 
            // txtDolarInformal
            // 
            this.txtDolarInformal.Location = new System.Drawing.Point(723, 141);
            this.txtDolarInformal.MaxLength = 6;
            this.txtDolarInformal.Name = "txtDolarInformal";
            this.txtDolarInformal.Size = new System.Drawing.Size(64, 20);
            this.txtDolarInformal.TabIndex = 5;
            this.txtDolarInformal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDolarInformal.TextChanged += new System.EventHandler(this.txtDolarInformal_TextChanged);
            this.txtDolarInformal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDolarInformal_KeyPress);
            // 
            // lblDolarOficial
            // 
            this.lblDolarOficial.AutoSize = true;
            this.lblDolarOficial.BackColor = System.Drawing.Color.Transparent;
            this.lblDolarOficial.Location = new System.Drawing.Point(722, 75);
            this.lblDolarOficial.Name = "lblDolarOficial";
            this.lblDolarOficial.Size = new System.Drawing.Size(64, 13);
            this.lblDolarOficial.TabIndex = 86;
            this.lblDolarOficial.Text = "Dolar Oficial";
            this.lblDolarOficial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDolarInformal
            // 
            this.lblDolarInformal.AutoSize = true;
            this.lblDolarInformal.BackColor = System.Drawing.Color.Transparent;
            this.lblDolarInformal.Location = new System.Drawing.Point(719, 125);
            this.lblDolarInformal.Name = "lblDolarInformal";
            this.lblDolarInformal.Size = new System.Drawing.Size(72, 13);
            this.lblDolarInformal.TabIndex = 87;
            this.lblDolarInformal.Text = "Dolar Informal";
            this.lblDolarInformal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rBtnDolarOficial
            // 
            this.rBtnDolarOficial.AutoSize = true;
            this.rBtnDolarOficial.BackColor = System.Drawing.Color.Transparent;
            this.rBtnDolarOficial.Location = new System.Drawing.Point(703, 94);
            this.rBtnDolarOficial.Name = "rBtnDolarOficial";
            this.rBtnDolarOficial.Size = new System.Drawing.Size(14, 13);
            this.rBtnDolarOficial.TabIndex = 2;
            this.rBtnDolarOficial.TabStop = true;
            this.rBtnDolarOficial.UseVisualStyleBackColor = false;
            this.rBtnDolarOficial.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rBtnDolarOficial_MouseClick);
            // 
            // rBtnDolarInformal
            // 
            this.rBtnDolarInformal.AutoSize = true;
            this.rBtnDolarInformal.BackColor = System.Drawing.Color.Transparent;
            this.rBtnDolarInformal.Location = new System.Drawing.Point(703, 144);
            this.rBtnDolarInformal.Name = "rBtnDolarInformal";
            this.rBtnDolarInformal.Size = new System.Drawing.Size(14, 13);
            this.rBtnDolarInformal.TabIndex = 4;
            this.rBtnDolarInformal.TabStop = true;
            this.rBtnDolarInformal.UseVisualStyleBackColor = false;
            this.rBtnDolarInformal.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rBtnDolarInformal_MouseClick);
            // 
            // listPrecios
            // 
            this.listPrecios.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listPrecios.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.listPrecios.BackColor = System.Drawing.Color.LightBlue;
            this.listPrecios.BackgroundImageTiled = true;
            this.listPrecios.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colID,
            this.colDescripcion,
            this.colPesos,
            this.colDolares});
            this.listPrecios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listPrecios.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listPrecios.FullRowSelect = true;
            this.listPrecios.GridLines = true;
            this.listPrecios.HideSelection = false;
            this.listPrecios.Location = new System.Drawing.Point(12, 12);
            this.listPrecios.MultiSelect = false;
            this.listPrecios.Name = "listPrecios";
            this.listPrecios.Size = new System.Drawing.Size(685, 385);
            this.listPrecios.TabIndex = 1;
            this.listPrecios.UseCompatibleStateImageBehavior = false;
            this.listPrecios.View = System.Windows.Forms.View.Details;
            this.listPrecios.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listPrecios_ColumnClick);
            this.listPrecios.SelectedIndexChanged += new System.EventHandler(this.listPrecios_SelectedIndexChanged);
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
            this.colDolares.Width = 93;
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.Transparent;
            this.btnAtras.BackgroundImage = global::CompuGross.Properties.Resources.volver;
            this.btnAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAtras.Location = new System.Drawing.Point(746, 358);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(40, 39);
            this.btnAtras.TabIndex = 6;
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // lblDolar
            // 
            this.lblDolar.AutoSize = true;
            this.lblDolar.BackColor = System.Drawing.Color.Transparent;
            this.lblDolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDolar.Location = new System.Drawing.Point(701, 11);
            this.lblDolar.Name = "lblDolar";
            this.lblDolar.Size = new System.Drawing.Size(95, 20);
            this.lblDolar.TabIndex = 90;
            this.lblDolar.Text = "Precio Dolar";
            this.lblDolar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDolar
            // 
            this.txtDolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDolar.Location = new System.Drawing.Point(720, 31);
            this.txtDolar.MaxLength = 6;
            this.txtDolar.Name = "txtDolar";
            this.txtDolar.Size = new System.Drawing.Size(64, 24);
            this.txtDolar.TabIndex = 0;
            this.txtDolar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDolar.TextChanged += new System.EventHandler(this.txtDolar_TextChanged);
            this.txtDolar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDolar_KeyPress);
            // 
            // lblDolar2
            // 
            this.lblDolar2.AutoSize = true;
            this.lblDolar2.BackColor = System.Drawing.Color.Transparent;
            this.lblDolar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDolar2.Location = new System.Drawing.Point(701, 33);
            this.lblDolar2.Name = "lblDolar2";
            this.lblDolar2.Size = new System.Drawing.Size(18, 20);
            this.lblDolar2.TabIndex = 91;
            this.lblDolar2.Text = "$";
            this.lblDolar2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ListadoPrecios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CompuGross.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(798, 405);
            this.Controls.Add(this.lblDolar2);
            this.Controls.Add(this.lblDolar);
            this.Controls.Add(this.txtDolar);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.listPrecios);
            this.Controls.Add(this.rBtnDolarInformal);
            this.Controls.Add(this.rBtnDolarOficial);
            this.Controls.Add(this.lblDolarInformal);
            this.Controls.Add(this.lblDolarOficial);
            this.Controls.Add(this.txtDolarInformal);
            this.Controls.Add(this.txtDolarOficial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "ListadoPrecios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de precios vigentes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ListaPrecios_FormClosed);
            this.Load += new System.EventHandler(this.ListaPrecios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtDolarOficial;
        private System.Windows.Forms.TextBox txtDolarInformal;
        private System.Windows.Forms.Label lblDolarOficial;
        private System.Windows.Forms.Label lblDolarInformal;
        private System.Windows.Forms.RadioButton rBtnDolarOficial;
        private System.Windows.Forms.RadioButton rBtnDolarInformal;
        private System.Windows.Forms.ListView listPrecios;
        private System.Windows.Forms.ColumnHeader colID;
        private System.Windows.Forms.ColumnHeader colPesos;
        private System.Windows.Forms.ColumnHeader colDolares;
        private System.Windows.Forms.ColumnHeader colDescripcion;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Label lblDolar;
        private System.Windows.Forms.TextBox txtDolar;
        private System.Windows.Forms.Label lblDolar2;
    }
}