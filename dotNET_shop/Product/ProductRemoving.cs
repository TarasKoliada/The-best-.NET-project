using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNET_shop
{
    class ProductRemoving
    {
        FileWriter fileWriter = new FileWriter();
        public void RemoveProduct()
        {
            if (ProductAdding.productList.Count != 0)
            {
                string stringId;
                int productId;
                Console.Write("\nEnter product ID: ");
                stringId = Console.ReadLine();
                if (int.TryParse(stringId, out productId))
                {
                    var deleteProduct = ProductAdding.productList.FirstOrDefault(prod => prod.Id == productId);
                    if (deleteProduct == null)
                    {
                        Console.WriteLine($"!!!!The product with ID: {productId} not found!!!!"); ;
                    }
                    else
                    {
                        ProductAdding.productList.Remove(deleteProduct);
                        fileWriter.SetProductFileData();
                        Console.WriteLine($"\n---The Product with ID: {productId} has been removed---");
                    }
                }
                else
                {
                    TextInfoClass.ErrorMsg();
                }
                if (ProductAdding.productList.Count == 0)
                {
                    ProductAdding.idIterator = 0;
                }
            }
            else
            {
                Console.WriteLine("\n---There are no Products to delete---");
            }
        }
    }
}
