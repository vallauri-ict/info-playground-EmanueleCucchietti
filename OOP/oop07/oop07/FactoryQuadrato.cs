using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop07
{
    class FactoryQuadrato
    {
        private int lato;

        private FactoryQuadrato(int val)
        {
            this.lato = val;
        }

        public static FactoryQuadrato creaQuadrato(int val)
        {
            if (val > 0)
            {
                return new FactoryQuadrato(val);
            }
            else 
                throw new Exception("Il lato deve essere maggiore di 0");
        }
    }
}
