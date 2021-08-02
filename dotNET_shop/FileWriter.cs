using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNET_shop
{
    class FileWriter
    {
        public void SetProductFileData()
        {
            string path1 = Directory.GetCurrentDirectory();
            string path2 = Path.GetDirectoryName(path1);
            path1 = Path.GetDirectoryName(path2);
            string filePath = $@"{path1}\FilesContent\Product.txt";
            using (StreamWriter sw = new StreamWriter(filePath, false))
             {
                foreach (Product item in ProductAdding.productList)
                {
                    sw.WriteLine("----------------");
                    sw.WriteLine($"ID: {item.Id}");
                    sw.WriteLine($"Name: {item.Name}");
                    sw.WriteLine($"Price: {item.Price}$");
                    sw.WriteLine("----------------\n");
                }
             }
        }
        public void SetCategoryFileData()
        {
            string path1 = Directory.GetCurrentDirectory();
            string path2 = Path.GetDirectoryName(path1);
            path1 = Path.GetDirectoryName(path2);
            string filePath = $@"{path1}\FilesContent\Category.txt";
            using (StreamWriter sw = new StreamWriter(filePath, false))
            {
                foreach (Category item in CategoryAdding.categoryList)
                {
                    sw.WriteLine("----------------");
                    sw.WriteLine($"ID: {item.Id}");
                    sw.WriteLine($"Category: {item.category}");
                    sw.WriteLine("----------------\n");
                }
            }
        }
    }
}
