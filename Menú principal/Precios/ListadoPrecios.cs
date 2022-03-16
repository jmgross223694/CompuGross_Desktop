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

namespace CompuGross
{
    public partial class ListadoPrecios : Form
    {

        private int sortOrder = 0;

        public ListadoPrecios()
        {
            InitializeComponent();
        }

        private void ajustarAnchoColumnas()
        {
            listPrecios.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.HeaderSize);
            listPrecios.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.ColumnContent);
            listPrecios.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.HeaderSize);
            listPrecios.AutoResizeColumn(3, ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void ListaPrecios_Load(object sender, EventArgs e)
        {
            rBtnDolarInformal.Visible = false;
            rBtnDolarOficial.Visible = false;
            lblDolarInformal.Visible = false;
            lblDolarOficial.Visible = false;
            txtDolarInformal.Visible = false;
            txtDolarOficial.Visible = false;
            listPrecios.Visible = false;
            txtDolar.Focus();
        }

        private void cargarListado(string select)
        {
            AccesoDatos datos = new AccesoDatos();
            
            try
            {
                datos.SetearConsulta(select);
                datos.EjecutarLectura();
                decimal dolarHoy = Convert.ToDecimal(txtDolar.Text);
                //decimal dolarOficial = 0;
                //decimal dolarInformal = 0;

                /*if (txtDolarOficial.Text != "") 
                { dolarOficial = Convert.ToDecimal(txtDolarOficial.Text); }

                if (txtDolarInformal.Text != "") 
                { dolarInformal = Convert.ToDecimal(txtDolarInformal.Text); }*/

                while (datos.Lector.Read() == true)
                {
                    int ID = Convert.ToInt32(datos.Lector["ID"]);
                    string Descripcion = datos.Lector["Descripcion"].ToString();
                    decimal PrecioDolares = Convert.ToDecimal(datos.Lector["Precio"].ToString());
                    decimal PrecioPesos = PrecioDolares * dolarHoy;

                    ListViewItem registro = new ListViewItem(ID.ToString());

                    registro.SubItems.Add(Descripcion);

                    /*if (dolarOficial == 0 && dolarInformal == 0) { registro.SubItems.Add("$ 0"); }
                    else
                    {
                        if (rBtnDolarOficial.Checked == true && txtDolarOficial.Text != "")
                        {
                            PrecioPesos = PrecioDolar * dolarOficial;
                        }
                        else if (rBtnDolarInformal.Checked == true)
                        {
                            PrecioPesos = PrecioDolar * dolarInformal;
                        }

                        registro.SubItems.Add("$ " + PrecioPesos.ToString());
                    }*/

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
                ajustarAnchoColumnas();
            }
        }

        private void rBtnDolarOficial_MouseClick(object sender, MouseEventArgs e)
        {
            rBtnDolarInformal.Checked = false;

            listPrecios.Items.Clear();

            cargarListado("select * from ListaPrecios order by ID asc");

            if (txtDolarOficial.Text != "")
            {
                txtDolarOficial.BackColor = Color.White;
            }
            else
            {
                txtDolarOficial.BackColor = Color.FromArgb(255, 236, 236);
                txtDolarOficial.Focus();
            }
        }

        private void rBtnDolarInformal_MouseClick(object sender, MouseEventArgs e)
        {
            rBtnDolarOficial.Checked = false;

            listPrecios.Items.Clear();

            cargarListado("select * from ListaPrecios order by ID asc");
            
            if (txtDolarInformal.Text != "")
            {
                txtDolarInformal.BackColor = Color.White;
            }
            else
            {
                txtDolarInformal.BackColor = Color.FromArgb(255,236,236);
                txtDolarInformal.Focus();
            }
        }

        private void listPrecios_SelectedIndexChanged(object sender, EventArgs e)
        {
            
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

            cargarListado(selectOrder);
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            MenuPrincipal frmMenu = new MenuPrincipal();
            this.Hide();
            frmMenu.ShowDialog();
        }

        private void ListaPrecios_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login frmLogin = new Login();
            frmLogin.borrarUsuarioLogueado();

            Application.Exit();
        }

        private void txtDolarOficial_TextChanged(object sender, EventArgs e)
        {
            if (txtDolarOficial.Text != "")
            {
                txtDolarOficial.BackColor = Color.White;
            }
            else
            {
                listPrecios.Items.Clear();

                cargarListado("select * from ListaPrecios order by ID asc");

                txtDolarOficial.BackColor = Color.FromArgb(255, 236, 236);
            }
        }

        private void txtDolarInformal_TextChanged(object sender, EventArgs e)
        {
            if (txtDolarInformal.Text != "")
            {
                txtDolarInformal.BackColor = Color.White;
            }
            else
            {
                txtDolarInformal.BackColor = Color.FromArgb(255, 236, 236);
            }
        }

        private void txtDolarOficial_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumerosEnteros_Y_Decimales(sender, e);
        }

        private void txtDolarInformal_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumerosEnteros_Y_Decimales(sender, e);
        }

        private void soloNumerosEnteros_Y_Decimales(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar == ',')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtDolar_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumerosEnteros_Y_Decimales(sender, e);
        }

        private void txtDolar_TextChanged(object sender, EventArgs e)
        {
            listPrecios.Items.Clear();
            if (txtDolar.Text != "")
            {
                listPrecios.Visible = true;
                txtDolar.BackColor = Color.White;
                cargarListado("select * from ListaPrecios order by ID asc");
            }
            else
            {
                listPrecios.Visible = false;
                txtDolar.BackColor = Color.FromArgb(255, 236, 236);
            }
        }
    }
}
