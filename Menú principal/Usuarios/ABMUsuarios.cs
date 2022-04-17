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
using Dominio;

namespace CompuGross
{
    public partial class ABMUsuarios : Form
    {
        private string user = "", tipo = "";
        private List<Usuario> listaUsuarios = new List<Usuario>();

        public ABMUsuarios(string user, string tipo)
        {
            InitializeComponent();
            this.user = user;
            this.tipo = tipo;
        }

        private void AgregarUsuario_Load(object sender, EventArgs e)
        {
            VisibilidadCamposAgregarUsuario("hide");
            dgvUsuarios.Visible = true;
            txtFiltro.Visible = true;
            lblFiltro.Visible = true;
            btnCancelar.Visible = false;
            CargarListadoUsuarios();
            OrdenarColumnasUsuarios();
            OcultarColumnasListadoUsuarios();
            AlinearColumnasListadoUsuarios();
            RenombrarColumnasListadoUsuarios();
        }

        private void VisibilidadInicialAgregarUsuario()
        {
            btnRegistrar.Enabled = false;

            txtNombres.Enabled = false;
            txtApellidos.Enabled = false;
            txtMail.Enabled = false;
            txtDni.Enabled = false;
            txtClave.Enabled = false;

            lblMailInvalido.Visible = false;
            lblMailValido.Visible = false;

            lblCaracteres.Visible = false;
            lblMayus.Visible = false;
            lblMinus.Visible = false;
            lblNum.Visible = false;

            cbMostrarClave.Enabled = false;

            ResetearCamposNuevoUsuario();
        }

        private void VisibilidadCamposAgregarUsuario(string aux)
        {
            if (aux == "hide")
            {
                lblAsterisco1.Visible = false;
                lblAsterisco2.Visible = false;
                lblAsterisco3.Visible = false;
                lblAsterisco4.Visible = false;
                lblAsterisco5.Visible = false;
                lblAsterisco6.Visible = false;
                lblTipoUsuario.Visible = false;
                ddlTipoUsuario.Visible = false;
                lblNombres.Visible = false;
                txtNombres.Visible = false;
                lblApellidos.Visible = false;
                txtApellidos.Visible = false;
                lblMail.Visible = false;
                txtMail.Visible = false;
                lblMailValido.Visible = false;
                lblMailInvalido.Visible = false;
                lblDni.Visible = false;
                txtDni.Visible = false;
                lblClave.Visible = false;
                txtClave.Visible = false;
                cbMostrarClave.Visible = false;
                lblCaracteres.Visible = false;
                lblMayus.Visible = false;
                lblMinus.Visible = false;
                lblNum.Visible = false;
                btnRegistrar.Visible = false;
            }
            if (aux == "show")
            {
                lblAsterisco1.Visible = true;
                lblAsterisco2.Visible = true;
                lblAsterisco3.Visible = true;
                lblAsterisco4.Visible = true;
                lblAsterisco5.Visible = true;
                lblAsterisco6.Visible = true;
                lblTipoUsuario.Visible = true;
                ddlTipoUsuario.Visible = true;
                lblNombres.Visible = true;
                txtNombres.Visible = true;
                lblApellidos.Visible = true;
                txtApellidos.Visible = true;
                lblMail.Visible = true;
                txtMail.Visible = true;
                lblMailValido.Visible = true;
                lblMailInvalido.Visible = true;
                lblDni.Visible = true;
                txtDni.Visible = true;
                lblClave.Visible = true;
                txtClave.Visible = true;
                cbMostrarClave.Visible = true;
                lblCaracteres.Visible = true;
                lblMayus.Visible = true;
                lblMinus.Visible = true;
                lblNum.Visible = true;
                btnRegistrar.Visible = true;
            }
        }

        private void ResetearCamposNuevoUsuario()
        {
            ddlTipoUsuario.SelectedItem = "-";
            txtNombres.Text = "";
            txtApellidos.Text = "";
            txtMail.Text = "";
            txtDni.Text = "";
            txtClave.Text = "";
        }

