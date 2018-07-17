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
            Store<string> store = new Store<string>();

            store.Add("hello");
            //store.Add("world");

            //1. probléma bármit enged Addolni
            //Megoldás: A Store<string> már nem engedi hozzá adni
            //store.Add(new Person("Géza")); 
            
            Store<Person> store2 = new Store<Person>();
            store2.Add(new Person("Géza"));

            string first = store.Get(0);
            //2. probléma hogy nem tudjuk mire lehet castolni
            string second = store.Get(1); 

            Person p = store2.Get(0);

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
