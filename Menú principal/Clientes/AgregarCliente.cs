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
    public partial class AgregarCliente : Form
    {
        private Cliente cliente = null;
        public AgregarCliente()
        {
            InitializeComponent();
            Text = "Agregar Cliente";
        }

        public AgregarCliente(Cliente cliente)
        {
            InitializeComponent();
            this.cliente = cliente;
            Text = "Modificar Cliente";
        }

        private void Agregar_Load(object sender, EventArgs e)
        {
            btnConfirmar.Text = "Confirmar";
            cargarDdlLocalidades();
            txtTelefonoEditar.Visible = false;
            txtTelefonoEditar.Enabled = false;
            lblTel1.Visible = true;
            lblTel2.Visible = true;
            txtTelefono1.Visible = true;
            txtTelefono2.Visible = true;
            txtTelefono3.Visible = true;
            txtTelefono1.Enabled = true;
            txtTelefono2.Enabled = true;
            txtTelefono3.Enabled = true;
            txtTelefono1.TextAlign = HorizontalAlignment.Center;
            txtTelefono2.TextAlign = HorizontalAlignment.Center;
            txtTelefono3.TextAlign = HorizontalAlignment.Center;
            if (txtNombres.Text == "")
            {
                txtNombres.BackColor = Color.LightSalmon;
                btnConfirmar.Enabled = false;
            }
            if (txtTelefono1.Text == "" || txtTelefono2.Text == "" || txtTelefono3.Text == "")
            {
                txtTelefono1.BackColor = Color.LightSalmon;
                txtTelefono2.BackColor = Color.LightSalmon;
                txtTelefono3.BackColor = Color.LightSalmon;
                btnConfirmar.Enabled = false;
                txtTelefono2.Enabled = false;
                txtTelefono3.Enabled = false;
            }

            if (cliente != null)
            {
                lblMailValido.Visible = true;

                btnConfirmar.Enabled = true;
                btnConfirmar.Text = "Confirmar cambios";
                txtId.Text = Convert.ToString(cliente.Id);
                txtDni.Text = cliente.DNI;
                if (txtDni.Text == "-") { txtDni.Text = ""; }
                txtNombres.Text = cliente.Nombres;
                txtDireccion.Text = cliente.Direccion;
                if (txtDireccion.Text == "-") { txtDireccion.Text = ""; }
                if (cliente.Localidad == "-") { ddlLocalidad.SelectedItem = "-"; }
                else { ddlLocalidad.SelectedItem = cliente.Localidad; }
                lblTel1.Visible = false;
                lblTel2.Visible = false;
                txtTelefono1.Visible = false;
                txtTelefono2.Visible = false;
                txtTelefono3.Visible = false;
                txtTelefono1.Enabled = false;
                txtTelefono2.Enabled = false;
                txtTelefono3.Enabled = false;
                txtTelefonoEditar.Visible = true;
                txtTelefonoEditar.Enabled = true;
                txtTelefonoEditar.Text = cliente.Telefono;
                if (txtTelefonoEditar.Text == "-") { txtTelefonoEditar.Text = ""; }
                txtMail.Text = cliente.Mail;
                if (txtMail.Text == "-") { txtMail.Text = ""; }
            }
            else
            {
                lblMailValido.Visible = false;
                lblMailInvalido.Visible = false;
            }
        }

        private void cargarDdlLocalidades()
        {
            string selectLocalidades = "select ID, Descripcion, Estado from Localidades where Estado = 1 order by ID asc";
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta(selectLocalidades);
                datos.EjecutarLectura();
                while (datos.Lector.Read())
                {
                    ddlLocalidad.Items.Add(datos.Lector["Descripcion"].ToString());
                }
                ddlLocalidad.SelectedItem = "-";
            }
            catch (Exception)
            {
                MessageBox.Show("Error al leer la tabla Localidades en la base de datos.");
                this.Close();
            }
            finally
            {
                datos.CerrarConexion();
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (btnConfirmar.Text == "Confirmar cambios")
            {
                if (txtNombres.Text == "")
                {
                    MessageBox.Show("Apellido y Nombre sin completar.", "Atención!!",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNombres.BackColor = Color.LightSalmon;
                    txtNombres.Focus();
                }
                else if (txtTelefonoEditar.Text == "")
                {
                    txtNombres.BackColor = Color.White;

                    MessageBox.Show("Teléfono sin completar.", "Atención!!", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTelefonoEditar.BackColor = Color.LightSalmon;
                    txtTelefonoEditar.Focus();
                }
                else
                {
                    txtTelefonoEditar.BackColor = Color.White;

                    if (txtMail.Text != "" && txtMail.Text != "-")
                    {
                        if (!txtMail.Text.Contains("@") && !txtMail.Text.Contains(".com"))
                        {
                            MessageBox.Show("El mail ingresado es inválido.", "Atención!!",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtMail.BackColor = Color.LightSalmon;
                            txtMail.Focus();
                        }
                    }
                    else
                    {
                        txtMail.BackColor = Color.White;

                        ClienteDB clienteDB = new ClienteDB();

                        Cliente cliente = new Cliente();

                        cliente.Id = Convert.ToInt64(txtId.Text);
                        cliente.Nombres = txtNombres.Text;
                        cliente.DNI = txtDni.Text;
                        cliente.Direccion = txtDireccion.Text;
                        cliente.Localidad = ddlLocalidad.SelectedItem.ToString();
                        cliente.Telefono = txtTelefonoEditar.Text;
                        cliente.Mail = txtMail.Text;

                        try
                        {
                            int clienteModificado = 0;
                            clienteModificado = clienteDB.ModificarCliente(cliente);

                            if (clienteModificado == 1)
                            {
                                MessageBox.Show("Cliente modificado con éxito!");
                                Form.ActiveForm.Close();
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Se produjo un error y no se modificó el cliente.", "Atención!",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            else
            {
                if (txtNombres.Text == "")
                {
                    MessageBox.Show("Apellido y Nombre sin completar.", "Atención!!",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNombres.BackColor = Color.LightSalmon;
                    txtNombres.Focus();
                }
                else if (txtTelefono1.Text == "")
                {
                    MessageBox.Show("Código de Área sin completar.", "Atención!!",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTelefono1.BackColor = Color.LightSalmon;
                    txtTelefono1.Focus();
                }
                else if (txtTelefono2.Text == "")
                {
                    MessageBox.Show("Prefijo del teléfono sin completar.", "Atención!!",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTelefono2.BackColor = Color.LightSalmon;
                    txtTelefono2.Focus();
                }
                else if (txtTelefono3.Text == "")
                {
                    MessageBox.Show("Sufijo del teléfono sin completar.", "Atención!!",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTelefono3.BackColor = Color.LightSalmon;
                    txtTelefono3.Focus();
                }
                else
                {
                    txtTelefono1.BackColor = Color.White;
                    txtTelefono2.BackColor = Color.White;
                    txtTelefono3.BackColor = Color.White;

                    ClienteDB clienteDB = new ClienteDB();

                    Cliente cliente = new Cliente();

                    int clienteAgregado = 0;

                    if (txtDni.Text == "") { cliente.DNI = "-"; }
                    else { cliente.DNI = txtDni.Text; }

                    cliente.Nombres = txtNombres.Text;

                    if (txtDireccion.Text == "") { cliente.Direccion = "-"; }
                    else { cliente.Direccion = txtDireccion.Text; }

                    if (ddlLocalidad.SelectedItem.ToString() == "-") { cliente.Localidad = "-"; }
                    else { cliente.Localidad = ddlLocalidad.SelectedItem.ToString(); }

                    cliente.Telefono = txtTelefono1.Text + "-" + txtTelefono2.Text + "-" + txtTelefono3.Text;

                    if (txtMail.Text == "") { cliente.Mail = "-"; }
                    else { cliente.Mail = txtMail.Text; }

                    try
                    {
                        clienteAgregado = clienteDB.AgregarCliente(cliente);

                        if (clienteAgregado == 1)
                        {
                            MessageBox.Show("Cliente agregado con éxito !!!");
                            Form.ActiveForm.Close();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Se produjo un error y no se agregó el nuevo cliente.", "Atención!",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void txtNombres_TextChanged(object sender, EventArgs e)
        {
            string nombres = txtNombres.Text;
            int len = nombres.Length;

            if (nombres != "" && len >= 3)
            {
                txtNombres.BackColor = Color.White;
                txtTelefono1.Enabled = true;
            }
            else
            {
                txtNombres.BackColor = Color.LightSalmon;
                txtTelefono1.Enabled = false;
                txtTelefono2.Enabled = false;
                txtTelefono3.Enabled = false;
                btnConfirmar.Enabled = false;
            }
        }

        private void txtTelefono1_TextChanged(object sender, EventArgs e)
        {
            string tel1 = txtTelefono1.Text;
            int len = tel1.Length;

            if (tel1 != "" && len >= 2)
            {
                txtTelefono1.BackColor = Color.White;
                txtTelefono2.Enabled = true;
            }
            else
            {
                txtTelefono1.BackColor = Color.LightSalmon;
                txtTelefono2.Enabled = false;
                txtTelefono3.Enabled = false;
                btnConfirmar.Enabled = false;
            }
        }

        private void txtTelefono2_TextChanged(object sender, EventArgs e)
        {
            string tel2 = txtTelefono2.Text;
            int len = tel2.Length;

            if (tel2 != "" && len >= 3)
            {
                txtTelefono2.BackColor = Color.White;
                txtTelefono3.Enabled = true;
            }
            else
            {
                txtTelefono2.BackColor = Color.LightSalmon;
                txtTelefono3.Enabled = false;
                btnConfirmar.Enabled = false;
            }
        }

        private void txtTelefono3_TextChanged(object sender, EventArgs e)
        {
            string nombres = txtNombres.Text;
            int lenNombres = nombres.Length;
            string tel3 = txtTelefono3.Text;
            int lenTel3 = tel3.Length;

            if (tel3 != "" && lenTel3 >= 3)
            {
                txtTelefono3.BackColor = Color.White;
                if (nombres != "" && lenNombres >= 3) 
                { 
                    if (txtMail.Text != "" && validarMail(txtMail.Text))
                    {
                        btnConfirmar.Enabled = true;
                    }
                    else if (txtMail.Text == "" || txtMail.Text == "-")
                    {
                        btnConfirmar.Enabled = true;
                    }
                    else
                    {
                        btnConfirmar.Enabled = false;
                    }
                }
            }
            else
            {
                txtTelefono3.BackColor = Color.LightSalmon;
                btnConfirmar.Enabled = false;
            }
        }

        private void txtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloLetras(sender, e);
        }

        private void txtTelefonoEditar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || Char.IsControl(e.KeyChar) || e.KeyChar == ' ' || e.KeyChar == '-')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtTelefono1_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(sender, e);
        }

        private void txtTelefono2_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(sender, e);
        }

        private void txtTelefono3_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(sender, e);
        }

        private void txtMail_TextChanged(object sender, EventArgs e)
        {
            if (txtMail.Text != "" && txtMail.Text != "-")
            {
                string mail = txtMail.Text;
                int len = mail.Length;

                bool mailValido = validarMail(mail);

                if (mailValido) 
                { 
                    lblMailValido.Visible = true; 
                    lblMailInvalido.Visible = false;
                    txtMail.BackColor = Color.White;
                    btnConfirmar.Enabled = true;
                }
                else 
                { 
                    lblMailValido.Visible = false; 
                    lblMailInvalido.Visible = true;
                    txtMail.BackColor = Color.LightCoral;
                    btnConfirmar.Enabled = false;
                }
            }
            else
            {
                txtMail.BackColor = Color.White;
                btnConfirmar.Enabled = true;
            }
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

        private bool validarMail(string mail)
        {
            bool resultado = false;
            int len = mail.Length;

            if (mail == "-")
            {
                resultado = true;
            }
            else if (mail.Contains("@") && mail.Contains(".com") && !mail.Contains("@.com") && len > 5)
            {
                resultado = true;
            }

            return resultado;
        }
    }
}
