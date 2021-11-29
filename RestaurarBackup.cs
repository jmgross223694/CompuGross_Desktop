using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace CompuGross
{
    public partial class RestaurarBackup : Form
    {
        private DataSet dtsTablas = new DataSet();

        public RestaurarBackup()
        {
            InitializeComponent();
            cbTabla.SelectedItem = "-";
            txtArchivo.Text = "";
            dgvContenidoExcel.DataSource = null;
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            //configuracion de ventana para seleccionar un archivo
            OpenFileDialog oOpenFileDialog = new OpenFileDialog();
            oOpenFileDialog.Filter = "Excel Worbook|*.xlsx";

            if (oOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                dgvContenidoExcel.DataSource = null;

                txtArchivo.Text = oOpenFileDialog.FileName;

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

        private void btnMostrarArchivo_Click(object sender, EventArgs e)
        {
            if (txtArchivo.Text == "")
            {
                MessageBox.Show("No hay ningún archivo seleccionado.");
            }
            else if (cbTabla.SelectedItem.ToString() == "-")
            {
                MessageBox.Show("No ha seleccionado una tabla.");
            }
            else
            {
                try
                {
                    dgvContenidoExcel.DataSource = dtsTablas.Tables[0];
                }
                catch
                {
                    MessageBox.Show("Se produjo un error al intentar mostrar el archivo seleccionado.");
                }
            }
        }

        private void btnCargarArchivo_Click(object sender, EventArgs e)
        {
            if (txtArchivo.Text == "")
            {
                MessageBox.Show("No hay ningún archivo seleccionado.");
            }
            else if (cbTabla.SelectedItem.ToString() == "-")
            {
                MessageBox.Show("No ha seleccionado una tabla.");
            }
            else
            {

                DataTable data = (DataTable)(dgvContenidoExcel.DataSource);

                bool resultado = new FuncionalidadesExcel().CargarDatos(data, cbTabla.SelectedItem.ToString());

                if (resultado)
                {
                    MessageBox.Show("El archivo se importó correctamente.");

                    dgvContenidoExcel.DataSource = null;
                    txtArchivo.Text = "";
                    cbTabla.SelectedItem = "-";
                }
                else
                {
                    MessageBox.Show("Se produjo un error y no se importó el archivo.");
                }
            }
        }
    }
}
