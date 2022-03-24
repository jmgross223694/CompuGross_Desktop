
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
            this.listPrecios = new System.Windows.Forms.ListView();
            this.colID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDescripcion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPesos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDolares = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblDolar = new System.Windows.Forms.Label();
            this.txtDolar = new System.Windows.Forms.TextBox();
            this.lblDolar2 = new System.Windows.Forms.Label();
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
            // lblDolar
            // 
            this.lblDolar.AutoSize = true;
            this.lblDolar.BackColor = System.Drawing.Color.Transparent;
            this.lblDolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDolar.Location = new System.Drawing.Point(6, 9);
            this.lblDolar.Name = "lblDolar";
            this.lblDolar.Size = new System.Drawing.Size(95, 20);
            this.lblDolar.TabIndex = 90;
            this.lblDolar.Text = "Precio Dolar";
            this.lblDolar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDolar
            // 
            this.txtDolar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.txtDolar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDolar.ForeColor = System.Drawing.Color.White;
            this.txtDolar.Location = new System.Drawing.Point(25, 29);
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
            this.lblDolar2.Location = new System.Drawing.Point(6, 31);
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
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(703, 405);
            this.Controls.Add(this.lblDolar2);
            this.Controls.Add(this.lblDolar);
            this.Controls.Add(this.txtDolar);
            this.Controls.Add(this.listPrecios);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "ListadoPrecios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de precios vigentes";
            this.Load += new System.EventHandler(this.ListaPrecios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listPrecios;
        private System.Windows.Forms.ColumnHeader colID;
        private System.Windows.Forms.ColumnHeader colPesos;
        private System.Windows.Forms.ColumnHeader colDolares;
        private System.Windows.Forms.ColumnHeader colDescripcion;
        private System.Windows.Forms.Label lblDolar;
        private System.Windows.Forms.TextBox txtDolar;
        private System.Windows.Forms.Label lblDolar2;
    }
}