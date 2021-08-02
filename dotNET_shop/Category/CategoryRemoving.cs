using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNET_shop
{
    class CategoryRemoving
    {
        private FileWriter fileWriter = new FileWriter();
        public void RemoveCategory()
        {
            if (CategoryAdding.categoryList.Count != 0)
            {
                string stringId;
                int categoryId;
                Console.Write("\nEnter category ID: ");
                stringId = Console.ReadLine();
                if (int.TryParse(stringId, out categoryId))
                {
                    var deleteCategory = CategoryAdding.categoryList.FirstOrDefault(categ => categ.Id == categoryId);
                    if (deleteCategory == null)
                    {
                        Console.WriteLine($"!!!!The Category with ID: {categoryId} not found!!!!"); ;
                    }
                    else
                    {
                        CategoryAdding.categoryList.Remove(deleteCategory);
                        fileWriter.SetCategoryFileData();
                        Console.WriteLine($"\n---The Category with ID: {categoryId} has been removed---");
                    }
                }
                else
                {
                    TextInfoClass.ErrorMsg();
                }
                if (CategoryAdding.categoryList.Count == 0)
                {
                    CategoryAdding.idIterator = 0;
                }
            }
            else
            {
                Console.WriteLine("\n---There are no Categories to delete---");
            }
        }
    }
}
