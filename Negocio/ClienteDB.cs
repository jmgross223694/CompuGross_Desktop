using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;

namespace Negocio
{
    public class ClienteDB
    {
        private AccesoDatos datos;
        public List<Cliente> Listar()
        {
            List<Cliente> lista = new List<Cliente>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                string consulta = "select C.ID as ID, C.Nombres as 'Cliente', isnull(C.DNI,'-') as DNI, " +
                    "isnull(C.Direccion, '-') as Direccion, isnull((select L.Descripcion from Localidades L " +
                    "where C.IdLocalidad = L.ID), '-') as Localidad, isnull(C.IdLocalidad, '-') as IdLocalidad, " +
                    "isnull(C.Telefono, '-') as Telefono, isnull(C.Mail, '-') as Mail from Clientes C ORDER BY Cliente ASC";

                datos.SetearConsulta(consulta);
                datos.EjecutarLectura();

                while (datos.Lector.Read())
                {
                    Cliente aux = new Cliente();
                    aux.Id = (long)datos.Lector["ID"];
                    aux.Nombres = Convert.ToString(datos.Lector["Cliente"]);
                    aux.DNI = Convert.ToString(datos.Lector["DNI"]);
                    aux.Direccion = Convert.ToString(datos.Lector["Direccion"]);
                    aux.IdLocalidad = (long)datos.Lector["IdLocalidad"];
                    aux.Localidad = Convert.ToString(datos.Lector["Localidad"]);
                    aux.Telefono = Convert.ToString(datos.Lector["Telefono"]);
                    aux.Mail = Convert.ToString(datos.Lector["Mail"]);

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

        public void EliminarCliente(string nombres, string telefono)
        {
            datos = new AccesoDatos();

            try
            {
                string delete = "delete from Clientes where Nombres = '" + nombres + "' and Telefono = '" + telefono + "'";

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

        public void ModificarCliente(Cliente cliente)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string update = "update Clientes set Nombres = '" + cliente.Nombres + 
                                "', DNI = '" + cliente.DNI + 
                                "', Direccion = '" + cliente.Direccion + "', " +
                                "IdLocalidad = (select ID from Localidades where Descripcion = '" + cliente.Localidad + 
                                "'), Telefono = '" + cliente.Telefono + 
                                "', Mail = '" + cliente.Mail + "' " + 
                                "WHERE ID = " + cliente.Id;

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
