using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo
{
    class Peliculas
    {
       public string Titulo { get; set; }
       // public int Estreno { get; set; } //  1800< >2019
       public string Director { get; set; }
       // public string Genero { get; set; }
       public string Pais { get; set; }
       public int Minutos { get; set; }// #>0
       public int Ratin { get; set; } //0 -10
       public string Sinopsis { get; set; }

        public List<Playlist> Lista { get; set; }

        public Peliculas()
        {
            Lista = new List<Playlist>();
        }

        private int _estreno { get; set; }
        private int Estreno
        {
            get
            {
                return _estreno;
            }
            set
            {
                if (value > 1800)
                {
                    if (value < 2019)
                    {
                        _estreno = value;

                    }
                    else if (value > 2019)
                    {
                        throw new Exception("La fecha de estreno no puede ser despues del año 2019");
                    }
                }
                else
                {
                    throw new Exception("la pelicula debio estrenarse despues del año 1800");
                }
            }
        }



    }
}
