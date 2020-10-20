using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasyObjetos
{
    class Artista
    {
        public string Nombre { get; set; }
        public List<Album> Albumes { get; set; }
        public Artista()
        {
            this.Albumes = new List<Album>();
        }
        public Artista(string Nombre)
        {
            this.Nombre = Nombre;
            this.Albumes = new List<Album>();
        }
    }
}
