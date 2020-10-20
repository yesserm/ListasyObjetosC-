using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasyObjetos
{
    class Album
    {
        public string Nombre { get; set; }
        public List<Cancion> Canciones { get; set; }
        public Album()
        {
            this.Canciones = new List<Cancion>();
        }
        public Album(string nombre)
        {
            this.Nombre = nombre;
            this.Canciones = new List<Cancion>();
        }
    }
}
