using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Generic_Collections_Datastructure.Models
{
    abstract class Product
    {
        public static int Id; 

        public static int TotalInCome;
        
        public string Name;
        public int Price;
        public int Count = 20;
        
        public Product(string name, int price)
        {
            Id++;
            Name = name;
            Price = price;
        }
        public abstract void ShowInfo();
        public abstract void Sell();
        
            

        
    }

}
