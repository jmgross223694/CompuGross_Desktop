using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class CompraProveedorDB
    {
        private AccesoDatos datos = new AccesoDatos();
        private ProveedorDB proveedorDB = new ProveedorDB();
        private ClienteDB clienteDB = new ClienteDB();

        public List<CompraProveedor> Listar()
        {
            List<CompraProveedor> listaComprasProveedores = new List<CompraProveedor>();

            try
            {
                string consulta = "select * from ComprasProveedores ORDER BY FechaCompra desc";

                this.datos.SetearConsulta(consulta);
                this.datos.EjecutarLectura();

                while (this.datos.Lector.Read())
                {
                    CompraProveedor compra = new CompraProveedor
                    {
                        ID = Convert.ToInt64(datos.Lector["ID"]),
                        Proveedor = proveedorDB.BuscarPorID(Convert.ToInt32(datos.Lector["IdProveedor"])),
                        Cliente = clienteDB.CargarClientePorID(Convert.ToInt64(datos.Lector["IdClienteAsignado"])),
                        Articulo = new Articulo
                        {
                            Codigo = datos.Lector["CodigoArticuloProveedor"].ToString(),
                            Descripcion = datos.Lector["DescripcionArticulo"].ToString(),
                            NumeroSerie = datos.Lector["NumeroSerieArticulo"].ToString(),
                            CodigoVerificacion = datos.Lector["CodigoVerificacionArticulo"].ToString()
                        },
                        MontoAbonado = Convert.ToDecimal(datos.Lector["MontoAbonado"]),
                        FechaCompra = Convert.ToDateTime(datos.Lector["FechaCompra"]),
                        Devolucion = Convert.ToBoolean(datos.Lector["Devolucion"]),
                        Estado = Convert.ToBoolean(datos.Lector["Estado"])
                    };
                    if (compra.Articulo.CodigoVerificacion == "") { compra.Articulo.CodigoVerificacion = "-"; }
                    listaComprasProveedores.Add(compra);
                }

                return listaComprasProveedores;
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

        public CompraProveedor BuscarPorID(CompraProveedor compra)
        {
            try
            {
                string consulta = "select * from ComprasProveedores Where ID = " + compra.ID;

                this.datos.SetearConsulta(consulta);
                this.datos.EjecutarLectura();

                if (this.datos.Lector.Read())
                {
                    compra.ID = Convert.ToInt64(datos.Lector["ID"]);
                    compra.Proveedor = proveedorDB.BuscarPorID(Convert.ToInt32(datos.Lector["IdProveedor"]));
                    compra.Cliente = clienteDB.CargarClientePorID(Convert.ToInt64(datos.Lector["IdClienteAsignado"]));
                    compra.Articulo = new Articulo
                    {
                        Codigo = datos.Lector["CodigoArticuloProveedor"].ToString(),
                        Descripcion = datos.Lector["DescripcionArticulo"].ToString(),
                        NumeroSerie = datos.Lector["NumeroSerieArticulo"].ToString(),
                        CodigoVerificacion = datos.Lector["CodigoVerificacionArticulo"].ToString()
                    };
                    compra.MontoAbonado = Convert.ToDecimal(datos.Lector["MontoAbonado"]);
                    compra.FechaCompra = Convert.ToDateTime(datos.Lector["FechaCompra"]);
                    compra.Devolucion = Convert.ToBoolean(datos.Lector["Devolucion"]);
                    compra.Estado = Convert.ToBoolean(datos.Lector["Estado"]);
                }
                return compra;
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

        public bool BajaLogica(CompraProveedor compra)
        {
            bool resultado = false;
            try
            {
                string consulta = "update ComprasProveedores set Estado = 0 where ID = " + compra.ID;

                this.datos.SetearConsulta(consulta);
                this.datos.EjecutarLectura();

                resultado = true;
            }
            catch
            {
                resultado = false;
            }
            finally
            {
                datos.CerrarConexion();
            }

            return resultado;
        }

        public bool Agregar(CompraProveedor compra)
        {
            bool resultado = false;
            try
            {
                string consulta = "insert into ComprasProveedores(IdProveedor,CodigoArticuloProveedor," +
                                                                 "DescripcionArticulo,NumeroSerieArticulo," +
                                                                 "CodigoVerificacionArticulo,MontoAbonado," +
                                                                 "FechaCompra,IdClienteAsignado,Devolucion," +
                                                                 "Estado) " +
                                  "values(" + compra.Proveedor.ID + ", '" + compra.Articulo.Codigo + "', " +
                                          "'" + compra.Articulo.Descripcion + "', '" + compra.Articulo.NumeroSerie + "', " +
                                          "'" + compra.Articulo.CodigoVerificacion + "', " + compra.MontoAbonado + ", " +
                                          "'" + compra.FechaCompra + "', " + compra.Cliente.Id + ", " + compra.Devolucion + ", " +
                                          compra.Estado + ")";

                this.datos.SetearConsulta(consulta);
                this.datos.EjecutarLectura();

                resultado = true;
            }
            catch
            {
                resultado = false;
            }
            finally
            {
                datos.CerrarConexion();
            }

            return resultado;
        }

        public bool Modificar(CompraProveedor compra)
        {
            bool resultado = false;
            try
            {
                int devolucion = 1, estado = 1;
                if (!compra.Devolucion) { devolucion = 0; }
                if (!compra.Estado) { estado = 0; }
                string consulta = "update ComprasProveedores set " +
                                  "IdProveedor = " + compra.Proveedor.ID + ", " +
                                  "CodigoArticuloProveedor = '" + compra.Articulo.Codigo + "', " +
                                  "DescripcionArticulo = '" + compra.Articulo.Descripcion + "', " +
                                  "NumeroSerieArticulo = '" + compra.Articulo.NumeroSerie + "', " +
                                  "CodigoVerificacionArticulo = '" + compra.Articulo.CodigoVerificacion + "', " +
                                  "IdClienteAsignado = " + compra.Cliente.Id + ", " +
                                  "MontoAbonado = " + compra.MontoAbonado + ", " +
                                  "FechaCompra = '" + compra.FechaCompra.Year + "-" + compra.FechaCompra.Month + "-" + compra.FechaCompra.Day + "', " +
                                  "Devolucion = " + devolucion + ", " +
                                  "Estado = " + estado + " " +
                                  "where ID = " + compra.ID;

                this.datos.SetearConsulta(consulta);
                this.datos.EjecutarLectura();

                resultado = true;
            }
            catch
            {
                resultado = false;
            }
            finally
            {
                datos.CerrarConexion();
            }

            return resultado;
        }
    }
}
