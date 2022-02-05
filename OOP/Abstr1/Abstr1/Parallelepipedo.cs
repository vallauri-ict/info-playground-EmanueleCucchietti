using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstr1
{
     class Parallelepipedo : Figura
    {
        int Lato1;
        int Lato2;
        public Parallelepipedo()
        {

        }
        public Parallelepipedo(int lato1, int lato2, int altezza)
        {
            this.Lato1 = lato1;
            this.Lato2 = lato2;
            base.Altezza = altezza;
        }

        protected override double Area()
        {
            return Lato1 * Lato2;
        }
    }
}
