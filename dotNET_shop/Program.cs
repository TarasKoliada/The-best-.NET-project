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
            /* Category category = new Category();
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
             } while (choise != 0);*/








            



            var menu = new List<string>();
            menu.Add("1) menu1");
            menu.Add("2) menu2");
            menu.Add("3) menu3");

            ConsoleKeyInfo keyPushed;
            int position = 0;
            do
            {
                for (int i = 0; i < menu.Count; i++)
                {
                    if (i == position)
                    {
                        Console.WriteLine("-> " + menu[i]);
                    }
                    else
                    {
                        Console.WriteLine(menu[i]);
                    }
                }
                keyPushed = Console.ReadKey();
                //////
                for (int i = 0; i < menu.Count; i++)
                {
                    if (i == position)
                    {
                        if (keyPushed.Key == ConsoleKey.RightArrow)
                        {
                            Console.WriteLine("    1) SubMenu");
                        }
                    }
                }
                ///////
                if (keyPushed.Key == ConsoleKey.DownArrow)
                {
                    Console.Clear();
                    position++;
                }
                if (keyPushed.Key == ConsoleKey.UpArrow)
                {
                    Console.Clear();
                    position--;
                }
            } while (keyPushed.Key != ConsoleKey.Escape);

            
        }
    }
}
