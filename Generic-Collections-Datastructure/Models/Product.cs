using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Generic_Collections_Datastructure.Models
{
    abstract class Product
    {
        static private int _id;
        public int Id 
        { 
            get 
            { 
                return _id;
            }
            set 
            {
                value++;
                _id = value; 
            }
        }
        static private int _totalincome;

        public int TotalInCome 
        { 
            get 
            { 
                return _totalincome; 
            } 
            set 
            { 
                _totalincome = value; 
            } 
        }
        
        public string Name;
        public int Price;
        public int Count;
        
        public Product(int totalincome, string name, int price, int count)
        {
            TotalInCome = totalincome;
            Name = name;
            Price = price;
            Count = count;
        }
        public abstract void ShowInfo();
        
    }

}
