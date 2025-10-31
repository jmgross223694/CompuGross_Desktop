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
    public partial class ListadoPrecios : Form
    {
        bool agregar, modificar = false;
        private int sortOrder = 0;

        public ListadoPrecios()
        {
            InitializeComponent();
        }

        private void ajustarAnchoColumnasListaPrecios()
        {
            listPrecios.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.HeaderSize);
            listPrecios.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.ColumnContent);
            //listPrecios.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.HeaderSize);
            //listPrecios.AutoResizeColumn(3, ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void Precios_Load(object sender, EventArgs e)
        {
            listPrecios.Visible = false;
            txtPesos.Focus();
        }

        private void cargarListadoPrecios(string select)
        {
            if (txtPesos.Text != "")
            {
                AccesoDatos datos = new AccesoDatos();

                try
                {
                    datos.SetearConsulta(select);
                    datos.EjecutarLectura();
                    decimal dolarHoy = Convert.ToDecimal(txtPesos.Text);

                    while (datos.Lector.Read() == true)
                    {
                        int ID = Convert.ToInt32(datos.Lector["ID"]);
                        string Codigo = datos.Lector["Codigo"].ToString();
                        string Descripcion = datos.Lector["Descripcion"].ToString();
                        decimal PrecioDolares = Convert.ToDecimal(Convert.ToDouble(Math.Truncate((decimal)datos.Lector["Precio_Dolares"] * 100) / 100));
                        decimal PrecioPesos = PrecioDolares * dolarHoy;
                        ListViewItem registro = new ListViewItem(Codigo);
                        registro.SubItems.Add(Descripcion);
                        registro.SubItems.Add("$ " + PrecioPesos.ToString());
                        registro.SubItems.Add("u$s " + PrecioDolares.ToString());
                        listPrecios.Items.Add(registro);
                    }
                }
                catch
                {
                    MessageBox.Show("Error al buscar los precios en la Base de datos.");
                }
                finally
                {
                    datos.CerrarConexion();
                    ajustarAnchoColumnasListaPrecios();
                }
            }
        }

        private void listPrecios_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            string col;
            if (e.Column == 0) { col = "ID"; }
            else if (e.Column == 1) { col = "Descripcion"; }
            else { col = "Precio"; }

            string selectOrder = "select * from ListaPrecios order by " + col + " desc";

            if (sortOrder == 1) { this.sortOrder = 0; }
            else
            {
                selectOrder = "select * from ListaPrecios order by " + col + " asc";
                this.sortOrder = 1;
            }

            listPrecios.Items.Clear();

            cargarListadoPrecios(selectOrder);
        }

        private void soloNumerosEnteros_Y_Decimales(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar == ',' || e.KeyChar == '.')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtPesos_KeyPress(object sender, KeyPressEventArgs e)
        {
            int len = txtPesos.Text.Length;

            if (len == 0 && e.KeyChar == ',')
            {
                e.Handled = true;
            }
            else
            {
                soloNumerosEnteros_Y_Decimales(sender, e);
            }
        }

        private void txtPesos_TextChanged(object sender, EventArgs e)
        {
            listPrecios.Items.Clear();
            if (txtPesos.Text != "")
            {
                listPrecios.Visible = true;
                cargarListadoPrecios("select * from ListaPrecios order by ID asc");
            }
            else
            {
                listPrecios.Visible = false;
            }
        }

        private void AlinearColumnasDgv()
        {
            dgvPrecios.Columns["ID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPrecios.Columns["Codigo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPrecios.Columns["Dolares"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void AlinearTitulosDgv()
        {
            dgvPrecios.Columns["ID"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPrecios.Columns["Codigo"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPrecios.Columns["Descripcion"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPrecios.Columns["Dolares"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvPrecios.Columns["Aclaraciones"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void OrdenarColumnasDgv()
        {
            dgvPrecios.AllowUserToOrderColumns = true;
            dgvPrecios.Columns["ID"].DisplayIndex = 0;
            dgvPrecios.Columns["Codigo"].DisplayIndex = 1;
            dgvPrecios.Columns["Descripcion"].DisplayIndex = 2;
            dgvPrecios.Columns["Dolares"].DisplayIndex = 3;
            dgvPrecios.Columns["Aclaraciones"].DisplayIndex = 4;
        }

        private void RenombrarColumnasDgv()
        {
            dgvPrecios.Columns["Codigo"].HeaderText = "Código";
            dgvPrecios.Columns["Descripcion"].HeaderText = "Descripción";
            dgvPrecios.Columns["Dolares"].HeaderText = "Precio u$s";
        }

        private void OcultarColumnasDgv()
        {
            dgvPrecios.Columns["Pesos"].Visible = false;
            dgvPrecios.Columns["Estado"].Visible = false;
        }

        private void CargarListadoAbm()
        {
            List<Precio> lista = new List<Precio>();
            PrecioDB pDb = new PrecioDB();

            lista = pDb.Listar();
            dgvPrecios.DataSource = lista;

            OcultarColumnasDgv();
            AlinearTitulosDgv();
            AlinearColumnasDgv();
            OrdenarColumnasDgv();
            RenombrarColumnasDgv();
        }

        private void btnAbm_Click(object sender, EventArgs e)
        {
            CargarListadoAbm();
            dgvPrecios.Visible = true;
            lblPesos1.Visible = false;
            lblPesos2.Visible = false;
            txtPesos.Visible = false;
            btnAtras.Visible = true;
            btnAgregar.Visible = true;
            btnModificar.Visible = true;
            btnEliminar.Visible = true;
            btnAbm.Visible = false;
            listPrecios.Visible = false;
            lblDolares.Visible = false;
            lblDescripcion.Visible = false;
            txtDolares.Visible = false;
            txtDescripcion.Visible = false;
            btnConfirmar.Visible = false;

            txtPesos.Text = "";
            txtDolares.Text = "";
            txtDescripcion.Text = "";
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            dgvPrecios.DataSource = null;
            dgvPrecios.Visible = false;
            lblPesos1.Visible = true;
            lblPesos2.Visible = true;
            txtPesos.Visible = true;
            btnAtras.Visible = false;
            btnAgregar.Visible = false;
            btnModificar.Visible = false;
            btnEliminar.Visible = false;
            btnAbm.Visible = true;

            txtPesos.Text = "";
            txtDolares.Text = "";
            txtDescripcion.Text = "";

            lblDolares.Visible = false;
            lblDescripcion.Visible = false;
            txtDolares.Visible = false;
            txtDescripcion.Visible = false;
            btnConfirmar.Visible = false;

            lblCodigo.Visible = false;
            txtCodigo.Text = "";
            txtCodigo.Visible = false;
            lblAclaraciones.Visible = false;
            txtAclaraciones.Text = "";
            txtAclaraciones.Visible = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            lblPesos1.Visible = false;
            lblPesos2.Visible = false;
            txtPesos.Visible = false;
            txtPesos.Text = "";
            listPrecios.Visible = false;
            dgvPrecios.Visible = false;
            btnEliminar.Visible = false;
            btnModificar.Visible = false;
            btnAtras.Visible = true;
            btnAbm.Visible = true;
            btnAgregar.Visible = false;

            lblDolares.Visible = true;
            lblDescripcion.Visible = true;
            txtDolares.Visible = true;
            txtDolares.Text = "";
            txtDescripcion.Visible = true;
            txtDescripcion.Text = "";

            lblCodigo.Visible = true;
            txtCodigo.Text = "";
            txtCodigo.Visible = true;
            lblAclaraciones.Visible = true;
            txtAclaraciones.Text = "";
            txtAclaraciones.Visible = true;

            btnConfirmar.Visible = true;

            txtDolares.Focus();

            this.modificar = false;
            this.agregar = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            listPrecios.Visible = false;

            Precio p = (Precio)dgvPrecios.CurrentRow.DataBoundItem;

            lblPesos1.Visible = false;
            lblPesos2.Visible = false;
            txtPesos.Visible = false;
            txtPesos.Text = "";
            dgvPrecios.Visible = false;
            btnEliminar.Visible = false;
            btnModificar.Visible = false;
            btnAtras.Visible = true;
            btnAbm.Visible = false;
            btnAgregar.Visible = false;

            lblCodigo.Visible = true;
            txtCodigo.Visible = true;
            lblAclaraciones.Visible = true;
            txtAclaraciones.Visible = true;

            lblDolares.Visible = true;
            lblDescripcion.Visible = true;
            txtDolares.Visible = true;
            txtCodigo.Text = p.Codigo.ToString();
            txtDolares.Text = p.Dolares.ToString();
            txtDescripcion.Visible = true;
            txtDescripcion.Text = p.Descripcion;
            txtAclaraciones.Text = p.Aclaraciones;

            txtPesos.Text = p.ID.ToString();

            btnConfirmar.Visible = true;

            txtDolares.Focus();

            listPrecios.Visible = false;

            this.modificar = true;
            this.agregar = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea eliminar el Precio seleccionado?", "Atención!!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    PrecioDB pDb = new PrecioDB();

                    Precio precio = (Precio)dgvPrecios.CurrentRow.DataBoundItem;
                    pDb.Eliminar(precio);

                    MessageBox.Show("Se ha eliminado el precio seleccionado.", "Atención!!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    CargarListadoAbm();
                    cargarListadoPrecios("select * from ListaPrecios order by ID asc");
                }
                catch
                {
                    MessageBox.Show("Error al intentar eliminar el Precio.", "Atención!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtDolares_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Tab || e.KeyChar == (Char)Keys.Enter)
            {
                txtDescripcion.Focus();
            }
            else
            {
                int len = txtDolares.Text.Length;

                if (len == 0 && e.KeyChar == ',')
                {
                    e.Handled = true;
                }
                if (len == 0 && e.KeyChar == '.')
                {
                    e.Handled = true;
                }
                else
                {
                    soloNumerosEnteros_Y_Decimales(sender, e);
                }
            }
        }

        private void btnConfirmar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Tab)
            {
                txtDolares.Focus();
            }
            if (e.KeyChar == (Char)Keys.Enter)
            {
                ConfirmarPrecio();
            }
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Tab || e.KeyChar == (Char)Keys.Enter)
            {
                btnConfirmar.Focus();
            }
        }

        private void ConfirmarPrecio()
        {
            if (txtDolares.Text != "" && txtDescripcion.Text != "" && txtCodigo.Text != "")
            {
                decimal precioDolares = Convert.ToDecimal(txtDolares.Text.Replace(",", "."));
                string descripcion = txtDescripcion.Text, codigo = txtCodigo.Text, aclaraciones = txtAclaraciones.Text;

                if (precioDolares == 0 || descripcion == "" || descripcion == "-" || descripcion == " " || codigo == "" || codigo == "-")
                {
                    MessageBox.Show("Precio, Código o Descripción inválidos o vacíos.", "Atención!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (this.agregar)
                    {
                        if (MessageBox.Show("¿Confirma agregar el nuevo Precio a la lista?", "Atención!!",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            try
                            {
                                PrecioDB pDb = new PrecioDB();

                                Precio precio = new Precio();
                                precio.ID = 1;
                                precio.Codigo = codigo;
                                precio.Descripcion = descripcion;
                                precio.Aclaraciones = aclaraciones;
                                precio.Dolares = precioDolares;
                                pDb.Agregar(precio);

                                MessageBox.Show("Precio registrado correctamente en el sistema.", "Atención!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch
                            {
                                MessageBox.Show("Error al intentar agregar el Precio.", "Atención!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    if (this.modificar)
                    {
                        if (MessageBox.Show("¿Confirma modificar el Precio seleccionado?", "Atención!!",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            try
                            {
                                PrecioDB pDb = new PrecioDB();

                                Precio precio = new Precio();

                                precio.ID = Convert.ToInt64(txtPesos.Text);
                                precio.Codigo = codigo;
                                precio.Descripcion = descripcion;
                                precio.Aclaraciones = txtAclaraciones.Text;
                                precio.Dolares = precioDolares;

                                pDb.Modificar(precio);

                                MessageBox.Show("Precio modificado correctamente.", "Atención!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch
                            {
                                MessageBox.Show("Error al intentar modificar el Precio.", "Atención!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }

                    lblDolares.Visible = false;
                    lblDescripcion.Visible = false;
                    txtDolares.Visible = false;
                    txtDolares.Text = "";
                    txtDescripcion.Visible = false;
                    txtDescripcion.Text = "";
                    txtPesos.Text = "";
                    btnConfirmar.Visible = false;

                    lblCodigo.Visible = false;
                    txtCodigo.Text = "";
                    txtCodigo.Visible = false;
                    lblAclaraciones.Visible = false;
                    txtAclaraciones.Text = "";
                    txtAclaraciones.Visible = false;

                    btnAbm.Visible = false;
                    btnAtras.Visible = true;
                    btnAgregar.Visible = true;
                    btnModificar.Visible = true;
                    btnEliminar.Visible = true;
                    dgvPrecios.Visible = true;
                }

                CargarListadoAbm();
                cargarListadoPrecios("select * from ListaPrecios order by ID asc");
            }
            else
            {
                MessageBox.Show("Precio, Código o Descripción inválidos o vacíos.", "Atención!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            ConfirmarPrecio();
        }
    }
}
