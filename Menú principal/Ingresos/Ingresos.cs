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
    public partial class Ingresos : Form
    {
        public Ingresos()
        {
            InitializeComponent();
            cbAnios.Focus();
        }

        private void Ingresos_Load(object sender, EventArgs e)
        {
            /* IdTipo:
             * 1 = Armado de gabinete
             * 2 = Cámaras de seguridad
             * 3 = Servicio técnico
             */

            cargarDdlAños();

            cbAnios.SelectedItem = "Año";

            lblGananciaTotal2.Text = "$ ";
            lblMensualMonto.Text = "$ ";
            lblAnualMonto.Text = "$ ";

            string selectGanancias = "select * from ExportIngresos";
            
            AccesoDatos datos = new AccesoDatos();

            int gananciaArmadoGabinete, gananciaCamarasSeguridad, gananciaServicioTecnico, cant1, cant2, cant3 = 0;
            double totalDiasServicio = 0;

            try
            {
                datos.SetearConsulta(selectGanancias);
                datos.EjecutarLectura();

                if (datos.Lector.Read() == true)
                {
                    gananciaArmadoGabinete = Convert.ToInt32(datos.Lector["Ganancia1"]);
                    gananciaCamarasSeguridad = Convert.ToInt32(datos.Lector["Ganancia2"]);
                    gananciaServicioTecnico = Convert.ToInt32(datos.Lector["Ganancia3"]);

                    double gananciaTotal = gananciaArmadoGabinete + gananciaCamarasSeguridad + gananciaServicioTecnico;

                    cant1 = Convert.ToInt32(datos.Lector["Cant1"]);
                    cant2 = Convert.ToInt32(datos.Lector["Cant2"]);
                    cant3 = Convert.ToInt32(datos.Lector["Cant3"]);

                    int cantTotal = cant1 + cant2 + cant3;

                    totalDiasServicio = Convert.ToDouble(datos.Lector["TotalDiasServicio"]);

                    txtCantidad1.Text = Convert.ToString(cant1);
                    txtCantidad2.Text = Convert.ToString(cant2);
                    txtCantidad3.Text = Convert.ToString(cant3);

                    txtGanancia1.Text = "$ " + gananciaArmadoGabinete;
                    txtGanancia2.Text = "$ " + gananciaCamarasSeguridad;
                    txtGanancia3.Text = "$ " + gananciaServicioTecnico;

                    double promGananciaAnual = Convert.ToInt32(gananciaTotal) / (Convert.ToInt32(totalDiasServicio) / 365);

                    lblGananciaTotal2.Text = "$ " + gananciaTotal;

                    lblPromedioGananciaAnual2.Text = "$ " + Convert.ToString(promGananciaAnual);

                    lblPromedioGananciaMensual2.Text = "$ " + Convert.ToString(Convert.ToInt32(promGananciaAnual / 12));
                    
                    double promServiciosPorDia = cantTotal / totalDiasServicio;

                    lblServicioDias2.Text = Convert.ToString(Convert.ToInt32(1 / promServiciosPorDia));
                }
            }
            catch
            {
                MessageBox.Show("Error en la Base de datos.");
            }
            finally
            {
                datos.CerrarConexion();
            }
        }

        private void cargarDdlAños()
        {
            List<int> listaAños = new List<int>();

            int añoDesde = 2017;
            int añoHasta = DateTime.Today.Year;

            for (int i = añoDesde; i <= añoHasta; i++)
            {
                listaAños.Add(i);
            }

            int tamaño = añoHasta - añoDesde;

            for (int i = 0; i <= tamaño; i++)
            {
                cbAnios.Items.Add(listaAños[i].ToString());
            }
        }

        private void cbAnios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbAnios.SelectedItem.ToString() == "Año") 
            {
                lblAnualMonto.Text = "$ ";
                lblMensualMonto.Text = "$ ";
                lblCantidad2.Text = "-";
            }
            else
            {
                string anioElegido = cbAnios.SelectedItem.ToString();

                string selectCantidadServiciosPorAnio = "select isnull(count(*), 0) as Cantidad " +
                                                "from OrdenesTrabajo where year(FechaDevolucion) = " +
                                                anioElegido;

                string selectGananciasPorAnio = "select isnull(count(*), 0) as Cantidad, " +
                                                "convert(int,sum(Ganancia)) as 'GananciaAnual' " +
                                                "from OrdenesTrabajo where year(FechaDevolucion) = " +
                                                anioElegido;

                AccesoDatos datos = new AccesoDatos();
                AccesoDatos datos2 = new AccesoDatos();

                try
                {
                    datos2.SetearConsulta(selectCantidadServiciosPorAnio);
                    datos2.EjecutarLectura();

                    if (datos2.Lector.Read() == true)
                    {
                        int cantidad = Convert.ToInt32(datos2.Lector["Cantidad"]);

                        if (cantidad != 0)
                        {
                            try
                            {
                                datos.SetearConsulta(selectGananciasPorAnio);
                                datos.EjecutarLectura();

                                if (datos.Lector.Read() == true)
                                {
                                    int cantidad2 = Convert.ToInt32(datos.Lector["Cantidad"]);

                                    int gananciaAnual = Convert.ToInt32(datos.Lector["GananciaAnual"]);

                                    lblAnualMonto.Text = "$ " + Convert.ToString(gananciaAnual);

                                    int mesesTrabajados = 12;

                                    if (anioElegido == "2017") { mesesTrabajados = 6; }
                                    if (anioElegido == DateTime.Now.Year.ToString()) { mesesTrabajados = DateTime.Now.Month; }

                                    lblMensualMonto.Text = "$ " + Convert.ToString(Convert.ToInt32(gananciaAnual / mesesTrabajados));

                                    lblCantidad2.Text = cantidad2.ToString();
                                }
                            }
                            catch
                            {
                                MessageBox.Show("Error en la base de datos.", "Atención !!",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            finally
                            {
                                datos.CerrarConexion();
                            }
                        }
                        else
                        {
                            //MessageBox.Show("No se realizaron servicios en el año seleccionado.", "Atención !!",
                                //MessageBoxButtons.OK, MessageBoxIcon.Information);

                            lblAnualMonto.Text = "$ 0";
                            lblMensualMonto.Text = "$ 0";
                            lblCantidad2.Text = "0";
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Error en la base de datos.", "Atención !!", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                finally
                {
                    datos2.CerrarConexion();
                }
            }
        }

        /*private void button1_Click(object sender, EventArgs e)
        {
            //minimizar el formulario para que no aparezca en la captura
            //this.WindowState = FormWindowState.Minimized;
            //tiempo de espera con el formulario minimizado
            //el proceso de esperar y enviar Alt + ImprPant se realiza 2 veces seguidas, si se lanza 
            //sólo una vez no captura bien la ventana que está en primer plano
            //tiempo de espera con el formulario minimizado
            //System.Threading.Thread.Sleep(500);
            //enviar la pulsación equivalente a Alt + ImprPant
            SendKeys.SendWait("%{PRTSC}");
            //tiempo de espera con el formulario minimizado
            //System.Threading.Thread.Sleep(500);
            //enviar la pulsación equivalente a Alt + ImprPant
            //SendKeys.SendWait("%{PRTSC}");
            //capturar, guardar y mostrar la captura en el PictureBox
            //crear variable Bitmap
            Bitmap pantalla;
            //asignar al Bitmap el contenido del portapapeles
            pantalla = ((Bitmap)(Clipboard.GetDataObject().GetData("Bitmap")));
            //guardar el Bitmap como JPG
            pantalla.Save("Ventana.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
            //mostrar el Bitmap en el control PictureBox
            //ImgPantalla.Image = pantalla;
            //restaurar el formulario a su tamaño normal desde minimizado
            //this.WindowState = FormWindowState.Normal;
        }*/
    }
}
