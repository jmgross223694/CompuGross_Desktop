using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompuGross
{
    public partial class OrdenesTrabajo : Form
    {
        public OrdenesTrabajo()
        {
            InitializeComponent();
        }

        /*
         select * from ExportOrdenesTrabajo 
         where 
         Cliente like '%texto%' 
         OR ID like '%texto%'
         OR TipoServicio like '%texto%'
         OR TipoEquipo like '%texto%'
         OR DatosEquipo like '%texto%'
         OR Descripcion like '%texto%'
         OR FechaRecepcion like '%texto%'
         OR FechaDevolucion like '%texto%'
            Clientes:
            ID, Cliente, DNI, Mail
        */
    }
}
