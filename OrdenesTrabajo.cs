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
            alinearTitulos();
            alinearColumnas();
            ocultarColumnas();
            ordenarColumnas();
            cambiarTitulos();
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
            dgvOrdenesTrabajo.Columns["ID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvOrdenesTrabajo.Columns["FechaRecepcion"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvOrdenesTrabajo.Columns["FechaDevolucion"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvOrdenesTrabajo.Columns["TipoEquipo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvOrdenesTrabajo.Columns["TipoServicio"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvOrdenesTrabajo.Columns["CostoTotal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvOrdenesTrabajo.Columns["Ganancia"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void cambiarTitulos()
        {
            dgvOrdenesTrabajo.Columns["FechaRecepcion"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvOrdenesTrabajo.Columns["FechaDevolucion"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvOrdenesTrabajo.Columns["CostoTotal"].DefaultCellStyle.Format = "C0";
            dgvOrdenesTrabajo.Columns["Ganancia"].DefaultCellStyle.Format = "C0";

            dgvOrdenesTrabajo.Columns["ID"].HeaderText = "N° de orden";
            dgvOrdenesTrabajo.Columns["FechaRecepcion"].HeaderText = "Fecha de recepción";
            dgvOrdenesTrabajo.Columns["FechaDevolucion"].HeaderText = "Fecha de devolución";
            dgvOrdenesTrabajo.Columns["MarcaModelo"].HeaderText = "Equipo";
            dgvOrdenesTrabajo.Columns["TipoServicio"].HeaderText = "Tipo de servicio";
            dgvOrdenesTrabajo.Columns["TipoEquipo"].HeaderText = "Tipo de equipo";
            dgvOrdenesTrabajo.Columns["Descripcion"].HeaderText = "Descripción";
            dgvOrdenesTrabajo.Columns["CostoTotal"].HeaderText = "Subtotal";
        }

        private void alinearTitulos()
        {
            dgvOrdenesTrabajo.Columns["ID"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvOrdenesTrabajo.Columns["FechaRecepcion"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvOrdenesTrabajo.Columns["FechaDevolucion"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvOrdenesTrabajo.Columns["Cliente"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvOrdenesTrabajo.Columns["TipoEquipo"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvOrdenesTrabajo.Columns["MarcaModelo"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvOrdenesTrabajo.Columns["TipoServicio"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvOrdenesTrabajo.Columns["CostoTotal"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvOrdenesTrabajo.Columns["Ganancia"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void ocultarColumnas()
        {
            dgvOrdenesTrabajo.Columns["RAM"].Visible = false;
            dgvOrdenesTrabajo.Columns["PlacaMadre"].Visible = false;
            dgvOrdenesTrabajo.Columns["Microprocesador"].Visible = false;
            dgvOrdenesTrabajo.Columns["Almacenamiento"].Visible = false;
            dgvOrdenesTrabajo.Columns["CdDvd"].Visible = false;
            dgvOrdenesTrabajo.Columns["Fuente"].Visible = false;
            dgvOrdenesTrabajo.Columns["Adicionales"].Visible = false;
            dgvOrdenesTrabajo.Columns["NumSerie"].Visible = false;
            dgvOrdenesTrabajo.Columns["Descripcion"].Visible = false;
            dgvOrdenesTrabajo.Columns["CostoRepuestos"].Visible = false;
            dgvOrdenesTrabajo.Columns["CostoTerceros"].Visible = false;
            dgvOrdenesTrabajo.Columns["CostoCG"].Visible = false;
            dgvOrdenesTrabajo.Columns["Estado"].Visible = false;
        }

        private void ordenarColumnas()
        {
            dgvOrdenesTrabajo.AllowUserToOrderColumns = true;

            dgvOrdenesTrabajo.Columns["ID"].DisplayIndex = 0;
            dgvOrdenesTrabajo.Columns["Cliente"].DisplayIndex = 1;
            dgvOrdenesTrabajo.Columns["FechaRecepcion"].DisplayIndex = 2;
            dgvOrdenesTrabajo.Columns["FechaDevolucion"].DisplayIndex = 3;
            dgvOrdenesTrabajo.Columns["TipoServicio"].DisplayIndex = 4;
            dgvOrdenesTrabajo.Columns["TipoEquipo"].DisplayIndex = 5;
            dgvOrdenesTrabajo.Columns["MarcaModelo"].DisplayIndex = 6;
            dgvOrdenesTrabajo.Columns["CostoTotal"].DisplayIndex = 7;
            dgvOrdenesTrabajo.Columns["Ganancia"].DisplayIndex = 8;
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
                                               Art.MarcaModelo.ToUpper().Contains(txtFiltro.Text.ToUpper()) ||
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
            alinearTitulos();
            alinearColumnas();
            ocultarColumnas();
            ordenarColumnas();
            cambiarTitulos();
        }

        private void txtFiltro_KeyUp(object sender, KeyEventArgs e)
        {
            BuscarFiltro();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarOrden frmAgregar = new AgregarOrden();
            this.Hide();
            frmAgregar.ShowDialog();
            this.Show();
            cargarListado();
            alinearTitulos();
            alinearColumnas();
            ocultarColumnas();
            ordenarColumnas();
            cambiarTitulos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            OrdenTrabajo seleccionado = (OrdenTrabajo)dgvOrdenesTrabajo.CurrentRow.DataBoundItem;

            AgregarOrden frmModificar = new AgregarOrden(seleccionado);
            this.Hide();
            frmModificar.ShowDialog();
            this.Show();
            cargarListado();
            alinearTitulos();
            alinearColumnas();
            ocultarColumnas();
            ordenarColumnas();
            cambiarTitulos();
        }
    }
}
