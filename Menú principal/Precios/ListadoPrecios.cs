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
    public partial class ListaPrecios : Form
    {

        private int sortOrder = 0;

        public ListaPrecios()
        {
            InitializeComponent();
        }

        private void ajustarAnchoColumnas()
        {
            listPrecios.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.HeaderSize);
            listPrecios.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.ColumnContent);
            listPrecios.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.HeaderSize);
            listPrecios.AutoResizeColumn(3, ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void ListaPrecios_Load(object sender, EventArgs e)
        {
            cargarListado("select * from ListaPrecios order by ID asc");
        }

        private void cargarListado(string select)
        {
            AccesoDatos datos = new AccesoDatos();
            
            try
            {
                datos.SetearConsulta(select);
                datos.EjecutarLectura();
                decimal dolarOficial = 0;
                decimal dolarInformal = 0;

                if (txtDolarOficial.Text != "") 
                { dolarOficial = Convert.ToDecimal(txtDolarOficial.Text); }

                if (txtDolarInformal.Text != "") 
                { dolarInformal = Convert.ToDecimal(txtDolarInformal.Text); }

                while (datos.Lector.Read() == true)
                {
                    int ID = Convert.ToInt32(datos.Lector["ID"]);
                    string Descripcion = datos.Lector["Descripcion"].ToString();
                    decimal PrecioPesos = 0;
                    decimal PrecioDolar = Convert.ToDecimal(datos.Lector["Precio"].ToString());

                    ListViewItem registro = new ListViewItem(ID.ToString());

                    registro.SubItems.Add(Descripcion);

                    if (dolarOficial == 0 && dolarInformal == 0) { registro.SubItems.Add("$ 0"); }
                    else
                    {
                        if (rBtnDolarOficial.Checked == true)
                        {
                            PrecioPesos = PrecioDolar * dolarOficial;
                        }
                        else if (rBtnDolarInformal.Checked == true)
                        {
                            PrecioPesos = PrecioDolar * dolarInformal;
                        }

                        registro.SubItems.Add("$ " + PrecioPesos.ToString());
                    }
                    
                    registro.SubItems.Add("u$s " + PrecioDolar.ToString());

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

        private void rBtnDolarInformal_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtDolarInformal.Text == "")
            {
                MessageBox.Show("Dolar informal vacío!");
            }
            else
            {
                rBtnDolarOficial.Checked = false;

                listPrecios.Items.Clear();

                cargarListado("select * from ListaPrecios order by ID asc");
            }
        }

        private void rBtnDolarOficial_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtDolarOficial.Text == "")
            {
                MessageBox.Show("Dolar oficial vacío!");
            }
            else
            {
                rBtnDolarInformal.Checked = false;

                listPrecios.Items.Clear();

                cargarListado("select * from ListaPrecios order by ID asc");
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
    }
}
