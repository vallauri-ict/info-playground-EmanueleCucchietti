using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstr1
{
    abstract class Figura
    {
        protected int Altezza;
        abstract protected double Area();
        public double Volume()
        {
            return Area() * Altezza;
        }
        public string StampaArea()
        {
            return "Area: " + Area();
        }
        public string StampaVolume()
        {
            return "Volume: " + Volume();
        }
    }
}
