using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop04
{
    class Mannaro : Mostro
    {
        protected bool mutato;
        new private string verso;
        public Mannaro()
        {
            punti = 33;
            verso = "ululato";
            mutato = true;
        }
        new public double Valore()
        {
            if (mutato)
                return 2 * base.Valore();
            else
                return base.Valore();
        }
        new public string Verso()
        {
            if (mutato)
                return verso;
            else
                return base.verso;
        }
        public void Muta()
        {
            mutato = !mutato;
        }
    }
}
