using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Mail { get; set; }
        public string Dni { get;  set; }
        public string Clave { get; set; }

        public Usuario()
        {

        }

        public Usuario (int id, string tipo, string nombres, string apellidos, string mail, string dni)
        {
            Id = id;
            Tipo = tipo;
            Nombres = nombres;
            Apellidos = apellidos;
            Mail = mail;
            Dni = dni;
        }
    }
}
