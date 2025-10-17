using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class ProveedorDB
    {
        private AccesoDatos datos = new AccesoDatos();

        public List<Proveedor> Listar()
        {
            List<Proveedor> lista = new List<Proveedor>();

            try
            {
                string consulta = "select * from ExportProveedores ORDER BY Nombre asc";

                this.datos.SetearConsulta(consulta);
                this.datos.EjecutarLectura();

                while (this.datos.Lector.Read())
                {
                    Proveedor aux = new Proveedor
                    {
                        ID = Convert.ToInt32(datos.Lector["ID"]),
                        Nombre = datos.Lector["Nombre"].ToString(),
                        Mail = datos.Lector["Mail"].ToString(),
                        Telefono =  datos.Lector["Telefono"].ToString(),
                        IdTipo =  Convert.ToInt32(datos.Lector["IdTipo"]),
                        Tipo = datos.Lector["TipoProveedor"].ToString(),
                        SitioWeb = datos.Lector["SitioWeb"].ToString(),
                        Estado = Convert.ToInt32(datos.Lector["Estado"]),
                        FechaAlta = (Convert.ToDateTime(datos.Lector["FechaAlta"])).ToShortDateString()
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

        public Proveedor BuscarPorID(int ID)
        {
            Proveedor proveedor = new Proveedor();
            try
            {
                string consulta = "select * from ExportProveedores where ID = " + ID;

                this.datos.SetearConsulta(consulta);
                this.datos.EjecutarLectura();

                if (this.datos.Lector.Read())
                {
                    proveedor.ID = Convert.ToInt32(datos.Lector["ID"]);
                    proveedor.Nombre = datos.Lector["Nombre"].ToString();
                    proveedor.Mail = datos.Lector["Mail"].ToString();
                    proveedor.Telefono = datos.Lector["Telefono"].ToString();
                    proveedor.IdTipo = Convert.ToInt32(datos.Lector["IdTipo"]);
                    proveedor.Tipo = datos.Lector["TipoProveedor"].ToString();
                    proveedor.SitioWeb = datos.Lector["SitioWeb"].ToString();
                    proveedor.Estado = Convert.ToInt32(datos.Lector["Estado"]);
                    proveedor.FechaAlta = (Convert.ToDateTime(datos.Lector["FechaAlta"])).ToShortDateString();
                }

                return proveedor;
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

        public Proveedor BuscarPorTelefono(string telefono)
        {
            Proveedor proveedor = new Proveedor();
            try
            {
                string consulta = "select top 1 * from Proveedores where Replace(Telefono,'-','') = '" + telefono + "' order by Nombre asc";

                this.datos.SetearConsulta(consulta);
                this.datos.EjecutarLectura();

                if (this.datos.Lector.Read())
                {
                    proveedor.ID = Convert.ToInt32(datos.Lector["ID"]);
                    proveedor.Nombre = datos.Lector["Nombre"].ToString();
                }

                return proveedor;
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

        public int Eliminar(int id)
        {
            int resultado = 0;
            try
            {
                string consulta = "delete from Proveedores where ID = " + id;

                this.datos.SetearConsulta(consulta);
                this.datos.EjecutarLectura();

                resultado = 1;
            }
            catch
            {
                resultado = -1;
            }
            finally
            {
                datos.CerrarConexion();
            }

            return resultado;
        }

        public int Agregar(Proveedor p)
        {
            int resultado = 0;
            try
            {
                string consulta = "insert into Proveedores(Nombre, Mail, Telefono, IdTipo, SitioWeb) " +
                                  "values('" + p.Nombre + "', '" + p.Mail + "', '" + p.Telefono + "', " + 
                                  "(select ID from TiposProveedor where Descripcion = '" + p.Tipo + "'), " +
                                  "'" + p.SitioWeb + "')";

                this.datos.SetearConsulta(consulta);
                this.datos.EjecutarLectura();

                resultado = 1;
            }
            catch
            {
                resultado = -1;
            }
            finally
            {
                datos.CerrarConexion();
            }

            return resultado;
        }

        public int Modificar(Proveedor p)
        {
            int resultado = 0;
            try
            {
                string consulta = "update Proveedores set " +
                                  "Nombre = '" + p.Nombre + "', " +
                                  "Mail = '" + p.Mail + "', " +
                                  "Telefono = '" + p.Telefono + "', " +
                                  "IdTipo = (select ID from TiposProveedor where Descripcion = '" + p.Tipo + "'), " +
                                  "SitioWeb = '" + p.SitioWeb + "', " +
                                  "FechaAlta = '" + p.FechaAlta + "', " +
                                  "Estado = " + p.Estado + " " +
                                  "where ID = " + p.ID;

                this.datos.SetearConsulta(consulta);
                this.datos.EjecutarLectura();

                resultado = 1;
            }
            catch
            {
                resultado = -1;
            }
            finally
            {
                datos.CerrarConexion();
            }

            return resultado;
        }
    }
}
