using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacciaStrumenti
{
    internal class Strumento : ISuonatore
    {
        public virtual void Suona()
        {
            MessageBox.Show("Sono uno strumento che suona");
        }
    }
}
