using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store();

            store.Add("hello");
            //store.Add("world");

            //1. probléma bármit enged Addolni
            store.Add(new Person("Géza")); 
            
            string first = (string)store.Get(0);
            //2. probléma hogy nem tudjuk mire lehet castolni
            string second = (string)store.Get(1); 

            try
            {
                store.Get(2);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Túlindexeltük a Store-t");
            }

            Console.WriteLine("{0} {1}", first, second);
            Console.ReadKey();
        }
    }
}
