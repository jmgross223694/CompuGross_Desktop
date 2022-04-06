using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class PrecioDB
    {
        private AccesoDatos datos = new AccesoDatos();

        public List<Precio> Listar()
        {
            List<Precio> lista = new List<Precio>();

            try
            {
                string consulta = "select * from ListaPrecios ORDER BY Descripcion asc";

                this.datos.SetearConsulta(consulta);
                this.datos.EjecutarLectura();

                while (this.datos.Lector.Read())
                {
                    Precio aux = new Precio
                    {
                        ID = Convert.ToInt64(datos.Lector["ID"]),
                        Descripcion = datos.Lector["Descripcion"].ToString(),
                        PrecioDolares = Convert.ToDecimal(datos.Lector["Precio"])
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

        public void Modificar(Precio p)
        {
            try
            {
                string consulta = "update ListaPrecios set Descripcion = '" + p.Descripcion + "', Precio = " + p.PrecioDolares + " where ID = " + p.ID;

                datos.IUD(consulta);
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

        public void Agregar(Precio p)
        {
            try
            {
                string consulta = "insert into ListaPrecios(Descripcion, Precio) values('" + p.Descripcion + "', " + p.PrecioDolares + ")";

                datos.IUD(consulta);
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

        public void Eliminar(Precio p)
        {
            try
            {
                string consulta = "delete from ListaPrecios where ID = " + p.ID;

                datos.IUD(consulta);
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
