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
            btnRegistrar.Enabled = false;

            txtApellidos.Enabled = false;
            txtMail.Enabled = false;
            txtUsername.Enabled = false;
            txtClave.Enabled = false;

            txtNombres.Text = "";
            txtApellidos.Text = "";
            txtMail.Text = "";
            txtUsername.Text = "";
            txtClave.Text = "";

            txtNombres.BackColor = Color.White;
            txtApellidos.BackColor = Color.White;
            txtMail.BackColor = Color.White;
            txtUsername.BackColor = Color.White;
            txtClave.BackColor = Color.White;
        }


        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtNombres.Text == "" || txtApellidos.Text == "" || txtMail.Text == "" || txtUsername.Text == "" || txtClave.Text == "" || txtClave.Text.Length < 8)
            {
                MessageBox.Show("Hay campos vacíos y/o la clave es menor de 8 caracteres.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                if (txtUsername.Text == "")
                {
                    txtUsername.BackColor = Color.LightSalmon;
                }
                if (txtClave.Text == "")
                {
                    txtClave.BackColor = Color.LightSalmon;
                }
            }
            else
            {
                AccesoDatos datos = new AccesoDatos();

                string nombres = txtNombres.Text, apellidos = txtApellidos.Text, mail = txtMail.Text, usuario = txtUsername.Text, clave = txtClave.Text;

                string insertUsuario = "insert into Usuarios(Nombre, Apellido, Mail, Username, Clave) values('" + nombres + "', '" + apellidos + "', '" +
                    mail + "', '" + usuario + "', PWDENCRYPT('" + clave + "'))";

                try
                {
                    datos.SetearConsulta(insertUsuario);
                    datos.EjecutarLectura();
                    datos.CerrarConexion();

                    MessageBox.Show("Usuario creado correctamente.", "Atención!");

                    DialogResult result = MessageBox.Show("¿ Desea agregar otro usuario ?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.No)
                    {
                        this.Close();
                    }
                    else
                    {
                        txtNombres.Text = "";
                        txtApellidos.Text = "";
                        txtMail.Text = "";
                        txtUsername.Text = "";
                        txtClave.Text = "";

                        txtNombres.BackColor = Color.White;
                        txtApellidos.BackColor = Color.White;
                        txtMail.BackColor = Color.White;
                        txtUsername.BackColor = Color.White;
                        txtClave.BackColor = Color.White;
                    }
                }
                catch
                {
                    MessageBox.Show("Error al crear usuario", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
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
            if (txtMail.Text == "") { txtMail.BackColor = Color.LightSalmon; txtUsername.Enabled = false; }
            else { txtMail.BackColor = Color.White; }
            if (txtMail.Text.Length >= 5) { txtUsername.Enabled = true; }

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if (txtUsername.Text == "") { txtUsername.BackColor = Color.LightSalmon; txtClave.Enabled = false; }
            else { txtUsername.BackColor = Color.White; }
            if (txtUsername.Text.Length >= 5) { txtClave.Enabled = true; }
        }

        private void txtClave_TextChanged(object sender, EventArgs e)
        {
            if (txtClave.Text == "") { txtClave.BackColor = Color.LightSalmon; }
            else { txtClave.BackColor = Color.White; }
            if (txtClave.Text.Length == 8) { btnRegistrar.Enabled = true; }
        }
    }
}
