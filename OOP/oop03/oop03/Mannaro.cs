using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop03
{
    class Mannaro : Mostro
    {
        public double punti;
        public Mannaro(string n)
        {
            nome = n;
            punti = 500;
        }
        public double Valore_Proprio()
        {
            return punti;
        }

        public double Valore_Padre()
        {
            return base.punti;
        }
        public double Valore()
        {
            return punti + base.Valore();
        }
    }
}
