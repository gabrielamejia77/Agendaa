using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agendaa
{
    public class Contactos
    {

        public string nombre { get; set; }

        public string app { get; set; }

        public string apm { get; set; }

        public string direccion { get; set; }
        public string telefono { get; set; }
        public string correo { get; set; }

        public Contactos() { }
        public Contactos(string nombre, string app, string apm, string direccion, string telefono, string correo)
        {
            this.nombre = nombre;
            this.app = app;
            this.apm = apm;
            this.direccion = direccion;
            this.telefono = telefono;
            this.correo = correo;
        }
    }

}

