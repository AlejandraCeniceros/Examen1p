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


        public Playlist(string titulo, string descripcion)
        {
            Titulo = titulo;
            Descripcion = descripcion;

        }



    }
}
