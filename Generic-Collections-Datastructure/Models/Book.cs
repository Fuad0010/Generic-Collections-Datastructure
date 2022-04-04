using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Collections_Datastructure.Models
{
    internal class Book:Product
    {
        public string AuthorName;
        public int PageCount;
       public Book(int totalincome, string name, int price, int count, string authorname, int pagecount):base(totalincome, name, price, count)
        {
            AuthorName = authorname;
            PageCount = pagecount;
        }
        public override void ShowInfo()
        {
            
            Console.WriteLine($"Id: {Id}\n"+
                              $"Name: {Name}\n" +
                              $"Price: {Price}\n" +
                              $"Count: {Count}\n" +
                              $"Total In Come {TotalInCome}\n"+
                              $"Author name: {AuthorName}\n" +
                              $"Page Count: {PageCount}");
        }

    }
}
