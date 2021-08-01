using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNET_shop
{
    class GetProduct
    {
        public void Show()
        {
            if (ProductAdding.productList.Count == 0)
            {
                Console.WriteLine("\n---There are no products yet. Add them and come back here---");
            }
            else
            {
                foreach (Product item in ProductAdding.productList)
                {
                    Console.WriteLine($"\nID: {item.Id}");
                    Console.WriteLine($"Name: {item.Name}");
                    Console.WriteLine($"Price: {item.Price}$");
                }
            }
        }
    }
}
