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
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
           /*
            cargarListado();
            ocultarColumnas();
            alinearColumnas();
            cambiarTitulosColumnas();
            ordenarColumnas();
           */
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
            //dgvClientes.Columns["Direccion"].Visible = false;
        }

        private void cambiarTitulosColumnas()
        {
            dgvClientes.Columns["Id"].HeaderText = "N° de cliente";
            dgvClientes.Columns["Nombres"].HeaderText = "Cliente";
            dgvClientes.Columns["Telefono"].HeaderText = "Teléfono";
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
            }
            catch (Exception es)
            {
                MessageBox.Show(es.ToString());
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
            if (txtBoxBusquedaCliente.Text != "")
            {
                filtro = listaClientes.FindAll(Art => Art.DNI.ToUpper().Contains(txtBoxBusquedaCliente.Text.ToUpper()) || 
                                               Art.Nombres.ToUpper().Contains(txtBoxBusquedaCliente.Text.ToUpper()) || 
                                               Art.Direccion.ToUpper().Contains(txtBoxBusquedaCliente.Text.ToUpper()) ||
                                               Art.Localidad.ToUpper().Contains(txtBoxBusquedaCliente.Text.ToUpper()) ||
                                               Art.Telefono.ToUpper().Contains(txtBoxBusquedaCliente.Text.ToUpper()));
                dgvClientes.DataSource = null;
                dgvClientes.DataSource = filtro;
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

        private void txtBoxBusquedaCliente_KeyUp(object sender, KeyEventArgs e)
        {
            BuscarFiltro();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarCliente frmAgregar = new AgregarCliente();
            frmAgregar.ShowDialog();
            txtBoxBusquedaCliente.Text = "";
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            Cliente seleccionado = (Cliente)dgvClientes.CurrentRow.DataBoundItem;
            ClienteDB clienteDB = new ClienteDB();

            try
            {
                if (MessageBox.Show("¿ Seguro que desea eliminar al cliente " + seleccionado.Nombres + " ?", "Atención!", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    clienteDB.EliminarCliente(seleccionado.Nombres, seleccionado.Telefono);
                    MessageBox.Show("El cliente " + seleccionado.Nombres + ", se ha eliminado correctamente");
                    txtBoxBusquedaCliente.Text = "";
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente seleccionado = (Cliente)dgvClientes.CurrentRow.DataBoundItem;
                AgregarCliente modificar = new AgregarCliente(seleccionado);
                modificar.ShowDialog();
                txtBoxBusquedaCliente.Text = "";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
