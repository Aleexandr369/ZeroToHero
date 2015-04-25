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
                    throw new ArgumentOutOfRangeException("Index invalid !");
                else
                    return items[index];
            }
            set
            {
                if (index < 0 || index >= this.count)
                    throw new ArgumentOutOfRangeException("Index invalid !");
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
            if (items.Length > this.count)
            {
                items[count] = item;
                this.count++;
            }
            else
            {
                Array.Resize(ref items, (this.count + 1) * 2);
                items[count] = item;
                this.count++;
            }
        }

        public void Clear()  // sterge toate elementele listei
        {
            this.count = 0;
            items = new T[count];
        }

        public bool Contains(T item)  // verifica daca un element exista in lista
        {
            for (int i = 0; i < this.count; i++)
            {
                if (this[i].Equals(item))
                {
                    return true;
                }    
            }
            return false;
        }

        public void RemoveAt(int index)  // sterge un element din lista
        {
            if (index < 0 || index >= this.count)
                throw new ArgumentOutOfRangeException("Index invalid !");
            else
            {
                for (int i = index; i < this.count - 1; i++)
                {
                    items[i] = items[i + 1];
                }
                this.count = this.count - 1;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.count; i++)
                yield return items[i];
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public MyList<T> FindAll(Func<T,bool> match)
        {
            MyList<T> lista = new MyList<T>();
            for (int i = 0; i < this.count; i++)
            {
                if (match(items[i]))
                    lista.AddItem(items[i]);
            }
            return lista;
        }    
    }
}
