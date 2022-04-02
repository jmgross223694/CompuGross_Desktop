using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class ReportePorClienteDB
    {
        public List<ReportePorCliente> Listar()
        {
            List<ReportePorCliente> lista = new List<ReportePorCliente>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                string consulta = "SELECT * FROM ExportIngresosServiciosPorCliente ORDER BY TotalIngresos DESC";

                datos.SetearConsulta(consulta);
                datos.EjecutarLectura();

                while (datos.Lector.Read())
                {
                    ReportePorCliente aux = new ReportePorCliente
                    {
                        ID = (long)datos.Lector["ID"],
                        Nombres = Convert.ToString(datos.Lector["Nombres"]),
                        TotalServicios = Convert.ToString(Convert.ToInt32(datos.Lector["TotalServicios"])) +
                                        " ($ " + Convert.ToString(Convert.ToDecimal(datos.Lector["TotalIngresos"])) + ")",
                        ServicioTecnico = Convert.ToString(Convert.ToInt32(datos.Lector["ServicioTecnico"]))+
                                            " ($ "+Convert.ToString(Convert.ToDecimal(datos.Lector["IngresoServicioTecnico"]))+")",
                        Camaras = Convert.ToString(Convert.ToInt32(datos.Lector["Camaras"])) +
                                            " ($ " + Convert.ToString(Convert.ToDecimal(datos.Lector["IngresoCamaras"])) + ")",
                        ArmadoGabinete = Convert.ToString(Convert.ToInt32(datos.Lector["ArmadoGabinete"])) +
                                            " ($ " + Convert.ToString(Convert.ToDecimal(datos.Lector["IngresoArmadoGabinete"])) + ")"
                    };

                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }
    }
}
