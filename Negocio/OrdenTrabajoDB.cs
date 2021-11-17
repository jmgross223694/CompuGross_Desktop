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
        private AccesoDatos datos;
        public List<OrdenTrabajo> Listar()
        {
            List<OrdenTrabajo> lista = new List<OrdenTrabajo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                string consulta = "select * from ExportOrdenesTrabajo ORDER BY ID ASC";

                datos.SetearConsulta(consulta);
                datos.EjecutarLectura();

                while (datos.Lector.Read())
                {
                    OrdenTrabajo aux = new OrdenTrabajo();
                    aux.ID = (long)datos.Lector["ID"];
                    aux.Cliente = datos.Lector["Cliente"].ToString();
                    aux.FechaRecepcion = datos.Lector["FechaRecepcion"].ToString();
                    aux.TipoEquipo = datos.Lector["TipoEquipo"].ToString();
                    aux.DatosEquipo = datos.Lector["DatosEquipo"].ToString();
                    aux.TipoServicio = datos.Lector["TipoServicio"].ToString();
                    aux.Descripcion = datos.Lector["Descripcion"].ToString();
                    aux.CostoRepuestos = datos.Lector["CostoRepuestos"].ToString();
                    aux.CostoTerceros = datos.Lector["CostoTerceros"].ToString();
                    aux.CostoCG = datos.Lector["CostoCG"].ToString();
                    aux.CostoTotal = datos.Lector["CostoTotal"].ToString();
                    aux.FechaDevolucion = datos.Lector["FechaDevolucion"].ToString();
                    aux.Ganancia = datos.Lector["Ganancia"].ToString();
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

        public void EliminarOrden(long ID)
        {
            datos = new AccesoDatos();

            try
            {
                string delete = "delete from OrdenesTrabajo where ID = " + ID;

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
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string update = "exec SP_UPDATE_ORDEN_TRABAJO " +
                                ordenTrabajo.ID + ", " +
                                ordenTrabajo.Cliente + ", '" +
                                ordenTrabajo.FechaRecepcion + "', " +
                                ordenTrabajo.TipoEquipo + ", '" +
                                ordenTrabajo.DatosEquipo + "', " +
                                ordenTrabajo.TipoServicio + ", '" +
                                ordenTrabajo.Descripcion + "', " +
                                ordenTrabajo.CostoRepuestos + ", " +
                                ordenTrabajo.CostoTerceros + ", " +
                                ordenTrabajo.CostoCG + ", " +
                                ordenTrabajo.CostoTotal + ", '" +
                                ordenTrabajo.FechaDevolucion + "', " +
                                ordenTrabajo.Ganancia + ", " +
                                ordenTrabajo.Estado;

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
