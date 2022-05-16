using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Proveedor
    {
        public Proveedor()
        {

        }

        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Mail { get; set; }
        public string Telefono { get; set; }
        public int IdTipo { get; set; }
        public string Tipo { get; set; }
        public string SitioWeb { get; set; }
        public int Estado { get; set; }
        public string FechaAlta { get; set; }

        public Proveedor(int iD, string nombre, string mail, string telefono, int idTipo, 
                        string tipo, string sitioWeb, int estado, string fechaAlta)
        {
            ID = iD;
            Nombre = nombre;
            Mail = mail;
            Telefono = telefono;
            IdTipo = idTipo;
            Tipo = tipo;
            SitioWeb = sitioWeb;
            Estado = estado;
            FechaAlta = fechaAlta;
        }
    }
}
