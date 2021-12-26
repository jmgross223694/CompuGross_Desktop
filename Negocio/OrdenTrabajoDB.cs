using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;

namespace Negocio
{
    public class OrdenTrabajoDB
    {
        public List<OrdenTrabajo> Listar()
        {
            List<OrdenTrabajo> lista = new List<OrdenTrabajo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                string consulta = "select * from ExportOrdenesTrabajo ORDER BY FechaRecepcion desc";

                datos.SetearConsulta(consulta);
                datos.EjecutarLectura();

                while (datos.Lector.Read())
                {
                    OrdenTrabajo aux = new OrdenTrabajo();
                    aux.ID = (long)datos.Lector["ID"];
                    aux.Cliente = datos.Lector["Cliente"].ToString();
                    DateTime aux1 = Convert.ToDateTime(datos.Lector["FechaRecepcion"]);
                    aux.FechaRecepcion = aux1.ToShortDateString();
                    DateTime aux2 = Convert.ToDateTime(datos.Lector["FechaDevolucion"]);
                    aux.FechaDevolucion = aux2.ToShortDateString();
                    aux.TipoEquipo = datos.Lector["TipoEquipo"].ToString();
                    aux.RAM = datos.Lector["RAM"].ToString();
                    aux.PlacaMadre = datos.Lector["PlacaMadre"].ToString();
                    aux.MarcaModelo = datos.Lector["MarcaModelo"].ToString();
                    aux.Microprocesador = datos.Lector["Microprocesador"].ToString();
                    aux.Almacenamiento = datos.Lector["Almacenamiento"].ToString();
                    aux.CdDvd = datos.Lector["CdDvd"].ToString();
                    aux.Fuente = datos.Lector["Fuente"].ToString();
                    aux.Adicionales = datos.Lector["Adicionales"].ToString();
                    aux.NumSerie = datos.Lector["NumSerie"].ToString();
                    aux.TipoServicio = datos.Lector["TipoServicio"].ToString();
                    aux.Descripcion = datos.Lector["Descripcion"].ToString();
                    aux.CostoRepuestos = Convert.ToInt32(datos.Lector["CostoRepuestos"]);
                    aux.CostoTerceros = Convert.ToInt32(datos.Lector["CostoTerceros"]);
                    aux.CostoCG = Convert.ToInt32(datos.Lector["CostoCG"]);
                    aux.CostoTotal = Convert.ToInt32(datos.Lector["CostoTotal"]);
                    aux.Ganancia = Convert.ToInt32(datos.Lector["Ganancia"]);
                    aux.Estado = Convert.ToInt32(datos.Lector["Estado"]);

                    if (aux.Estado == 1) { lista.Add(aux); }
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

        public void AgregarOrden(OrdenTrabajo orden)
        {
            string insertOrden = "EXEC SP_INSERT_ORDEN_TRABAJO '" + orden.Cliente + "', '" + 
                                orden.FechaRecepcion + "', '" + orden.TipoEquipo + "', '" + 
                                orden.RAM + ", '" + orden.PlacaMadre + "', '" + 
                                orden.MarcaModelo + "', '" + orden.Microprocesador + "', '" + 
                                orden.Almacenamiento + "', '" + orden.CdDvd + "', '" + 
                                orden.Fuente + "', '" + orden.Adicionales + "', '" +
                                orden.NumSerie + "', '" + orden.TipoServicio + "', '" + 
                                orden.Descripcion + "', " + orden.CostoRepuestos + ", " + 
                                orden.CostoTerceros + ", " + orden.CostoCG + ", '" + orden.FechaDevolucion + "'";

            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta(insertOrden);
                datos.EjecutarLectura();
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

        public void EliminarOrden(long ID)
        {
            string delete = "delete from OrdenesTrabajo where ID = " + ID;

            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta(delete);
                datos.EjecutarLectura();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
                datos = null;
            }
        }

        public void ModificarOrden(OrdenTrabajo ordenTrabajo)
        {
            string update = "exec SP_UPDATE_ORDEN_TRABAJO " +
                                ordenTrabajo.ID + ", '" +
                                ordenTrabajo.Cliente + "', '" +
                                ordenTrabajo.FechaRecepcion + "', '" +
                                ordenTrabajo.TipoEquipo + "', '" +
                                ordenTrabajo.RAM + "', '" +
                                ordenTrabajo.PlacaMadre + "', '" +
                                ordenTrabajo.MarcaModelo + "', '" +
                                ordenTrabajo.Microprocesador + "', '" +
                                ordenTrabajo.Almacenamiento + "', '" +
                                ordenTrabajo.CdDvd + "', '" +
                                ordenTrabajo.Fuente + "', '" +
                                ordenTrabajo.Adicionales + "', '" +
                                ordenTrabajo.NumSerie + "', '" +
                                ordenTrabajo.TipoServicio + "', '" +
                                ordenTrabajo.Descripcion + "', " +
                                ordenTrabajo.CostoRepuestos + ", " +
                                ordenTrabajo.CostoTerceros + ", " +
                                ordenTrabajo.CostoCG + ", '" +
                                ordenTrabajo.FechaDevolucion + "'";

            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta(update);
                datos.EjecutarLectura();
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
