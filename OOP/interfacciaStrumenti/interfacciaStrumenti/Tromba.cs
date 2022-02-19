using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfacciaStrumenti
{
    internal class Tromba : Strumento
    {
        public override void Suona()
        {
            MessageBox.Show("Sono una tromba che suona");
        }
    }
}
