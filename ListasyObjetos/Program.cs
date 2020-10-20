using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasyObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            //listar un artista con sus albumes y canciones
            //construir el objeto cancion
            List<Cancion> lista_cancion = new List<Cancion>();
            string titulo = "";
            TimeSpan duracion = new TimeSpan();
            int cantidad_canciones = 0;

            Console.WriteLine("Ingrese la cantidad de canciones del album");
            try
            {
                cantidad_canciones = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR: " + e.Message);
            }
            
            for (int i = 0; i < cantidad_canciones; i++)
            {
                Console.WriteLine("Ingrese los datos de la cancion");
                Console.Write("Ingrese el titulo : ");
                titulo = Console.ReadLine();
                Console.Write("Ingrese la duracion : ");
                duracion = TimeSpan.Parse(Console.ReadLine());
                Cancion nueva_cancion = new Cancion(titulo, duracion);
                lista_cancion.Add(nueva_cancion);
            }

            //Construir el objeto Album
            Album nuevo_album = new Album();
            string nombre_album = "";
            Console.Write("\n\nIngrese el nombre del album: ");
            nombre_album = Console.ReadLine();
            nuevo_album.Nombre = nombre_album;
            nuevo_album.Canciones = lista_cancion;

            //Construir el objeto Artista
            string nombre_artista = "";
            Console.Write("\n\nIngrese el nombre del artista: ");
            nombre_artista = Console.ReadLine();
            Artista nuevo_artista = new Artista(nombre_artista);
            nuevo_artista.Albumes.Add(nuevo_album);

            //listar todo
            listar_todo(nuevo_artista);
            Console.ReadKey();
        }

        private static void listar_todo(Artista nuevo_artista)
        {
            Console.WriteLine("Artista: " + nuevo_artista.Nombre);
            foreach(var album in nuevo_artista.Albumes)
            {
                Console.WriteLine("Album: " + album.Nombre);
                foreach (var cancion in album.Canciones)
                {
                    Console.WriteLine("Cancion: " + cancion.Titulo + " con duracion: " + cancion.Duracion);
                }
            }
        }
    }
}
