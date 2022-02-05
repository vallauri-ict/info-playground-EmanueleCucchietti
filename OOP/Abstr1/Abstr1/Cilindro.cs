using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstr1
{
    class Cilindro : Figura
    {
        int Raggio;
        public Cilindro()
        {

        }
        public Cilindro(int raggio, int altezza)
        {
            this.Raggio = raggio;
            this.Altezza = altezza;
        }

        protected override double Area()
        {
            return Raggio * Raggio * Math.PI;
        }
        
    }
}
