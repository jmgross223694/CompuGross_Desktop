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
    public partial class Clientes : Form
    {
        private List<Cliente> listaClientes;

        public Clientes()
        {
            InitializeComponent();
            listarTodos();
        }

        private void listarTodos()
        {
            //this.Height = 800;
            //this.Width = 800;
            //this.CenterToScreen();

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

        private void alinearColumnas()
        {
            dgvClientes.Columns["Id"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvClientes.Columns["Nombres"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvClientes.Columns["DNI"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvClientes.Columns["Direccion"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvClientes.Columns["Telefono"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvClientes.Columns["Id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvClientes.Columns["Telefono"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvClientes.Columns["DNI"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvClientes.Columns["Localidad"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void ocultarColumnas()
        {
            dgvClientes.Columns["IdLocalidad"].Visible = false;
            dgvClientes.Columns["Direccion"].Visible = false;
        }

        private void cambiarTitulosColumnas()
        {
            dgvClientes.Columns["Id"].HeaderText = "N°";
            dgvClientes.Columns["Nombres"].HeaderText = "Cliente";
            dgvClientes.Columns["Telefono"].HeaderText = "Contacto";
            dgvClientes.Columns["Direccion"].HeaderText = "Dirección";
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
            catch (Exception es)
            {
                MessageBox.Show(es.ToString());
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

        private void lblListarTodos_Click(object sender, EventArgs e)
        {
            listarTodos();
        }

        private void Clientes_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login frmLogin = new Login();
            frmLogin.borrarUsuarioLogueado();

            Application.Exit();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            MenuPrincipal frmMenu = new MenuPrincipal();
            this.Hide();
            frmMenu.ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarFiltro();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarCliente frmAgregar = new AgregarCliente();
            txtFiltro.Text = "";
            this.Hide();
            frmAgregar.ShowDialog();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvClientes.CurrentRow != null)
                {
                    txtFiltro.Text = "";

                    Cliente seleccionado = (Cliente)dgvClientes.CurrentRow.DataBoundItem;

                    AgregarCliente modificar = new AgregarCliente(seleccionado);
                    this.Hide();
                    modificar.ShowDialog();
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

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cliente seleccionado = (Cliente)dgvClientes.CurrentRow.DataBoundItem;
            ClienteDB clienteDB = new ClienteDB();

            try
            {
                if (MessageBox.Show("¿Seguro que desea eliminar al cliente " + seleccionado.Nombres + "?", "Atención!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    clienteDB.EliminarCliente(seleccionado.Nombres, seleccionado.Telefono);
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
                MessageBox.Show("No se pudo eliminar al cliente. " + ex.ToString(), "Atención!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
