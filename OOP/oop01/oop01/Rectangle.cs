using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop01
{
    class Rectangle
    {
        public int side1;

        private int _side2;
        public int side2 
        { 
            get { return _side2; } 
            set { if (value > 0) _side2 = value; else _side2 = 0; } 
        }
        public Rectangle() : this (1)
        {

        }
        private Rectangle (int lato) : this(lato,lato)
        {
            
        }
        private Rectangle(int latoBase,int latoAltezza)
        {
            side1 = latoBase;
            side2 = latoAltezza;
        }
    }
}
