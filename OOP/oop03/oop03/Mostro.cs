using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop03
{
    class Mostro
    {
        public string nome;
        public double punti;
        public Mostro()
        {
            nome = "SenzaNome";
            punti = 100;
        }
        public Mostro(string n)
        {
            nome = n;
            punti = 100;
        }
        public double Valore()
        {
            return punti;
        }
    }
}
