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
            //this.Width = 844;
            //this.Height = 594;
            cbAnios.Focus();
        }

        private void Ingresos_Load(object sender, EventArgs e)
        {
            /* IdTipo:
             * 1 = Armado de gabinete
             * 2 = Cámaras de seguridad
             * 3 = Servicio técnico
             */

            panelGananciasPorMes.Visible = false;

            cargarDdlAños();

            cbAnios.SelectedItem = "Año";

            lblGananciaTotal2.Text = "$ ";
            lblMensualMonto.Text = "$ ";
            lblAnualMonto.Text = "$ ";

            string selectGanancias = "select * from ExportIngresos";
            
            AccesoDatos datos = new AccesoDatos();

            int gananciaArmadoGabinete = 0, gananciaCamarasSeguridad = 0, gananciaServicioTecnico = 0, cant1 = 0, cant2 = 0, cant3 = 0;
            double totalDiasServicio = 0;

            try
            {
                datos.SetearConsulta(selectGanancias);
                datos.EjecutarLectura();

                while (datos.Lector.Read())
                {
                    string ID = Convert.ToString(datos.Lector["ID"]);

                    if (ID == "ArmadoGabinete")
                    {
                        cant1 = Convert.ToInt32(datos.Lector["Cant"]);
                        gananciaArmadoGabinete = Convert.ToInt32(datos.Lector["Ganancia"]);
                    }
                    else if (ID == "CamarasSeguridad")
                    {
                        cant2 = Convert.ToInt32(datos.Lector["Cant"]);
                        gananciaCamarasSeguridad = Convert.ToInt32(datos.Lector["Ganancia"]);
                    }
                    else if (ID == "ServicioTecnico")
                    {
                        cant3 = Convert.ToInt32(datos.Lector["Cant"]);
                        gananciaServicioTecnico = Convert.ToInt32(datos.Lector["Ganancia"]);
                    }
                    else
                    {
                        if (ID == "TotalDiasServicio")
                        {
                            totalDiasServicio = Convert.ToDouble(datos.Lector["Cant"]);
                        }
                    }
                }

                double gananciaTotal = gananciaArmadoGabinete + gananciaCamarasSeguridad + gananciaServicioTecnico;
                int cantTotal = cant1 + cant2 + cant3;

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

        private void CargarGananciasPorMes(string anioElegido)
        {
            string selectCantidadPorMes = "select (select isnull(count(*), 0) " +
                "from OrdenesTrabajo " +
                "where Estado = 1 and Month(FechaDevolucion) = 1 and year(FechaDevolucion) = " + 
                anioElegido + ") '1', (select isnull(count(*), 0) from OrdenesTrabajo " +
                "where Estado = 1 and Month(FechaDevolucion) = 2 and year(FechaDevolucion) = " + 
                anioElegido + ") '2', (select isnull(count(*), 0) from OrdenesTrabajo " +
                "where Estado = 1 and Month(FechaDevolucion) = 3 and year(FechaDevolucion) = " + 
                anioElegido + ") '3', (select isnull(count(*), 0) from OrdenesTrabajo " +
                "where Estado = 1 and Month(FechaDevolucion) = 4 and year(FechaDevolucion) = " + 
                anioElegido + ") '4', (select isnull(count(*), 0) from OrdenesTrabajo " +
                "where Estado = 1 and Month(FechaDevolucion) = 5 and year(FechaDevolucion) = " + 
                anioElegido + ") '5', (select isnull(count(*), 0) from OrdenesTrabajo " +
                "where Estado = 1 and Month(FechaDevolucion) = 6 and year(FechaDevolucion) = " + 
                anioElegido + ") '6', (select isnull(count(*), 0) from OrdenesTrabajo " +
                "where Estado = 1 and Month(FechaDevolucion) = 7 and year(FechaDevolucion) = " + 
                anioElegido + ") '7', (select isnull(count(*), 0) from OrdenesTrabajo " +
                "where Estado = 1 and Month(FechaDevolucion) = 8 and year(FechaDevolucion) = " + 
                anioElegido + ") '8', (select isnull(count(*), 0) from OrdenesTrabajo " +
                "where Estado = 1 and Month(FechaDevolucion) = 9 and year(FechaDevolucion) = " + 
                anioElegido + ") '9', (select isnull(count(*), 0) from OrdenesTrabajo " +
                "where Estado = 1 and Month(FechaDevolucion) = 10 and year(FechaDevolucion) = " + 
                anioElegido + ") '10', (select isnull(count(*), 0) from OrdenesTrabajo " +
                "where Estado = 1 and Month(FechaDevolucion) = 11 and year(FechaDevolucion) = " + 
                anioElegido + ") '11', (select isnull(count(*), 0) from OrdenesTrabajo " +
                "where Estado = 1 and Month(FechaDevolucion) = 12 and year(FechaDevolucion) = " + 
                anioElegido + ") '12'";

            string selectGananciasPorMes = "select (select convert(int,isnull(sum(Ganancia),0)) " +
                "from OrdenesTrabajo " +
                "where Estado = 1 and Month(FechaDevolucion) = 1 and year(FechaDevolucion) = " + 
                anioElegido + ") '1', (select convert(int,isnull(sum(Ganancia),0)) from OrdenesTrabajo " +
                "where Estado = 1 and Month(FechaDevolucion) = 2 and year(FechaDevolucion) = " +
                anioElegido + ") '2', (select convert(int,isnull(sum(Ganancia),0)) from OrdenesTrabajo " +
                "where Estado = 1 and Month(FechaDevolucion) = 3 and year(FechaDevolucion) = " +
                anioElegido + ") '3', (select convert(int,isnull(sum(Ganancia),0)) from OrdenesTrabajo " +
                "where Estado = 1 and Month(FechaDevolucion) = 4 and year(FechaDevolucion) = " +
                anioElegido + ") '4', (select convert(int,isnull(sum(Ganancia),0)) from OrdenesTrabajo " +
                "where Estado = 1 and Month(FechaDevolucion) = 5 and year(FechaDevolucion) = " +
                anioElegido + ") '5', (select convert(int,isnull(sum(Ganancia),0)) from OrdenesTrabajo " +
                "where Estado = 1 and Month(FechaDevolucion) = 6 and year(FechaDevolucion) = " +
                anioElegido + ") '6', (select convert(int,isnull(sum(Ganancia),0)) from OrdenesTrabajo " +
                "where Estado = 1 and Month(FechaDevolucion) = 7 and year(FechaDevolucion) = " +
                anioElegido + ") '7', (select convert(int,isnull(sum(Ganancia),0)) from OrdenesTrabajo " +
                "where Estado = 1 and Month(FechaDevolucion) = 8 and year(FechaDevolucion) = " +
                anioElegido + ") '8', (select convert(int,isnull(sum(Ganancia),0)) from OrdenesTrabajo " +
                "where Estado = 1 and Month(FechaDevolucion) = 9 and year(FechaDevolucion) = " +
                anioElegido + ") '9', (select convert(int,isnull(sum(Ganancia),0)) from OrdenesTrabajo " +
                "where Estado = 1 and Month(FechaDevolucion) = 10 and year(FechaDevolucion) = " +
                anioElegido + ") '10', (select convert(int,isnull(sum(Ganancia),0)) from OrdenesTrabajo " +
                "where Estado = 1 and Month(FechaDevolucion) = 11 and year(FechaDevolucion) = " +
                anioElegido + ") '11', (select convert(int,isnull(sum(Ganancia),0)) from OrdenesTrabajo " +
                "where Estado = 1 and Month(FechaDevolucion) = 12 and year(FechaDevolucion) = " +
                anioElegido + ") '12'";

            AccesoDatos datosCantidad = new AccesoDatos();
            AccesoDatos datosGanancia = new AccesoDatos();

            try
            {
                datosGanancia.SetearConsulta(selectGananciasPorMes);
                datosGanancia.EjecutarLectura();

                if (datosGanancia.Lector.Read())
                {
                    lblGananciaMes1.Text = "$" + datosGanancia.Lector["1"].ToString();
                    lblGananciaMes2.Text = "$" + datosGanancia.Lector["2"].ToString();
                    lblGananciaMes3.Text = "$" + datosGanancia.Lector["3"].ToString();
                    lblGananciaMes4.Text = "$" + datosGanancia.Lector["4"].ToString();
                    lblGananciaMes5.Text = "$" + datosGanancia.Lector["5"].ToString();
                    lblGananciaMes6.Text = "$" + datosGanancia.Lector["6"].ToString();
                    lblGananciaMes7.Text = "$" + datosGanancia.Lector["7"].ToString();
                    lblGananciaMes8.Text = "$" + datosGanancia.Lector["8"].ToString();
                    lblGananciaMes9.Text = "$" + datosGanancia.Lector["9"].ToString();
                    lblGananciaMes10.Text = "$" + datosGanancia.Lector["10"].ToString();
                    lblGananciaMes11.Text = "$" + datosGanancia.Lector["11"].ToString();
                    lblGananciaMes12.Text = "$" + datosGanancia.Lector["12"].ToString();
                }

                datosGanancia.CerrarConexion();

                datosCantidad.SetearConsulta(selectCantidadPorMes);
                datosCantidad.EjecutarLectura();

                if (datosCantidad.Lector.Read())
                {
                    lblGananciaMes1.Text = lblGananciaMes1.Text + " (" + datosCantidad.Lector["1"].ToString() + ")";
                    lblGananciaMes2.Text = lblGananciaMes2.Text + " (" + datosCantidad.Lector["2"].ToString() + ")";
                    lblGananciaMes3.Text = lblGananciaMes3.Text + " (" + datosCantidad.Lector["3"].ToString() + ")";
                    lblGananciaMes4.Text = lblGananciaMes4.Text + " (" + datosCantidad.Lector["4"].ToString() + ")";
                    lblGananciaMes5.Text = lblGananciaMes5.Text + " (" + datosCantidad.Lector["5"].ToString() + ")";
                    lblGananciaMes6.Text = lblGananciaMes6.Text + " (" + datosCantidad.Lector["6"].ToString() + ")";
                    lblGananciaMes7.Text = lblGananciaMes7.Text + " (" + datosCantidad.Lector["7"].ToString() + ")";
                    lblGananciaMes8.Text = lblGananciaMes8.Text + " (" + datosCantidad.Lector["8"].ToString() + ")";
                    lblGananciaMes9.Text = lblGananciaMes9.Text + " (" + datosCantidad.Lector["9"].ToString() + ")";
                    lblGananciaMes10.Text = lblGananciaMes10.Text + " (" + datosCantidad.Lector["10"].ToString() + ")";
                    lblGananciaMes11.Text = lblGananciaMes11.Text + " (" + datosCantidad.Lector["11"].ToString() + ")";
                    lblGananciaMes12.Text = lblGananciaMes12.Text + " (" + datosCantidad.Lector["12"].ToString() + ")";
                }

                datosCantidad.CerrarConexion();
            }
            catch
            {
                MessageBox.Show("Error en la base de datos.", "Atención !!",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                panelGananciasPorMes.Visible = false;
            }
        }

        private void cbAnios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbAnios.SelectedItem.ToString() == "Año") 
            {
                lblAnualMonto.Text = "$ ";
                lblMensualMonto.Text = "$ ";
                lblCantidad2.Text = "-";
                panelGananciasPorMes.Visible = false;
            }
            else
            {
                string anioElegido = cbAnios.SelectedItem.ToString();

                string selectCantidadServiciosPorAnio = "select isnull(count(*), 0) as Cantidad " +
                                                "from OrdenesTrabajo where Estado = 1 and " +
                                                "year(FechaDevolucion) = " + anioElegido;

                string selectGananciasPorAnio = "select isnull(count(*), 0) as Cantidad, " +
                                                "convert(int,sum(Ganancia)) as 'GananciaAnual' " +
                                                "from OrdenesTrabajo where Estado = 1 and " +
                                                "year(FechaDevolucion) = " + anioElegido;

                panelGananciasPorMes.Visible = true;
                CargarGananciasPorMes(anioElegido);

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
