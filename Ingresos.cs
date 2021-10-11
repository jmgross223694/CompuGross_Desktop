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

                    int cantTotal = Convert.ToInt32(cant1) + Convert.ToInt32(cant2) + Convert.ToInt32(cant3);

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
            }
            else
            {
                string anioElegido = cbAnios.SelectedItem.ToString();

                string selectGananciasPorAnio = "select convert(int,sum(Ganancia)) as 'GananciaAnual' " +
                                                "from OrdenesTrabajo where year(Devolucion) = " +
                                                anioElegido;

                AccesoDatos datos = new AccesoDatos();

                try
                {
                    datos.SetearConsulta(selectGananciasPorAnio);
                    datos.EjecutarLectura();

                    if (datos.Lector.Read() == true)
                    {
                        int gananciaAnual = Convert.ToInt32(datos.Lector["GananciaAnual"]);

                        lblAnualMonto.Text = "$ " + Convert.ToString(gananciaAnual);

                        int mesesTrabajados = 12;

                        if (anioElegido == "2017") { mesesTrabajados = 6; }
                        else if (anioElegido == DateTime.Now.Year.ToString()) { mesesTrabajados = DateTime.Now.Month; }

                        lblMensualMonto.Text = "$ " + Convert.ToString(Convert.ToInt32(gananciaAnual / mesesTrabajados));
                    }
                }
                catch
                {
                    MessageBox.Show("Error en la base de datos.");
                }
                finally
                {
                    datos.CerrarConexion();
                }
            }
        }
    }
}
