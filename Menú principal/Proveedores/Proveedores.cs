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
    public partial class Proveedores : Form
    {
        private List<Proveedor> listaProveedores = new List<Proveedor>();
        private bool primerCarga = true;
        private int IdProveedor = 0;
        public Proveedores()
        {
            InitializeComponent();
        }

        private void Proveedores_Load(object sender, EventArgs e)
        {
            CargarDdlSitiosProveedores();
            CargarDdlTiposProveedor();
            primerCarga = false;
            navegadorProveedores.Visible = false;
        }

        private void CargarDdlSitiosProveedores()
        {
            string selectSitiosProveedores = "select Nombre from Proveedores where Estado = 1 order by ID asc";
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta(selectSitiosProveedores);
                datos.EjecutarLectura();
                while (datos.Lector.Read())
                {
                    ddlSitiosProveedores.Items.Add(datos.Lector["Nombre"].ToString());
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al leer la tabla Proveedores en la base de datos.");
                this.Close();
            }
            finally
            {
                datos.CerrarConexion();
            }

            ddlSitiosProveedores.SelectedItem = "Seleccione...";
        }

        private void CargarDdlTiposProveedor()
        {
            string consulta = "select Descripcion from TiposProveedor where Estado = 1 order by Descripcion asc";
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta(consulta);
                datos.EjecutarLectura();
                while (datos.Lector.Read())
                {
                    ddlTipoProveedor.Items.Add(datos.Lector["Descripcion"].ToString());
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al leer la tabla TiposProveedores en la base de datos.");
                this.Close();
            }
            finally
            {
                datos.CerrarConexion();
            }

            ddlTipoProveedor.SelectedItem = "Seleccione...";
        }

        private void ddlSitiosProveedores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!primerCarga)
            {
                string nombreProveedor = ddlSitiosProveedores.SelectedItem.ToString(),
                       selectSitioProveedor = "select SitioWeb from Proveedores where Nombre = '" + nombreProveedor + "'",
                       sitioWeb = "";

                AccesoDatos datos = new AccesoDatos();

                try
                {
                    datos.SetearConsulta(selectSitioProveedor);
                    datos.EjecutarLectura();
                    if (datos.Lector.Read())
                    {
                        sitioWeb = datos.Lector["SitioWeb"].ToString();
                    }

                    btnModificar.Visible = false;
                    btnEliminar.Visible = false;
                    btnCancelar.Visible = false;
                    dgvProveedores.Visible = false;
                    navegadorProveedores.Visible = true;
                }
                catch
                {
                    MessageBox.Show("El proveedor " + nombreProveedor + " no tiene un sitio web cargado en el sistema.",
                                    "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    datos.CerrarConexion();
                }



                navegadorProveedores.Navigate(sitioWeb);
            }
        }

        private void BuscarFiltroDgvProveedores()
        {
            string filtro = txtUrl.Text;

            CargarDgvProveedores();

            List<Proveedor> listaFiltrada;
            if (filtro != "")
            {
                listaFiltrada = listaProveedores.FindAll(Art => Art.Nombre.ToUpper().Contains(filtro.ToUpper()) ||
                                               Art.Mail.ToUpper().Contains(filtro.ToUpper()) ||
                                               Art.Telefono.ToUpper().Contains(filtro.ToUpper()) ||
                                               Art.Tipo.ToUpper().Contains(filtro.ToUpper()) ||
                                               Art.FechaAlta.ToUpper().Contains(filtro.ToUpper()) ||
                                               Art.SitioWeb.ToUpper().Contains(filtro.ToUpper()));
                dgvProveedores.DataSource = null;
                dgvProveedores.DataSource = listaFiltrada;
            }
            else
            {
                dgvProveedores.DataSource = null;
                dgvProveedores.DataSource = listaProveedores;
            }
        }

        private void txtUrl_KeyDown(object sender, KeyEventArgs e)
        {
            if (navegadorProveedores.Visible == true)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    try
                    {
                        navegadorProveedores.Navigate(txtUrl.Text);
                    }
                    catch
                    {
                        MessageBox.Show("El sitio web ingresado es inválido.",
                                        "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            if (dgvProveedores.Visible == true)
            {
                BuscarFiltroDgvProveedores();
            }

            OrdenarColumnas();
            AlinearColumnas();
            OcultarColumnas();
            RenombrarColumnas();
        }

        private void navegadorProveedores_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            string urlActual = navegadorProveedores.Url.ToString();

            if (urlActual == "about:blank")
            {
                txtUrl.Text = "";
                navegadorProveedores.Visible = false;
            }
            else
            {
                txtUrl.Text = navegadorProveedores.Url.ToString();
                navegadorProveedores.Visible = true;
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Listar los Proveedores actuales?", "Atención!",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                btnModificar.Visible = true;
                btnEliminar.Visible = true;
                btnCancelar.Visible = false;
                navegadorProveedores.Visible = false;
                ddlSitiosProveedores.Visible = false;
                lblSitiosWeb.Visible = false;
                txtUrl.Text = "";
                lblFiltrar.Visible = true;

                CargarDgvProveedores();
                dgvProveedores.Visible = true;

                txtUrl.Focus();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea cancelar la operación actual?", "Atención!",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                btnModificar.Visible = true;
                btnEliminar.Visible = true;
                CargarDgvProveedores();
                dgvProveedores.Visible = true;
                ddlSitiosProveedores.Visible = false;
                lblSitiosWeb.Visible = false;
                lblFiltrar.Visible = true;
                txtUrl.Visible = true;
                btnCancelar.Visible = false;
                visibilidadCamposAgregarModificar("hide");
                BorrarCamposAgregarModificar();
                lblTitulo.Text = "Proveedores";
            }
        }

        private void visibilidadCamposAgregarModificar(string aux)
        {
            if (aux == "show")
            {
                lblNombre.Visible = true;
                txtNombre.Visible = true;
                lblMail.Visible = true;
                txtMail.Visible = true;
                lblTelefono.Visible = true;
                txtTelefono.Visible = true;
                lblTipo.Visible = true;
                ddlTipoProveedor.Visible = true;
                lblSitioWeb.Visible = true;
                txtSitioWeb.Visible = true;
                lblFechaAlta.Visible = true;
                fechaAlta.Visible = true;
                lblEstado.Visible = true;
                ddlEstado.Visible = true;
                btnConfirmar.Visible = true;
            }
            if (aux == "hide")
            {
                lblNombre.Visible = false;
                txtNombre.Visible = false;
                lblMail.Visible = false;
                txtMail.Visible = false;
                lblTelefono.Visible = false;
                txtTelefono.Visible = false;
                lblTipo.Visible = false;
                ddlTipoProveedor.Visible = false;
                lblSitioWeb.Visible = false;
                txtSitioWeb.Visible = false;
                lblFechaAlta.Visible = false;
                fechaAlta.Visible = false;
                lblEstado.Visible = false;
                ddlEstado.Visible = false;
                btnConfirmar.Visible = false;
            }
        }

        private void CargarCamposProveedor(Proveedor p)
        {
            txtNombre.Text = p.Nombre;
            txtMail.Text = p.Mail;
            txtTelefono.Text = p.Telefono;
            ddlTipoProveedor.SelectedItem = p.Tipo;
            txtSitioWeb.Text = p.SitioWeb;
            fechaAlta.Text = p.FechaAlta.ToString();
            ddlEstado.SelectedItem = "Activo";
            if (p.Estado == 0)
            {
                ddlEstado.SelectedItem = "Inactivo";
            }
        }

        private void BorrarCamposAgregarModificar()
        {
            txtNombre.Text = "";
            txtMail.Text = "";
            txtTelefono.Text = "";
            ddlTipoProveedor.SelectedItem = "-";
            txtSitioWeb.Text = "";
            fechaAlta.Value = DateTime.Now;
            ddlEstado.SelectedItem = "Activado";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Abrir formulario de cargar de Proveedores?", "Atención!",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                btnCancelar.Visible = true;
                btnModificar.Visible = false;
                btnEliminar.Visible = false;
                ddlSitiosProveedores.Visible = false;
                lblSitiosWeb.Visible = false;
                lblFiltrar.Visible = false;
                txtUrl.Visible = false;
                dgvProveedores.Visible = false;

                lblTitulo.Text = "Nuevo Proveedor";

                visibilidadCamposAgregarModificar("show");
            }
        }

        private void AlinearColumnas()
        {
            dgvProveedores.Columns["ID"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProveedores.Columns["Nombre"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProveedores.Columns["Mail"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProveedores.Columns["IdTipo"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProveedores.Columns["Tipo"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProveedores.Columns["Telefono"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProveedores.Columns["SitioWeb"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProveedores.Columns["FechaAlta"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProveedores.Columns["Estado"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvProveedores.Columns["ID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProveedores.Columns["Nombre"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProveedores.Columns["Mail"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvProveedores.Columns["IdTipo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProveedores.Columns["Tipo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProveedores.Columns["Telefono"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProveedores.Columns["SitioWeb"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvProveedores.Columns["FechaAlta"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProveedores.Columns["Estado"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void OcultarColumnas()
        {
            dgvProveedores.Columns["ID"].Visible = false;
            dgvProveedores.Columns["Mail"].Visible = false;
            dgvProveedores.Columns["IdTipo"].Visible = false;
            dgvProveedores.Columns["SitioWeb"].Visible = false;
            dgvProveedores.Columns["FechaAlta"].Visible = false;
            dgvProveedores.Columns["Estado"].Visible = false;
        }

        private void RenombrarColumnas()
        {
            dgvProveedores.Columns["Nombre"].HeaderText = "Proveedor";
            dgvProveedores.Columns["Telefono"].HeaderText = "Contacto";
            dgvProveedores.Columns["Tipo"].HeaderText = "Sector";
            //dgvProveedores.Columns["Direccion"].HeaderText = "Domicilio";
        }

        private void OrdenarColumnas()
        {
            dgvProveedores.AllowUserToOrderColumns = true;

            dgvProveedores.Columns["ID"].DisplayIndex = 0;
            dgvProveedores.Columns["Nombre"].DisplayIndex = 1;
            dgvProveedores.Columns["IdTipo"].DisplayIndex = 1;
            dgvProveedores.Columns["Tipo"].DisplayIndex = 1;
            dgvProveedores.Columns["Telefono"].DisplayIndex = 2;
            dgvProveedores.Columns["Mail"].DisplayIndex = 3;
            //dgvProveedores.Columns["Direccion"].DisplayIndex = 4;
            dgvProveedores.Columns["SitioWeb"].DisplayIndex = 4;
            dgvProveedores.Columns["FechaAlta"].DisplayIndex = 5;
            dgvProveedores.Columns["Estado"].DisplayIndex = 6;

            dgvProveedores.AllowUserToOrderColumns = false;
        }

        private void CargarDgvProveedores()
        {
            ProveedorDB pDB = new ProveedorDB();
            listaProveedores = pDB.Listar();
            dgvProveedores.DataSource = listaProveedores;
            OrdenarColumnas();
            AlinearColumnas();
            OcultarColumnas();
            RenombrarColumnas();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                Proveedor p = (Proveedor)dgvProveedores.CurrentRow.DataBoundItem;
                if (MessageBox.Show("¿Cargar datos del Proveedor " + p.Nombre + " para modificarlo?",
                    "Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    btnCancelar.Visible = true;
                    btnModificar.Visible = false;
                    txtUrl.Visible = false;
                    lblFiltrar.Visible = false;
                    dgvProveedores.Visible = false;
                    CargarCamposProveedor(p);
                    this.IdProveedor = p.ID;
                    visibilidadCamposAgregarModificar("show");
                    lblTitulo.Text = "Modificando Proveedor";
                }
            }
            catch
            {
                MessageBox.Show("´Debe seleccionar un Proveedor del listado.", "Atención!",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string tit = lblTitulo.Text;
            Proveedor p = new Proveedor();
            ProveedorDB pDB = new ProveedorDB();
            int resultado = 0;

            p.Nombre = txtNombre.Text;
            p.Mail = txtMail.Text;
            p.Telefono = txtTelefono.Text;
            p.Tipo = ddlTipoProveedor.SelectedItem.ToString();
            p.SitioWeb = txtSitioWeb.Text;
            DateTime aux = Convert.ToDateTime(fechaAlta.Value);
            p.FechaAlta = aux.Day + "/" + aux.Month + "/" + aux.Year;
            p.Estado = 1;
            if (ddlEstado.SelectedItem.ToString() == "Inactivo")
            {
                p.Estado = 0;
            }

            if (tit == "Modificando Proveedor")
            { //Modificar Proveedor
                p.ID = IdProveedor;

                try
                {
                    resultado = pDB.Modificar(p);
                    if (resultado == 1)
                    {
                        MessageBox.Show("Proveedor " + p.Nombre + " modificado correctamente.", "Atención!", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Se produjo un error al intentar modificar al nuevo proveedor.", "Atención!",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    } 
                }
                catch
                {
                    MessageBox.Show("Se produjo un error al intentar modificar al nuevo proveedor.", "Atención!",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            { //Agregar nuevo Proveedor
                try
                {
                    resultado = pDB.Agregar(p);
                    if (resultado == 1)
                    {
                        MessageBox.Show("Proveedor " + p.Nombre + " agregado correctamente.", "Atención!",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Se produjo un error al intentar agregar al nuevo proveedor.", "Atención!",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch
                {
                    MessageBox.Show("Se produjo un error al intentar agregar al nuevo proveedor.", "Atención!",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            visibilidadCamposAgregarModificar("hide");
            lblTitulo.Text = "Proveedor";
            BorrarCamposAgregarModificar();
            btnCancelar.Visible = false;
            btnModificar.Visible = false;
            btnEliminar.Visible = false;
            lblSitiosWeb.Visible = false;
            ddlSitiosProveedores.Visible = false;
            lblFiltrar.Visible = true;
            txtUrl.Visible = true;
            navegadorProveedores.Visible = false;
            CargarDgvProveedores();
            dgvProveedores.Visible = true;
        }

        private void btnSitiosProveedores_Click(object sender, EventArgs e)
        {
            btnCancelar.Visible = false;
            btnEliminar.Visible = false;
            btnModificar.Visible = false;
            dgvProveedores.Visible = false;
            lblFiltrar.Visible = false;
            lblSitiosWeb.Visible = true;
            ddlSitiosProveedores.Visible = true;
            txtUrl.Visible = true;
            navegadorProveedores.Visible = false;
            visibilidadCamposAgregarModificar("hide");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Proveedor p = (Proveedor)dgvProveedores.CurrentRow.DataBoundItem;
                try
                {
                    if (MessageBox.Show("¿Confirmar eliminar al Proveedor " + p.Nombre + " del sistema?",
                    "Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        ProveedorDB pDB = new ProveedorDB();
                        int resultado = pDB.Eliminar(p.ID);

                        if (resultado == 1)
                        {
                            MessageBox.Show("El Proveedor " + p.Nombre + " se ha eliminado correctamente.",
                            "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            BorrarCamposAgregarModificar();
                            CargarDgvProveedores();
                        }
                        else
                        {
                            MessageBox.Show("Se produjo un error al intentar eliminar al Proveedor seleccionado.",
                            "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Se produjo un error al intentar eliminar al Proveedor seleccionado.",
                            "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("´Debe seleccionar un Proveedor del listado.", "Atención!",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}