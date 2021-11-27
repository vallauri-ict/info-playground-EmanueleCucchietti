using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop07
{
    class StringheIndexate
    {
        private string[] myData;

        public StringheIndexate(int size)
        {
            myData = new string[size];
            for (int i = 0; i < size; i++)
            {
                myData[i] = "empty" + i;
            }
        }
        public string this[int pos]
        {
            get { return myData[pos]; }
            set { myData[pos] = value; }
        }
    }
}
