using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace CompuGross
{
    public partial class AgregarUsuario : Form
    {
        private string user = "", tipo = "";

        public AgregarUsuario(string user, string tipo)
        {
            InitializeComponent();
            this.user = user;
            this.tipo = tipo;
        }

        private void AgregarUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'compuGrossDataSet1.Localidades' Puede moverla o quitarla según sea necesario.
            //this.localidadesTableAdapter.Fill(this.compuGrossDataSet1.Localidades);
            btnRegistrar.Enabled = false;

            //cbTipoUsuario.Enabled = false;
            txtNombres.Enabled = false;
            txtApellidos.Enabled = false;
            txtMail.Enabled = false;
            txtDni.Enabled = false;
            txtClave.Enabled = false;

            cbTipoUsuario.SelectedItem = "-";
            txtNombres.Text = "";
            txtApellidos.Text = "";
            txtMail.Text = "";
            txtDni.Text = "";
            txtClave.Text = "";

            lblMailInvalido.Visible = false;
            lblMailValido.Visible = false;

            lblCaracteres.Visible = false;
            lblMayus.Visible = false;
            lblMinus.Visible = false;
            lblNum.Visible = false;

            cbMostrarClave.Enabled = false;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (cbTipoUsuario.SelectedItem.ToString() == "-" || txtNombres.Text == "" || txtApellidos.Text == "" 
                || txtMail.Text == "" || !txtMail.Text.Contains("@") || !txtMail.Text.Contains(".com")
                || txtDni.Text == "" || txtClave.Text == "" || txtClave.Text.Length < 8)
            {
                MessageBox.Show("Hay datos inválidos o sin completar.", "Atención!!", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
                if (!txtMail.Text.Contains("@") && !txtMail.Text.Contains(".com"))
                {
                    MessageBox.Show("Mail inválido.", "Atención!!",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (txtClave.Text == "" || txtClave.Text.Length < 8)
                {
                    if (txtClave.Text.Length < 8)
                    {
                        MessageBox.Show("La clave es menor a 8 caracteres.", "Atención!!",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                DialogResult result2 = MessageBox.Show("¿Confirma los datos ingresados?", "Confirmar",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result2 == DialogResult.Yes)
                {
                    bool mayuscula = validarMayusculaClave(txtClave.Text);

                    bool numero = validarNumeroClave(txtClave.Text);

                    bool minuscula = validarMinusculaClave(txtClave.Text);

                    if (mayuscula && numero && minuscula)
                    {
                        AccesoDatos datos = new AccesoDatos();

                        string tipo = cbTipoUsuario.SelectedItem.ToString(), nombres = txtNombres.Text,
                            apellidos = txtApellidos.Text, mail = txtMail.Text, usuario = txtDni.Text,
                            clave = txtClave.Text;

                        string insertUsuario = "insert into Usuarios(IdTipo, Nombre, Apellido, Mail, Username, Clave) " +
                            "values((select ID from TiposUsuario where Tipo = '" + tipo + "'), '"
                            + nombres + "', '" + apellidos + "', '" +
                            mail + "', '" + usuario + "', PWDENCRYPT('" + clave + "'))";

                        try
                        {
                            datos.SetearConsulta(insertUsuario);
                            datos.EjecutarLectura();
                            datos.CerrarConexion();

                            MessageBox.Show("Usuario creado correctamente.", "Atención!!",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                            txtNombres.Text = "";
                            txtApellidos.Text = "";
                            txtMail.Text = "";
                            txtDni.Text = "";
                            txtClave.Text = "";
                        }
                        catch
                        {
                            MessageBox.Show("Error al crear usuario", "Atención!!",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        if (!mayuscula)
                        {
                            MessageBox.Show("La clave ingresada no contiene ninguna mayúscula.", "Atención!!",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        if (!minuscula)
                        {
                            MessageBox.Show("La clave ingresada no contiene ninguna minúscula.", "Atención!!",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        if (!numero)
                        {
                            MessageBox.Show("La clave ingresada no contiene ningún número.", "Atención!!",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                        txtClave.Focus();
                    }
                }
            }
        }

        private bool validarMinusculaClave(string clave)
        {
            bool resultado = false;
            string claveMinuscula = clave.ToLower();
            int minuscula = 0;

            for (int i = 0; i < clave.Length; i++)
            {
                if (!char.IsDigit(clave[i]) && clave[i] == claveMinuscula[i])
                {
                    minuscula++;
                }
            }

            if (minuscula > 0) { resultado = true; }

            return resultado;
        }

        private bool validarMayusculaClave(string clave)
        {
            bool resultado = false;
            string claveMayuscula = clave.ToUpper();
            int mayuscula = 0;

            for (int i = 0; i < clave.Length; i++)
            {
                if (!char.IsDigit(clave[i]) && clave[i] == claveMayuscula[i])
                {
                    mayuscula++;
                }
            }

            if (mayuscula > 0) { resultado = true; }

            return resultado;
        }

        private bool validarNumeroClave(string clave)
        {
            bool resultado = false;
            int numero = 0;

            for (int i = 0; i < clave.Length; i++)
            {
                if (char.IsNumber(clave, i))
                {
                    numero++;
                }
            }

            if (numero > 0) { resultado = true; }

            return resultado;
        }

        private bool validarMail(string mail)
        {
            bool resultado = false;
            int len = mail.Length;

            if (mail.Contains("@") && mail.Contains(".com") && !mail.Contains("@.com") && len > 5)
            {
                resultado = true;
            }

            return resultado;
        }

        private void txtNombres_TextChanged(object sender, EventArgs e)
        {
            string nombres = txtNombres.Text;
            int len = nombres.Length;

            if (nombres != "" && len >= 3) 
            {
                txtApellidos.Enabled = true;

                string tipo = cbTipoUsuario.SelectedItem.ToString();
                string apellidos = txtApellidos.Text;
                string mail = txtMail.Text;
                string dni = txtDni.Text;
                string clave = txtClave.Text;
                bool claveValida = false, mailValido = false;
                if (validarMayusculaClave(clave) && validarMinusculaClave(clave) && validarNumeroClave(clave))
                {
                    claveValida = true;
                }
                if (validarMail(mail)) 
                { 
                    mailValido = true; 
                }

                if (tipo != "-" && apellidos.Length >= 3 && mailValido && dni.Length >= 7 && claveValida)
                {
                    btnRegistrar.Enabled = true;
                }
            }
            else 
            {
                txtApellidos.Enabled = false;
                txtDni.Enabled = false;
                txtMail.Enabled = false;
                txtClave.Enabled = false;
                btnRegistrar.Enabled = false;
            }
        }

        private void txtApellidos_TextChanged(object sender, EventArgs e)
        {
            string apellidos = txtApellidos.Text;
            int len = apellidos.Length;

            if (apellidos != "" && len >= 3) 
            {
                txtMail.Enabled = true;

                string tipo = cbTipoUsuario.SelectedItem.ToString();
                string nombres = txtNombres.Text;
                string mail = txtMail.Text;
                string dni = txtDni.Text;
                string clave = txtClave.Text;
                bool claveValida = false, mailValido = false;
                if (validarMayusculaClave(clave) && validarMinusculaClave(clave) && validarNumeroClave(clave))
                {
                    claveValida = true;
                }
                if (validarMail(mail))
                {
                    mailValido = true;
                }

                if (tipo != "-" && nombres.Length >= 3 && mailValido && dni.Length >= 7 && claveValida)
                {
                    btnRegistrar.Enabled = true;
                }
            }
            else 
            {
                txtMail.Enabled = false;
                txtDni.Enabled = false;
                txtClave.Enabled = false;
                btnRegistrar.Enabled = false;
            }
        }

        private void txtMail_TextChanged(object sender, EventArgs e)
        {
            string mail = txtMail.Text;
            int len = mail.Length;
            bool mailValido = validarMail(mail);

            if (mailValido) 
            {
                lblMailValido.Visible = true;
                lblMailInvalido.Visible = false;
                txtDni.Enabled = true;

                string tipo = cbTipoUsuario.SelectedItem.ToString();
                string nombres = txtNombres.Text;
                string apellidos = txtApellidos.Text;
                string dni = txtDni.Text;
                string clave = txtClave.Text;
                bool claveValida = false;
                if (validarMayusculaClave(clave) && validarMinusculaClave(clave) && validarNumeroClave(clave))
                {
                    claveValida = true;
                }

                if (tipo != "-" && nombres.Length >= 3 && apellidos.Length >= 3 && dni.Length >= 7 && claveValida)
                {
                    btnRegistrar.Enabled = true;
                }
            }
            else 
            {
                lblMailValido.Visible = false;
                lblMailInvalido.Visible = true;
                txtDni.Enabled = false;
                txtClave.Enabled = false;
                btnRegistrar.Enabled = false;
            }
        }

        private void txtDni_TextChanged(object sender, EventArgs e)
        {
            string dni = txtDni.Text;
            int len = dni.Length;

            if (dni != "" && len >= 7)
            {
                txtClave.Enabled = true;

                string tipo = cbTipoUsuario.SelectedItem.ToString();
                string nombres = txtNombres.Text;
                string apellidos = txtApellidos.Text;
                string mail = txtMail.Text;
                string clave = txtClave.Text;
                bool claveValida = false, mailValido = false;
                if (validarMayusculaClave(clave) && validarMinusculaClave(clave) && validarNumeroClave(clave))
                {
                    claveValida = true;
                }
                if (validarMail(mail))
                {
                    mailValido = true;
                }

                if (tipo != "-" && nombres.Length >= 3 && apellidos.Length >= 3 && mailValido && claveValida)
                {
                    btnRegistrar.Enabled = true;
                }
            }
            else
            {
                txtClave.Enabled = false;
                btnRegistrar.Enabled = false;
            }
        }

        private void txtClave_TextChanged(object sender, EventArgs e)
        {
            string clave = txtClave.Text;
            int len = clave.Length;

            if (txtClave.Text == "") 
            {
                lblCaracteres.ForeColor = Color.Red;
                lblCaracteres.Visible = true;
                lblMayus.ForeColor = Color.Red;
                lblMayus.Visible = true;
                lblMinus.ForeColor = Color.Red;
                lblMinus.Visible = true;
                lblNum.ForeColor = Color.Red;
                lblNum.Visible = true;
                btnRegistrar.Enabled = false;
            }
            else 
            {
                bool mayuscula = validarMayusculaClave(clave), 
                     minuscula = validarMinusculaClave(clave),
                     numero = validarNumeroClave(clave),
                     claveValida = false;
                
                if (mayuscula && minuscula && numero && len == 8) { claveValida = true; }

                if (len >= 8) { lblCaracteres.ForeColor = Color.ForestGreen; lblCaracteres.Visible = false; }
                else { lblCaracteres.ForeColor = Color.Red; lblCaracteres.Visible = true; }

                if (mayuscula) { lblMayus.ForeColor = Color.ForestGreen; lblMayus.Visible = false; }
                else { lblMayus.ForeColor = Color.Red; lblMayus.Visible = true; }

                if (minuscula) { lblMinus.ForeColor = Color.ForestGreen; lblMinus.Visible = false; }
                else { lblMinus.ForeColor = Color.Red; lblMinus.Visible = true; }

                if (numero) { lblNum.ForeColor = Color.ForestGreen; lblNum.Visible = false; }
                else { lblNum.ForeColor = Color.Red; lblNum.Visible = true; }

                if (claveValida)
                {
                    string tipo = cbTipoUsuario.SelectedItem.ToString();
                    string nombres = txtNombres.Text;
                    string apellidos = txtApellidos.Text;
                    string mail = txtMail.Text;
                    string dni = txtDni.Text;
                    bool mailValido = false;
                    if (validarMail(mail))
                    {
                        mailValido = true;
                    }

                    if (tipo != "-" && nombres.Length >= 3 && apellidos.Length >= 3 && mailValido && dni.Length >= 7)
                    {
                        btnRegistrar.Enabled = true;
                    }
                }
                else
                {
                    btnRegistrar.Enabled = false;
                }
            }
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(sender, e);
        }

        private void soloNumeros(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void soloLetras(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar == ' ')
            {
                e.Handled = false;
            }
            else if (e.KeyChar == '-')
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloLetras(sender, e);
        }

        private void txtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloLetras(sender, e);
        }

        private void txtClave_Enter(object sender, EventArgs e)
        {
            string clave = txtClave.Text;
            int len = clave.Length;
            bool mayuscula = validarMayusculaClave(clave),
                     minuscula = validarMinusculaClave(clave),
                     numero = validarNumeroClave(clave);

            if (len >= 8) { lblCaracteres.ForeColor = Color.ForestGreen; lblCaracteres.Visible = false; }
            else { lblCaracteres.ForeColor = Color.Red; lblCaracteres.Visible = true; }

            if (mayuscula) { lblMayus.ForeColor = Color.ForestGreen; lblMayus.Visible = false; }
            else { lblMayus.ForeColor = Color.Red; lblMayus.Visible = true; }

            if (minuscula) { lblMinus.ForeColor = Color.ForestGreen; lblMinus.Visible = false; }
            else { lblMinus.ForeColor = Color.Red; lblMinus.Visible = true; }

            if (numero) { lblNum.ForeColor = Color.ForestGreen; lblNum.Visible = false; }
            else { lblNum.ForeColor = Color.Red; lblNum.Visible = true; }

            cbMostrarClave.Enabled = true;
        }

        private void txtClave_Leave(object sender, EventArgs e)
        {
            lblCaracteres.Visible = false;
            lblMayus.Visible = false;
            lblMinus.Visible = false;
            lblNum.Visible = false;
        }

        private void txtMail_Enter(object sender, EventArgs e)
        {
            lblMailInvalido.Visible = true;
        }

        private void txtMail_Leave(object sender, EventArgs e)
        {
            lblMailInvalido.Visible = false;
            lblMailValido.Visible = false;
        }

        private void cbTipoUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTipoUsuario.SelectedItem.ToString() != "-")
            {
                int lenNombres = txtNombres.Text.Length;
                int lenApellidos = txtApellidos.Text.Length;
                int lenDni = txtDni.Text.Length;
                bool mailValido = validarMail(txtMail.Text);
                string clave = txtClave.Text;
                bool claveValida = false;
                if (validarMayusculaClave(clave) && validarMinusculaClave(clave) && validarNumeroClave(clave))
                {
                    claveValida = true;
                }

                txtNombres.Enabled = true;
                if (lenNombres >= 3) { txtApellidos.Enabled = true; }
                if (lenApellidos >= 3 && lenNombres >= 3) { txtMail.Enabled = true; }
                if (lenNombres >= 3 && lenApellidos >= 3 && mailValido) { txtDni.Enabled = true; }
                if (lenNombres >= 3 && lenApellidos >= 3 && mailValido && lenDni >= 7) { txtClave.Enabled = true; }
                if (lenNombres >= 3 && lenApellidos >= 3 && mailValido && lenDni >= 7 && claveValida)
                {
                    btnRegistrar.Enabled = true;
                }
                else
                {
                    btnRegistrar.Enabled = false;
                }
            }
            else
            {
                txtNombres.Enabled = false;
                txtApellidos.Enabled = false;
                txtDni.Enabled = false;
                txtMail.Enabled = false;
                txtClave.Enabled = false;
            }
        }

        private void txtClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == " ")
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void txtMail_KeyPress(object sender, KeyPressEventArgs e)
        {
            string mail = txtMail.Text;

            if (mail.Length < 3 && e.KeyChar == '@')
            {
                e.Handled = true;
            }
            else if (mail.Contains("@") && mail.Contains(".com"))
            {
                e.Handled = true;

                if (Char.IsControl(e.KeyChar))
                {
                    if (e.KeyChar == (char)Keys.Delete)
                    {
                        e.Handled = true;
                    }
                    else
                    {
                        e.Handled = false;
                    }
                }
            }
            else if (mail.Contains("@"))
            {
                if (Char.IsLetter(e.KeyChar) || e.KeyChar == '.')
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            else if (Char.IsNumber(e.KeyChar) || Char.IsControl(e.KeyChar) || e.KeyChar == '_' ||
                e.KeyChar == '-' || e.KeyChar == '.' || e.KeyChar == '@' || Char.IsLetter(e.KeyChar))
            {
                if (e.KeyChar != 'ñ')
                {
                    e.Handled = false;
                }
            }
            else
            {
                e.Handled = true;
            }
        }

        private void cbMostrarClave_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMostrarClave.Checked)
            {
                txtClave.UseSystemPasswordChar = false;
            }
            else
            {
                txtClave.UseSystemPasswordChar = true;
            }
        }
    }
}
