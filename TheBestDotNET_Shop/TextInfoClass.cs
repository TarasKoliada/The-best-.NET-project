using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBestDotNET_Shop
{
    public static class TextInfoClass
    {
        public static void ShowStartProgramMenu()
        {
            Console.WriteLine("\n1) Product");
            Console.WriteLine("0) Exit");
            Console.Write("Your choise: ");
        }

        public static void ShowChoiseProductMenu()
        {
            Console.WriteLine("\nSelect an action: ");
            Console.WriteLine("\n1) Get all prooducts.");
            Console.WriteLine("2) Add Product.");
            Console.WriteLine("3) Get Product by ID.");
            Console.WriteLine("4) Remove Product.");
            Console.WriteLine("0) Exit");
            Console.Write("Your choise: ");
        }
        public static void ErrorMsg()
        {
            Console.WriteLine("\n!!!!!!!!!!!!!!!!!! Wrong Input Format !!!!!!!!!!!!!!!!!!");
        }
    }
}
