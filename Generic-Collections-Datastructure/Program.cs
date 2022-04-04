
using Generic_Collections_Datastructure.Models;
using System;

namespace Generic_Collections_Datastructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int totalincome = 15;
            string name = "asd";
            int price = 123;
            int count = 22;
            string authorname = "Fd";
            int pagecount = 20;

            Book book = new Book(totalincome, name, price, count, authorname, pagecount);
            
            book.ShowInfo();

            Book book2 = new Book(totalincome, name, price, count, authorname, pagecount);
            
            book.ShowInfo();
        }
    }
}
