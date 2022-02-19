using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacciaStrumenti
{
    internal class Complesso
    {
        List<ISuonatore> suonatori = new List<ISuonatore>();
        public void aggiungiStrumento(Strumento str)
        {
            suonatori.Add(str);
        }
        public void aggiungiRumorista(Rumorista rum)
        {
            suonatori.Add(rum);
        }
        public void Play()
        {
            foreach (var str in suonatori)
            {
                str.Suona();
            }
        }
    }
}
