using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class FuncionalidadesExcel
    {
        public bool CargarDatos(DataTable tbData, string tablaSeleccionada)
        {
            bool resultado = true;

            //string strConLocal = "data source=.\\SQLEXPRESS; initial catalog=CompuGross; integrated security=sspi";
            string strConLan = "Server=AMD-FX-8320\\SQLEXPRESS,1433;DataBase=CompuGross;User Id=compugross;Password=compugross";

            using (SqlConnection con = new SqlConnection(strConLan))
            {
                con.Open();
                using (SqlBulkCopy s = new SqlBulkCopy(con))
                {
                    if (tablaSeleccionada == "ListaPrecios")
                    {
                        s.ColumnMappings.Add("Descripcion", "Descripcion");
                        s.ColumnMappings.Add("Precio", "Precio");
                    }

                    if (tablaSeleccionada == "OrdenesTrabajo")
                    {
                        s.ColumnMappings.Add("IdCliente", "IdCliente");
                        s.ColumnMappings.Add("FechaRecepcion", "FechaRecepcion");
                        s.ColumnMappings.Add("IdTipoEquipo", "IdTipoEquipo");
                        s.ColumnMappings.Add("RAM", "RAM");
                        s.ColumnMappings.Add("PlacaMadre", "PlacaMadre");
                        s.ColumnMappings.Add("MarcaModelo", "MarcaModelo");
                        s.ColumnMappings.Add("Microprocesador", "Microprocesador");
                        s.ColumnMappings.Add("Almacenamiento", "Almacenamiento");
                        s.ColumnMappings.Add("CdDvd", "CdDvd");
                        s.ColumnMappings.Add("Fuente", "Fuente");
                        s.ColumnMappings.Add("Adicionales", "Adicionales");
                        s.ColumnMappings.Add("NumSerie", "NumSerie");
                        s.ColumnMappings.Add("IdTipoServicio", "IdTipoServicio");
                        s.ColumnMappings.Add("Descripcion", "Descripcion");
                        s.ColumnMappings.Add("CostoRepuestos", "CostoRepuestos");
                        s.ColumnMappings.Add("CostoTerceros", "CostoTerceros");
                        s.ColumnMappings.Add("CostoCG", "CostoCG");
                        s.ColumnMappings.Add("CostoTotal", "CostoTotal");
                        s.ColumnMappings.Add("FechaDevolucion", "FechaDevolucion");
                        s.ColumnMappings.Add("Ganancia", "Ganancia");
                        s.ColumnMappings.Add("Estado", "Estado");
                    }

                    if (tablaSeleccionada == "TiposEquipo")
                    {
                        s.ColumnMappings.Add("Descripcion", "Descripcion");
                        s.ColumnMappings.Add("Estado", "Estado");
                    }

                    if (tablaSeleccionada == "TiposServicio")
                    {
                        s.ColumnMappings.Add("Descripcion", "Descripcion");
                        s.ColumnMappings.Add("Estado", "Estado");
                    }

                    if (tablaSeleccionada == "Clientes")
                    {
                        s.ColumnMappings.Add("Nombres", "Nombres");
                        s.ColumnMappings.Add("DNI", "DNI");
                        s.ColumnMappings.Add("Direccion", "Direccion");
                        s.ColumnMappings.Add("IdLocalidad", "IdLocalidad");
                        s.ColumnMappings.Add("Telefono", "Telefono");
                        s.ColumnMappings.Add("Mail", "Mail");
                        s.ColumnMappings.Add("Estado", "Estado");
                    }

                    if (tablaSeleccionada == "Localidades")
                    {
                        s.ColumnMappings.Add("Descripcion", "Descripcion");
                        s.ColumnMappings.Add("Estado", "Estado");
                    }

                    if (tablaSeleccionada == "Usuarios")
                    {
                        s.ColumnMappings.Add("IdTipo", "IdTipo");
                        s.ColumnMappings.Add("Apellido", "Apellido");
                        s.ColumnMappings.Add("Nombre", "Nombre");
                        s.ColumnMappings.Add("Username", "Username");
                        s.ColumnMappings.Add("Mail", "Mail");
                        s.ColumnMappings.Add("Clave", "Clave");
                        s.ColumnMappings.Add("CodigoRecuperarClave", "CodigoRecuperarClave");
                    }

                    if (tablaSeleccionada == "TiposUsuario")
                    {
                        s.ColumnMappings.Add("Tipo", "Tipo");
                    }

                    if (tablaSeleccionada == "Activado")
                    {
                        s.ColumnMappings.Add("IdLicencia", "IdLicencia");
                        s.ColumnMappings.Add("Estado", "Estado");
                        s.ColumnMappings.Add("Validez", "Validez");
                    }

                    if (tablaSeleccionada == "credencialesMail")
                    {
                        s.ColumnMappings.Add("mail", "mail");
                        s.ColumnMappings.Add("pass", "pass");
                    }

                    if (tablaSeleccionada == "Licencias")
                    {
                        s.ColumnMappings.Add("Serial", "Serial");
                        s.ColumnMappings.Add("Estado", "Estado");
                    }

                    if (tablaSeleccionada == "UsuarioLogueado")
                    {
                        s.ColumnMappings.Add("Username", "Username");
                        s.ColumnMappings.Add("Tipo", "Tipo");
                    }

                    s.DestinationTableName = tablaSeleccionada;

                    s.BulkCopyTimeout = 1500;

                    try
                    {
                        s.WriteToServer(tbData);
                    }
                    catch (Exception e)
                    {
                        string mensaje = e.Message;
                        resultado = false;
                    }
                }
            }
            return resultado;
        }
    }
}