using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNET_shop
{
    class ProductAdding
    {
        public static List<Product> productList = new List<Product>();
        public static int idIterator = 0;
        public void AddProduct()
        {
            string name, stringPrice, stringExit;
            int exit = 0;
            while (exit != 2)
            {
                Console.Clear();
                Console.Write("Name: ");
                name = Console.ReadLine();
                Console.Write("Price: ");
                stringPrice = Console.ReadLine();
                Console.Clear();
                if (decimal.TryParse(stringPrice, out decimal price))
                {
                    idIterator++;
                    productList.Add(new Product() { Name = name, Price = price, Id = idIterator });

                    Console.WriteLine("\n1) Add another one.");
                    Console.WriteLine("2) Stop");
                    Console.Write("Your choise: ");
                    stringExit = Console.ReadLine();
                    Console.Clear();
                    if (int.TryParse(stringExit, out exit) == false)
                    {
                        TextInfoClass.ErrorMsg();
                        break;
                    }
                }
                else
                {
                    TextInfoClass.ErrorMsg();
                    break;
                }
            }
        }
    }
}
