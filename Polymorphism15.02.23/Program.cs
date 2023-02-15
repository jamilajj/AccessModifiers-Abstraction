using System;

namespace Polymorphism15._02._23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store();
            store.AddProduct(new Dairy());
            store.AddProduct(new Dairy());
            store.AddProduct(new Drink());
            Console.WriteLine(store.DairyProductCountLimit());
        }

       
    }
}
