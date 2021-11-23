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
    public partial class Backup : Form
    {
        public Backup()
        {
            InitializeComponent();
        }

        private void btnHacerBackup_Click(object sender, EventArgs e)
        {
            List<string> listaTablas = new List<string>();

            listaTablas.Add("Usuarios");
            listaTablas.Add("Localidades");
            listaTablas.Add("Clientes");
            listaTablas.Add("TiposServicio");
            listaTablas.Add("TiposEquipo");
            listaTablas.Add("OrdenesTrabajo");
            listaTablas.Add("ListaPrecios");

            string select = "select * from ";

            bool bandera = false;

            SqlConnection con = new SqlConnection("Data source=localhost\\SQLEXPRESS;Initial Catalog=CompuGross;Trusted_Connection=true");

            foreach (var nombreTabla in listaTablas)
            {
                try
                {
                    con.Open();

                    SqlDataAdapter adap = new SqlDataAdapter(select+nombreTabla, con);

                    DataTable tabla = new DataTable();
                    adap.Fill(tabla);

                    List<string> lineas = new List<string>(), columnas = new List<string>();
                    foreach (DataColumn col in tabla.Columns) columnas.Add(col.ColumnName);

                    lineas.Add(string.Join(";", columnas));
                    foreach (DataRow fila in tabla.Rows)
                    {
                        List<string> celdas = new List<string>();
                        foreach (object celda in fila.ItemArray) celdas.Add(celda.ToString());

                        lineas.Add(string.Join(";", celdas));
                    }

                    string path = txtPath.Text + "/" + nombreTabla + ".csv";

                    File.WriteAllLines(path, lineas);

                    con.Close();

                    bandera = true;
                }
                catch
                {
                    bandera = false;
                }
            }
            if (bandera == true)
            {
                MessageBox.Show("Backup realizado correctamente.");
            }
            else
            {
                MessageBox.Show("Se produjo un error y no se realizó el Backup.");
            }
        }

        private void btnRestaurarBackup_Click(object sender, EventArgs e)
        {

        }

        private void btnPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK) txtPath.Text = fbd.SelectedPath;
        }
    }
}
