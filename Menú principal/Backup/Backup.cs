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
using ExcelDataReader;

namespace CompuGross
{
    public partial class Backup : Form
    {
        private DataSet dtsTablas = new DataSet();

        public Backup()
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
                listaTablas.Add("NumSerieCodVerificacionOrdenesTrabajo");
                //listaTablas.Add("Activado");
                //listaTablas.Add("credencialesMail");
                //listaTablas.Add("Licencias");
                //listaTablas.Add("UsuarioLogueado");

                bool bandera = false;

                foreach (var nombreTabla in listaTablas)
                {
                    SqlConnection con = new SqlConnection();
                    DataTable dt = new DataTable();

                    try
                    {
                        //INICIAMOS CONEXION
                        //string strConLocal = "data source=.\\SQLEXPRESS; initial catalog=CompuGross; integrated security=sspi";
                        string strConLan = "Server=.\\SQLEXPRESS,1433;DataBase=CompuGross;User Id=compugross;Password=compugross";

                        con = new SqlConnection(strConLan);

                        con.Open();
                        
                        string selectTabla = "select * from " + nombreTabla + " where Estado = 1";

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
            //ocultar controles para realizar backup
            btnSeleccionarCarpeta.Visible = false;
            btnHacerBackup.Visible = false;
            btnRestaurarBackup.Visible = false;
            txtPath.Visible = false;
            pbRealizarBackup.Visible = false;
            pbRestaurarBackup.Visible = false;

            //mostrar controles para restaurar backup
            btnElegirArchivo.Visible = true;
            txtArchivoSeleccionado.Visible = true;
            btnMostrarArchivo.Visible = true;
            btnCargarArchivo.Visible = true;
            lblSeleccionarTabla.Visible = true;
            ddlTablas.Visible = true;
            dgvArchivo.Visible = true;
            btnVolver.Visible = true;

            //borrar contenido de controles
            ddlTablas.SelectedItem = "-";
            txtArchivoSeleccionado.Text = "";
            dgvArchivo.DataSource = null;
        }

        private void btnSeleccionarCarpeta_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK) txtPath.Text = fbd.SelectedPath;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            //mostrar controles para realizar backup
            btnSeleccionarCarpeta.Visible = true;
            btnHacerBackup.Visible = true;
            btnRestaurarBackup.Visible = true;
            txtPath.Visible = true;
            pbRealizarBackup.Visible = true;
            pbRestaurarBackup.Visible = true;

            //ocultar controles para restaurar backup
            btnElegirArchivo.Visible = false;
            txtArchivoSeleccionado.Visible = false;
            btnMostrarArchivo.Visible = false;
            btnCargarArchivo.Visible = false;
            lblSeleccionarTabla.Visible = false;
            ddlTablas.Visible = false;
            dgvArchivo.Visible = false;
            btnVolver.Visible = false;
        }

        private void btnElegirArchivo_Click(object sender, EventArgs e)
        {
            try
            {
                //configuracion de ventana para seleccionar un archivo
                OpenFileDialog oOpenFileDialog = new OpenFileDialog();
                oOpenFileDialog.Filter = "Excel Worbook|*.xlsx";

                if (oOpenFileDialog.ShowDialog() == DialogResult.OK)
                {
                    dgvArchivo.DataSource = null;

                    txtArchivoSeleccionado.Text = oOpenFileDialog.FileName;

                    //FileStream nos permite leer, escribir, abrir y cerrar archivos en un sistema de archivos, como matrices de bytes
                    FileStream fsSource = new FileStream(oOpenFileDialog.FileName, FileMode.Open, FileAccess.Read);


                    //ExcelReaderFactory.CreateBinaryReader = formato XLS
                    //ExcelReaderFactory.CreateOpenXmlReader = formato XLSX
                    //ExcelReaderFactory.CreateReader = XLS o XLSX
                    IExcelDataReader reader = ExcelReaderFactory.CreateReader(fsSource);

                    //convierte todas las hojas a un DataSet
                    dtsTablas = reader.AsDataSet(new ExcelDataSetConfiguration()
                    {
                        ConfigureDataTable = (tableReader) => new ExcelDataTableConfiguration()
                        {
                            UseHeaderRow = true
                        }
                    });

                    //obtenemos las tablas y añadimos sus nombres en el desplegable de hojas
                    //foreach (DataTable tabla in dtsTablas.Tables)
                    //{
                    //    cboHojas.Items.Add(tabla.TableName);
                    //}
                    //cboHojas.SelectedIndex = 0;

                    reader.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("El archivo seleccionado está siendo utilizado por otra aplicación. Ciérrelo y reintente.");
            }
        }

        private void btnMostrarArchivo_Click(object sender, EventArgs e)
        {
            if (txtArchivoSeleccionado.Text == "")
            {
                MessageBox.Show("No hay ningún archivo seleccionado.");
            }
            else if (ddlTablas.SelectedItem.ToString() == "-")
            {
                MessageBox.Show("No ha seleccionado una tabla.");
            }
            else
            {
                try
                {
                    dgvArchivo.DataSource = dtsTablas.Tables[0];
                }
                catch
                {
                    MessageBox.Show("Se produjo un error al intentar mostrar el archivo seleccionado.");
                }
            }
        }

        private void btnCargarArchivo_Click(object sender, EventArgs e)
        {
            if (txtArchivoSeleccionado.Text == "")
            {
                MessageBox.Show("No hay ningún archivo seleccionado.");
            }
            else if (ddlTablas.SelectedItem.ToString() == "-")
            {
                MessageBox.Show("No ha seleccionado una tabla.");
            }
            else
            {
                string tabla = "";

                switch (ddlTablas.SelectedItem.ToString())
                {
                    case "Clientes":
                        tabla = "Clientes";
                        break;
                    case "Servicios":
                        tabla = "OrdenesTrabajo";
                        break;
                    case "Localidades":
                        tabla = "Localidades";
                        break;
                    case "Tipos de Equipo":
                        tabla = "TiposEquipo";
                        break;
                    case "Tipos de Servicio":
                        tabla = "TiposServicio";
                        break;
                    case "Listado de precios":
                        tabla = "ListaPrecios";
                        break;
                    case "Usuarios":
                        tabla = "Usuarios";
                        break;
                    case "Tipos de Usuario":
                        tabla = "TiposUsuario";
                        break;
                    case "Usuario Logueado":
                        tabla = "UsuarioLogueado";
                        break;
                    case "Credenciales del Mail":
                        tabla = "credencialesMail";
                        break;
                    case "Licencias":
                        tabla = "Licencias";
                        break;
                }

                DataTable data = (DataTable)(dgvArchivo.DataSource);

                bool resultado = new FuncionalidadesExcel().CargarDatos(data, tabla);

                if (resultado)
                {
                    MessageBox.Show("El archivo se importó correctamente.");

                    dgvArchivo.DataSource = null;
                    txtArchivoSeleccionado.Text = "";
                    ddlTablas.SelectedItem = "-";
                }
                else
                {
                    MessageBox.Show("Se produjo un error y no se importó el archivo.");
                }
            }
        }
    }
}
