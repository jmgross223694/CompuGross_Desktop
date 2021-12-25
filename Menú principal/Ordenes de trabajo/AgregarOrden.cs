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
        private long IdOrden = 0;
        private List<Cliente> listaClientes;
        private OrdenTrabajo orden = null;

        public AgregarOrden()
        {
            InitializeComponent();
            cargarDdlTiposEquipo();
            cargarDdlTiposServicio();
            btnBuscarCliente.Visible = true;
            inhabilitarCampos();
            ocultarCampos();
            dgvClientes.Visible = false;
            lblBuscarCliente.Visible = false;
            txtBuscarCliente.Visible = false;
            fechaDevolucion.Enabled = false;
            this.Height = 120;
            this.Width = 270;

            ddlTiposEquipo.SelectedValue = "-";
            ddlTiposServicio.SelectedValue = "-";
            ddlCdDvd.SelectedValue = "-";
        }

        public AgregarOrden(OrdenTrabajo orden) //Modificar orden
        {
            InitializeComponent();
            this.orden = orden;
            Text = "Modificar Orden";

            cargarDdlTiposEquipo();
            cargarDdlTiposServicio();
            btnBuscarCliente.Visible = true;
            dgvClientes.Visible = false;
            habilitarCampos();
            mostrarCampos();
            lblBuscarCliente.Visible = false;
            txtBuscarCliente.Visible = false;
            if (orden.FechaDevolucion != "") { fechaDevolucion.Enabled = true; }
            else { fechaDevolucion.Enabled = false; }

            completarCamposOrden(orden);

            this.IdOrden = orden.ID;
        }

        private void AgregarOrden_Load(object sender, EventArgs e)
        {
            cargarListadoClientes();
            AlinearColumnasGrillaClientes();
            ordenarColumnasGrillaClientes();
            cambiarTitulosGrillaClientes();
        }

        private void borrarContenidoCampos()
        {
            txtCliente.Text = "";
            ddlTiposServicio.Text = "";
            ddlTiposEquipo.Text = "";
            txtRam.Text = "";
            txtPlacaMadre.Text = "";
            txtMarcaModelo.Text = "";
            txtMicroprocesador.Text = "";
            txtAlmacenamiento.Text = "";
            ddlCdDvd.SelectedItem = "-";
            txtFuente.Text = "";
            txtAdicionales.Text = "";
            txtNumSerie.Text = "";
            txtCostoRepuestos.Text = "";
            txtCostoManoObra.Text = "";
            txtCostoTerceros.Text = "";
            txtDescripcion.Text = "";
        }

        private void ocultarCampos()
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

            cbFechaDevolucion.Visible = false;
        }

        private void mostrarCampos()
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

            cbFechaDevolucion.Visible = true;
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

        private void completarCamposOrden(OrdenTrabajo orden)
        {
            txtCliente.Text = orden.Cliente;
            fechaRecepcion.Text = orden.FechaRecepcion;
            ddlTiposServicio.SelectedItem = orden.TipoServicio;
            ddlTiposEquipo.SelectedItem = orden.TipoEquipo;
            txtRam.Text = orden.RAM;
            txtPlacaMadre.Text = orden.PlacaMadre;
            txtMarcaModelo.Text = orden.MarcaModelo;
            txtMicroprocesador.Text = orden.Microprocesador;
            txtAlmacenamiento.Text = orden.Almacenamiento;
            ddlCdDvd.SelectedItem = orden.CdDvd;
            txtFuente.Text = orden.Fuente;
            txtAdicionales.Text = orden.Adicionales;
            txtNumSerie.Text = orden.NumSerie;
            txtCostoRepuestos.Text = orden.CostoRepuestos.ToString();
            txtCostoManoObra.Text = orden.CostoCG.ToString();
            txtCostoTerceros.Text = orden.CostoTerceros.ToString();
            fechaDevolucion.Text = orden.FechaDevolucion;
            txtDescripcion.Text = orden.Descripcion;
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
            this.Height = 596;
            this.Width = 544;

            this.CenterToScreen();

            if (dgvClientes.Visible == false)
            {
                ocultarCampos();

                dgvClientes.Visible = true;
                ocultarColumnasClientes();

                lblBuscarCliente.Visible = true;
                txtBuscarCliente.Visible = true;
            }
            else
            {
                Cliente seleccionado = (Cliente)dgvClientes.CurrentRow.DataBoundItem;

                mostrarCampos();

                txtCliente.Text = seleccionado.Nombres;

                dgvClientes.Visible = false;

                lblBuscarCliente.Visible = false;
                txtBuscarCliente.Visible = false;
                txtBuscarCliente.Text = "";
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            ddlTiposServicio.BackColor = Color.White;
            ddlTiposEquipo.BackColor = Color.White;
            txtMarcaModelo.BackColor = Color.White;
            txtCostoManoObra.BackColor = Color.White;
            txtDescripcion.BackColor = Color.White;

            if (ddlTiposEquipo.SelectedItem.ToString() == "-"
               || txtMarcaModelo.Text == "" || ddlTiposServicio.SelectedItem.ToString() == "-"
               || txtCostoManoObra.Text == "" || txtDescripcion.Text == "")
            {
                MessageBox.Show("Faltan completar campos obligatorios !!");
                if (ddlTiposServicio.SelectedItem.ToString() == "-")
                { ddlTiposServicio.BackColor = Color.FromArgb(255, 175, 158); }
                if (ddlTiposEquipo.SelectedItem.ToString() == "-")
                { ddlTiposEquipo.BackColor = Color.FromArgb(255, 175, 158); }
                if (txtMarcaModelo.Text == "")
                { txtMarcaModelo.BackColor = Color.FromArgb(255, 175, 158); }
                if (txtCostoManoObra.Text == "")
                { txtCostoManoObra.BackColor = Color.FromArgb(255, 175, 158); }
                if (txtDescripcion.Text == "")
                { txtDescripcion.BackColor = Color.FromArgb(255, 175, 158); }
            }
            else
            {
                if (Text == "Modificar Orden") //Modificar orden
                {
                    OrdenTrabajoDB ordenDb = new OrdenTrabajoDB();
                    OrdenTrabajo orden = new OrdenTrabajo();

                    orden.ID = this.IdOrden;

                    orden.Cliente = txtCliente.Text;
                    orden.FechaRecepcion = fechaRecepcion.Text;
                    orden.TipoEquipo = ddlTiposEquipo.SelectedItem.ToString();

                    if (txtRam.Text == "") { orden.RAM = "-"; }
                    else { orden.RAM = txtRam.Text; }

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

                    if (fechaDevolucion.Enabled == false) { orden.FechaDevolucion = ""; }
                    else { orden.FechaDevolucion = fechaDevolucion.Text; }
                    
                    orden.MarcaModelo = txtMarcaModelo.Text;
                    orden.TipoServicio = ddlTiposServicio.SelectedItem.ToString();
                    orden.Descripcion = txtDescripcion.Text;
                    orden.CostoCG = Convert.ToInt32(txtCostoManoObra.Text);

                    try
                    {
                        ordenDb.ModificarOrden(orden);

                        MessageBox.Show("Se guardaron los cambios en la Orden de trabajo N°" + orden.ID + ".");

                        this.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Se produjo un error y no se modificó la orden de trabajo.");
                    }
                }
                else //Agregar nueva
                {
                    OrdenTrabajoDB ordenDb = new OrdenTrabajoDB();
                    OrdenTrabajo orden = new OrdenTrabajo();

                    orden.Cliente = txtCliente.Text;
                    orden.FechaRecepcion = fechaRecepcion.Text;
                    orden.TipoEquipo = ddlTiposEquipo.SelectedItem.ToString();

                    if (txtRam.Text == "") { orden.RAM = "-"; }
                    else { orden.RAM = txtRam.Text; }

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

                        MessageBox.Show("Orden de trabajo agregada correctamente.");

                        this.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Se produjo un error al intentar agregar la orden de trabajo.");
                    }
                }
            }
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
            if (cbFechaDevolucion.Checked == true) { fechaDevolucion.Enabled = true; }
            else { fechaDevolucion.Enabled = false; }
        }
    }
}
