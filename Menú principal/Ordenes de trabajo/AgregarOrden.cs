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
    public partial class AgregarOrden : Form
    {
        private List<Cliente> listaClientes;

        public AgregarOrden()
        {
            InitializeComponent();
            cargarDdlTiposEquipo();
            cargarDdlTiposServicio();
            btnBuscarCliente.Visible = true;
            inhabilitarCampos();
            visibilidadCamposServicio("hide");
            dgvClientes.Visible = false;
            lblBuscarCliente.Visible = false;
            txtBuscarCliente.Visible = false;
            fechaDevolucion.Enabled = false;
            lblSeleccionarCliente.Text = "Seleccionar Cliente";
            lblSeleccionarCliente.Visible = true;
            lblFechaDevolucion.ForeColor = Color.FromArgb(26, 26, 29);

            ddlTiposEquipo.SelectedValue = "-";
            ddlTiposServicio.SelectedValue = "-";
            ddlCdDvd.SelectedItem = "-";
        }

        private void AgregarOrden_Load(object sender, EventArgs e)
        {
            cargarListadoClientes();
            AlinearColumnasGrillaClientes();
            ordenarColumnasGrillaClientes();
            cambiarTitulosGrillaClientes();
        }

        private void visibilidadCamposServicio(string aux)
        {
            if (aux == "show")
            {
                txtCliente.Visible = true;
                fechaRecepcion.Visible = true;
                ddlTiposServicio.Visible = true;
                ddlTiposEquipo.Visible = true;
                txtRam.Visible = true;
                txtPlacaMadre.Visible = true;
                txtMarcaModelo.Visible = true;
                txtMicroprocesador.Visible = true;
                txtAlmacenamiento.Visible = true;
                ddlCdDvd.Visible = true;
                txtFuente.Visible = true;
                txtAdicionales.Visible = true;
                txtNumSerie.Visible = true;
                txtCostoRepuestos.Visible = true;
                txtCostoManoObra.Visible = true;
                txtCostoTerceros.Visible = true;
                fechaDevolucion.Visible = true;
                txtDescripcion.Visible = true;
                btnConfirmar.Visible = true;

                lblCliente.Visible = true;
                lblFechaRecepcion.Visible = true;
                lblTipoServicio.Visible = true;
                lblTipoEquipo.Visible = true;
                lblRam.Visible = true;
                lblPlacaMadre.Visible = true;
                lblMarca.Visible = true;
                lblMicroProcesador.Visible = true;
                lblAlmacenamiento.Visible = true;
                lblCdDvd.Visible = true;
                lblFuente.Visible = true;
                lblAdicionales.Visible = true;
                lblNumSerie.Visible = true;
                lblCostoRepuestos.Visible = true;
                lblManoObra.Visible = true;
                lblCostoTerceros.Visible = true;
                lblFechaDevolucion.Visible = true;
                lblDescripcion.Visible = true;
                lblAsterisco1.Visible = true;
                lblAsterisco2.Visible = true;
                lblAsterisco3.Visible = true;
                lblAsterisco4.Visible = true;
                lblAsterisco5.Visible = true;
                lblCamposObligatorios.Visible = true;

                cbFechaDevolucion.Visible = true;
            }
            if (aux == "hide")
            {
                txtCliente.Visible = false;
                fechaRecepcion.Visible = false;
                ddlTiposServicio.Visible = false;
                ddlTiposEquipo.Visible = false;
                txtRam.Visible = false;
                txtPlacaMadre.Visible = false;
                txtMarcaModelo.Visible = false;
                txtMicroprocesador.Visible = false;
                txtAlmacenamiento.Visible = false;
                ddlCdDvd.Visible = false;
                txtFuente.Visible = false;
                txtAdicionales.Visible = false;
                txtNumSerie.Visible = false;
                txtCostoRepuestos.Visible = false;
                txtCostoManoObra.Visible = false;
                txtCostoTerceros.Visible = false;
                fechaDevolucion.Visible = false;
                txtDescripcion.Visible = false;
                btnConfirmar.Visible = false;

                lblCliente.Visible = false;
                lblFechaRecepcion.Visible = false;
                lblTipoServicio.Visible = false;
                lblTipoEquipo.Visible = false;
                lblRam.Visible = false;
                lblPlacaMadre.Visible = false;
                lblMarca.Visible = false;
                lblMicroProcesador.Visible = false;
                lblAlmacenamiento.Visible = false;
                lblCdDvd.Visible = false;
                lblFuente.Visible = false;
                lblAdicionales.Visible = false;
                lblNumSerie.Visible = false;
                lblCostoRepuestos.Visible = false;
                lblManoObra.Visible = false;
                lblCostoTerceros.Visible = false;
                lblFechaDevolucion.Visible = false;
                lblDescripcion.Visible = false;
                lblAsterisco1.Visible = false;
                lblAsterisco2.Visible = false;
                lblAsterisco3.Visible = false;
                lblAsterisco4.Visible = false;
                lblAsterisco5.Visible = false;
                lblCamposObligatorios.Visible = false;

                cbFechaDevolucion.Visible = false;
            }
        }

        private void inhabilitarCampos()
        {
            txtCliente.Enabled = false;
            fechaRecepcion.Enabled = false;
            ddlTiposServicio.Enabled = false;
            ddlTiposEquipo.Enabled = false;
            txtRam.Enabled = false;
            txtPlacaMadre.Enabled = false;
            txtMarcaModelo.Enabled = false;
            txtMicroprocesador.Enabled = false;
            txtAlmacenamiento.Enabled = false;
            ddlCdDvd.Enabled = false;
            txtFuente.Enabled = false;
            txtAdicionales.Enabled = false;
            txtNumSerie.Enabled = false;
            txtCostoRepuestos.Enabled = false;
            txtCostoManoObra.Enabled = false;
            txtCostoTerceros.Enabled = false;
            txtDescripcion.Enabled = false;
            btnConfirmar.Enabled = false;
        }

        private void habilitarCampos()
        {
            txtCliente.Enabled = true;
            fechaRecepcion.Enabled = true;
            ddlTiposServicio.Enabled = true;
            ddlTiposEquipo.Enabled = true;
            txtRam.Enabled = true;
            txtPlacaMadre.Enabled = true;
            txtMarcaModelo.Enabled = true;
            txtMicroprocesador.Enabled = true;
            txtAlmacenamiento.Enabled = true;
            ddlCdDvd.Enabled = true;
            txtFuente.Enabled = true;
            txtAdicionales.Enabled = true;
            txtNumSerie.Enabled = true;
            txtCostoRepuestos.Enabled = true;
            txtCostoManoObra.Enabled = true;
            txtCostoTerceros.Enabled = true;
            txtDescripcion.Enabled = true;
            btnConfirmar.Enabled = true;
        }

        private void cargarDdlTiposServicio()
        {
            string selectTiposServicio = "select Descripcion from TiposServicio where Estado = 1 order by ID asc";
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta(selectTiposServicio);
                datos.EjecutarLectura();
                while (datos.Lector.Read())
                {
                    ddlTiposServicio.Items.Add(datos.Lector["Descripcion"].ToString());
                }
                ddlTiposServicio.SelectedItem = "-";
            }
            catch (Exception)
            {
                MessageBox.Show("Error al leer la tabla TiposServicio en la base de datos.");
                this.Close();
            }
            finally
            {
                datos.CerrarConexion();
            }
        }

        private void cargarDdlTiposEquipo()
        {
            string selectTiposEquipo = "select Descripcion from TiposEquipo where Estado = 1 order by Descripcion asc";
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta(selectTiposEquipo);
                datos.EjecutarLectura();
                while (datos.Lector.Read())
                {
                    ddlTiposEquipo.Items.Add(datos.Lector["Descripcion"].ToString());
                }
                ddlTiposEquipo.SelectedItem = "-";
            }
            catch (Exception)
            {
                MessageBox.Show("Error al leer la tabla TiposEquipo en la base de datos.");
                this.Close();
            }
            finally
            {
                datos.CerrarConexion();
            }
        }

        private void cargarListadoClientes()
        {
            ClienteDB clienteDB = new ClienteDB();

            try
            {
                listaClientes = clienteDB.Listar();
                dgvClientes.DataSource = listaClientes;
            }
            catch (Exception es)
            {
                MessageBox.Show(es.ToString());
            }
        }

        private void ocultarColumnasClientes()
        {
            dgvClientes.Columns["Direccion"].Visible = false;
            dgvClientes.Columns["Localidad"].Visible = false;
            dgvClientes.Columns["IdLocalidad"].Visible = false;
            dgvClientes.Columns["Mail"].Visible = false;
        }

        private void cambiarTitulosGrillaClientes()
        {
            dgvClientes.Columns["Id"].HeaderText = "N° cliente";
            dgvClientes.Columns["Nombres"].HeaderText = "Cliente";
            dgvClientes.Columns["Telefono"].HeaderText = "Teléfono";
        }

        private void ordenarColumnasGrillaClientes()
        {
            dgvClientes.AllowUserToOrderColumns = true;

            dgvClientes.Columns["Id"].DisplayIndex = 0;
            dgvClientes.Columns["Nombres"].DisplayIndex = 1;
            dgvClientes.Columns["Telefono"].DisplayIndex = 2;
            dgvClientes.Columns["DNI"].DisplayIndex = 3;
        }

        private void AlinearColumnasGrillaClientes()
        {
            dgvClientes.Columns["Id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvClientes.Columns["Telefono"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvClientes.Columns["DNI"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvClientes.Columns["Id"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvClientes.Columns["Nombres"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvClientes.Columns["Telefono"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvClientes.Columns["DNI"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            if (dgvClientes.Visible == false)
            {
                visibilidadCamposServicio("hide");

                dgvClientes.Visible = true;
                ocultarColumnasClientes();

                lblBuscarCliente.Visible = true;
                txtBuscarCliente.Visible = true;
                lblSeleccionarCliente.Text = "Confirmar Cliente";
            }
            else
            {
                Cliente seleccionado = (Cliente)dgvClientes.CurrentRow.DataBoundItem;

                visibilidadCamposServicio("show");

                txtCliente.Text = seleccionado.Nombres;

                dgvClientes.Visible = false;

                lblBuscarCliente.Visible = false;
                txtBuscarCliente.Visible = false;
                txtBuscarCliente.Text = "";
                lblSeleccionarCliente.Text = "Seleccionar Cliente";
                lblSeleccionarCliente.Visible = false;
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (ddlTiposEquipo.SelectedItem.ToString() == "-"
               || txtMarcaModelo.Text == "" || ddlTiposServicio.SelectedItem.ToString() == "-"
               || txtCostoManoObra.Text == "" || txtDescripcion.Text == "")
            {
                MessageBox.Show("Faltan completar campos obligatorios !!");
            }
            else if (txtDescripcion.Text.Contains("-"))
            {
                MessageBox.Show("La descripción no puede contener '-'.");
            }
            else
            {
               ServicioDB ordenDb = new ServicioDB();
               Servicio orden = new Servicio();

               orden.Cliente = txtCliente.Text;
               orden.FechaRecepcion = fechaRecepcion.Text;
               orden.TipoEquipo = ddlTiposEquipo.SelectedItem.ToString();

               if (txtRam.Text == "") { orden.RAM = "-"; }
               else { orden.RAM = txtRam.Text + " GB"; }

               if (txtPlacaMadre.Text == "") { orden.PlacaMadre = "-"; }
               else { orden.PlacaMadre = txtPlacaMadre.Text; }

               if (txtMicroprocesador.Text == "") { orden.Microprocesador = "-"; }
               else { orden.Microprocesador = txtMicroprocesador.Text; }

               if (txtAlmacenamiento.Text == "") { orden.Almacenamiento = "-"; }
               else { orden.Almacenamiento = txtAlmacenamiento.Text; }

               orden.CdDvd = ddlCdDvd.SelectedItem.ToString();

               if (txtFuente.Text == "") { orden.Fuente = "-"; }
               else { orden.Fuente = txtFuente.Text; }

               if (txtAdicionales.Text == "") { orden.Adicionales = "-"; }
               else { orden.Adicionales = txtAdicionales.Text; }

               if (txtNumSerie.Text == "") { orden.NumSerie = "-"; }
               else { orden.NumSerie = txtNumSerie.Text; }

               if (txtCostoRepuestos.Text == "") { orden.CostoRepuestos = 0; }
               else { orden.CostoRepuestos = Convert.ToInt32(txtCostoRepuestos.Text); }

               if (txtCostoTerceros.Text == "") { orden.CostoTerceros = 0; }
               else { orden.CostoTerceros = Convert.ToInt32(txtCostoTerceros.Text); }

               orden.FechaDevolucion = fechaDevolucion.Text;
               orden.MarcaModelo = txtMarcaModelo.Text;
               orden.TipoServicio = ddlTiposServicio.SelectedItem.ToString();
               orden.Descripcion = txtDescripcion.Text;
               orden.CostoCG = Convert.ToInt32(txtCostoManoObra.Text);

               try
               {
                    ordenDb.AgregarOrden(orden);

                    MessageBox.Show("Servicio registrado correctamente.");

                    borrarCamposServicio();
               }
               catch (Exception)
               {
                   MessageBox.Show("Se produjo un error al intentar registrar el servicio.");
               }
            }
        }

        private void borrarCamposServicio()
        {
            txtBuscarCliente.Text = "";
            txtCliente.Text = "";
            fechaRecepcion.Value = DateTime.Now;
            fechaDevolucion.Value = DateTime.Now;
            cbFechaDevolucion.Checked = false;
            ddlTiposServicio.SelectedItem = "-";
            ddlTiposEquipo.SelectedItem = "-";
            txtMarcaModelo.Text = "";
            txtRam.Text = "";
            txtMicroprocesador.Text = "";
            txtAlmacenamiento.Text = "";
            txtPlacaMadre.Text = "";
            txtNumSerie.Text = "";
            txtAdicionales.Text = "";
            txtFuente.Text = "";
            ddlCdDvd.SelectedItem = "-";
            txtCostoRepuestos.Text = "";
            txtCostoManoObra.Text = "";
            txtCostoTerceros.Text = "";
            txtDescripcion.Text = "";
        }

        private void BuscarFiltro()
        {
            List<Cliente> filtro;
            if (txtBuscarCliente.Text != "")
            {
                filtro = listaClientes.FindAll(Art => Art.Nombres.ToUpper().Contains(txtBuscarCliente.Text.ToUpper()) ||
                                               Art.Mail.ToUpper().Contains(txtBuscarCliente.Text.ToUpper()) ||
                                               Art.Id.ToString().Contains(txtBuscarCliente.Text) ||
                                               Art.Telefono.ToUpper().Contains(txtBuscarCliente.Text.ToUpper()));
                dgvClientes.DataSource = null;
                dgvClientes.DataSource = filtro;
            }
            else
            {
                dgvClientes.DataSource = null;
                dgvClientes.DataSource = listaClientes;
            }
        }

        private void txtBuscarCliente_KeyUp(object sender, KeyEventArgs e)
        {
            BuscarFiltro();
        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {
            if (txtCliente.Text == "")
            {
                inhabilitarCampos();
            }
            else
            {
                habilitarCampos();
            }
        }

        private void cbFechaDevolucion_CheckedChanged(object sender, EventArgs e)
        {
            if (cbFechaDevolucion.Checked == true) 
            { 
                fechaDevolucion.Enabled = true;
                lblFechaDevolucion.ForeColor = Color.White;
            }
            else 
            { 
                fechaDevolucion.Enabled = false;
                lblFechaDevolucion.ForeColor = Color.FromArgb(26,26,29);
            }
        }

        private void txtDescripcion_KeyDown(object sender, KeyEventArgs e)
        {
            string descripcionActual = txtDescripcion.Text;

            if (e.KeyCode.Equals(Keys.Enter) || e.KeyValue == 189 || e.KeyValue == 109)
            {
                if (e.KeyCode.Equals(Keys.Enter))
                {
                    MessageBox.Show("No se permiten saltos de línea en la descripción.", "Atención!!", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("No se permiten guiones en la descripción.", "Atención!!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                txtDescripcion.Text = descripcionActual;
                int largo = txtDescripcion.Text.Length;
                txtDescripcion.Select(largo, 0);
            }
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

        private void txtCostoRepuestos_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtCostoManoObra_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(sender, e);
        }

        private void txtCostoTerceros_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(sender, e);
        }

        private void lblSeleccionarCliente_Click(object sender, EventArgs e)
        {
            if (dgvClientes.Visible == false)
            {
                visibilidadCamposServicio("hide");

                dgvClientes.Visible = true;
                ocultarColumnasClientes();

                lblBuscarCliente.Visible = true;
                txtBuscarCliente.Visible = true;
                lblSeleccionarCliente.Text = "Confirmar Cliente";
            }
            else
            {
                Cliente seleccionado = (Cliente)dgvClientes.CurrentRow.DataBoundItem;

                visibilidadCamposServicio("show");

                txtCliente.Text = seleccionado.Nombres;

                dgvClientes.Visible = false;

                lblBuscarCliente.Visible = false;
                txtBuscarCliente.Visible = false;
                txtBuscarCliente.Text = "";
                lblSeleccionarCliente.Text = "Seleccionar Cliente";
                lblSeleccionarCliente.Visible = false;
            }
        }

        private void dgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvClientes.Visible == false)
            {
                visibilidadCamposServicio("hide");

                dgvClientes.Visible = true;
                ocultarColumnasClientes();

                lblBuscarCliente.Visible = true;
                txtBuscarCliente.Visible = true;
                lblSeleccionarCliente.Text = "Confirmar Cliente";
            }
            else
            {
                Cliente seleccionado = (Cliente)dgvClientes.CurrentRow.DataBoundItem;

                visibilidadCamposServicio("show");

                txtCliente.Text = seleccionado.Nombres;

                dgvClientes.Visible = false;

                lblBuscarCliente.Visible = false;
                txtBuscarCliente.Visible = false;
                txtBuscarCliente.Text = "";
                lblSeleccionarCliente.Text = "Seleccionar Cliente";
                lblSeleccionarCliente.Visible = false;
            }
        }
    }
}
