﻿using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.Office.Interop.Excel;

namespace CompuGross
{
    public partial class Clientes : Form
    {
        private List<Cliente> listaClientes;
        private Cliente clienteSeleccionado = new Cliente();
        private Cliente clienteModificado = new Cliente();

        public Clientes()
        {
            InitializeComponent();
            listarTodos();
            cargarDdlLocalidades();
        }

        private void listarTodos()
        {
            txtFiltro.Visible = true;
            txtFiltro.Enabled = true;

            if (dgvClientes.DataSource == null)
            {
                cargarListado();
                ocultarColumnas();
                alinearColumnas();
                cambiarTitulosColumnas();
                ordenarColumnas();
            }
            else if (txtFiltro.Text != "")
            {
                BuscarFiltro();
            }
            txtFiltro.Focus();
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
                    ddlLocalidades.Items.Add(datos.Lector["Descripcion"].ToString());
                }
                ddlLocalidades.SelectedItem = "-";
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

        private void alinearColumnas()
        {
            dgvClientes.Columns["Id"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvClientes.Columns["Nombres"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvClientes.Columns["DNI"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvClientes.Columns["Direccion"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvClientes.Columns["Telefono"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvClientes.Columns["FechaAlta"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvClientes.Columns["Id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvClientes.Columns["Telefono"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvClientes.Columns["DNI"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvClientes.Columns["Localidad"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvClientes.Columns["FechaAlta"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void ocultarColumnas()
        {
            dgvClientes.Columns["IdLocalidad"].Visible = false;
            //dgvClientes.Columns["Direccion"].Visible = false;
        }

        private void cambiarTitulosColumnas()
        {
            dgvClientes.Columns["Id"].HeaderText = "N°";
            dgvClientes.Columns["Nombres"].HeaderText = "Cliente";
            dgvClientes.Columns["Telefono"].HeaderText = "Contacto";
            dgvClientes.Columns["Direccion"].HeaderText = "Dirección";
            dgvClientes.Columns["FechaAlta"].HeaderText = "Alta";
        }

        private void ordenarColumnas()
        {
            dgvClientes.AllowUserToOrderColumns = true;

            dgvClientes.Columns["Id"].DisplayIndex = 0;
            dgvClientes.Columns["DNI"].DisplayIndex = 1;
            dgvClientes.Columns["Nombres"].DisplayIndex = 2;
            dgvClientes.Columns["Telefono"].DisplayIndex = 3;
            dgvClientes.Columns["Mail"].DisplayIndex = 4;
            dgvClientes.Columns["Direccion"].DisplayIndex = 5;
            dgvClientes.Columns["Localidad"].DisplayIndex = 6;
            dgvClientes.Columns["FechaAlta"].DisplayIndex = 7;

            dgvClientes.AllowUserToOrderColumns = false;
        }

        private void cargarListado()
        {
            ClienteDB clienteDB = new ClienteDB();

            try
            {
                listaClientes = clienteDB.Listar();
                dgvClientes.DataSource = listaClientes;
                int resultado = listaClientes.Count();
                lblCantidadClientes.Visible = true;
                lblCantidadClientes.Text = "Cantidad: " + resultado.ToString();
                if (resultado == 0)
                {
                    lblCantidadClientes.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                lblCantidadClientes.Text = "Cantidad: 0";
            }
        }

        private void BuscarFiltro()
        {
            cargarListado();
            ocultarColumnas();
            alinearColumnas();
            cambiarTitulosColumnas();
            ordenarColumnas();

            List<Cliente> filtro;
            if (txtFiltro.Text != "")
            {
                filtro = listaClientes.FindAll(Art => Art.DNI.ToUpper().Contains(txtFiltro.Text.ToUpper()) ||
                                               Art.Nombres.ToUpper().Contains(txtFiltro.Text.ToUpper()) ||
                                               Art.Direccion.ToUpper().Contains(txtFiltro.Text.ToUpper()) ||
                                               Art.Localidad.ToUpper().Contains(txtFiltro.Text.ToUpper()) ||
                                               Art.FechaAlta.ToUpper().Contains(txtFiltro.Text.ToUpper()) ||
                                               Art.Telefono.ToUpper().Contains(txtFiltro.Text.ToUpper()));
                dgvClientes.DataSource = null;
                dgvClientes.DataSource = filtro;

                int resultado = filtro.Count();
                lblCantidadClientes.Visible = true;
                lblCantidadClientes.Text = "Cantidad: " + resultado.ToString();
                if (resultado == 0)
                {
                    lblCantidadClientes.Text = "Cantidad: 0";
                }
            }
            else
            {
                dgvClientes.DataSource = null;
                dgvClientes.DataSource = listaClientes;
            }
            ocultarColumnas();
            alinearColumnas();
            cambiarTitulosColumnas();
            ordenarColumnas();
        }

        private void txtFiltro_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtFiltro.Text != "" && e.KeyCode.Equals(Keys.Enter))
            {
                if (dgvClientes.DataSource == null)
                {
                    cargarListado();
                    ocultarColumnas();
                    alinearColumnas();
                    cambiarTitulosColumnas();
                    ordenarColumnas();
                }

                BuscarFiltro();

            }
        }

        private void txtFiltro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                if (dgvClientes.DataSource == null)
                {
                    cargarListado();
                    ocultarColumnas();
                    alinearColumnas();
                    cambiarTitulosColumnas();
                    ordenarColumnas();
                }

                BuscarFiltro();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarFiltro();
        }

        private void cargarCamposCliente(Cliente cliente)
        {
            if (cliente != null)
            {
                btnConfirmar.Enabled = true;
                txtFiltro.Text = Convert.ToString(cliente.Id);
                txtDni.Text = cliente.DNI;
                if (txtDni.Text == "-") { txtDni.Text = ""; }
                txtNombres.Text = cliente.Nombres;
                txtDireccion.Text = cliente.Direccion;
                if (txtDireccion.Text == "-") { txtDireccion.Text = ""; }
                if (cliente.Localidad == "-") { ddlLocalidades.SelectedItem = "-"; }
                else { ddlLocalidades.SelectedItem = cliente.Localidad; }
                txtTelefono.Visible = true;
                txtTelefono.Enabled = true;
                txtTelefono.Text = cliente.Telefono;
                if (txtTelefono.Text == "-") { txtTelefono.Text = ""; }
                txtMail.Text = cliente.Mail;
                if (txtMail.Text == "-") { txtMail.Text = ""; }
            }
            lblMailValido.Visible = false;
            lblMailInvalido.Visible = false;
            this.clienteSeleccionado = cliente;
        }

        private void visibilidadCamposModificarCliente(string aux)
        {
            if (aux == "show")
            {
                lblDni.Visible = true;
                txtDni.Visible = true;
                lblNombres.Visible = true;
                txtNombres.Visible = true;
                lblAsteriscoNombres.Visible = true;
                lblDirección.Visible = true;
                txtDireccion.Visible = true;
                lblLocalidad.Visible = true;
                ddlLocalidades.Visible = true;
                lblTelefono.Visible = true;
                txtTelefono.Visible = true;
                lblMail.Visible = true;
                txtMail.Visible = true;
                lblAsteriscoTelefono.Visible = true;
                lblCamposObligatorios.Visible = true;
                btnConfirmar.Visible = true;
            }
            else if (aux == "hide")
            {
                lblDni.Visible = false;
                txtDni.Visible = false;
                lblNombres.Visible = false;
                txtNombres.Visible = false;
                lblAsteriscoNombres.Visible = false;
                lblDirección.Visible = false;
                txtDireccion.Visible = false;
                lblLocalidad.Visible = false;
                ddlLocalidades.Visible = false;
                lblTelefono.Visible = false;
                txtTelefono.Visible = false;
                lblMail.Visible = false;
                txtMail.Visible = false;
                lblAsteriscoTelefono.Visible = false;
                lblCamposObligatorios.Visible = false;
                btnConfirmar.Visible = false;
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (txtNombres.Text == "")
            {
                MessageBox.Show("Apellido y Nombre sin completar.", "Atención!!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombres.Focus();
            }
            else if (txtTelefono.Text == "")
            {
                MessageBox.Show("Teléfono sin completar.", "Atención!!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTelefono.Focus();
            }
            else
            {
                string mail = txtMail.Text;

                if (mail != "" && mail != "-")
                {
                    if (!validarMail(mail))
                    {
                        MessageBox.Show("El mail ingresado es inválido.", "Atención!!",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtMail.Focus();
                    }
                    else
                    {
                        modificarCliente();
                        visibilidadCamposModificarCliente("hide");
                        cargarListado();
                        btnModificar.Visible = true;
                        btnCancelar.Visible = false;
                        btnBuscar.Visible = true;
                        txtFiltro.Visible = true;
                        lblCantidadClientes.Visible = true;
                        dgvClientes.Visible = true;
                        txtFiltro.Text = "";
                    }
                }
                else
                {
                    modificarCliente();
                    visibilidadCamposModificarCliente("hide");
                    cargarListado();
                    btnModificar.Visible = true;
                    btnCancelar.Visible = false;
                    btnBuscar.Visible = true;
                    txtFiltro.Visible = true;
                    lblCantidadClientes.Visible = true;
                    dgvClientes.Visible = true;
                    txtFiltro.Text = "";
                }
            }
        }

        private void modificarCliente()
        {
            ClienteDB clienteDB = new ClienteDB();

            try
            {
                int clienteModificado = 0;

                this.clienteModificado.Id = Convert.ToInt64(txtFiltro.Text);
                this.clienteModificado.Nombres = txtNombres.Text;
                this.clienteModificado.DNI = txtDni.Text;
                if (txtDni.Text == "") { this.clienteModificado.DNI = "-"; }
                this.clienteModificado.Direccion = txtDireccion.Text;
                if (txtDireccion.Text == "") { this.clienteModificado.Direccion = "-"; }
                this.clienteModificado.Localidad = ddlLocalidades.SelectedItem.ToString();
                this.clienteModificado.Telefono = txtTelefono.Text;
                this.clienteModificado.Mail = txtMail.Text;
                if (txtMail.Text == "") { this.clienteModificado.Mail = "-"; }

                if (this.clienteSeleccionado.Nombres != this.clienteModificado.Nombres || 
                    this.clienteSeleccionado.DNI != this.clienteModificado.DNI || 
                    this.clienteSeleccionado.Direccion != this.clienteModificado.Direccion ||
                    this.clienteSeleccionado.Localidad != this.clienteModificado.Localidad || 
                    this.clienteSeleccionado.Telefono != this.clienteModificado.Telefono || 
                    this.clienteSeleccionado.Mail != this.clienteModificado.Mail)
                {
                    if (MessageBox.Show("¿Confirma los cambios?", "Atención!",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        clienteModificado = clienteDB.ModificarCliente(this.clienteModificado);

                        if (clienteModificado == 1)
                        {
                            MessageBox.Show("¡Cliente " + this.clienteModificado.Nombres + " modificado/a con éxito!", "Atención!!",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se modificó al cliente " + this.clienteSeleccionado.Nombres + ".", "Atención!!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("No se modificó al cliente " + this.clienteSeleccionado.Nombres + ".", "Atención!!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Error al intentar modificar al cliente.", "Atención!!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.clienteSeleccionado = null;
            }
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
            if (e.KeyChar == '-')
            {
                e.Handled = false;
            }
            else
            {
                soloLetras(sender, e);
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
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
                }
                else
                {
                    lblMailValido.Visible = false;
                    lblMailInvalido.Visible = true;
                }
            }
            else
            {
                lblMailValido.Visible = false;
                lblMailInvalido.Visible = false;
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

        private void cancelarEdiciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea cancelar la edición?", "Atención!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                visibilidadCamposModificarCliente("hide");
                btnCancelar.Visible = false;
                btnModificar.Visible = true;
                btnBuscar.Visible = true;
                txtFiltro.Visible = true;
                lblCantidadClientes.Visible = true;
                dgvClientes.Visible = true;
                txtFiltro.Text = "";
                txtFiltro.Focus();

                /*MessageBox.Show("No se modificó al cliente " + this.cliente.Nombres + ".", "Atención!!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);*/
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvClientes.CurrentRow != null)
                {
                    txtFiltro.Text = "";
                    this.clienteSeleccionado = (Cliente)dgvClientes.CurrentRow.DataBoundItem;

                    cargarCamposCliente(this.clienteSeleccionado);

                    //ocultar campos de busqueda
                    btnCancelar.Visible = true;
                    btnModificar.Visible = false;
                    btnBuscar.Visible = false;
                    txtFiltro.Visible = false;
                    lblCantidadClientes.Visible = false;
                    dgvClientes.Visible = false;

                    //mostrar campos para editar
                    visibilidadCamposModificarCliente("show");
                    txtDni.Focus();
                }
                else
                {
                    MessageBox.Show("No se ha seleccionado ningún cliente.", "Atención!",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch
            {

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Cliente seleccionado = (Cliente)dgvClientes.CurrentRow.DataBoundItem;
            ClienteDB clienteDB = new ClienteDB();

            try
            {
                if (MessageBox.Show("¿Confirma eliminar al cliente " + seleccionado.Nombres + "?", "Atención!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    clienteDB.EliminarCliente(seleccionado.Id);
                    MessageBox.Show("El cliente " + seleccionado.Nombres + ", se ha eliminado correctamente");
                    txtFiltro.Text = "";

                    cargarListado();
                    ocultarColumnas();
                    alinearColumnas();
                    cambiarTitulosColumnas();
                    ordenarColumnas();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar eliminar al cliente. " + ex.ToString(), "Atención!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExportExcel(DataGridView tabla)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application(); //creamos nuevo archivo excel
            Workbook wb = excel.Workbooks.Add();
            Worksheet ws = wb.ActiveSheet;

            int indiceColumna = 0;
            foreach (DataGridViewColumn col in tabla.Columns) //agregamos encabezados a la nueva hoja
            {
                indiceColumna++;

                if (indiceColumna == 1)
                {
                    excel.Cells[1, indiceColumna] = "N° de Cliente";
                }
                else if (indiceColumna == 2)
                {
                    excel.Cells[1, indiceColumna] = "Nombre y Apellido";
                }
                else if (indiceColumna == 3)
                {
                    excel.Cells[1, indiceColumna] = "DNI";
                }
                else if (indiceColumna == 4)
                {
                    excel.Cells[1, indiceColumna] = "Dirección";
                }
                else if (indiceColumna == 5)
                {
                    excel.Cells[1, indiceColumna] = "Localidad";
                }
                else if (indiceColumna == 6)
                {
                    excel.Cells[1, indiceColumna] = "ID Localidad";
                }
                else if (indiceColumna == 7)
                {
                    excel.Cells[1, indiceColumna] = "Contacto";
                }
                else if (indiceColumna == 8)
                {
                    excel.Cells[1, indiceColumna] = "Mail";
                }
                else if (indiceColumna == 9)
                {
                    excel.Cells[1, indiceColumna] = "Fecha de Alta";
                }
                else
                {
                    excel.Cells[1, indiceColumna] = col.Name;
                }
            }

            int indiceFila = 0;
            foreach (DataGridViewRow row in tabla.Rows) //agregamos contenido a la nueva hoja
            {
                indiceFila++;
                indiceColumna = 0;

                foreach (DataGridViewColumn col in tabla.Columns)
                {
                    indiceColumna++;

                    if (indiceColumna == 1)
                    {
                        long aux = Convert.ToInt64(row.Cells[col.Name].Value);
                        excel.Cells[indiceFila + 1, indiceColumna] = aux;
                    }
                    else if (indiceColumna == 3 && row.Cells[col.Name].Value.ToString() != "-")
                    {
                        long aux = Convert.ToInt64(row.Cells[col.Name].Value);
                        excel.Cells[indiceFila + 1, indiceColumna] = aux;
                    }
                    else if (indiceColumna == 6)
                    {
                        long aux = Convert.ToInt64(row.Cells[col.Name].Value);
                        excel.Cells[indiceFila + 1, indiceColumna] = aux;
                    }
                    else if (indiceColumna == 9)
                    {
                        DateTime aux = Convert.ToDateTime(row.Cells[col.Name].Value);
                        excel.Cells[indiceFila + 1, indiceColumna] = aux;
                    }
                    else
                    {
                        excel.Cells[indiceFila + 1, indiceColumna] = row.Cells[col.Name].Value;
                    }
                }
            }

            for (int i = 1; i <= 9; i++)
            {
                excel.Cells[1, i].Interior.Color = System.Drawing.ColorTranslator.ToOle(Color.Orange);
            }
            excel.Columns.AutoFit();

            ws.Range["C2:C1048576"].NumberFormat = "0";
            ws.Range["A2:A1048576"].NumberFormat = "0";
            ws.Range["F2:F1048576"].NumberFormat = "0";
            
            ws.Range["A:I"].HorizontalAlignment = HorizontalAlignment.Center;

            excel.Visible = true;
        }
        
        private void btnExcel_Click(object sender, EventArgs e)
        {
            ExportExcel(dgvClientes);
        }
    }
}
