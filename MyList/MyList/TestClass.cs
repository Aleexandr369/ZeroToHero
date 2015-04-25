using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace MyList
{
    class TestClass // clasa de test pentru verificare
    {
        int x=10; 
        int y=20;
        [DefaultValue(20)]
        public int Y { get { return y; } set { y = value; } }
        [DefaultValue(10)]
        public int X { get { return x; } set { x = value; } }
  
        public TestClass(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public TestClass()
        {
        }
    }
}
