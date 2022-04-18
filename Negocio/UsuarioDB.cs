using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class UsuarioDB
    {
        public List<Usuario> Listar()
        {
            List<Usuario> lista = new List<Usuario>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                string consulta = "select * from ExportUsuarios order by Nombres asc";

                datos.SetearConsulta(consulta);
                datos.EjecutarLectura();

                while (datos.Lector.Read())
                {
                    Usuario aux = new Usuario
                    {
                        Id = (int)datos.Lector["ID"],
                        Tipo = Convert.ToString(datos.Lector["Tipo"]),
                        Nombres = Convert.ToString(datos.Lector["Nombres"]),
                        Apellidos = Convert.ToString(datos.Lector["Apellidos"]),
                        Mail = Convert.ToString(datos.Lector["Mail"]),
                        Dni = Convert.ToString(datos.Lector["DNI"])
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

        public int AgregarUsuario(Usuario usuario)
        {
            string insert = "insert into Usuarios(IdTipo, Nombre, Apellido, Mail, Username, Clave) " +
                            "values((select TU.ID from TiposUsuario TU where TU.Tipo = '" + usuario.Tipo + "'), " +
                            "'" + usuario.Nombres + "', '" + usuario.Apellidos + "', '" + usuario.Mail + "', '" + 
                            usuario.Dni + "', pwdencrypt('" + usuario.Clave + "'))";

            AccesoDatos datos = new AccesoDatos();

            int usuarioAgregado = 0;

            try
            {
                datos.SetearConsulta(insert);
                datos.EjecutarLectura();

                usuarioAgregado = 1;
            }
            catch
            {
                usuarioAgregado = -1;
            }
            finally
            {
                datos.CerrarConexion();
            }

            return usuarioAgregado;
        }

        public int EliminarUsuario(int ID, string tipo)
        {
            AccesoDatos datos = new AccesoDatos();
            AccesoDatos datos2 = new AccesoDatos();

            int usuarioEliminado = 0;

            try
            {
                string contarUsuariosTipo = "select count(*) as Cantidad from Usuarios where IdTipo = " +
                                            "(select ID from TiposUsuario where Tipo = 'admin')";

                if (tipo == "user")
                {
                    contarUsuariosTipo = "select count(*) as Cantidad from Usuarios where IdTipo = " +
                                         "(select ID from TiposUsuario where Tipo = 'user')";
                }

                datos2.SetearConsulta(contarUsuariosTipo);
                datos2.EjecutarLectura();

                if (datos2.Lector.Read())
                {
                    int cantidad = 0;

                    cantidad = Convert.ToInt32(datos2.Lector["Cantidad"]);

                    if (cantidad > 1)
                    {
                        try
                        {
                            string delete = "delete from Usuarios where ID = " + ID;

                            datos.SetearConsulta(delete);
                            datos.EjecutarLectura();

                            usuarioEliminado = 1;
                        }
                        catch
                        {
                            usuarioEliminado = -1;
                        }
                        finally
                        {
                            datos.CerrarConexion();
                        }
                    }
                    else
                    {
                        usuarioEliminado = -1;
                    }
                }
            }
            catch
            {
                usuarioEliminado = -1;
            }
            finally
            {
                datos2.CerrarConexion();
            }

            return usuarioEliminado;
        }

        public int ModificarUsuario(Usuario usuario)
        {
            AccesoDatos datos = new AccesoDatos();

            int usuarioModificado = 0;

            try
            {
                string update = "update Usuarios set " +
                                "IdTipo = (select TU.ID from TiposUsuario TU where TU.Tipo = '" + usuario.Tipo + "'), " + 
                                "Nombre = '" + usuario.Nombres + "', " +
                                "Apellido = '" + usuario.Apellidos + "', " +
                                "Username = '" + usuario.Dni + "', " +
                                "Mail = '" + usuario.Mail + "' " +
                                "where ID = " + usuario.Id;

                datos.SetearConsulta(update);
                datos.EjecutarLectura();

                usuarioModificado = 1;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }

            return usuarioModificado;
        }
    }
}
