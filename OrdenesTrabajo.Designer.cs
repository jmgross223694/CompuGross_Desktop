
namespace CompuGross
{
    partial class OrdenesTrabajo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrdenesTrabajo));
            this.btnNuevaOrden = new System.Windows.Forms.Button();
            this.btnVerEditarOrden = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNuevaOrden
            // 
            this.btnNuevaOrden.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnNuevaOrden.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNuevaOrden.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNuevaOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaOrden.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNuevaOrden.Location = new System.Drawing.Point(12, 40);
            this.btnNuevaOrden.Name = "btnNuevaOrden";
            this.btnNuevaOrden.Size = new System.Drawing.Size(254, 63);
            this.btnNuevaOrden.TabIndex = 0;
            this.btnNuevaOrden.Text = "Crear Nueva";
            this.btnNuevaOrden.UseVisualStyleBackColor = true;
            // 
            // btnVerEditarOrden
            // 
            this.btnVerEditarOrden.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnVerEditarOrden.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVerEditarOrden.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerEditarOrden.Location = new System.Drawing.Point(14, 128);
            this.btnVerEditarOrden.Name = "btnVerEditarOrden";
            this.btnVerEditarOrden.Size = new System.Drawing.Size(254, 63);
            this.btnVerEditarOrden.TabIndex = 1;
            this.btnVerEditarOrden.Text = "Editar / Eliminar";
            this.btnVerEditarOrden.UseVisualStyleBackColor = false;
            // 
            // OrdenesTrabajo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CompuGross.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(280, 228);
            this.Controls.Add(this.btnVerEditarOrden);
            this.Controls.Add(this.btnNuevaOrden);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OrdenesTrabajo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ordenes de Trabajo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNuevaOrden;
        private System.Windows.Forms.Button btnVerEditarOrden;
    }
}