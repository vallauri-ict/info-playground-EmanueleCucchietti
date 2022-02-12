using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstr2
{
    class Moneta
    {
        Random rnd = new Random();
        private int v;
        public int V { get { return v; } }

        public Moneta()
        {
            this.v = 0;
        }
        public Moneta(int v)
            { this.v = v; }

        public void Lancio()
        {
            v = rnd.Next(2); //0 testa : 1 croce
        }
        
    }
}
