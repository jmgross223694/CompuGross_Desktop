using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Cliente
    {
        public Cliente()
        {
        }

        public Cliente(long id, string nombres, string dNI, string direccion, string localidad, long idLocalidad, string telefono, string mail)
        {
            Id = id;
            Nombres = nombres;
            DNI = dNI;
            Direccion = direccion;
            Localidad = localidad;
            IdLocalidad = idLocalidad;
            Telefono = telefono;
            Mail = mail;
        }

        public long Id { get; set; }

        public string Nombres { get; set; }

        public string DNI { get; set; }

        public string Direccion { get; set; }

        public string Localidad { get; set; }

        public long IdLocalidad { get; set; }

        public string Telefono { get; set; }

        public string Mail { get; set; }
    }
}
