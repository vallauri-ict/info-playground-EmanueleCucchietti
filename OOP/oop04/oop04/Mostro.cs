using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop04
{
    class Mostro
    {
        protected double punti;
        protected string verso;
        public Mostro():this(25) //Viene richiamato prima il costruttore "this" e poi il costruttore "Mostro()"
        {
            //punti = 25;
        }
        public Mostro(int p)
        {
            punti = p;
            verso = "grugnito";
        }
        public double Valore()
        {
            return punti;
        }
        public string Verso()
        {
            return verso;
        }
    }
}
