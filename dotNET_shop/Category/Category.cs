using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNET_shop
{
    class Category
    {
        //List<Category> categories = new List<Category>();
        public string category { get; set; }
        public int Id { get; set; }

       /* private static int idIterator = 0;

        private void ErrorMsg()
        {
            Console.WriteLine("\n!!!!!!!!!!!!!!!!!! Wrong Input Format !!!!!!!!!!!!!!!!!!");
        }
        private void ShowCategoryInfo()
        {
            Console.WriteLine($"\nID: {Id}");
            Console.WriteLine($"Category: {category}");
        }
        public void AddCategory()
        {
            string category, stringExit;
            int exit = 0;
            while (exit != 2)
            {
                Console.Clear();
                Console.Write("Category: ");
                category = Console.ReadLine();
                idIterator++;

                categories.Add(new Category() { category = category, Id = idIterator });

                Console.WriteLine("\n1) Add another one.");
                Console.WriteLine("2) Stop");
                Console.Write("Your choise: ");
                stringExit = Console.ReadLine();
                if (int.TryParse(stringExit, out exit) == false)
                {
                    ErrorMsg();
                    break;
                }
            }
        }
        public void ShowCategory()
        {
            if (categories.Count == 0)
            {
                Console.WriteLine("\n---There are no Categorise yet. Add them and come back here---");
            }
            else
            {
                foreach (Category item in categories)
                {
                    item.ShowCategoryInfo();
                }
            }
        }
        public void RemoveCategory()
        {
            if (categories.Count != 0)
            {
                string stringId;
                int categoryId;
                Console.Write("\nEnter category ID: ");
                stringId = Console.ReadLine();
                if (int.TryParse(stringId, out categoryId))
                {
                    var deleteCategory = categories.FirstOrDefault(categ => categ.Id == categoryId);
                    if (deleteCategory == null)
                    {
                        Console.WriteLine($"!!!!The Category with ID: {categoryId} not found!!!!"); ;
                    }
                    else
                    {
                        categories.Remove(deleteCategory);
                        Console.WriteLine($"\n---The Category with ID: {categoryId} has been removed---");
                    }
                }
                else
                {
                    ErrorMsg();
                }
                if (categories.Count == 0)
                {
                    idIterator = 0;
                }
            }
            else
            {
                Console.WriteLine("\n---There are no Categories to delete---");
            }
        }*/
    }
}
