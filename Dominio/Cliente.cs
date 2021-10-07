using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Cliente
    {
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
