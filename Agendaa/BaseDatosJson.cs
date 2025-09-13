using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agendaa
{
    public class BaseDatosJson
    {
        public List<Contactos> Contactos { get; set; }
        public DateTime Actualizacion { get; set; }

        public int TotalRegistros { get; set; }

        public BaseDatosJson()
        {
            Contactos = new List<Contactos>();
            Actualizacion = DateTime.Now;
        }
    }
}
