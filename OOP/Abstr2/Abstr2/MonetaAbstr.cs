using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstr2
{
    class MonetaAbstr : OggettiLanciati
    {
        Random rnd = new Random();
        public MonetaAbstr()
        {
            this.x = 0;
        }

        public override void Lancio()
        {
            x = rnd.Next(2); //0 testa : 1 croce
        }
    }
}
