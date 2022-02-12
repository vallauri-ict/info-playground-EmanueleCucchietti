using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstr2
{
    class DadoAbstr : OggettiLanciati
    {
        Random rnd = new Random();
        public DadoAbstr()
        {
            x = 1;
        }

        public override void Lancio()
        {
            x = rnd.Next(6) + 1;
        }
    }
}
