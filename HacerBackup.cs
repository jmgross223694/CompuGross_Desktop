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
using System.Data.SqlClient;
using System.Data.Sql;
using System.IO;

namespace CompuGross
{
    public partial class HacerBackup : Form
    {
        public HacerBackup()
        {
            InitializeComponent();
        }

        private void btnHacerBackup_Click(object sender, EventArgs e)
        {
            if (txtPath.Text == "")
            {
                MessageBox.Show("Debe seleccionar una ruta para guardar los archivos.");
            }
            else
            {

                List<string> listaTablas = new List<string>();

                listaTablas.Add("TiposUsuario");
                listaTablas.Add("Usuarios");
                listaTablas.Add("Localidades");
                listaTablas.Add("Clientes");
                listaTablas.Add("TiposServicio");
                listaTablas.Add("TiposEquipo");
                listaTablas.Add("OrdenesTrabajo");
                listaTablas.Add("ListaPrecios");
                
                bool bandera = false;

                foreach (var nombreTabla in listaTablas)
                {
                    SqlConnection con = new SqlConnection();
                    DataTable dt = new DataTable();

                    try
                    {
                        //INICIAMOS CONEXICON
                        con = new SqlConnection("Data source=localhost\\SQLEXPRESS;Initial Catalog=CompuGross;Trusted_Connection=true");

                        con.Open();

                        string selectTabla = "select * from " + nombreTabla;

                        //CARGAMOS TABLA EN MEMORIA CON LA CONSULTA
                        SqlCommand cmd = new SqlCommand(selectTabla, con);
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(dt);

                        string strFilePath = @"" + txtPath.Text + "\\" + nombreTabla + ".csv";

                        //CREAMOS ARCHIVO CSV
                        StreamWriter sw = new StreamWriter(strFilePath, false, Encoding.UTF8);

                        //copiar encabezados de la consulta

                        long cantidadColumnas = dt.Columns.Count;

                        for (int ncolumna = 0; ncolumna < cantidadColumnas; ncolumna++)
                        {
                            sw.Write(dt.Columns[ncolumna]);
                            if (ncolumna < cantidadColumnas - 1)
                            {
                                sw.Write(";");
                            }
                        }
                        sw.Write(sw.NewLine); //saltamos linea


                        // copiar info linea por linea
                        foreach (DataRow renglon in dt.Rows)
                        {
                            for (int ncolumna = 0; ncolumna < cantidadColumnas; ncolumna++)
                            {
                                if (!Convert.IsDBNull(renglon[ncolumna]))
                                {
                                    sw.Write(renglon[ncolumna]);
                                }
                                if (ncolumna < cantidadColumnas)
                                {
                                    sw.Write(";");
                                }
                            }
                            sw.Write(sw.NewLine); //saltamos linea
                        }
                        sw.Close();
                        con.Close();

                        bandera = true;
                    }
                    catch
                    {
                        con.Close();
                        bandera = false;
                    }
                }

                if (bandera == true)
                {
                    MessageBox.Show("Backup realizado correctamente");
                }
                else
                {
                    MessageBox.Show("Se produjo un error y no se realizo el backup.");
                }
            }
        }

        private void btnRestaurarBackup_Click(object sender, EventArgs e)
        {
            RestaurarBackup frmRestaurarBackup = new RestaurarBackup();
            this.Hide();
            frmRestaurarBackup.ShowDialog();
            this.Show();
        }

        private void btnPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK) txtPath.Text = fbd.SelectedPath;
        }
    }
}
