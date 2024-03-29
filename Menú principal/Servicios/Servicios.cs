﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.Office.Interop.Excel;
using Negocio;
using Dominio;

namespace CompuGross
{
    public partial class Servicios : Form
    {
        private List<Servicio> listaServicios;
        private List<Cliente> listaClientes;
        private long IdCliente = 0;
        private bool primerIngreso = false;

        public Servicios()
        {
            InitializeComponent();
        }

        private void Servicios_Load(object sender, EventArgs e)
        {
            visibilidadCamposModificar("hide");
            listarTodas();
            this.primerIngreso = true;
        }

        private void cargarListado()
        {
            Negocio.ServicioDB servicioDB = new Negocio.ServicioDB();

            try
            {
                listaServicios = servicioDB.Listar();
                dgvServicios.DataSource = listaServicios;
            }
            catch (Exception es)
            {
                MessageBox.Show(es.ToString());
            }
        }

        private void alinearColumnas()
        {
            dgvServicios.Columns["ID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvServicios.Columns["FechaRecepcion"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvServicios.Columns["FechaDevolucion"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvServicios.Columns["TipoEquipo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvServicios.Columns["TipoServicio"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvServicios.Columns["CostoTotal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void cambiarTitulos()
        {
            dgvServicios.Columns["FechaRecepcion"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvServicios.Columns["FechaDevolucion"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvServicios.Columns["CostoTotal"].DefaultCellStyle.Format = "C0";

            dgvServicios.Columns["ID"].HeaderText = "N° de orden";
            dgvServicios.Columns["FechaRecepcion"].HeaderText = "Recepción";
            dgvServicios.Columns["FechaDevolucion"].HeaderText = "Devolución";
            dgvServicios.Columns["TipoServicio"].HeaderText = "Tipo";
            dgvServicios.Columns["TipoEquipo"].HeaderText = "Equipo";
            dgvServicios.Columns["MarcaModelo"].HeaderText = "Marca y modelo";
            dgvServicios.Columns["CostoTotal"].HeaderText = "Subtotal";
        }

        private void alinearTitulos()
        {
            dgvServicios.Columns["ID"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvServicios.Columns["FechaRecepcion"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvServicios.Columns["FechaDevolucion"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvServicios.Columns["Cliente"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvServicios.Columns["TipoEquipo"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvServicios.Columns["MarcaModelo"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvServicios.Columns["TipoServicio"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvServicios.Columns["CostoTotal"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void ocultarColumnas()
        {
            dgvServicios.Columns["IdCliente"].Visible = false;
            dgvServicios.Columns["MarcaModelo"].Visible = false;
            dgvServicios.Columns["RAM"].Visible = false;
            dgvServicios.Columns["PlacaMadre"].Visible = false;
            dgvServicios.Columns["Microprocesador"].Visible = false;
            dgvServicios.Columns["Almacenamiento"].Visible = false;
            dgvServicios.Columns["CdDvd"].Visible = false;
            dgvServicios.Columns["Fuente"].Visible = false;
            dgvServicios.Columns["Adicionales"].Visible = false;
            dgvServicios.Columns["NumSerie"].Visible = false;
            dgvServicios.Columns["Descripcion"].Visible = false;
            dgvServicios.Columns["CostoRepuestos"].Visible = false;
            dgvServicios.Columns["CostoTerceros"].Visible = false;
            dgvServicios.Columns["CostoCG"].Visible = false;
            dgvServicios.Columns["Estado"].Visible = false;
            dgvServicios.Columns["Ganancia"].Visible = false;
        }

        private void ordenarColumnas()
        {
            dgvServicios.AllowUserToOrderColumns = true;

            dgvServicios.Columns["ID"].DisplayIndex = 0;
            dgvServicios.Columns["Cliente"].DisplayIndex = 1;
            dgvServicios.Columns["FechaRecepcion"].DisplayIndex = 2;
            dgvServicios.Columns["FechaDevolucion"].DisplayIndex = 3;
            dgvServicios.Columns["TipoServicio"].DisplayIndex = 4;
            dgvServicios.Columns["TipoEquipo"].DisplayIndex = 5;
            dgvServicios.Columns["MarcaModelo"].DisplayIndex = 6;
            dgvServicios.Columns["CostoTotal"].DisplayIndex = 7;
        }

        private void BuscarFiltro()
        {
            cargarListado();
            alinearTitulos();
            alinearColumnas();
            ocultarColumnas();
            ordenarColumnas();
            cambiarTitulos();

            List<Dominio.Servicio> filtro;
            if (txtFiltro.Text != "")
            {
                filtro = listaServicios.FindAll(Art => Art.ID.ToString().Contains(txtFiltro.Text.ToUpper()) ||
                                               Art.Cliente.ToUpper().Contains(txtFiltro.Text.ToUpper()) ||
                                               Art.TipoEquipo.ToUpper().Contains(txtFiltro.Text.ToUpper()) ||
                                               Art.TipoServicio.ToUpper().Contains(txtFiltro.Text.ToUpper()) ||
                                               Art.CostoTotal.ToString().Contains(txtFiltro.Text.ToUpper()) ||
                                               Art.FechaRecepcion.ToUpper().Contains(txtFiltro.Text.ToUpper()) ||
                                               Art.FechaDevolucion.ToUpper().Contains(txtFiltro.Text.ToUpper()));
                dgvServicios.DataSource = null;
                dgvServicios.DataSource = filtro;
            }
            else
            {
                dgvServicios.DataSource = null;
                dgvServicios.DataSource = listaServicios;
            }
            alinearTitulos();
            alinearColumnas();
            ocultarColumnas();
            ordenarColumnas();
            cambiarTitulos();
        }

        private void txtFiltro_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtFiltro.Text != "" && e.KeyCode.Equals(Keys.Enter))
            {
                if (dgvServicios.DataSource == null)
                {
                    cargarListado();
                    ocultarColumnas();
                    alinearColumnas();
                    ordenarColumnas();
                    cambiarTitulos();
                }

                BuscarFiltro();
            }
        }

        private void listarTodas()
        {
            if (dgvServicios.DataSource == null)
            {
                cargarListado();
                ocultarColumnas();
                alinearColumnas();
                ordenarColumnas();
                cambiarTitulos();
            }
            else if (txtFiltro.Text != "")
            {
                BuscarFiltro();
            }
        }

        private void txtFiltro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                if (dgvServicios.DataSource == null)
                {
                    cargarListado();
                    ocultarColumnas();
                    alinearColumnas();
                    ordenarColumnas();
                    cambiarTitulos();
                }

                BuscarFiltro();
            }
        }

        private void completarCamposServicio(Dominio.Servicio servicio)
        {
            txtFiltro.Text = servicio.ID.ToString();
            txtCliente.Text = servicio.Cliente;
            fechaRecepcion.Text = servicio.FechaRecepcion;
            ddlTiposServicio.SelectedItem = servicio.TipoServicio;
            ddlTiposEquipo.SelectedItem = servicio.TipoEquipo;
            txtRam.Text = servicio.RAM;
            txtPlacaMadre.Text = servicio.PlacaMadre;
            txtMarcaModelo.Text = servicio.MarcaModelo;
            txtMicroprocesador.Text = servicio.Microprocesador;
            txtAlmacenamiento.Text = servicio.Almacenamiento;
            ddlUnidadOptica.SelectedItem = servicio.CdDvd;
            txtAlimentacion.Text = servicio.Fuente;
            txtAdicionales.Text = servicio.Adicionales;
            txtNumSerie.Text = servicio.NumSerie;
            txtCostoRepuestos.Text = servicio.CostoRepuestos.ToString();
            txtManoObra.Text = servicio.CostoCG.ToString();
            txtCostoTerceros.Text = servicio.CostoTerceros.ToString();
            cbFechaDevolucion.Checked = false;
            fechaDevolucion.Visible = false;
            if (servicio.FechaDevolucion != "-")
            {
                cbFechaDevolucion.Checked = true;
                fechaDevolucion.Visible = true;
                fechaDevolucion.Text = servicio.FechaDevolucion;
            }
            txtDescripcion.Text = servicio.Descripcion;
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

        private void visibilidadCamposModificar(string aux)
        {
            if (aux == "show")
            {
                lblNumOrden.Visible = true;
                btnCancelar.Visible = true;
                lblFechaRecepcion.Visible = true;
                lblFechaDevolucion.Visible = true;
                cbFechaDevolucion.Visible = true;
                lblTipoServicio.Visible = true;
                lblTipoEquipo.Visible = true;
                lblMarcaModelo.Visible = true;
                lblRam.Visible = true;
                lblMicroprocesador.Visible = true;
                lblAlmacenamiento.Visible = true;
                lblPlacaMadre.Visible = true;
                lblNumSerie.Visible = true;
                lblAdicionales.Visible = true;
                lblAlimentacion.Visible = true;
                lblUnidadOptica.Visible = true;
                lblCostoRepuestos.Visible = true;
                lblManoObra.Visible = true;
                lblCostoTerceros.Visible = true;
                fechaRecepcion.Visible = true;
                fechaDevolucion.Visible = true;
                ddlTiposServicio.Visible = true;
                ddlTiposEquipo.Visible = true;
                txtMarcaModelo.Visible = true;
                txtRam.Visible = true;
                txtMicroprocesador.Visible = true;
                txtAlmacenamiento.Visible = true;
                txtPlacaMadre.Visible = true;
                txtNumSerie.Visible = true;
                txtAdicionales.Visible = true;
                txtAlimentacion.Visible = true;
                ddlUnidadOptica.Visible = true;
                txtCostoRepuestos.Visible = true;
                txtManoObra.Visible = true;
                txtCostoTerceros.Visible = true;
                lblDescripcion.Visible = true;
                txtDescripcion.Visible = true;
                lblAsteriscoTipoServicio.Visible = true;
                lblAsteriscoTipoEquipo.Visible = true;
                lblAsteriscoMarcaModelo.Visible = true;
                lblAsteriscoManoObra.Visible = true;
                lblAsteriscoDescripcion.Visible = true;
                lblCamposObligatorios.Visible = true;
                btnConfirmar.Visible = true;
            }
            if (aux == "hide")
            {
                lblNumOrden.Visible = false;
                btnCancelar.Visible = false;
                lblFechaRecepcion.Visible = false;
                lblFechaDevolucion.Visible = false;
                cbFechaDevolucion.Visible = false;
                lblTipoServicio.Visible = false;
                lblTipoEquipo.Visible = false;
                lblMarcaModelo.Visible = false;
                lblRam.Visible = false;
                lblMicroprocesador.Visible = false;
                lblAlmacenamiento.Visible = false;
                lblPlacaMadre.Visible = false;
                lblNumSerie.Visible = false;
                lblAdicionales.Visible = false;
                lblAlimentacion.Visible = false;
                lblUnidadOptica.Visible = false;
                lblCostoRepuestos.Visible = false;
                lblManoObra.Visible = false;
                lblCostoTerceros.Visible = false;
                fechaRecepcion.Visible = false;
                fechaDevolucion.Visible = false;
                ddlTiposServicio.Visible = false;
                ddlTiposEquipo.Visible = false;
                txtMarcaModelo.Visible = false;
                txtRam.Visible = false;
                txtMicroprocesador.Visible = false;
                txtAlmacenamiento.Visible = false;
                txtPlacaMadre.Visible = false;
                txtNumSerie.Visible = false;
                txtAdicionales.Visible = false;
                txtAlimentacion.Visible = false;
                ddlUnidadOptica.Visible = false;
                txtCostoRepuestos.Visible = false;
                txtManoObra.Visible = false;
                txtCostoTerceros.Visible = false;
                lblDescripcion.Visible = false;
                txtDescripcion.Visible = false;
                lblAsteriscoTipoServicio.Visible = false;
                lblAsteriscoTipoEquipo.Visible = false;
                lblAsteriscoMarcaModelo.Visible = false;
                lblAsteriscoManoObra.Visible = false;
                lblAsteriscoDescripcion.Visible = false;
                lblCamposObligatorios.Visible = false;
                btnConfirmar.Visible = false;
            }
        }

        private void btnCambiarCliente_Click(object sender, EventArgs e)
        {
            if (dgvClientes.Visible == false)
            {
                visibilidadCamposModificar("hide");
                btnCambiarCliente.Visible = true;
                txtCliente.Visible = true;
                dgvClientes.Visible = true;

                ocultarColumnasClientes();
            }
            else
            {
                Cliente cliente = (Cliente)dgvClientes.CurrentRow.DataBoundItem;

                visibilidadCamposModificar("show");
                dgvClientes.Visible = false;

                txtCliente.Text = cliente.Nombres;

                dgvClientes.Visible = false;
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

        private void dgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Cliente cliente = (Cliente)dgvClientes.CurrentRow.DataBoundItem;

            visibilidadCamposModificar("show");

            txtCliente.Text = cliente.Nombres;

            dgvClientes.Visible = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea cancelar la edición?", "Atención!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                txtFiltro.Text = "";
                btnCambiarCliente.Visible = false;
                txtCliente.Visible = false;
                borrarCamposServicio();
                visibilidadCamposModificar("hide");
                btnModificar.Visible = true;
                btnBuscarOrden.Visible = true;
                txtFiltro.Visible = true;
                cargarListado();
                ocultarColumnas();
                alinearColumnas();
                ordenarColumnas();
                cambiarTitulos();
                dgvServicios.Visible = true;

                /*MessageBox.Show("No se modificó el servicio.", "Atención!!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);*/
            }
        }

        private void borrarCamposServicio()
        {
            txtCliente.Text = "";
            fechaRecepcion.Text = default;
            ddlTiposServicio.SelectedItem = "-";
            ddlTiposEquipo.SelectedItem = "-";
            txtRam.Text = "";
            txtPlacaMadre.Text = "";
            txtMarcaModelo.Text = "";
            txtMicroprocesador.Text = "";
            txtAlmacenamiento.Text = "";
            ddlUnidadOptica.SelectedItem = "-";
            txtAlimentacion.Text = "";
            txtAdicionales.Text = "";
            txtNumSerie.Text = "";
            txtCostoRepuestos.Text = "";
            txtManoObra.Text = "";
            txtCostoTerceros.Text = "";
            fechaDevolucion.Text = default;
            txtDescripcion.Text = "";
        }

        private void cbFechaDevolucion_CheckedChanged(object sender, EventArgs e)
        {
            if (cbFechaDevolucion.Checked == true)
            {
                fechaDevolucion.Visible = true;
            }
            else
            {
                fechaDevolucion.Visible = false;
            }
        }

        private void EnviarMailAlCliente(Cliente c, Servicio s)
        {
            if (c.Mail != null && c.Mail != "-")
            {
                EmailService mail = new EmailService();

                try
                {
                    string asunto = "COMPUGROSS - ORDEN DE SERVICIO N°" + s.ID;

                    decimal costoTotalServicio = s.CostoRepuestos + s.CostoTerceros + s.CostoCG;

                    string cuerpo = "Esperamos se encuentre muy bien Sr/a " + c.Nombres + ".\n\n" +
                                    "A continuación le acercamos los datos actualizados de su orden de servicio N°" + s.ID + " realizada con nosotros:\n\n\n" +
                                    "- Fecha de recepción de equipo: " + s.FechaRecepcion + "\n\n" +
                                    "- Fecha de devolución de equipo: " + s.FechaDevolucion + "\n\n" +
                                    "- Equipo: " + s.TipoEquipo + " " + s.MarcaModelo + "\n\n" +
                                    "- Detalles de servicio: " + s.Descripcion + "\n\n" +
                                    "- Costo total del servicio: $" + costoTotalServicio.ToString() +
                                    "\n\n\nSaludos cordiales.\n\nCompuGross";

                    if (s.TipoServicio != "Servicio técnico")
                    {
                        cuerpo = "Esperamos se encuentre muy bien Sr/a " + c.Nombres + ".\n\n" +
                                 "A continuación le acercamos los datos actualizados de su orden de servicio N°" + s.ID + " realizada con nosotros:\n\n\n" +
                                 "- Fecha de ejecución del servicio: " + s.FechaDevolucion + "\n\n" +
                                 "- Equipo: " + s.TipoEquipo + " " + s.MarcaModelo + "\n\n" +
                                 "- Detalles de servicio: " + s.Descripcion + "\n\n" +
                                 "- Costo total del servicio: $" + costoTotalServicio.ToString() +
                                 "\n\n\nSaludos cordiales.\n\nCompuGross";
                    }

                    mail.armarCorreo(c.Mail, asunto, cuerpo);
                    mail.enviarEmail();

                    MessageBox.Show("El correo al Cliente " + c.Nombres + " se ha enviado correctamente.", "Atención!!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("No se pudo enviar el correo al Cliente " + c.Nombres + ".", "Atención!!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("El Cliente " + c.Nombres + " no tiene un Mail registrado.", "Atención!!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            ServicioDB servicioDb = new ServicioDB();
            Servicio servicio = new Servicio();

            servicio.ID = Convert.ToInt64(txtFiltro.Text);

            DateTime fecha = Convert.ToDateTime(fechaRecepcion.Text);
            string fecRecepcion = fecha.Day.ToString() + "/" + fecha.Month.ToString() + "/" + fecha.Year.ToString();

            servicio.Cliente = txtCliente.Text;
            servicio.FechaRecepcion = fecRecepcion;
            servicio.TipoEquipo = ddlTiposEquipo.SelectedItem.ToString();

            if (txtRam.Text == "") { servicio.RAM = "-"; }
            else { servicio.RAM = txtRam.Text; }

            if (txtPlacaMadre.Text == "") { servicio.PlacaMadre = "-"; }
            else { servicio.PlacaMadre = txtPlacaMadre.Text; }

            if (txtMicroprocesador.Text == "") { servicio.Microprocesador = "-"; }
            else { servicio.Microprocesador = txtMicroprocesador.Text; }

            if (txtAlmacenamiento.Text == "") { servicio.Almacenamiento = "-"; }
            else { servicio.Almacenamiento = txtAlmacenamiento.Text; }

            servicio.CdDvd = ddlUnidadOptica.SelectedItem.ToString();

            if (txtAlimentacion.Text == "") { servicio.Fuente = "-"; }
            else { servicio.Fuente = txtAlimentacion.Text; }

            if (txtAdicionales.Text == "") { servicio.Adicionales = "-"; }
            else { servicio.Adicionales = txtAdicionales.Text; }

            if (txtNumSerie.Text == "") { servicio.NumSerie = "-"; }
            else { servicio.NumSerie = txtNumSerie.Text; }

            if (txtCostoRepuestos.Text == "") { servicio.CostoRepuestos = 0; }
            else { servicio.CostoRepuestos = Convert.ToInt32(txtCostoRepuestos.Text); }

            if (txtCostoTerceros.Text == "") { servicio.CostoTerceros = 0; }
            else { servicio.CostoTerceros = Convert.ToInt32(txtCostoTerceros.Text); }

            fecha = Convert.ToDateTime(fechaDevolucion.Text);
            string fecDevolucion = fecha.Day.ToString() + "/" + fecha.Month.ToString() + "/" + fecha.Year.ToString();

            if (cbFechaDevolucion.Checked == false)
            {
                fecDevolucion = "";
            }

            servicio.FechaDevolucion = fecDevolucion;

            servicio.MarcaModelo = txtMarcaModelo.Text;
            servicio.TipoServicio = ddlTiposServicio.SelectedItem.ToString();
            servicio.Descripcion = txtDescripcion.Text;
            servicio.CostoCG = Convert.ToInt32(txtManoObra.Text);

            if (MessageBox.Show("¿Confirma los cambios?", "Atención!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    servicioDb.ModificarServicio(servicio);

                    MessageBox.Show("Se guardaron los cambios para el servicio N°" + servicio.ID + ".", "Atención!!",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (cbFechaDevolucion.Checked == true)
                    {
                        if (MessageBox.Show("¿Informar al cliente sobre los cambios en el servicio?", "Atención!!",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            ClienteDB cDB = new ClienteDB();

                            Cliente cliente = cDB.CargarClientePorID(this.IdCliente);

                            EnviarMailAlCliente(cliente, servicio);
                        }
                    }

                    txtFiltro.Text = "";
                    btnCambiarCliente.Visible = false;
                    txtCliente.Visible = false;
                    borrarCamposServicio();
                    visibilidadCamposModificar("hide");
                    btnModificar.Visible = true;
                    btnBuscarOrden.Visible = true;
                    txtFiltro.Visible = true;
                    cargarListado();
                    ocultarColumnas();
                    alinearColumnas();
                    ordenarColumnas();
                    cambiarTitulos();
                    dgvServicios.Visible = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al intentar modificar el servicio.", "Atención!!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No se modificó el servicio.", "Atención!!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvServicios.CurrentRow != null)
                {
                    if (this.primerIngreso)
                    {
                        cargarDdlTiposEquipo();
                        cargarDdlTiposServicio();
                        cargarListadoClientes();
                        AlinearColumnasGrillaClientes();
                        ordenarColumnasGrillaClientes();
                        cambiarTitulosGrillaClientes();

                        this.primerIngreso = false;
                    }
                    
                    txtFiltro.Text = "";
                    Servicio servicio = (Servicio)dgvServicios.CurrentRow.DataBoundItem;
                    ServicioDB sDB = new ServicioDB();

                    servicio = sDB.CargarDatosOrden(servicio.ID);

                    IdCliente = servicio.IdCliente;

                    btnBuscarOrden.Visible = false;
                    txtFiltro.Visible = false;
                    dgvServicios.Visible = false;
                    btnModificar.Visible = false;
                    lblNumOrden.Text = "*Editando orden N° " + servicio.ID;
                    visibilidadCamposModificar("show");
                    btnCambiarCliente.Visible = true;
                    txtCliente.Visible = true;

                    completarCamposServicio(servicio);
                }
                else
                {
                    MessageBox.Show("No se ha seleccionado ninguna orden.", "Atención!",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch
            {

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Dominio.Servicio seleccionado = (Dominio.Servicio)dgvServicios.CurrentRow.DataBoundItem;
            Negocio.ServicioDB ordentTrabajoDB = new Negocio.ServicioDB();

            try
            {
                if (MessageBox.Show("¿Confirma eliminar la Orden N° " + seleccionado.ID + " del cliente " +
                                    seleccionado.Cliente + "?", "Atención!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ordentTrabajoDB.EliminarServicio(seleccionado.ID);
                    MessageBox.Show("La Orden N° " + seleccionado.ID + ", del cliente " + seleccionado.Cliente +
                                    ", se ha eliminado correctamente");

                    visibilidadCamposModificar("hide");
                    listarTodas();

                    cargarDdlTiposEquipo();
                    cargarDdlTiposServicio();

                    cargarListado();

                    cargarListadoClientes();
                    AlinearColumnasGrillaClientes();
                    ordenarColumnasGrillaClientes();
                    cambiarTitulosGrillaClientes();
                }
            }
            catch
            {

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
                if (indiceColumna == 1 || indiceColumna == 2 || indiceColumna == 4 || indiceColumna == 5 ||
                    indiceColumna == 15 || indiceColumna == 21 || indiceColumna == 22)
                {
                    if (indiceColumna == 1)
                    {
                        excel.Cells[1, 1] = "N° de Servicio";
                    }
                    else if (indiceColumna == 2)
                    {
                        excel.Cells[1, 2] = "Recepción";
                    }
                    else if (indiceColumna == 4)
                    {
                        excel.Cells[1, 3] = col.Name;
                    }
                    else if (indiceColumna == 5)
                    {
                        excel.Cells[1, 4] = "Tipo de Equipo";
                    }
                    else if (indiceColumna == 15)
                    {
                        excel.Cells[1, 5] = "Tipo de Servicio";
                    }
                    else if (indiceColumna == 21)
                    {
                        excel.Cells[1, 6] = "Devolución";
                    }
                    else if (indiceColumna == 22)
                    {
                        excel.Cells[1, 7] = col.Name;
                    }
                    else
                    {
                        excel.Cells[1, indiceColumna] = col.Name;
                    }
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
                    if (indiceColumna == 1 || indiceColumna == 2 || indiceColumna == 4 || indiceColumna == 5 ||
                    indiceColumna == 15 || indiceColumna == 21 || indiceColumna == 22)
                    {
                        if (indiceColumna == 2)
                        {
                            DateTime aux = Convert.ToDateTime(row.Cells[col.Name].Value);
                            excel.Cells[indiceFila + 1, indiceColumna] = aux;
                        }
                        else if (indiceColumna == 4)
                        {
                            excel.Cells[indiceFila + 1, 3] = row.Cells[col.Name].Value;
                        }
                        else if (indiceColumna == 5)
                        {
                            excel.Cells[indiceFila + 1, 4] = row.Cells[col.Name].Value;
                        }
                        else if (indiceColumna == 15)
                        {
                            excel.Cells[indiceFila + 1, 5] = row.Cells[col.Name].Value;
                        }
                        else if (indiceColumna == 21)
                        {
                            DateTime aux = Convert.ToDateTime(row.Cells[col.Name].Value);
                            excel.Cells[indiceFila + 1, 6] = aux;
                        }
                        else if (indiceColumna == 22)
                        {
                            excel.Cells[indiceFila + 1, 7] = row.Cells[col.Name].Value;
                        }
                        else
                        {
                            excel.Cells[indiceFila + 1, indiceColumna] = row.Cells[col.Name].Value;
                        }
                    }
                }
            }

            for (int i = 1; i <= 7; i++)
            {
                excel.Cells[1, i].Interior.Color = System.Drawing.ColorTranslator.ToOle(Color.Orange);
            }
            excel.Columns.AutoFit();

            ws.Range["A:G"].HorizontalAlignment = HorizontalAlignment.Center;

            excel.Visible = true;
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            ExportExcel(dgvServicios);
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {

        }
    }
}
