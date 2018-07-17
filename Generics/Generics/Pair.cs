using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Pair<T, K>
    {
        public T Item1 { get; set; }

        public K Item2 { get; set; }
    }
}
