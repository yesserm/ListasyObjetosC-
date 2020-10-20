using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasyObjetos
{
    class Cancion
    {
        public string Titulo { get; set; }
        public TimeSpan Duracion { get; set; }
        public Cancion()
        {

        }
        public Cancion(string titulo, TimeSpan duracion)
        {
            this.Titulo = titulo;
            this.Duracion = duracion;
        }
    }
}
