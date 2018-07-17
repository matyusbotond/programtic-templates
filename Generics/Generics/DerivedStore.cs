using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    //class DerivedStore : Store<Person>
    //{
    //    public void Test()
    //    {
    //        this.Add(new Person("Alajos"));
    //    }
    //}

    class DerivedStore<T> : Store<T>
    {
        public void Test()
        {
            //this.Add()
        }
    }
}
