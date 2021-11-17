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
            cargarListado();
            ocultarColumnas();
            centrarColumnas();
        }

        private void centrarColumnas()
        {
            this.dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvClientes.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvClientes.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvClientes.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void ocultarColumnas()
        {
            dgvClientes.Columns["ID"].Visible = false;
            dgvClientes.Columns["IdLocalidad"].Visible = false;
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

        private void comboBoxBuscarCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBoxBusquedaCliente.Text = "";
        }

        private void BuscarFiltro()
        {
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
            centrarColumnas();
        }

        private void txtBoxBusquedaCliente_KeyUp(object sender, KeyEventArgs e)
        {
            BuscarFiltro();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarCliente frmAgregar = new AgregarCliente();
            frmAgregar.ShowDialog();
            cargarListado();
            ocultarColumnas();
            centrarColumnas();
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
                    cargarListado();
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
                cargarListado();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
