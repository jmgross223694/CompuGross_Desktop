using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class ReportePorCliente
    {
        public long ID { get; set; }

        public string Nombres { get; set; }

        public string TotalServicios { get; set; }

        public string ServicioTecnico { get; set; }

        public string Camaras { get; set; }

        public string ArmadoGabinete { get; set; }
    }
}
