using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo
{
    class Program
    {
        static void Main(string[] args)
        {
          
            
            
            
            /* List<Peliculas> peliculas1 = new List<Peliculas>();

            Peliculas primeras = new Peliculas();
            primeras.Titulo = "Pulp Fiction";
            primeras.Estreno = 1994;
            primeras.Director ="Tarantino";
            primeras.Genero= "Accion";
            primeras.Pais = "USA";
            primeras.Minutos = 153;
            primeras.Rating = 8.5;
            primeras.Sinopsis = "Jules y Vincent, dos asesinos a sueldo con no demasiadas luces, trabajan para el gángster Marsellus Wallace";
            Peliculas.Add(primeras);

            Playlist uno = new Playlist ("peliculas de accion", "las que mas me gustaron");
            Playlist dos = new Playlist ("peliculas de terror", "las que mas me gustaron");
            Playlist dos = new Playlist ("peliculas de terror", "las que mas me gustaron");

            primeras.Lista.Add(playlist1);
            primeras.Lista.Add(playlist2);

            foreach (Peliculas peliculas in peliculas1)
            {
                Console.WriteLine("Titulo:"+ peliculas.Titulo);
                Console.WriteLine("Estreno:"+ peliculas.Estreno);
                Console.WriteLine("Director:"+ peliculas.Director);
                Console.WriteLine("Genero:"+ peliculas.Genero);
                Console.WriteLine("Pais:"+ peliculas.Pais);
                Console.WriteLine("Minutos:"+ peliculas.Minutos);
                Console.WriteLine("Rating:"+ peliculas.Rating);
                Console.WriteLine("Sinpsis:"+ peliculas.Sinopsis);
                foreach (Playlist playlist in peliculas.Lista)
                {
                    Console.WriteLine("*"+ playlist.Titulo + "*" + "*" + playlist.Descripcion);

                }
                Console.WriteLine("");
            }
            Console.ReadLine();
        }
    }
}
