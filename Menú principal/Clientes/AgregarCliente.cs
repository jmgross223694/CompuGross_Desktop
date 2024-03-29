﻿using System;
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
        public AgregarCliente()
        {
            InitializeComponent();
            Text = "Agregar Cliente";
        }

        private void Agregar_Load(object sender, EventArgs e)
        {
            cargarDdlLocalidades();
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
            if (txtTelefono1.Text == "" || txtTelefono2.Text == "" || txtTelefono3.Text == "")
            {
                txtTelefono2.Enabled = false;
                txtTelefono3.Enabled = false;
            }
            lblMailValido.Visible = false;
            lblMailInvalido.Visible = false;
        }

        private void cargarDdlLocalidades()
        {
            string selectLocalidades = "select ID, Descripcion, Estado from Localidades where Estado = 1 " +
                                       "order by Descripcion asc";
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
                
                txtTelefono1.Enabled = true;
            }
            else
            {
                
                txtTelefono1.Enabled = false;
                txtTelefono2.Enabled = false;
                txtTelefono3.Enabled = false;
            }
        }

        private void txtTelefono1_TextChanged(object sender, EventArgs e)
        {
            string tel1 = txtTelefono1.Text;
            int len = tel1.Length;

            if (tel1 != "" && len >= 2)
            {
                
                txtTelefono2.Enabled = true;
            }
            else
            {
                
                txtTelefono2.Enabled = false;
                txtTelefono3.Enabled = false;
            }
        }

        private void txtTelefono2_TextChanged(object sender, EventArgs e)
        {
            string tel2 = txtTelefono2.Text;
            int len = tel2.Length;

            if (tel2 != "" && len >= 3)
            {
                
                txtTelefono3.Enabled = true;
            }
            else
            {
                
                txtTelefono3.Enabled = false;
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
                }
            }
            else
            {

            }
        }

        private void txtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '-')
            {
                e.Handled = false;
            }
            else
            {
                soloLetras(sender, e);
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

                bool mailValido = validarMail(mail);

                if (mailValido) 
                { 
                    lblMailValido.Visible = true; 
                    lblMailInvalido.Visible = false;
                    btnConfirmar.Enabled = true;
                }
                else 
                { 
                    lblMailValido.Visible = false; 
                    lblMailInvalido.Visible = true;
                }
            }
            else
            {
                btnConfirmar.Enabled = true;
            }
        }

        private void txtMail_Enter(object sender, EventArgs e)
        {
            string mail = txtMail.Text;

            if (mail != "")
            {
                if (validarMail(mail)) { lblMailValido.Visible = true; lblMailInvalido.Visible = false; }
                else { lblMailValido.Visible = false; lblMailInvalido.Visible = true; }
            }
            else
            {
                lblMailValido.Visible = false;
                lblMailInvalido.Visible = false;
            }
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

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (txtNombres.Text == "")
            {
                MessageBox.Show("Apellido y Nombre sin completar.", "Atención!!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
                txtNombres.Focus();
            }
            else if (txtTelefono1.Text == "")
            {
                MessageBox.Show("Código de Área sin completar.", "Atención!!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
                txtTelefono1.Focus();
            }
            else if (txtTelefono2.Text == "")
            {
                MessageBox.Show("Prefijo del teléfono sin completar.", "Atención!!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
                txtTelefono2.Focus();
            }
            else if (txtTelefono3.Text == "")
            {
                MessageBox.Show("Sufijo del teléfono sin completar.", "Atención!!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
                txtTelefono3.Focus();
            }
            else
            {
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

                if (MessageBox.Show("¿Confirma al nuevo cliente?", "Atención!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        clienteAgregado = clienteDB.AgregarCliente(cliente);

                        if (clienteAgregado == 1)
                        {
                            MessageBox.Show("Cliente agregado con éxito !!!");
                            resetearCampos();
                            txtDni.Focus();
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

        private void resetearCampos()
        {
            txtDni.Text = "";
            txtNombres.Text = "";
            txtDireccion.Text = "";
            ddlLocalidad.SelectedItem = "-";
            txtTelefono1.Text = "";
            txtTelefono2.Text = "";
            txtTelefono3.Text = "";
            txtMail.Text = "";
            lblMailValido.Visible = false;
            lblMailInvalido.Visible = false;
        }
    }
}
