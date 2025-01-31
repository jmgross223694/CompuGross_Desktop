using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Activacion
    {
        public long ID { get; set; }
        public string IdLicencia { get; set; }
        public bool Estado { get; set; }
        public DateTime Validez { get; set; }

        public Activacion() { }
    }
}
