
namespace CompuGross
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblClave = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.lblRecuperarClave = new System.Windows.Forms.LinkLabel();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.btnEnviarCodigo = new System.Windows.Forms.Button();
            this.lblCodigoRecuperacion = new System.Windows.Forms.Label();
            this.lblClaveNueva = new System.Windows.Forms.Label();
            this.cbMostrarClave2 = new System.Windows.Forms.CheckBox();
            this.lblLargoClave2 = new System.Windows.Forms.Label();
            this.cbMostrarClave1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            resources.ApplyResources(this.txtUsuario, "txtUsuario");
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario_KeyPress);
            // 
            // lblUsuario
            // 
            resources.ApplyResources(this.lblUsuario, "lblUsuario");
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.Name = "lblUsuario";
            // 
            // lblClave
            // 
            resources.ApplyResources(this.lblClave, "lblClave");
            this.lblClave.BackColor = System.Drawing.Color.Transparent;
            this.lblClave.Name = "lblClave";
            // 
            // txtClave
            // 
            resources.ApplyResources(this.txtClave, "txtClave");
            this.txtClave.Name = "txtClave";
            this.txtClave.UseSystemPasswordChar = true;
            this.txtClave.TextChanged += new System.EventHandler(this.txtClave_TextChanged);
            this.txtClave.Enter += new System.EventHandler(this.txtClave_Enter);
            this.txtClave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtClave_KeyPress);
            this.txtClave.Leave += new System.EventHandler(this.txtClave_Leave);
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.YellowGreen;
            resources.ApplyResources(this.btnIngresar, "btnIngresar");
            this.btnIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIngresar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // lblRecuperarClave
            // 
            resources.ApplyResources(this.lblRecuperarClave, "lblRecuperarClave");
            this.lblRecuperarClave.BackColor = System.Drawing.Color.Transparent;
            this.lblRecuperarClave.Name = "lblRecuperarClave";
            this.lblRecuperarClave.TabStop = true;
            this.lblRecuperarClave.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblRecuperarClave_LinkClicked);
            // 
            // btnRegistro
            // 
            this.btnRegistro.BackColor = System.Drawing.Color.AntiqueWhite;
            resources.ApplyResources(this.btnRegistro, "btnRegistro");
            this.btnRegistro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.UseVisualStyleBackColor = false;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // txtMail
            // 
            resources.ApplyResources(this.txtMail, "txtMail");
            this.txtMail.Name = "txtMail";
            // 
            // lblMail
            // 
            resources.ApplyResources(this.lblMail, "lblMail");
            this.lblMail.BackColor = System.Drawing.Color.Transparent;
            this.lblMail.Name = "lblMail";
            // 
            // btnEnviarCodigo
            // 
            this.btnEnviarCodigo.BackColor = System.Drawing.Color.AntiqueWhite;
            resources.ApplyResources(this.btnEnviarCodigo, "btnEnviarCodigo");
            this.btnEnviarCodigo.Name = "btnEnviarCodigo";
            this.btnEnviarCodigo.UseVisualStyleBackColor = false;
            this.btnEnviarCodigo.Click += new System.EventHandler(this.btnEnviarCodigo_Click);
            // 
            // lblCodigoRecuperacion
            // 
            resources.ApplyResources(this.lblCodigoRecuperacion, "lblCodigoRecuperacion");
            this.lblCodigoRecuperacion.BackColor = System.Drawing.Color.Transparent;
            this.lblCodigoRecuperacion.Name = "lblCodigoRecuperacion";
            // 
            // lblClaveNueva
            // 
            resources.ApplyResources(this.lblClaveNueva, "lblClaveNueva");
            this.lblClaveNueva.BackColor = System.Drawing.Color.Transparent;
            this.lblClaveNueva.Name = "lblClaveNueva";
            // 
            // cbMostrarClave2
            // 
            resources.ApplyResources(this.cbMostrarClave2, "cbMostrarClave2");
            this.cbMostrarClave2.BackColor = System.Drawing.Color.Transparent;
            this.cbMostrarClave2.Name = "cbMostrarClave2";
            this.cbMostrarClave2.UseVisualStyleBackColor = false;
            this.cbMostrarClave2.CheckedChanged += new System.EventHandler(this.cbMostrarClave_CheckedChanged);
            // 
            // lblLargoClave2
            // 
            resources.ApplyResources(this.lblLargoClave2, "lblLargoClave2");
            this.lblLargoClave2.BackColor = System.Drawing.Color.Transparent;
            this.lblLargoClave2.ForeColor = System.Drawing.Color.Red;
            this.lblLargoClave2.Name = "lblLargoClave2";
            this.lblLargoClave2.UseMnemonic = false;
            // 
            // cbMostrarClave1
            // 
            resources.ApplyResources(this.cbMostrarClave1, "cbMostrarClave1");
            this.cbMostrarClave1.BackColor = System.Drawing.Color.Transparent;
            this.cbMostrarClave1.Name = "cbMostrarClave1";
            this.cbMostrarClave1.UseVisualStyleBackColor = false;
            this.cbMostrarClave1.CheckedChanged += new System.EventHandler(this.cbMostrarClave1_CheckedChanged);
            // 
            // Login
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.cbMostrarClave1);
            this.Controls.Add(this.lblLargoClave2);
            this.Controls.Add(this.cbMostrarClave2);
            this.Controls.Add(this.lblClaveNueva);
            this.Controls.Add(this.lblCodigoRecuperacion);
            this.Controls.Add(this.btnEnviarCodigo);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.btnRegistro);
            this.Controls.Add(this.lblRecuperarClave);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.txtUsuario);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.LinkLabel lblRecuperarClave;
        private System.Windows.Forms.Button btnRegistro;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Button btnEnviarCodigo;
        private System.Windows.Forms.Label lblCodigoRecuperacion;
        private System.Windows.Forms.Label lblClaveNueva;
        private System.Windows.Forms.CheckBox cbMostrarClave2;
        private System.Windows.Forms.Label lblLargoClave2;
        private System.Windows.Forms.CheckBox cbMostrarClave1;
    }
}