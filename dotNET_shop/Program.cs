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
            //-----Product Logic------
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


            //-------Menu Logic (Partly)-------
            //Menu menu = new Menu();
            //menu.GetMenu();


            //------Category logic-------
            Category category = new Category();
            int choise;
            do
            {
                Console.WriteLine("\n1) Add category");
                Console.WriteLine("2) Show category");
                Console.WriteLine("3) Remove category");
                Console.Write("Your Choise: ");
                choise = int.Parse(Console.ReadLine());
                switch (choise)
                {
                    case 1:
                        category.AddCategory();
                        break;
                    case 2:
                        category.ShowCategory();
                        break;
                    case 3:
                        category.RemoveCategory();
                        break;
                }
            } while (choise != 0);
        }
    }
}
