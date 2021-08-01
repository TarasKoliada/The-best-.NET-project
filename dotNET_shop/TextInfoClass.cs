using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNET_shop
{
    public static class TextInfoClass
    {
        public static void ShowStartProgramMenu()
        {
            Console.WriteLine("\n1) Product");
            Console.WriteLine("2) Category");
            Console.WriteLine("0) Exit");
            Console.Write("Your choise: ");
        }

        public static void ShowChoiseProductMenu()
        {
            Console.WriteLine("\nSelect an action: ");
            Console.WriteLine("\n1) Get all prooducts.");
            Console.WriteLine("2) Add Product.");
            Console.WriteLine("3) Remove Product.");
            Console.WriteLine("0) Exit");
            Console.Write("Your choise: ");
        }
        public static void ShowChoiseCategoryMenu()
        {
            Console.WriteLine("\nSelect an action: ");
            Console.WriteLine("\n1) Add category");
            Console.WriteLine("2) Show category");
            Console.WriteLine("3) Remove category");
            Console.WriteLine("0) Exit");
            Console.Write("Your Choise: ");
        }
        public static void ErrorMsg()
        {
            Console.WriteLine("\n!!!!!!!!!!!!!!!!!! Wrong Input Format !!!!!!!!!!!!!!!!!!");
        }
    }
}
