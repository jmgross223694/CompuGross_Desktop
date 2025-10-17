﻿using System;
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
                    "isnull(C.Telefono, '-') as Telefono, isnull(C.Mail, '-') as Mail, C.FechaAlta as FechaAlta from Clientes C " +
                    "where Estado = 1 ORDER BY Cliente ASC";

                datos.SetearConsulta(consulta);
                datos.EjecutarLectura();

                while (datos.Lector.Read())
                {
                    Cliente aux = new Cliente
                    {
                        Id = (long)datos.Lector["ID"],
                        Nombres = Convert.ToString(datos.Lector["Cliente"]),
                        DNI = Convert.ToString(datos.Lector["DNI"]),
                        Direccion = Convert.ToString(datos.Lector["Direccion"]),
                        IdLocalidad = (long)datos.Lector["IdLocalidad"],
                        Localidad = Convert.ToString(datos.Lector["Localidad"]),
                        Telefono = Convert.ToString(datos.Lector["Telefono"]),
                        Mail = Convert.ToString(datos.Lector["Mail"]),
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

        public int EliminarCliente(long ID)
        {
            AccesoDatos datos = new AccesoDatos();
            
            int clienteEliminado = 0;

            try
            {
                string delete = "delete from Clientes where ID = " + ID;

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

        public Cliente BuscarPorTelefono(string telefono)
        {
            Cliente c = new Cliente();

            AccesoDatos datos = new AccesoDatos();

            string select = "select top 1 * from Clientes where Replace(Telefono,'-','') = '" + telefono + "' order by Nombres asc";

            try
            {
                datos.SetearConsulta(select);
                datos.EjecutarLectura();

                if (datos.Lector.Read())
                {
                    c.Id = (long)datos.Lector["ID"];
                    c.Nombres = Convert.ToString(datos.Lector["Nombres"]);
                }
                return c;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }

        public Cliente CargarClientePorID(long id)
        {
            Cliente c = new Cliente();

            AccesoDatos datos = new AccesoDatos();

            string select = "select C.ID as ID, C.Nombres as 'Cliente', isnull(C.DNI,'-') as DNI, " +
                    "isnull(C.Direccion, '-') as Direccion, isnull((select L.Descripcion from Localidades L " +
                    "where C.IdLocalidad = L.ID), '-') as Localidad, isnull(C.IdLocalidad, '-') as IdLocalidad, " +
                    "isnull(C.Telefono, '-') as Telefono, isnull(C.Mail, '-') as Mail, C.FechaAlta as FechaAlta from Clientes C " +
                    "where Estado = 1 and ID = " + id;

            try
            {
                datos.SetearConsulta(select);
                datos.EjecutarLectura();

                if (datos.Lector.Read())
                {
                    c.Id = (long)datos.Lector["ID"];
                    c.Nombres = Convert.ToString(datos.Lector["Cliente"]);
                    c.DNI = Convert.ToString(datos.Lector["DNI"]);
                    c.Direccion = Convert.ToString(datos.Lector["Direccion"]);
                    c.IdLocalidad = (long)datos.Lector["IdLocalidad"];
                    c.Localidad = Convert.ToString(datos.Lector["Localidad"]);
                    c.Telefono = Convert.ToString(datos.Lector["Telefono"]);
                    c.Mail = Convert.ToString(datos.Lector["Mail"]);
                    c.FechaAlta = (Convert.ToDateTime(datos.Lector["FechaAlta"])).ToShortDateString();
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                datos.CerrarConexion();
            }

            return c;
        }
    }
}
