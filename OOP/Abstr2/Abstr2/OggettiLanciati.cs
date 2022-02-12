using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstr2
{
    abstract class OggettiLanciati
    {
        public int x;
        public int X { get { return x; } }
        public abstract void Lancio();
    }
}
