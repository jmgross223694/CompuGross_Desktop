using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;

namespace Negocio
{
    public class ServicioDB
    {
        public List<Servicio> Listar()
        {
            List<Servicio> lista = new List<Servicio>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                string consulta = "select * from ExportListarOrdenTrabajo ORDER BY FechaRecepcion desc, ID desc";

                datos.SetearConsulta(consulta);
                datos.EjecutarLectura();

                while (datos.Lector.Read())
                {
                    Servicio aux = new Servicio();
                    aux.ID = (long)datos.Lector["ID"];
                    aux.Cliente = datos.Lector["Cliente"].ToString();
                    DateTime aux1 = Convert.ToDateTime(datos.Lector["FechaRecepcion"]);
                    aux.FechaRecepcion = aux1.ToShortDateString();
                    DateTime aux2 = Convert.ToDateTime(datos.Lector["FechaDevolucion"]);
                    aux.FechaDevolucion = aux2.ToShortDateString();
                    if (aux2.Day.ToString() + "/" + aux2.Month.ToString() + "/" + aux2.Year.ToString() == "1/1/1900")
                    {
                        aux.FechaDevolucion = "-";
                    }
                    aux.TipoEquipo = datos.Lector["TipoEquipo"].ToString();
                    aux.TipoServicio = datos.Lector["TipoServicio"].ToString();
                    aux.CostoTotal = Convert.ToInt32(datos.Lector["CostoTotal"]);
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

        public void AgregarServicio(Servicio servicio)
        {
            string insertOrden = "EXEC SP_INSERT_ORDEN_TRABAJO '" + servicio.Cliente + "', '" + 
                                servicio.FechaRecepcion + "', '" + servicio.TipoEquipo + "', '" + 
                                servicio.RAM + "', '" + servicio.PlacaMadre + "', '" + 
                                servicio.MarcaModelo + "', '" + servicio.Microprocesador + "', '" + 
                                servicio.Almacenamiento + "', '" + servicio.CdDvd + "', '" + 
                                servicio.Fuente + "', '" + servicio.Adicionales + "', '" +
                                servicio.NumSerie + "', '" + servicio.TipoServicio + "', '" + 
                                servicio.Descripcion + "', " + servicio.CostoRepuestos + ", " +
                                servicio.CostoTerceros + ", " + servicio.CostoCG + ", '" + servicio.FechaDevolucion + "'";

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

        public void EliminarServicio(long ID)
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

        public Servicio CargarDatosOrden(long ID)
        {
            Servicio aux = new Servicio();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                string consulta = "select * from ExportModificarOrdenTrabajo where ID = " + ID;

                datos.SetearConsulta(consulta);
                datos.EjecutarLectura();

                if (datos.Lector.Read())
                {
                    aux.ID = (long)datos.Lector["ID"];
                    aux.Cliente = datos.Lector["Cliente"].ToString();
                    DateTime aux1 = Convert.ToDateTime(datos.Lector["FechaRecepcion"]);
                    aux.FechaRecepcion = aux1.ToShortDateString();
                    DateTime aux2 = Convert.ToDateTime(datos.Lector["FechaDevolucion"]);
                    aux.FechaDevolucion = aux2.ToShortDateString();
                    if (aux2.Day.ToString() + "/" + aux2.Month.ToString() + "/" + aux2.Year.ToString() == "1/1/1900")
                    {
                        aux.FechaDevolucion = "-";
                    }
                    aux.TipoEquipo = datos.Lector["TipoEquipo"].ToString();
                    aux.TipoServicio = datos.Lector["TipoServicio"].ToString();
                    aux.CostoTotal = Convert.ToInt32(datos.Lector["CostoTotal"]);
                    aux.IdCliente = (long)datos.Lector["IdCliente"];
                    aux.RAM = datos.Lector["RAM"].ToString();
                    aux.PlacaMadre = datos.Lector["PlacaMadre"].ToString();
                    aux.MarcaModelo = datos.Lector["MarcaModelo"].ToString();
                    aux.Microprocesador = datos.Lector["Microprocesador"].ToString();
                    aux.Almacenamiento = datos.Lector["Almacenamiento"].ToString();
                    aux.CdDvd = datos.Lector["CdDvd"].ToString();
                    aux.Fuente = datos.Lector["Fuente"].ToString();
                    aux.Adicionales = datos.Lector["Adicionales"].ToString();
                    aux.NumSerie = datos.Lector["NumSerie"].ToString();
                    aux.Descripcion = datos.Lector["Descripcion"].ToString();
                    aux.CostoRepuestos = Convert.ToInt32(datos.Lector["CostoRepuestos"]);
                    aux.CostoTerceros = Convert.ToInt32(datos.Lector["CostoTerceros"]);
                    aux.CostoCG = Convert.ToInt32(datos.Lector["CostoCG"]);
                    aux.Estado = Convert.ToInt32(datos.Lector["Estado"]);
                }

                return aux;
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

        public void ModificarServicio(Servicio servicio)
        {
            string update = "exec SP_UPDATE_ORDEN_TRABAJO " +
                                servicio.ID + ", '" +
                                servicio.Cliente + "', '" +
                                servicio.FechaRecepcion + "', '" +
                                servicio.TipoEquipo + "', '" +
                                servicio.RAM + "', '" +
                                servicio.PlacaMadre + "', '" +
                                servicio.MarcaModelo + "', '" +
                                servicio.Microprocesador + "', '" +
                                servicio.Almacenamiento + "', '" +
                                servicio.CdDvd + "', '" +
                                servicio.Fuente + "', '" +
                                servicio.Adicionales + "', '" +
                                servicio.NumSerie + "', '" +
                                servicio.TipoServicio + "', '" +
                                servicio.Descripcion + "', " +
                                servicio.CostoRepuestos + ", " +
                                servicio.CostoTerceros + ", " +
                                servicio.CostoCG + ", '" +
                                servicio.FechaDevolucion + "'";

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

        public long ObtenerIdUltimoServicio()
        {
            string select = "select top 1 ID from OrdenesTrabajo where Estado = 1 order by ID desc";
            long id = 0;

            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta(select);
                datos.EjecutarLectura();

                if (datos.Lector.Read())
                {
                    id = (long)datos.Lector["ID"];
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
            return id;
        }
    }
}
