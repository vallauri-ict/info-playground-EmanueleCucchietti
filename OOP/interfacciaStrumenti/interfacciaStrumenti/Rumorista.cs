using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacciaStrumenti
{
    internal class Rumorista : Persona, ISuonatore
    {
        public string NomeArte;
        public void Suona()
        {
            MessageBox.Show("Emette suoni con la bocca");
        }
    }
}
