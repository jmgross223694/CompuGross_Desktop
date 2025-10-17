using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompuGross.Menú_principal.Proveedores
{
    public partial class ComprasProveedores : Form
    {
        private Proveedor proveedor = new Proveedor();
        private ProveedorDB proveedorDB = new ProveedorDB();
        private Cliente cliente = new Cliente();
        private ClienteDB clienteDB = new ClienteDB();
        private CompraProveedor compraProveedor = new CompraProveedor();
        private CompraProveedorDB compraProveedorDB = new CompraProveedorDB();

        public ComprasProveedores()
        {
            InitializeComponent();
            ListarComprasProveedores();
            btnListar.Visible = false;
            btnAgregar.Visible = true;
            btnModificar.Visible = true;
            btnEliminar.Visible = true;
            lblTitle.Text = "Compras Proveedores";
        }

        private void VisibilidadCamposForm(bool visible)
        {
            lblProveedor.Visible = visible;
            lblCliente.Visible = visible;
            lblCodigoArticulo.Visible = visible;
            lblDescripcionArticulo.Visible = visible;
            lblNumSerieArticulo.Visible = visible;
            lblCodigoVerificacionArticulo.Visible = visible;
            lblMontoAbonado.Visible = visible;
            lblFechaCompra.Visible = visible;
            lblDevolucion.Visible = visible;
            lblEstado.Visible = visible;

            txtProveedor.Visible = visible;
            txtCliente.Visible = visible;
            txtCodigoArticulo.Visible = visible;
            txtDescripcionArticulo.Visible = visible;
            txtNumeroSerieArticulo.Visible = visible;
            txtCodigoVerificacionArticulo.Visible = visible;
            txtMontoAbonado.Visible = visible;
            calendarFechaCompra.Visible = visible;
            cbDevolucion.Visible = visible;
            cbEstado.Visible = visible;

            btnConfirmar.Visible = visible;
        }

        private void LimpiarCamposForm()
        {
            txtProveedor.Text = "";
            txtCliente.Text = "";
            txtCodigoArticulo.Text = "";
            txtDescripcionArticulo.Text = "";
            txtNumeroSerieArticulo.Text = "";
            txtCodigoVerificacionArticulo.Text = "";
            cbDevolucion.SelectedItem = "No";
            cbEstado.SelectedItem = "Activo";
        }

        private void ListarComprasProveedores()
        {
            try
            {
                CargarColumnasDataGridView();
                dgvComprasProveedores.DataSource = compraProveedorDB.Listar().Select(
                compra => new
                {
                    compra.ID,
                    Proveedor = compra.Proveedor?.Nombre,
                    CodigoArticulo = compra.Articulo?.Codigo,
                    NumeroSerieArticulo = compra.Articulo?.NumeroSerie,
                    CodigoVerificacionArticulo = compra.Articulo?.CodigoVerificacion,
                    MontoAbonado = compra.MontoAbonado,
                    FechaCompra = compra.FechaCompra,
                    Cliente = compra.Cliente?.Nombres,
                    Devolucion = compra.Devolucion,
                    Estado = compra.Estado
                }).ToList();
                FormatearDataGridView();
                VisibilidadCamposForm(false);
                dgvComprasProveedores.Visible = true;
                dgvComprasProveedores.Focus();
                btnListar.Visible = false;
                btnAgregar.Visible = true;
                btnModificar.Visible = true;
                btnEliminar.Visible = true;
            }
            catch
            {
                MessageBox.Show("No pudieron listarse Compras a Proveedores.");
            }
        }

        private void FormatearDataGridView()
        {
            dgvComprasProveedores.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvComprasProveedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvComprasProveedores.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void CargarColumnasDataGridView()
        {
            dgvComprasProveedores.Columns.Clear();
            dgvComprasProveedores.AutoGenerateColumns = false;
            dgvComprasProveedores.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "ID",
                DataPropertyName = "ID",
                Name = "columnaID"
            });

            dgvComprasProveedores.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Proveedor",
                DataPropertyName = "Proveedor",
                Name = "columnaProveedor"
            });

            dgvComprasProveedores.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Código",
                DataPropertyName = "CodigoArticulo",
                Name = "columnaCodigoArticulo"
            });

            dgvComprasProveedores.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Núm.Serie",
                DataPropertyName = "NumeroSerieArticulo",
                Name = "columnaNumeroSerieArticulo"
            });

            dgvComprasProveedores.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Cód.Verif.",
                DataPropertyName = "CodigoVerificacionArticulo",
                Name = "columnaCodigoVerificacionArticulo"
            });

            dgvComprasProveedores.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Monto",
                DataPropertyName = "MontoAbonado",
                Name = "columnaCodigoVerificacionArticulo",
                DefaultCellStyle = { Format = "C2" }
            });

            dgvComprasProveedores.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Fecha",
                DataPropertyName = "FechaCompra",
                Name = "colFechaCompra",
                DefaultCellStyle = { Format = "dd/MM/yyyy" }
            });

            dgvComprasProveedores.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Cliente",
                DataPropertyName = "Cliente",
                Name = "colCliente"
            });

            dgvComprasProveedores.Columns.Add(new DataGridViewCheckBoxColumn
            {
                HeaderText = "Devolución",
                DataPropertyName = "Devolucion",
                Name = "colDevolucion"
            });

            dgvComprasProveedores.Columns.Add(new DataGridViewCheckBoxColumn
            {
                HeaderText = "Estado",
                DataPropertyName = "Estado",
                Name = "colEstado"
            });

            dgvComprasProveedores.ReadOnly = true;
            dgvComprasProveedores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvComprasProveedores.AllowUserToAddRows = false;
            dgvComprasProveedores.AllowUserToDeleteRows = false;
            dgvComprasProveedores.AllowUserToOrderColumns = false;
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            ListarComprasProveedores();
            lblTitle.Text = "Compras Proveedores";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            LimpiarCamposForm();
            VisibilidadCamposForm(true);
            dgvComprasProveedores.Visible = false;
            dgvComprasProveedores.DataSource = null;
            txtProveedor.Focus();
            btnListar.Visible = true;
            btnAgregar.Visible = false;
            btnModificar.Visible = false;
            btnEliminar.Visible = false;
            lblTitle.Text = "Nueva Compra Proveedor";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvComprasProveedores.CurrentRow != null)
            {
                compraProveedor.ID = Convert.ToInt64(dgvComprasProveedores.CurrentRow.Cells[0].Value);
                DialogResult resultado = MessageBox.Show(
                    $"¿Seguro que querés dar de baja la compra con ID {compraProveedor.ID}?",
                    "Confirmación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );
                if (resultado == DialogResult.Yes)
                {
                    compraProveedorDB.BajaLogica(compraProveedor);
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvComprasProveedores.CurrentRow != null)
            {
                compraProveedor.ID = Convert.ToInt64(dgvComprasProveedores.CurrentRow.Cells[0].Value);
                compraProveedor = compraProveedorDB.BuscarPorID(compraProveedor);
                CargarCamposModificar();
                VisibilidadCamposForm(true);
                dgvComprasProveedores.Visible = false;
                txtProveedor.Focus();
                btnAgregar.Visible = true;
                btnListar.Visible = true;
                btnModificar.Visible = false;
                btnEliminar.Visible = false;
                lblTitle.Text = "Modificar Compra Proveedor";
            }
        }

        private void CargarCamposModificar()
        {
            LimpiarCamposForm();
            txtIdCompra.Text = compraProveedor.ID.ToString();
            txtProveedor.Text = compraProveedor.Proveedor.ID + "-" + compraProveedor.Proveedor.Nombre;
            txtCliente.Text = compraProveedor.Cliente.Id + "-" + compraProveedor.Cliente.Nombres;
            txtCodigoArticulo.Text = compraProveedor.Articulo.Codigo.ToUpper();
            txtDescripcionArticulo.Text = compraProveedor.Articulo.Descripcion;
            txtNumeroSerieArticulo.Text = compraProveedor.Articulo.NumeroSerie.ToUpper();
            txtCodigoVerificacionArticulo.Text = compraProveedor.Articulo.CodigoVerificacion.ToUpper();
            txtMontoAbonado.Text = compraProveedor.MontoAbonado.ToString("C", new CultureInfo("es-AR"));
            calendarFechaCompra.Text = compraProveedor.FechaCompra.ToString();
            cbDevolucion.SelectedItem = "No"; if (compraProveedor.Devolucion) { cbDevolucion.SelectedItem = "Si"; }
            cbEstado.SelectedItem = "Activo"; if (!compraProveedor.Estado) { cbEstado.SelectedItem = "Inactivo"; }
        }

        private void btnSeleccionarProveedor_Click(object sender, EventArgs e)
        {
            BuscarProveedorPorTelefono();
        }

        private void btnSeleccionarCliente_Click(object sender, EventArgs e)
        {
            BuscarClientePorTelefono();
        }

        private void BuscarProveedorPorTelefono()
        {
            if (txtProveedor.Text != "" || !txtProveedor.Text.Contains("-"))
            {
                proveedor = proveedorDB.BuscarPorTelefono(txtProveedor.Text.Replace("-", "").Replace(" ", ""));
                if (proveedor != null && proveedor.ID > 0)
                {
                    proveedor.Telefono = txtProveedor.Text;
                    txtProveedor.Text = proveedor.ID.ToString() + "-" + proveedor.Nombre;
                }
                else
                {
                    proveedor.Telefono = txtProveedor.Text;
                    MessageBox.Show("No se ha encontrado ningún Proveedor con el Teléfono: " + proveedor.Telefono + ".", "Atención!");
                }
            }
        }

        private void BuscarClientePorTelefono()
        {
            if (txtCliente.Text != "" || !txtCliente.Text.Contains("-"))
            {
                cliente = clienteDB.BuscarPorTelefono(txtCliente.Text.Replace("-", "").Replace(" ", ""));
                if (cliente != null && cliente.Id > 0 && txtProveedor.Text != "")
                {
                    cliente.Telefono = txtCliente.Text;
                    txtCliente.Text = cliente.Id.ToString() + "-" + cliente.Nombres;
                }
                else
                {
                    cliente.Telefono = txtCliente.Text;
                    if (txtProveedor.Text == "")
                    {
                        MessageBox.Show("Primero debe seleccionar un Proveedor.", "Atención!");
                    }
                    else
                    {
                        MessageBox.Show("No se ha encontrado ningún Cliente con el Teléfono: " + cliente.Telefono + ".");
                    }
                }
            }
        }

        private void txtCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                BuscarClientePorTelefono();
            }
        }

        private void txtProveedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                BuscarProveedorPorTelefono();
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (!txtProveedor.Text.Contains("-"))
            {
                MessageBox.Show("Proveedor no seleccionado.","Atención!");
            }
            if (lblTitle.Text.Contains("Nueva")) //Agregar compra
            {
                try
                {
                    compraProveedor = CargarCompraProveedor("agregar");
                    compraProveedorDB.Agregar(compraProveedor);
                    MessageBox.Show("Compra registrada correctamente.", "Confirmado!");
                }
                catch
                {
                    MessageBox.Show("Debido a un error no se pudo registrar la Compra.","Error!");
                }
            }
            if (lblTitle.Text.Contains("Modificar")) //Modificar compra
            {
                try
                {
                    compraProveedor = CargarCompraProveedor("modificar");
                    compraProveedorDB.Modificar(compraProveedor);
                    MessageBox.Show("Compra modificada.", "Confirmado!");
                }
                catch
                {
                    MessageBox.Show("Debido a un error no se pudo modificar la Compra.", "Error!");
                }
            }
        }

        private CompraProveedor CargarCompraProveedor(string accion) //accion = agregar/modificar
        {
            if (accion == "modificar") { compraProveedor.ID = Convert.ToInt64(txtIdCompra.Text); }
            compraProveedor.Proveedor.ID = Convert.ToInt32(txtProveedor.Text.Substring(0, txtProveedor.Text.IndexOf('-')));
            if (txtCliente.Text != "" && txtCliente.Text.Contains("-")) { compraProveedor.Cliente.Id = Convert.ToInt32(txtCliente.Text.Substring(0, txtCliente.Text.IndexOf('-'))); }
            compraProveedor.Articulo.Codigo = txtCodigoArticulo.Text;
            compraProveedor.Articulo.Descripcion = txtDescripcionArticulo.Text;
            compraProveedor.Articulo.NumeroSerie = txtNumeroSerieArticulo.Text;
            compraProveedor.Articulo.CodigoVerificacion = txtCodigoVerificacionArticulo.Text;
            compraProveedor.MontoAbonado = Decimal.Parse(txtMontoAbonado.Text, NumberStyles.Currency, new CultureInfo("es-AR"));
            compraProveedor.FechaCompra = calendarFechaCompra.Value;
            compraProveedor.Devolucion = false; if (cbDevolucion.SelectedItem.ToString() == "Si") { compraProveedor.Devolucion = true; }
            compraProveedor.Estado = true; if (cbEstado.SelectedItem.ToString() == "Inactivo") { compraProveedor.Estado = false; }
            return compraProveedor;
        }
    }
}
