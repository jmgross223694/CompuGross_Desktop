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
            AccesoDatos datos = new AccesoDatos();

            string selectPrecios = "select ID as ID, Descripcion as Descripcion, Precio as Precio from ListaPrecios order by ID asc";

            try
            {
                datos.SetearConsulta(selectPrecios);
                datos.EjecutarLectura();

                int n = 0;

                while (datos.Lector.Read() == true)
                {
                    n = Convert.ToInt32(datos.Lector["ID"]);

                    switch (n)
                    {
                        case 1:
                            {
                                txtDescripcion1.Text = datos.Lector["Descripcion"].ToString();
                                txtDolares1.Text = datos.Lector["Precio"].ToString();
                            }
                            break;
                        case 2:
                            {
                                txtDescripcion2.Text = datos.Lector["Descripcion"].ToString();
                                txtDolares2.Text = datos.Lector["Precio"].ToString();
                            }
                            break;
                        case 3:
                            {
                                txtDescripcion3.Text = datos.Lector["Descripcion"].ToString();
                                txtDolares3.Text = datos.Lector["Precio"].ToString();
                            }
                            break;
                        case 4:
                            {
                                txtDescripcion4.Text = datos.Lector["Descripcion"].ToString();
                                txtDolares4.Text = datos.Lector["Precio"].ToString();
                            }
                            break;
                        case 5:
                            {
                                txtDescripcion5.Text = datos.Lector["Descripcion"].ToString();
                                txtDolares5.Text = datos.Lector["Precio"].ToString();
                            }
                            break;
                        case 6:
                            {
                                txtDescripcion6.Text = datos.Lector["Descripcion"].ToString();
                                txtDolares6.Text = datos.Lector["Precio"].ToString();
                            }
                            break;
                        case 7:
                            {
                                txtDescripcion7.Text = datos.Lector["Descripcion"].ToString();
                                txtDolares7.Text = datos.Lector["Precio"].ToString();
                            }
                            break;
                        case 8:
                            {
                                txtDescripcion8.Text = datos.Lector["Descripcion"].ToString();
                                txtDolares8.Text = datos.Lector["Precio"].ToString();
                            }
                            break;
                        case 9:
                            {
                                txtDescripcion9.Text = datos.Lector["Descripcion"].ToString();
                                txtDolares9.Text = datos.Lector["Precio"].ToString();
                            }
                            break;
                        case 10:
                            {
                                txtDescripcion10.Text = datos.Lector["Descripcion"].ToString();
                                txtDolares10.Text = datos.Lector["Precio"].ToString();
                            }
                            break;
                        case 11:
                            {
                                txtDescripcion11.Text = datos.Lector["Descripcion"].ToString();
                                txtDolares11.Text = datos.Lector["Precio"].ToString();
                            }
                            break;
                        case 12:
                            {
                                txtDescripcion12.Text = datos.Lector["Descripcion"].ToString();
                                txtDolares12.Text = datos.Lector["Precio"].ToString();
                            }
                            break;
                        case 13:
                            {
                                txtDescripcion13.Text = datos.Lector["Descripcion"].ToString();
                                txtDolares13.Text = datos.Lector["Precio"].ToString();
                            }
                            break;
                        case 14:
                            {
                                txtDescripcion14.Text = datos.Lector["Descripcion"].ToString();
                                txtDolares14.Text = datos.Lector["Precio"].ToString();
                            }
                            break;
                        case 15:
                            {
                                txtDescripcion15.Text = datos.Lector["Descripcion"].ToString();
                                txtDolares15.Text = datos.Lector["Precio"].ToString();
                            }
                            break;
                        case 16:
                            {
                                txtDescripcion16.Text = datos.Lector["Descripcion"].ToString();
                                txtDolares16.Text = datos.Lector["Precio"].ToString();
                            }
                            break;
                        case 17:
                            {
                                txtDescripcion17.Text = datos.Lector["Descripcion"].ToString();
                                txtDolares17.Text = datos.Lector["Precio"].ToString();
                            }
                            break;
                        case 18:
                            {
                                txtDescripcion18.Text = datos.Lector["Descripcion"].ToString();
                                txtDolares18.Text = datos.Lector["Precio"].ToString();
                            }
                            break;
                        case 19:
                            {
                                txtDescripcion19.Text = datos.Lector["Descripcion"].ToString();
                                txtDolares19.Text = datos.Lector["Precio"].ToString();
                            }
                            break;
                        case 20:
                            {
                                txtDescripcion20.Text = datos.Lector["Descripcion"].ToString();
                                txtDolares20.Text = datos.Lector["Precio"].ToString();
                            }
                            break;
                    }
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

        public void CargarPesos(double valorDolar)
        {
            txtPesos1.Text = Convert.ToString(Convert.ToInt32(txtDolares1.Text) * valorDolar);
            txtPesos2.Text = Convert.ToString(Convert.ToInt32(txtDolares2.Text) * valorDolar);
            txtPesos3.Text = Convert.ToString(Convert.ToInt32(txtDolares3.Text) * valorDolar);
            txtPesos4.Text = Convert.ToString(Convert.ToInt32(txtDolares4.Text) * valorDolar);
            txtPesos5.Text = Convert.ToString(Convert.ToInt32(txtDolares5.Text) * valorDolar);
            txtPesos6.Text = Convert.ToString(Convert.ToInt32(txtDolares6.Text) * valorDolar);
            txtPesos7.Text = Convert.ToString(Convert.ToInt32(txtDolares7.Text) * valorDolar);
            txtPesos8.Text = Convert.ToString(Convert.ToInt32(txtDolares8.Text) * valorDolar);
            txtPesos9.Text = Convert.ToString(Convert.ToInt32(txtDolares9.Text) * valorDolar);
            txtPesos10.Text = Convert.ToString(Convert.ToInt32(txtDolares10.Text) * valorDolar);
            txtPesos11.Text = Convert.ToString(Convert.ToInt32(txtDolares11.Text) * valorDolar);
            txtPesos12.Text = Convert.ToString(Convert.ToInt32(txtDolares12.Text) * valorDolar);
            txtPesos13.Text = Convert.ToString(Convert.ToInt32(txtDolares13.Text) * valorDolar);
            txtPesos14.Text = Convert.ToString(Convert.ToInt32(txtDolares14.Text) * valorDolar);
            txtPesos15.Text = Convert.ToString(Convert.ToInt32(txtDolares15.Text) * valorDolar);
            txtPesos16.Text = Convert.ToString(Convert.ToInt32(txtDolares16.Text) * valorDolar);
            txtPesos17.Text = Convert.ToString(Convert.ToInt32(txtDolares17.Text) * valorDolar);
            txtPesos18.Text = Convert.ToString(Convert.ToInt32(txtDolares18.Text) * valorDolar);
            txtPesos19.Text = Convert.ToString(Convert.ToInt32(txtDolares19.Text) * valorDolar);
            txtPesos20.Text = Convert.ToString(Convert.ToInt32(txtDolares20.Text) * valorDolar);
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

                CargarPesos(Convert.ToDouble(txtDolarInformal.Text));
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

                CargarPesos(Convert.ToDouble(txtDolarOficial.Text));
            }
        }
    }
}
