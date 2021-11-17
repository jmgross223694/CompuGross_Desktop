using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class OrdenTrabajo
    {
        public long ID { get; set; }

        public string FechaRecepcion { get; set; }

        public string Cliente { get; set; }

        public string TipoEquipo { get; set; }

        public string DatosEquipo { get; set; }

        public string TipoServicio { get; set; }

        public string Descripcion { get; set; }

        public string CostoRepuestos { get; set; }

        public string CostoTerceros { get; set; }

        public string CostoCG { get; set; }

        public string CostoTotal { get; set; }

        public string FechaDevolucion { get; set; }

        public string Ganancia { get; set; }

        public int Estado { get; set; }
    }
}
