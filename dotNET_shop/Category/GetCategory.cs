using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNET_shop
{
    class GetCategory
    {
        public void Show()
        {
            if (CategoryAdding.categoryList.Count == 0)
            {
                Console.WriteLine("\n---There are no Categories yet. Add them and come back here---");
            }
            else
            {
                foreach (Category item in CategoryAdding.categoryList)
                {
                    Console.WriteLine($"\nID: {item.Id}");
                    Console.WriteLine($"Category: {item.category}");
                }
            }
        }
    }
}
