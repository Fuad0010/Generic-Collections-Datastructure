
using Generic_Collections_Datastructure.Models;
using System;

namespace Generic_Collections_Datastructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "asd";
            int price = 123;
            string authorname = "Fd";
            int pagecount = 20;

            Book book1 = new Book(name, price, authorname, pagecount);
            book1.Sell();
            book1.ShowInfo();

            Book book2 = new Book(name, price, authorname, pagecount);
            book2.Sell();
            book2.ShowInfo();
        }
    }
}
