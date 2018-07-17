using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class NewStore<T> where T : Person
    {
        public void Add(T item)
        {
            
        }
    }
}
