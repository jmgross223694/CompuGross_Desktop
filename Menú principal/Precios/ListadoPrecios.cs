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
        public ListaPrecios()
        {
            InitializeComponent();
        }

        private void ListaPrecios_Load(object sender, EventArgs e)
        {
            cargarListado();
        }

        private void cargarListado()
        {
            AccesoDatos datos = new AccesoDatos();

            string selectPrecios = "select ID as ID, Descripcion as Descripcion, Precio as Precio from ListaPrecios order by ID asc";
            
            try
            {
                datos.SetearConsulta(selectPrecios);
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

                cargarListado();
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

                cargarListado();
            }
        }
    }
}
