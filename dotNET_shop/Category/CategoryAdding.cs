using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNET_shop
{
    class CategoryAdding
    {
        public static int idIterator = 0;
        public static List<Category> categoryList = new List<Category>();
        public void AddCategory()
        {
            string category, stringExit;
            int exit = 0;
            while (exit != 2)
            {
                Console.Clear();
                Console.Write("Category: ");
                category = Console.ReadLine();
                Console.Clear();
                idIterator++;

                categoryList.Add(new Category() { category = category, Id = idIterator });

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
        }
    }
}
