using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class CompraProveedor
    {
        public long ID { get; set; }
        public Proveedor Proveedor { get; set; }
        public Articulo Articulo { get; set; }
        public Cliente Cliente { get; set; }
        public decimal MontoAbonado { get; set; }
        public DateTime FechaCompra { get; set; }
        public bool Devolucion { get; set; }
        public bool Estado { get; set; }
    }
}
