using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Servicio
    {
        public long ID { get; set; }

        public string FechaRecepcion { get; set; }

        public long IdCliente { get; set; }

        public string Cliente { get; set; }

        public string TipoEquipo { get; set; }
        
        public string RAM { get; set; }

        public string PlacaMadre { get; set; }

        public string MarcaModelo { get; set; }

        public string Microprocesador { get; set; }

        public string Almacenamiento { get; set; }

        public string CdDvd { get; set; }

        public string Fuente { get; set; }

        public string Adicionales { get; set; }

        public string NumSerie { get; set; }

        public string TipoServicio { get; set; }

        public string Descripcion { get; set; }

        public int CostoRepuestos { get; set; }

        public int CostoTerceros { get; set; }

        public int CostoCG { get; set; }

        public int CostoTotal { get; set; }

        public string FechaDevolucion { get; set; }

        public int Ganancia { get; set; }

        public int Estado { get; set; }
    }
}