        private void CargarListadoUsuarios()
        {
            UsuarioDB usuarioDB = new UsuarioDB();

            try
            {
                listaUsuarios = usuarioDB.Listar();
                dgvUsuarios.DataSource = listaUsuarios;
            }
            catch
            {
                MessageBox.Show("No se pudo cargar el listado de Usuarios.", "Atención!!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void OrdenarColumnasUsuarios()
        {
            dgvUsuarios.AllowUserToOrderColumns = true;

            dgvUsuarios.Columns["Tipo"].DisplayIndex = 0;
            dgvUsuarios.Columns["Nombres"].DisplayIndex = 1;
            dgvUsuarios.Columns["Apellidos"].DisplayIndex = 2;
            dgvUsuarios.Columns["DNI"].DisplayIndex = 3;
            dgvUsuarios.Columns["Mail"].DisplayIndex = 4;

            dgvUsuarios.AllowUserToOrderColumns = false;
        }

        private void AlinearColumnasListadoUsuarios()
        {
            dgvUsuarios.Columns["Tipo"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvUsuarios.Columns["Nombres"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvUsuarios.Columns["Apellidos"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvUsuarios.Columns["DNI"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvUsuarios.Columns["Mail"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvUsuarios.Columns["Tipo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvUsuarios.Columns["Nombres"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvUsuarios.Columns["Apellidos"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvUsuarios.Columns["DNI"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvUsuarios.Columns["Mail"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        }

        private void RenombrarColumnasListadoUsuarios()
        {
            dgvUsuarios.Columns["Nombres"].HeaderText = "Nombre";
            dgvUsuarios.Columns["Apellidos"].HeaderText = "Apellido";
            dgvUsuarios.Columns["DNI"].HeaderText = "Usuario";
        }

        private void OcultarColumnasListadoUsuarios()
        {
            dgvUsuarios.Columns["ID"].Visible = false;
            dgvUsuarios.Columns["Clave"].Visible = false;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (ddlTipoUsuario.SelectedItem.ToString() == "-" || txtNombres.Text == "" || txtApellidos.Text == ""
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
            else if (lblTitulo.Text == "MODIFICAR USUARIO") //Modificar Usuario
            {
                UsuarioDB uDB = new UsuarioDB();
                Usuario u = new Usuario();
                u.Id = Convert.ToInt32(txtFiltro.Text);
                u.Tipo = ddlTipoUsuario.SelectedItem.ToString();
                u.Nombres = txtNombres.Text;
                u.Apellidos = txtApellidos.Text;
                u.Mail = txtMail.Text;
                u.Dni = txtDni.Text;
                u.Clave = txtClave.Text;

                try
                {
                    int resultado = uDB.ModificarUsuario(u);

                    if (resultado != 1)
                    {
                        MessageBox.Show("No se pudo modificar Usuario/a " + u.Nombres + " " + u.Apellidos + ".", "Atención!!",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Usuario/a " + u.Nombres + " " + u.Apellidos + " modificado/a correctamente.", "Atención!!",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ClickBtnCancelar();
                    }
                }
                catch
                {
                    MessageBox.Show("No se pudo modificar Usuario/a " + u.Nombres + " " + u.Apellidos + ".", "Atención!!",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else //Agregar Usuario/a nuevo/a
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
                        Usuario u = new Usuario();
                        u.Tipo = ddlTipoUsuario.SelectedItem.ToString();
                        u.Nombres = txtNombres.Text;
                        u.Apellidos = txtApellidos.Text;
                        u.Mail = txtMail.Text;
                        u.Dni = txtDni.Text;
                        u.Clave = txtClave.Text;

                        try
                        {
                            UsuarioDB uDB = new UsuarioDB();
                            int resultado = uDB.AgregarUsuario(u);

                            if (resultado != 1)
                            {
                                MessageBox.Show("El DNI o Mail ya se encuentran registrados en el sistema.", "Atención!!",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                MessageBox.Show("Usuario creado correctamente.", "Atención!!",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                                txtNombres.Text = "";
                                txtApellidos.Text = "";
                                txtMail.Text = "";
                                txtDni.Text = "";
                                txtClave.Text = "";

                                ClickBtnCancelar();
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

                string tipo = ddlTipoUsuario.SelectedItem.ToString();
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

                if (lblTitulo.Text == "MODIFICAR USUARIO")
                {
                    ddlTipoUsuario.Enabled = true;
                    txtNombres.Enabled = true;
                    txtApellidos.Enabled = true;
                    txtDni.Enabled = true;
                    txtMail.Enabled = true;
                    txtClave.Enabled = true;
                    btnRegistrar.Enabled = true;
                }
            }
        }

        private void txtApellidos_TextChanged(object sender, EventArgs e)
        {
            string apellidos = txtApellidos.Text;
            int len = apellidos.Length;

            if (apellidos != "" && len >= 3)
            {
                txtMail.Enabled = true;

                string tipo = ddlTipoUsuario.SelectedItem.ToString();
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

                if (lblTitulo.Text == "MODIFICAR USUARIO")
                {
                    ddlTipoUsuario.Enabled = true;
                    txtNombres.Enabled = true;
                    txtApellidos.Enabled = true;
                    txtDni.Enabled = true;
                    txtMail.Enabled = true;
                    txtClave.Enabled = true;
                    btnRegistrar.Enabled = true;
                }
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

                string tipo = ddlTipoUsuario.SelectedItem.ToString();
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

                if (lblTitulo.Text == "MODIFICAR USUARIO")
                {
                    ddlTipoUsuario.Enabled = true;
                    txtNombres.Enabled = true;
                    txtApellidos.Enabled = true;
                    txtDni.Enabled = true;
                    txtMail.Enabled = true;
                    txtClave.Enabled = true;
                    btnRegistrar.Enabled = true;
                }
            }
        }

        private void txtDni_TextChanged(object sender, EventArgs e)
        {
            string dni = txtDni.Text;
            int len = dni.Length;

            if (dni != "" && len >= 7)
            {
                txtClave.Enabled = true;

                string tipo = ddlTipoUsuario.SelectedItem.ToString();
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

                if (lblTitulo.Text == "MODIFICAR USUARIO")
                {
                    ddlTipoUsuario.Enabled = true;
                    txtNombres.Enabled = true;
                    txtApellidos.Enabled = true;
                    txtDni.Enabled = true;
                    txtMail.Enabled = true;
                    txtClave.Enabled = true;
                    btnRegistrar.Enabled = true;
                }
            }
        }

        private void txtClave_TextChanged(object sender, EventArgs e)
        {
            string clave = txtClave.Text;
            int len = clave.Length;

            if (clave == "")
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

                if (mayuscula && minuscula && numero && len >= 8) { claveValida = true; }

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
                    string tipo = ddlTipoUsuario.SelectedItem.ToString();
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

                    if (lblTitulo.Text == "MODIFICAR USUARIO")
                    {
                        ddlTipoUsuario.Enabled = true;
                        txtNombres.Enabled = true;
                        txtApellidos.Enabled = true;
                        txtDni.Enabled = true;
                        txtMail.Enabled = true;
                        txtClave.Enabled = true;
                        btnRegistrar.Enabled = true;
                    }
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
            string mail = txtMail.Text;
            int len = mail.Length;
            if (mail == "")
            {
                lblMailInvalido.Visible = true;
            }
            else
            {
                validarMail(mail);
            }
        }

        private void txtMail_Leave(object sender, EventArgs e)
        {
            lblMailInvalido.Visible = false;
            lblMailValido.Visible = false;
        }

        private void cbTipoUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlTipoUsuario.SelectedItem.ToString() != "-")
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

                if (lblTitulo.Text == "MODIFICAR USUARIO")
                {
                    ddlTipoUsuario.Enabled = true;
                    txtNombres.Enabled = true;
                    txtApellidos.Enabled = true;
                    txtDni.Enabled = true;
                    txtMail.Enabled = true;
                    txtClave.Enabled = true;
                    btnRegistrar.Enabled = true;
                }
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

            if (lblMailValido.Visible == true && lblMailInvalido.Visible == false)
            {
                e.Handled = false;
            }
            else
            {

                if (mail.Length < 3 && e.KeyChar == '@')
                {
                    e.Handled = true;
                }
                else if (mail.Contains("@") && mail.Contains(".com"))
                {
                    e.Handled = true;

                    if (e.KeyChar == (char)Keys.Delete)
                    {
                        e.Handled = true;
                    }
                    else
                    {
                        e.Handled = false;
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
            if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            dgvUsuarios.Visible = false;
            lblFiltro.Visible = false;
            txtFiltro.Visible = false;
            btnAgregar.Visible = false;
            btnModificar.Visible = false;
            btnEliminar.Visible = false;
            btnCancelar.Visible = true;
            VisibilidadCamposAgregarUsuario("show");
            VisibilidadInicialAgregarUsuario();

            lblTitulo.Text = "NUEVO USUARIO";
        }

        private void ClickBtnCancelar()
        {
            ResetearCamposNuevoUsuario();
            VisibilidadCamposAgregarUsuario("hide");
            CargarListadoUsuarios();
            OrdenarColumnasUsuarios();
            OcultarColumnasListadoUsuarios();
            AlinearColumnasListadoUsuarios();
            RenombrarColumnasListadoUsuarios();
            dgvUsuarios.Visible = true;
            lblFiltro.Visible = true;
            txtFiltro.Visible = true;
            txtFiltro.Text = "";
            btnAgregar.Visible = true;
            btnModificar.Visible = true;
            btnEliminar.Visible = true;
            btnCancelar.Visible = false;

            lblTitulo.Text = "USUARIOS";
            btnRegistrar.Text = "Registrar";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ClickBtnCancelar();
        }

        private void CargarCamposUsuarioSeleccionado(Usuario u)
        {
            ddlTipoUsuario.SelectedItem = u.Tipo;
            txtFiltro.Text = u.Id.ToString();
            txtNombres.Text = u.Nombres;
            txtApellidos.Text = u.Apellidos;
            txtMail.Text = u.Mail;
            txtDni.Text = u.Dni;
            txtClave.Text = "";

            btnRegistrar.Enabled = false;
            ddlTipoUsuario.Focus();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            dgvUsuarios.Visible = false;
            lblFiltro.Visible = false;
            txtFiltro.Visible = false;
            btnAgregar.Visible = false;
            btnModificar.Visible = false;
            btnEliminar.Visible = false;
            btnCancelar.Visible = true;
            VisibilidadCamposAgregarUsuario("show");
            VisibilidadInicialAgregarUsuario();

            Usuario u = new Usuario();
            u = (Usuario)dgvUsuarios.CurrentRow.DataBoundItem;
            CargarCamposUsuarioSeleccionado(u);

            ddlTipoUsuario.Enabled = true;
            txtNombres.Enabled = true;
            txtApellidos.Enabled = true;
            txtMail.Enabled = true;
            txtDni.Enabled = true;
            txtClave.Enabled = true;

            lblTitulo.Text = "MODIFICAR USUARIO";
            btnRegistrar.Text = "Confirmar";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Usuario u = new Usuario();

            u = (Usuario)dgvUsuarios.CurrentRow.DataBoundItem;

            if (MessageBox.Show("¿Confirma eliminar Usuario/a " + u.Nombres + " " + u.Apellidos + "?", "Atención!!",
                  MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                UsuarioDB uDB = new UsuarioDB();

                int resultado = uDB.EliminarUsuario(u.Id, u.Tipo);

                if (resultado != 1)
                {
                    MessageBox.Show("No se pudo eliminar Usuario/a " + u.Nombres + " " + u.Apellidos + ".", "Atención!!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (resultado == 1)
                {
                    MessageBox.Show("Usuario/a " + u.Nombres + " " + u.Apellidos + " eliminado/a correctamente.", "Atención!!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ClickBtnCancelar();
                }
            }
        }

        private void FiltrarUsuarios()
        {
            CargarListadoUsuarios();
            OcultarColumnasListadoUsuarios();
            AlinearColumnasListadoUsuarios();
            RenombrarColumnasListadoUsuarios();
            OrdenarColumnasUsuarios();

            List<Usuario> filtro;
            if (txtFiltro.Text != "")
            {
                filtro = listaUsuarios.FindAll(Art => Art.Tipo.ToUpper().Contains(txtFiltro.Text.ToUpper()) ||
                                               Art.Nombres.ToUpper().Contains(txtFiltro.Text.ToUpper()) ||
                                               Art.Apellidos.ToUpper().Contains(txtFiltro.Text.ToUpper()) ||
                                               Art.Mail.ToUpper().Contains(txtFiltro.Text.ToUpper()) ||
                                               Art.Dni.ToUpper().Contains(txtFiltro.Text.ToUpper()));
                dgvUsuarios.DataSource = null;
                dgvUsuarios.DataSource = filtro;
            }
            else
            {
                dgvUsuarios.DataSource = null;
                dgvUsuarios.DataSource = listaUsuarios;
            }
            OcultarColumnasListadoUsuarios();
            AlinearColumnasListadoUsuarios();
            RenombrarColumnasListadoUsuarios();
            OrdenarColumnasUsuarios();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            FiltrarUsuarios();
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
