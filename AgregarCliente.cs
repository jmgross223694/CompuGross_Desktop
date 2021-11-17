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
            label4.Visible = true;
            label5.Visible = true;
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
                label4.Visible = false;
                label5.Visible = false;
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
                    MessageBox.Show("Apellido y nombre sin completar !!!");
                }
                else if (txtTelefonoEditar.Text == "")
                {
                    MessageBox.Show("Teléfono sin completar !!!");
                }
                else
                {
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
                        clienteDB.ModificarCliente(cliente);
                        MessageBox.Show("Cliente modificado con éxito!");
                        Form.ActiveForm.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Se produjo un error al intentar modificar el cliente.", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                if (txtNombres.Text == "")
                {
                    MessageBox.Show("Apellido y nombre sin completar !!!");
                }
                else if (txtTelefono1.Text == "")
                {
                    MessageBox.Show("Teléfono sin completar !!!");
                }
                string DNI = txtDni.Text, Nombres = txtNombres.Text, Direccion = txtDireccion.Text;
                string Localidad = ddlLocalidad.SelectedItem.ToString();
                string Telefono = txtTelefono1.Text + "-" + txtTelefono2.Text + "-" + txtTelefono3.Text;
                string Mail = txtMail.Text;

                string insertCliente = "EXEC SP_NUEVO_CLIENTE '" + DNI + "', '" +
                                       Nombres + "', '" + Direccion + "', " +
                                       Localidad + ", '" + Telefono + "', '" + Mail + "'";

                AccesoDatos datos = new AccesoDatos();

                try
                {
                    datos.SetearConsulta(insertCliente);
                    datos.EjecutarLectura();

                    MessageBox.Show("Cliente agregado con éxito !!!");

                    this.Hide();
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    datos.CerrarConexion();
                }
            }
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(sender, e);
        }

        private void soloNumeros(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtNombres_TextChanged(object sender, EventArgs e)
        {
            if (txtNombres.Text != "")
            {
                txtNombres.BackColor = Color.White;
                if (txtTelefono1.Text != "" && txtTelefono2.Text != "" && txtTelefono3.Text != "")
                {
                    btnConfirmar.Enabled = true;
                }
            }
            else
            {
                txtNombres.BackColor = Color.LightSalmon;
                btnConfirmar.Enabled = false;
            }
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            if (txtTelefono1.Text != "")
            {
                txtTelefono1.BackColor = Color.White;
                txtTelefono2.Enabled = true;
            }
            else
            {
                txtTelefono1.BackColor = Color.LightSalmon;
                btnConfirmar.Enabled = false;
                txtTelefono2.Enabled = false;
            }
        }

        private void txtTelefono2_TextChanged(object sender, EventArgs e)
        {
            if (txtTelefono2.Text != "")
            {
                txtTelefono2.BackColor = Color.White;
                txtTelefono3.Enabled = true;
            }
            else
            {
                txtTelefono2.BackColor = Color.LightSalmon;
                btnConfirmar.Enabled = false;
                txtTelefono3.Enabled = false;
            }
        }

        private void txtTelefono3_TextChanged(object sender, EventArgs e)
        {
            if (txtTelefono3.Text != "")
            {
                txtTelefono3.BackColor = Color.White;
                if (txtNombres.Text != "") { btnConfirmar.Enabled = true; }
            }
            else
            {
                txtTelefono3.BackColor = Color.LightSalmon;
                btnConfirmar.Enabled = false;
            }
        }

        private void Agregar_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
