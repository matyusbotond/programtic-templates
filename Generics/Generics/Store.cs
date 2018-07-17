using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Store<T>
    {
        T[] _innerStore;
        int _currentIndex;

        public Store()
        {
            _innerStore = new T[5];
        }

        public void Add(T item)
        {
            _innerStore[_currentIndex] = item;
            _currentIndex++;
        }

        public T Get(int index)
        {
            if (index >= _currentIndex)
            {
                throw new ArgumentOutOfRangeException();
            }

            //Egyik megoldás de nem az igazi
            //return (T)_innerStore[index];
            return _innerStore[index];
        }
    }
}
