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
            store.Add("world");

            //1. probléma bármit enged Addolni
            //Megoldás: A Store<string> már nem engedi hozzá adni
            //store.Add(new Person("Géza")); 
            
            Store<Person> store2 = new Store<Person>();
            store2.Add(new Person("Géza"));
            
            string first = store.Get(0);
            //2. probléma hogy nem tudjuk mire lehet castolni
            string second = store.Get(1); 

            Person p = store2.Get(0);

            //try
            //{
            //    store.Get(2);
            //}
            //catch (ArgumentOutOfRangeException)
            //{
            //    Console.WriteLine("Túlindexeltük a Store-t");
            //}

            //Console.WriteLine("{0} {1}", first, second);

            Person p1 = new Person("Gazsi");
            Person p2 = new Person("Jani");

            //Swap<Person>(ref p1, ref p2);
            //Swap(ref p1, ref p2);
            //Console.WriteLine(p1.Name);

            //Nem működik mert a string nem Person vagy annak 
            //leszármazott típusa
            //NewStore<string> newStore = new NewStore<string>();
            //így már jó
            NewStore<Developer> newStore = new NewStore<Developer>();
            //ez se jó mert Developert fogad el vagy
            //annak leszármazottját de a Person az őse
            //newStore.Add(new Person("asd"));
            newStore.Add(new Developer("A"));


            Pair<Developer, string> pair = new Pair<Developer, string>();
            pair.Item1 = new Developer("Gizi");
            pair.Item2 = "Józsi";




            Console.ReadKey();
        }

        static void Swap<TItem>(ref TItem lhs, ref TItem rhs)
        {
            TItem temp = lhs;
            lhs = rhs;
            rhs = temp;
        }
    }
}
