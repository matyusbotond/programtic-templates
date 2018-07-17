using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Developer : Person
    {
        public int Age { get; set; }

        public Developer(string name) : base(name)
        {
        }
    }
}
