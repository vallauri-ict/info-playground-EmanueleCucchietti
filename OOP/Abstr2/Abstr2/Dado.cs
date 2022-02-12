using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstr2
{
    class Dado
    {
        Random rnd = new Random();
        private int n;
        public int N { get { return n; } }

        public Dado(int n)
        {
            this.n = n;
        }
        public Dado()
        {
            n = 1;
        }
        public void Lancio()
        {
            n = rnd.Next(6) + 1;
        }
    }
}
