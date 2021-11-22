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

        public int AgregarCliente(Cliente cliente)
        {
            string insertCliente = "EXEC SP_NUEVO_CLIENTE '" + cliente.DNI + "', '" +
                                       cliente.Nombres + "', '" + cliente.Direccion + "', '" +
                                       cliente.Localidad + "', '" + cliente.Telefono + "', '" + cliente.Mail + "'";

            AccesoDatos datos = new AccesoDatos();

            int clienteAgregado = 0;

            try
            {
                datos.SetearConsulta(insertCliente);
                datos.EjecutarLectura();

                clienteAgregado = 1;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                datos.CerrarConexion();
            }

            return clienteAgregado;
        }

        public int EliminarCliente(string nombres, string telefono)
        {
            AccesoDatos datos = new AccesoDatos();
            
            int clienteEliminado = 0;

            try
            {
                string delete = "delete from Clientes where Nombres = '" + nombres + "' and Telefono = '" + telefono + "'";

                datos.SetearConsulta(delete);
                datos.EjecutarLectura();

                clienteEliminado = 1;
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

            return clienteEliminado;
        }

        public int ModificarCliente(Cliente cliente)
        {
            AccesoDatos datos = new AccesoDatos();
            
            int clienteModificado = 0;

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

                clienteModificado = 1;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }

            return clienteModificado;
        }
    }
}
