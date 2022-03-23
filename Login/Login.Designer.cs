
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
            this.txtDni = new System.Windows.Forms.TextBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.btnEnviarCodigo = new System.Windows.Forms.Button();
            this.lblCodigoRecuperacion = new System.Windows.Forms.Label();
            this.lblClaveNueva = new System.Windows.Forms.Label();
            this.cbMostrarClave2 = new System.Windows.Forms.CheckBox();
            this.cbMostrarClave1 = new System.Windows.Forms.CheckBox();
            this.lblCaracteres = new System.Windows.Forms.Label();
            this.lblMayus = new System.Windows.Forms.Label();
            this.lblMinus = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txtUsuario, "txtUsuario");
            this.txtUsuario.ForeColor = System.Drawing.Color.White;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario_KeyPress);
            // 
            // lblUsuario
            // 
            resources.ApplyResources(this.lblUsuario, "lblUsuario");
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Name = "lblUsuario";
            // 
            // lblClave
            // 
            resources.ApplyResources(this.lblClave, "lblClave");
            this.lblClave.BackColor = System.Drawing.Color.Transparent;
            this.lblClave.ForeColor = System.Drawing.Color.White;
            this.lblClave.Name = "lblClave";
            // 
            // txtClave
            // 
            this.txtClave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.txtClave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txtClave, "txtClave");
            this.txtClave.ForeColor = System.Drawing.Color.White;
            this.txtClave.Name = "txtClave";
            this.txtClave.UseSystemPasswordChar = true;
            this.txtClave.TextChanged += new System.EventHandler(this.txtClave_TextChanged);
            this.txtClave.Enter += new System.EventHandler(this.txtClave_Enter);
            this.txtClave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtClave_KeyPress);
            this.txtClave.Leave += new System.EventHandler(this.txtClave_Leave);
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            resources.ApplyResources(this.btnIngresar, "btnIngresar");
            this.btnIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIngresar.FlatAppearance.BorderSize = 0;
            this.btnIngresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnIngresar.ForeColor = System.Drawing.Color.White;
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // lblRecuperarClave
            // 
            resources.ApplyResources(this.lblRecuperarClave, "lblRecuperarClave");
            this.lblRecuperarClave.BackColor = System.Drawing.Color.Transparent;
            this.lblRecuperarClave.LinkColor = System.Drawing.Color.Cyan;
            this.lblRecuperarClave.Name = "lblRecuperarClave";
            this.lblRecuperarClave.TabStop = true;
            this.lblRecuperarClave.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblRecuperarClave_LinkClicked);
            // 
            // btnRegistro
            // 
            this.btnRegistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            resources.ApplyResources(this.btnRegistro, "btnRegistro");
            this.btnRegistro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistro.FlatAppearance.BorderSize = 0;
            this.btnRegistro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.btnRegistro.ForeColor = System.Drawing.Color.White;
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.UseVisualStyleBackColor = false;
            // 
            // txtDni
            // 
            this.txtDni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.txtDni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.txtDni, "txtDni");
            this.txtDni.ForeColor = System.Drawing.Color.White;
            this.txtDni.Name = "txtDni";
            this.txtDni.TextChanged += new System.EventHandler(this.txtMail_TextChanged);
            this.txtDni.Enter += new System.EventHandler(this.txtMail_Enter);
            this.txtDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDni_KeyPress);
            // 
            // lblDni
            // 
            resources.ApplyResources(this.lblDni, "lblDni");
            this.lblDni.BackColor = System.Drawing.Color.Transparent;
            this.lblDni.Name = "lblDni";
            // 
            // btnEnviarCodigo
            // 
            this.btnEnviarCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnEnviarCodigo.FlatAppearance.BorderSize = 0;
            this.btnEnviarCodigo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            resources.ApplyResources(this.btnEnviarCodigo, "btnEnviarCodigo");
            this.btnEnviarCodigo.ForeColor = System.Drawing.Color.White;
            this.btnEnviarCodigo.Name = "btnEnviarCodigo";
            this.btnEnviarCodigo.UseVisualStyleBackColor = false;
            this.btnEnviarCodigo.Click += new System.EventHandler(this.btnEnviarCodigo_Click);
            // 
            // lblCodigoRecuperacion
            // 
            resources.ApplyResources(this.lblCodigoRecuperacion, "lblCodigoRecuperacion");
            this.lblCodigoRecuperacion.BackColor = System.Drawing.Color.Transparent;
            this.lblCodigoRecuperacion.ForeColor = System.Drawing.Color.White;
            this.lblCodigoRecuperacion.Name = "lblCodigoRecuperacion";
            // 
            // lblClaveNueva
            // 
            resources.ApplyResources(this.lblClaveNueva, "lblClaveNueva");
            this.lblClaveNueva.BackColor = System.Drawing.Color.Transparent;
            this.lblClaveNueva.ForeColor = System.Drawing.Color.White;
            this.lblClaveNueva.Name = "lblClaveNueva";
            // 
            // cbMostrarClave2
            // 
            resources.ApplyResources(this.cbMostrarClave2, "cbMostrarClave2");
            this.cbMostrarClave2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.cbMostrarClave2.FlatAppearance.BorderSize = 0;
            this.cbMostrarClave2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.cbMostrarClave2.ForeColor = System.Drawing.Color.White;
            this.cbMostrarClave2.Name = "cbMostrarClave2";
            this.cbMostrarClave2.UseVisualStyleBackColor = false;
            this.cbMostrarClave2.CheckedChanged += new System.EventHandler(this.cbMostrarClave_CheckedChanged);
            // 
            // cbMostrarClave1
            // 
            resources.ApplyResources(this.cbMostrarClave1, "cbMostrarClave1");
            this.cbMostrarClave1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.cbMostrarClave1.FlatAppearance.BorderSize = 0;
            this.cbMostrarClave1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(80)))), ((int)(((byte)(90)))));
            this.cbMostrarClave1.ForeColor = System.Drawing.Color.White;
            this.cbMostrarClave1.Name = "cbMostrarClave1";
            this.cbMostrarClave1.UseVisualStyleBackColor = false;
            this.cbMostrarClave1.CheckedChanged += new System.EventHandler(this.cbMostrarClave1_CheckedChanged);
            // 
            // lblCaracteres
            // 
            resources.ApplyResources(this.lblCaracteres, "lblCaracteres");
            this.lblCaracteres.BackColor = System.Drawing.Color.Transparent;
            this.lblCaracteres.ForeColor = System.Drawing.Color.LightCoral;
            this.lblCaracteres.Name = "lblCaracteres";
            this.lblCaracteres.UseMnemonic = false;
            // 
            // lblMayus
            // 
            resources.ApplyResources(this.lblMayus, "lblMayus");
            this.lblMayus.BackColor = System.Drawing.Color.Transparent;
            this.lblMayus.ForeColor = System.Drawing.Color.LightCoral;
            this.lblMayus.Name = "lblMayus";
            this.lblMayus.UseMnemonic = false;
            // 
            // lblMinus
            // 
            resources.ApplyResources(this.lblMinus, "lblMinus");
            this.lblMinus.BackColor = System.Drawing.Color.Transparent;
            this.lblMinus.ForeColor = System.Drawing.Color.LightCoral;
            this.lblMinus.Name = "lblMinus";
            this.lblMinus.UseMnemonic = false;
            // 
            // lblNum
            // 
            resources.ApplyResources(this.lblNum, "lblNum");
            this.lblNum.BackColor = System.Drawing.Color.Transparent;
            this.lblNum.ForeColor = System.Drawing.Color.LightCoral;
            this.lblNum.Name = "lblNum";
            this.lblNum.UseMnemonic = false;
            // 
            // Login
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.lblMinus);
            this.Controls.Add(this.lblMayus);
            this.Controls.Add(this.cbMostrarClave1);
            this.Controls.Add(this.cbMostrarClave2);
            this.Controls.Add(this.btnEnviarCodigo);
            this.Controls.Add(this.btnRegistro);
            this.Controls.Add(this.lblRecuperarClave);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblCaracteres);
            this.Controls.Add(this.lblClaveNueva);
            this.Controls.Add(this.lblCodigoRecuperacion);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.txtClave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
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
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Button btnEnviarCodigo;
        private System.Windows.Forms.Label lblCodigoRecuperacion;
        private System.Windows.Forms.Label lblClaveNueva;
        private System.Windows.Forms.CheckBox cbMostrarClave2;
        private System.Windows.Forms.CheckBox cbMostrarClave1;
        private System.Windows.Forms.Label lblCaracteres;
        private System.Windows.Forms.Label lblMayus;
        private System.Windows.Forms.Label lblMinus;
        private System.Windows.Forms.Label lblNum;
    }
}