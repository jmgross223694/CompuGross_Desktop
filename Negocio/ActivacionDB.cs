using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ActivacionDB
    {
        private AccesoDatos accesoDatos = new AccesoDatos();
        
        public Activacion LeerDatos()
        {
            try
            {
                Activacion activacion = new Activacion();
                string consulta = "select top(1) * from Activado";
                accesoDatos.SetearConsulta(consulta);
                accesoDatos.EjecutarLectura();
                if (accesoDatos.Lector.Read())
                {
                    activacion.ID = Convert.ToInt64(accesoDatos.Lector["ID"]);
                    activacion.IdLicencia = accesoDatos.Lector["IdLicencia"].ToString();
                    activacion.Estado = Convert.ToBoolean(accesoDatos.Lector["Estado"]);
                    activacion.Validez = Convert.ToDateTime(accesoDatos.Lector["Validez"]);
                }
                if (activacion.ID > 0)
                {
                    return activacion;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                accesoDatos.CerrarConexion();
            }
        }
    }
}
