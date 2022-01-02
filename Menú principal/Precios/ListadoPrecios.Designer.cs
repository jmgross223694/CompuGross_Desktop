
namespace CompuGross
{
    partial class ListaPrecios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaPrecios));
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
            this.SuspendLayout();
            // 
            // txtDolarOficial
            // 
            this.txtDolarOficial.Location = new System.Drawing.Point(723, 28);
            this.txtDolarOficial.MaxLength = 6;
            this.txtDolarOficial.Name = "txtDolarOficial";
            this.txtDolarOficial.Size = new System.Drawing.Size(64, 20);
            this.txtDolarOficial.TabIndex = 1;
            this.txtDolarOficial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDolarInformal
            // 
            this.txtDolarInformal.Location = new System.Drawing.Point(723, 78);
            this.txtDolarInformal.MaxLength = 6;
            this.txtDolarInformal.Name = "txtDolarInformal";
            this.txtDolarInformal.Size = new System.Drawing.Size(64, 20);
            this.txtDolarInformal.TabIndex = 3;
            this.txtDolarInformal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDolarOficial
            // 
            this.lblDolarOficial.AutoSize = true;
            this.lblDolarOficial.BackColor = System.Drawing.Color.Transparent;
            this.lblDolarOficial.Location = new System.Drawing.Point(722, 12);
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
            this.lblDolarInformal.Location = new System.Drawing.Point(719, 62);
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
            this.rBtnDolarOficial.Location = new System.Drawing.Point(703, 31);
            this.rBtnDolarOficial.Name = "rBtnDolarOficial";
            this.rBtnDolarOficial.Size = new System.Drawing.Size(14, 13);
            this.rBtnDolarOficial.TabIndex = 0;
            this.rBtnDolarOficial.TabStop = true;
            this.rBtnDolarOficial.UseVisualStyleBackColor = false;
            this.rBtnDolarOficial.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rBtnDolarOficial_MouseClick);
            // 
            // rBtnDolarInformal
            // 
            this.rBtnDolarInformal.AutoSize = true;
            this.rBtnDolarInformal.BackColor = System.Drawing.Color.Transparent;
            this.rBtnDolarInformal.Location = new System.Drawing.Point(703, 81);
            this.rBtnDolarInformal.Name = "rBtnDolarInformal";
            this.rBtnDolarInformal.Size = new System.Drawing.Size(14, 13);
            this.rBtnDolarInformal.TabIndex = 2;
            this.rBtnDolarInformal.TabStop = true;
            this.rBtnDolarInformal.UseVisualStyleBackColor = false;
            this.rBtnDolarInformal.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rBtnDolarInformal_MouseClick);
            // 
            // listPrecios
            // 
            this.listPrecios.Activation = System.Windows.Forms.ItemActivation.OneClick;
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
            this.listPrecios.Size = new System.Drawing.Size(685, 510);
            this.listPrecios.TabIndex = 4;
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
            // ListaPrecios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CompuGross.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(798, 534);
            this.Controls.Add(this.listPrecios);
            this.Controls.Add(this.rBtnDolarInformal);
            this.Controls.Add(this.rBtnDolarOficial);
            this.Controls.Add(this.lblDolarInformal);
            this.Controls.Add(this.lblDolarOficial);
            this.Controls.Add(this.txtDolarInformal);
            this.Controls.Add(this.txtDolarOficial);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ListaPrecios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de precios vigentes";
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
    }
}