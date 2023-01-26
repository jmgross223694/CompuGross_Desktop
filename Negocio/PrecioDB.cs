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
                        Codigo = datos.Lector["Codigo"].ToString(),
                        Descripcion = datos.Lector["Descripcion"].ToString(),
                        Aclaraciones = datos.Lector["Aclaraciones"].ToString(),
                        Dolares = Convert.ToDecimal(Convert.ToDouble(Math.Truncate((decimal)datos.Lector["Precio_Dolares"] * 100) / 100)),
                        Estado = Convert.ToBoolean(datos.Lector["Estado"])
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
                string consulta = "update ListaPrecios set Codigo = '" + p.Codigo + "', " +
                                                      "Descripcion = '" + p.Descripcion + "', " +
                                                      "Aclaraciones = '" + p.Aclaraciones + "', " +
                                                      "Precio_Dolares = " + p.Dolares + " where ID = " + p.ID;

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
                string consulta = "insert into ListaPrecios(Codigo, Descripcion, Aclaraciones, Precio_Dolares) " +
                                  "values('" + p.Codigo + "', '" + p.Descripcion + "', '" + p.Aclaraciones + "', " + p.Dolares + ")";

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
