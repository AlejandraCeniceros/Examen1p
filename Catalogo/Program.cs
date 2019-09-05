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
            // List<Peliculas> peliculas1 = new List<Peliculas>();

            List<Playlist> playlists = new List<Playlist>();

          
            Playlist uno = new Playlist ("pelicula de accion", "las que mas me gustaron");
            Playlist dos = new Playlist ("pelicula de terror", "las que mas me gustaron");
           
            playlists.Add(uno);
            playlists.Add(dos);


             uno.Peliculas1.Add(new Peliculas("pelicula 1", 2012, "Cuaron", "terror", "Mexico", 122, 9, "divertida"));
             uno.Peliculas1.Add(new Peliculas("pelicula 2", 2013, "Cuaron", "terror", "Mexico", 122, 9, "divertida"));
             uno.Peliculas1.Add(new Peliculas("pelicula 3", 2014, "Cuaron", "terror", "Mexico", 122, 9, "divertida"));
             uno.Peliculas1.Add(new Peliculas("pelicula 4", 2015, "Cuaron", "terror", "Mexico", 122, 9, "divertida"));
             uno.Peliculas1.Add(new Peliculas("pelicula 5", 2016, "Cuaron", "terror", "Mexico", 122, 9, "divertida"));
             uno.Peliculas1.Add(new Peliculas("pelicula 6", 2017, "Cuaron", "terror", "Mexico", 122, 9, "divertida"));
             uno.Peliculas1.Add(new Peliculas("pelicula 7", 2018, "Cuaron", "terror", "Mexico", 122, 9, "divertida"));

             dos.Peliculas1.Add(new Peliculas("pelicula 1", 2011, "Cuaron", "terror", "Mexico", 122, 9, "divertida"));
             dos.Peliculas1.Add(new Peliculas("pelicula 2", 2010, "Cuaron", "terror", "Mexico", 122, 9, "divertida"));
             dos.Peliculas1.Add(new Peliculas("pelicula 3", 2009, "Cuaron", "terror", "Mexico", 122, 9, "divertida"));
             dos.Peliculas1.Add(new Peliculas("pelicula 4", 2008, "Cuaron", "terror", "Mexico", 122, 9, "divertida"));
             dos.Peliculas1.Add(new Peliculas("pelicula 5", 2007, "Cuaron", "terror", "Mexico", 122, 9, "divertida"));
             dos.Peliculas1.Add(new Peliculas("pelicula 6", 2006, "Cuaron", "terror", "Mexico", 122, 5, "divertida"));
             dos.Peliculas1.Add(new Peliculas("pelicula 7", 2005, "Cuaron", "terror", "Mexico", 122, 9, "divertida"));

            foreach (Playlist playlist in playlists)
            {
                Console.WriteLine("*");
                Console.WriteLine("Nombre de la playlist: " + playlist.Titulo);
                Console.WriteLine("Descripcion: " + playlist.Descripcion);

                foreach(Peliculas peliculas in playlist.Peliculas1)
                {
                     Console.WriteLine("Titulo: " + peliculas.Titulo + "Drirector: " + peliculas.Director + " Año: " + peliculas.Estreno +
                        "Genero: " + peliculas.Genero + "Pais : " + peliculas.Pais + "Duraion en Minutos: " + peliculas.Minutos +
                        "Rating: " + peliculas.Rating + "Sinopsis: " + peliculas.Sinopsis);
              
                }
            }  

            Console.Read();


            /*//{
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
            Playlist tres = new Playlist ("peliculas de terror", "las que mas me gustaron");

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

    */
        }
    }
}
