using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyList
{
    class MyList<T> : IEnumerable<T>
    {
        private int count; // numarul de elemente
        private T[] items; // un vector in care se tin elementele

        public int Count { get { return count; } }

        public T this[int index]  // returneaza un element de la o anumita pozitie
        {
            get
            {
                if (index < 0 || index >= this.count)
                    throw new MyListException("ArgumentOutOfRangeException!");
                else
                    return items[index];
            }
            set
            {
                if (index < 0 || index >= this.count)
                    throw new MyListException("ArgumentOutOfRangeException!");
                else
                    items[index] = value;
            }
        }

        public MyList() // constructor
        {
            this.count = 0;
            items = new T[count];
        }

        public void AddItem(T item) // adauga un element in lista
        {
            Array.Resize(ref items, count + 1);
            items[count] = item;
            count++;
        }
        public void Clear()  // sterge toate elementele listei
        {
            count = 0;
            items = new T[count];
        }

        public bool Contains(T item)  // verifica daca un element exista in lista
        {
            int flag = 0;
            for (int i = 0; i < this.count; i++)
            {
                if (((object)this[i]).Equals((object)item))
                {
                    flag = 1;
                    break;
                }    
            }
            if (flag == 1)
                return true;
            else
                return false;
        }

        public void RemoveAt(int index)  // sterge un element din lista
        {
            if (index < 0 || index >= this.count)
                throw new MyListException("ArgumentOutOfRangeException!");
            else
            {
                //items[index] = default(T); 
                for (int i = index; i < count - 1; i++)
                {
                    items[i] = items[i + 1];
                }
                this.count = this.count - 1;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach(T t in items)
            {
                if (count < 1)
                {
                    break;
                }
                count--;
                yield return t;
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public bool match (T variabila) // returneaza random true sau false ; am mai facut una si in class Program
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 100);
            if (randomNumber % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public MyList<T> FindAll(Func<T,bool> match)
        {
            bool flag;
            MyList<T> lista = new MyList<T>();
            foreach(var aa in this.items)
            {
                flag = match(aa);
                if (flag == true)
                    lista.AddItem(aa);
            }
            return lista;
        }
        
    }

    class MyListException : Exception
    {
        public MyListException() { }
        public MyListException(string message) : base(String.Format(message)) { }
        public MyListException(string message, Exception inner) : base(message, inner) { }
    }
}
