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
            //var product = new Product();
            //int choise;
            //do
            //{
            //    product.ShowChoiseMenu();
            //    choise = int.Parse(Console.ReadLine());
            //    switch (choise)
            //    {
            //        case 1:
            //            product.GetAllProducts();
            //            break;
            //        case 2:
            //            product.AddProduct();
            //            break;
            //        case 3:
            //            product.RemoveProduct();
            //            break;
            //        default:
            //            product.ErrorMsg();
            //            break;
            //    }
            //} while (choise != 0);
            Menu menu = new Menu();
            menu.GetMenu();
            

        }
    }
}
