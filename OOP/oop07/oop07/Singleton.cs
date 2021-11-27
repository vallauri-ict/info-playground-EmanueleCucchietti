using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop07
{
    class Singleton
    {
        private static Singleton istanza = null;
        private static int Id = 0;
        public readonly int n;

        private Singleton()
        {
            Id++;
            n = Id;
        }

        public static Singleton GetIstance()
        {
            if (istanza==null)
            {
                istanza = new Singleton();
            }
            return istanza;
        }
    }
}
