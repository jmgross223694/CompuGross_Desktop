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
    public partial class OrdenesTrabajo : Form
    {
        private List<OrdenTrabajo> listaOrdenes;
        public OrdenesTrabajo()
        {
            InitializeComponent();
        }

        private void OrdenesTrabajo_Load(object sender, EventArgs e)
        {
            cargarListado();
            alinearColumnas();
            ocultarColumnas();
        }

        private void cargarListado()
        {
            OrdenTrabajoDB ordenTrabajoDB = new OrdenTrabajoDB();

            try
            {
                listaOrdenes = ordenTrabajoDB.Listar();
                dgvOrdenesTrabajo.DataSource = listaOrdenes;
            }
            catch (Exception es)
            {
                MessageBox.Show(es.ToString());
            }
        }

        private void alinearColumnas()
        {
            dgvOrdenesTrabajo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvOrdenesTrabajo.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void ocultarColumnas()
        {
            dgvOrdenesTrabajo.Columns["Descripcion"].Visible = false;
            dgvOrdenesTrabajo.Columns["CostoRepuestos"].Visible = false;
            dgvOrdenesTrabajo.Columns["CostoTerceros"].Visible = false;
            dgvOrdenesTrabajo.Columns["CostoCG"].Visible = false;
            dgvOrdenesTrabajo.Columns["Estado"].Visible = false;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            OrdenTrabajo seleccionado = (OrdenTrabajo)dgvOrdenesTrabajo.CurrentRow.DataBoundItem;
            OrdenTrabajoDB ordentTrabajoDB = new OrdenTrabajoDB();

            try
            {
                if (MessageBox.Show("¿Está seguro de eliminar la Orden N° " + seleccionado.ID + " del cliente " + 
                                    seleccionado.Cliente + "?", "Atención!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ordentTrabajoDB.EliminarOrden(seleccionado.ID);
                    MessageBox.Show("La Orden N° " + seleccionado.ID + ", del cliente " + seleccionado.Cliente + 
                                    ", se ha eliminado correctamente");
                    cargarListado();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void BuscarFiltro()
        {
            List<OrdenTrabajo> filtro;
            if (txtFiltro.Text != "")
            {
                filtro = listaOrdenes.FindAll(Art => Art.ID.ToString().Contains(txtFiltro.Text.ToUpper()) ||
                                               Art.Cliente.ToUpper().Contains(txtFiltro.Text.ToUpper()) ||
                                               Art.TipoEquipo.ToUpper().Contains(txtFiltro.Text.ToUpper()) ||
                                               Art.TipoServicio.ToUpper().Contains(txtFiltro.Text.ToUpper()) ||
                                               Art.DatosEquipo.ToUpper().Contains(txtFiltro.Text.ToUpper()) ||
                                               Art.Descripcion.ToUpper().Contains(txtFiltro.Text.ToUpper()) ||
                                               Art.FechaRecepcion.ToUpper().Contains(txtFiltro.Text.ToUpper()) ||
                                               Art.FechaDevolucion.ToUpper().Contains(txtFiltro.Text.ToUpper()));
                dgvOrdenesTrabajo.DataSource = null;
                dgvOrdenesTrabajo.DataSource = filtro;
            }
            else
            {
                dgvOrdenesTrabajo.DataSource = null;
                dgvOrdenesTrabajo.DataSource = listaOrdenes;
            }
            ocultarColumnas();
            alinearColumnas();
        }

        private void txtFiltro_KeyUp(object sender, KeyEventArgs e)
        {
            BuscarFiltro();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        /*
            Clientes:
            ID, Cliente, DNI, Mail
        */
    }
}
