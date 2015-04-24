using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyList
{
    class TestClass // clasa de test pentru verificare
    {
        int x;
        int y;
        public int Y {get {return y;}}
        public int X {get {return x;}}
        public TestClass(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
