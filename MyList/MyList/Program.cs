using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyList
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> listaint = new MyList<int>();
            bool contine;
            listaint.AddItem(10);
            listaint.AddItem(20);
            listaint.AddItem(30);
            contine = listaint.Contains(30);
            //Console.Write(contine);
            listaint.RemoveAt(2);
            contine = listaint.Contains(30);
            //Console.Write(contine);
            listaint.AddItem(30);
            listaint.AddItem(30);
            listaint.AddItem(30);
            listaint.AddItem(30);

            MyList<TestClass> listatestclass = new MyList<TestClass>();
            TestClass test1 = new TestClass(11112, 2); // primul parametru e x al doilea e y
            TestClass test2 = new TestClass(111, 2); 
            listatestclass.AddItem(test1); listatestclass.AddItem(test1); listatestclass.AddItem(test1); 
            listatestclass.AddItem(test2); listatestclass.AddItem(test2);
            listatestclass.AddItem(test2); listatestclass.AddItem(test2); 
            
            MyList<TestClass> listatestclass2 = listatestclass.FindAll(match); // nu inteleg ce se intampla aici, de ce nu crapa ??? cum face ???
            foreach (var aa in listatestclass2)
            {
                Console.WriteLine(aa.X);
            }
        }



        static public bool match (TestClass tmp) // functie de test match pentru verificare functionalitate FindAll
        {
            if (tmp.X % 2 == 0)
                return true;
            else
                return false;
        }

        static public bool match1(int  tmp) // functie de test match pentru verificare functionalitate FindAll
        {
            if (tmp % 2 == 0)
                return true;
            else
                return false;
        }
    }
}
