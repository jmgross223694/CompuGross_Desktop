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
        public AgregarUsuario()
        {
            InitializeComponent();
        }

        private void AgregarUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'compuGrossDataSet1.Localidades' Puede moverla o quitarla según sea necesario.
            //this.localidadesTableAdapter.Fill(this.compuGrossDataSet1.Localidades);
            btnRegistrar.Enabled = false;

            //cbTipoUsuario.Enabled = false;
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

            txtNombres.BackColor = Color.White;
            txtApellidos.BackColor = Color.White;
            txtMail.BackColor = Color.White;
            txtDni.BackColor = Color.White;
            txtClave.BackColor = Color.White;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (cbTipoUsuario.SelectedItem.ToString() == "-" || txtNombres.Text == "" || txtApellidos.Text == "" 
                || txtMail.Text == "" || !txtMail.Text.Contains("@") || !txtMail.Text.Contains(".com")
                || txtDni.Text == "" || txtClave.Text == "" || txtClave.Text.Length < 8)
            {
                MessageBox.Show("Hay datos inválidos o sin completar.", "Atención!", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                if (cbTipoUsuario.SelectedItem.ToString() == "-")
                {
                    cbTipoUsuario.BackColor = Color.LightSalmon;
                }
                if (txtNombres.Text == "")
                {
                    txtNombres.BackColor = Color.LightSalmon;
                }
                if (txtApellidos.Text == "")
                {
                    txtApellidos.BackColor = Color.LightSalmon;
                }
                if (txtMail.Text == "")
                {
                    txtMail.BackColor = Color.LightSalmon;
                }
                if (!txtMail.Text.Contains("@") && !txtMail.Text.Contains(".com"))
                {
                    MessageBox.Show("Mail inválido.", "Atención!!",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    txtMail.BackColor = Color.LightSalmon;
                }
                if (txtDni.Text == "")
                {
                    txtDni.BackColor = Color.LightSalmon;
                }
                if (txtClave.Text == "" || txtClave.Text.Length < 8)
                {
                    if (txtClave.Text.Length < 8)
                    {
                        MessageBox.Show("La clave es menor a 8 caracteres.", "Atención!!",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    txtClave.BackColor = Color.LightSalmon;
                }
            }
            else
            {
                txtClave.BackColor = Color.White;

                bool claveValida = validarMayusculaClave(txtClave.Text);
                claveValida = validarNumeroClave(txtClave.Text);
                claveValida = validarMinusculaClave(txtClave.Text);

                if (claveValida == true)
                {

                    AccesoDatos datos = new AccesoDatos();

                    string tipo = cbTipoUsuario.SelectedItem.ToString(), nombres = txtNombres.Text,
                        apellidos = txtApellidos.Text, mail = txtMail.Text, usuario = txtDni.Text + ".cg",
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

                        DialogResult result = MessageBox.Show("¿ Desea agregar otro usuario ?", "Confirmar",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.No)
                        {
                            this.Close();
                        }
                        else
                        {
                            txtNombres.Text = "";
                            txtApellidos.Text = "";
                            txtMail.Text = "";
                            txtDni.Text = "";
                            txtClave.Text = "";

                            txtNombres.BackColor = Color.White;
                            txtApellidos.BackColor = Color.White;
                            txtMail.BackColor = Color.White;
                            txtDni.BackColor = Color.White;
                            txtClave.BackColor = Color.White;
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Error al crear usuario", "Atención!!",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Clave inválida.", "Atención!!",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtClave.BackColor = Color.LightSalmon;
                    txtClave.Focus();
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
                if (clave[i] == claveMinuscula[i])
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
                if (clave[i] == claveMayuscula[i])
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

        private void txtNombres_TextChanged(object sender, EventArgs e)
        {
            if (txtNombres.Text == "") { txtNombres.BackColor = Color.LightSalmon; txtApellidos.Enabled = false; }
            else { txtNombres.BackColor = Color.White; }
            if (txtNombres.Text.Length >= 5) { txtApellidos.Enabled = true; }
        }

        private void txtApellidos_TextChanged(object sender, EventArgs e)
        {
            if (txtApellidos.Text == "") { txtApellidos.BackColor = Color.LightSalmon; txtMail.Enabled = false; }
            else { txtApellidos.BackColor = Color.White; }
            if (txtApellidos.Text.Length >= 5) { txtMail.Enabled = true; }
        }

        private void txtMail_TextChanged(object sender, EventArgs e)
        {
            if (txtMail.Text == "") { txtMail.BackColor = Color.LightSalmon; txtDni.Enabled = false; }
            else { txtMail.BackColor = Color.White; }
            if (txtMail.Text.Length >= 5) { txtDni.Enabled = true; }

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if (txtDni.Text == "") { txtDni.BackColor = Color.LightSalmon; txtClave.Enabled = false; }
            else { txtDni.BackColor = Color.White; }
            if (txtDni.Text.Length >= 5) { txtClave.Enabled = true; }
        }

        private void txtClave_TextChanged(object sender, EventArgs e)
        {
            if (txtClave.Text == "") { txtClave.BackColor = Color.LightSalmon; }
            else { txtClave.BackColor = Color.White; }
            if (txtClave.Text.Length == 8) { btnRegistrar.Enabled = true; }
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
    }
}
