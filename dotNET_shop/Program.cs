using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNET_shop
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = new Product();
            int choise;
            do
            {
                product.showChoiseMenu();
                choise = int.Parse(Console.ReadLine());
                switch (choise)
                {
                    case 1:
                        product.getAllProducts();
                        break;
                    case 2:
                        product.addProduct();
                        break;
                    case 3:
                        product.removeProduct();
                        break;
                    default:
                        product.errorMsg();
                        break;
                }
            } while (choise != 0);

        }
    }
}
