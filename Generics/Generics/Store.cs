using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Store
    {
        object[] _innerStore;
        int _currentIndex;

        public Store()
        {
            _innerStore = new object[5];
        }

        public void Add(object item)
        {
            _innerStore[_currentIndex] = item;
            _currentIndex++;
        }

        public object Get(int index)
        {
            if (index >= _currentIndex)
            {
                throw new ArgumentOutOfRangeException();
            }

            return _innerStore[index];
        }
    }
}
