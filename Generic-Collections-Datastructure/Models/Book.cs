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
       public Book(string name, int price,string authorname, int pagecount):base(name, price)
        {
            AuthorName = authorname;
            PageCount = pagecount;
        }
        public override void Sell()
        {
            Count--;
            TotalInCome++;
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
