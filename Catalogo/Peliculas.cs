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
       //public int Estreno { get; set; } //  1800< >2019
       public string Director { get; set; }
       public string Genero { get; set; }
       public string Pais { get; set; }
       //public int Minutos { get; set; }// #>0
       //public int Rating { get; set; } //0 -10
       public string Sinopsis { get; set; }

        

        private int _estreno { get; set; }
        public int Estreno
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

        private int _minutos {get;set;}
        public int  Minutos
        {
            get
            {
                return _minutos;
            }
            set
            {
                if (value>0)
                {
                    _minutos = value;
                }
                else 
                {
                    throw new Exception ("debe durar al menos un min");
                }
            }
        }

        private double _rating {get; set;}
        public double Rating
        {
            get
            {
                return _rating;
            }
            set 
            {
                if (value>=0)
                {
                    if (value<10)
                    {
                        _rating = value;

                    }
                    else
                    {
                        throw new Exception("el rating no puede ser mayor a 10");
                    }
                }    
                else 
                {
                    throw new Exception ("el rating no puede ser menor a 0");
                }
            }
        }

        public Peliculas()
        {
            Titulo = "Sin definir";
            Estreno = 0;
            Director="Sin definir";
            Genero ="Sin definir";
            Pais ="Sin definir";
            Minutos=0;
            Rating=0;
            Sinopsis= "Sin definir";

        }
        public Peliculas (string titulo, int estreno, string director, string genero, string pais, int minutos, int rating, string sinopsis)
        {
            Titulo = titulo;
            Estreno = estreno;
            Director = director;
            Genero = genero;
            Pais = pais;
            Minutos = minutos;
            Rating = rating;
            Sinopsis = sinopsis;
        }
        

    }
}
