using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNET_shop
{
    class Product
    {
        public string Name{ get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
        public int Id { get; set; }

       // public static int globalID;
        public void showProduct()
        {
            //globalID++;
            //id = Interlocked.Increment(ref globalID);
            Console.WriteLine($"\nID: {Id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Category: {Category}");
        }
    }
}
