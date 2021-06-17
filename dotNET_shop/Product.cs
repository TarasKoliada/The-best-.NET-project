using System;
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

        public void showProduct()
        {
            Console.WriteLine($"\nName: {Name}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Category: {Category}");
        }
    }
}
