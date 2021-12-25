
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
            this.lblPath = new System.Windows.Forms.Label();
            this.btnPath = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHacerBackup
            // 
            this.btnHacerBackup.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnHacerBackup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHacerBackup.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnHacerBackup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHacerBackup.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHacerBackup.ForeColor = System.Drawing.Color.White;
            this.btnHacerBackup.Location = new System.Drawing.Point(12, 84);
            this.btnHacerBackup.Name = "btnHacerBackup";
            this.btnHacerBackup.Size = new System.Drawing.Size(252, 57);
            this.btnHacerBackup.TabIndex = 0;
            this.btnHacerBackup.Text = "Realizar Backup";
            this.btnHacerBackup.UseVisualStyleBackColor = false;
            this.btnHacerBackup.Click += new System.EventHandler(this.btnHacerBackup_Click);
            // 
            // btnRestaurarBackup
            // 
            this.btnRestaurarBackup.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnRestaurarBackup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRestaurarBackup.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnRestaurarBackup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRestaurarBackup.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestaurarBackup.ForeColor = System.Drawing.Color.White;
            this.btnRestaurarBackup.Location = new System.Drawing.Point(12, 168);
            this.btnRestaurarBackup.Name = "btnRestaurarBackup";
            this.btnRestaurarBackup.Size = new System.Drawing.Size(252, 57);
            this.btnRestaurarBackup.TabIndex = 1;
            this.btnRestaurarBackup.Text = "Restaurar Backup";
            this.btnRestaurarBackup.UseVisualStyleBackColor = false;
            this.btnRestaurarBackup.Click += new System.EventHandler(this.btnRestaurarBackup_Click);
            // 
            // txtPath
            // 
            this.txtPath.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPath.Location = new System.Drawing.Point(53, 22);
            this.txtPath.Multiline = true;
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(211, 35);
            this.txtPath.TabIndex = 2;
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.BackColor = System.Drawing.Color.Transparent;
            this.lblPath.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPath.Location = new System.Drawing.Point(50, 6);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(84, 16);
            this.lblPath.TabIndex = 3;
            this.lblPath.Text = "Guardar en...";
            // 
            // btnPath
            // 
            this.btnPath.BackColor = System.Drawing.Color.Transparent;
            this.btnPath.BackgroundImage = global::CompuGross.Properties.Resources.buscar;
            this.btnPath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPath.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnPath.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btnPath.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnPath.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPath.Location = new System.Drawing.Point(5, 6);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(42, 51);
            this.btnPath.TabIndex = 4;
            this.btnPath.UseVisualStyleBackColor = false;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // HacerBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::CompuGross.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(278, 247);
            this.Controls.Add(this.btnPath);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.btnRestaurarBackup);
            this.Controls.Add(this.btnHacerBackup);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "HacerBackup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Backup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHacerBackup;
        private System.Windows.Forms.Button btnRestaurarBackup;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Button btnPath;
    }
}