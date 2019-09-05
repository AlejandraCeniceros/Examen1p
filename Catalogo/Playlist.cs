using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo
{
    class Playlist
    {
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public  List<Peliculas> Peliculas1{get; set;}


        public Playlist()
        {
            Titulo = "No se inserto el titulo de la playlist";
            Descripcion = "No se inserto una descripcion para la playlist";
            Peliculas1 = new List<Peliculas>();
        }
        public Playlist(string titulo, string descripcion)
        {
            Titulo = titulo;
            Descripcion = descripcion;
            Peliculas1 = new List<Peliculas>();
        }
    }
}
