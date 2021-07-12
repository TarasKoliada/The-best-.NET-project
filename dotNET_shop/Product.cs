using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNET_shop
{
    class Product
    {
        List<Product> list = new List<Product>();
        public string Name{ get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
        public int Id { get; set; }

        private static int idIterator = 0;
        public void ErrorMsg()
        {
            Console.WriteLine("\n!!!!!!!!!!!!!!!!!! Wrong Input Format !!!!!!!!!!!!!!!!!!");
        }
        public void ShowProductInfo()
        {
            Console.WriteLine($"\nID: {Id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Price: {Price}$");
            Console.WriteLine($"Category: {Category}");
        }
        public void ShowChoiseMenu()
        {
            Console.WriteLine("\nSelect an action: ");
            Console.WriteLine("1) Get all prooducts.");
            Console.WriteLine("2) Add Product.");
            Console.WriteLine("3) Remove Product.");
            Console.WriteLine("0) Exit");
            Console.Write("Your choise: ");
        }
        public void GetAllProducts()
        {
            if (list.Count == 0)
            {
                Console.WriteLine("\n---There are no products yet. Add them and come back here---");
            }
            else
            {
                foreach (Product item in list)
                {
                    item.ShowProductInfo();
                }
            }
        }
        public void AddProduct()
        {
            string name, category, stringPrice, stringExit;
            int exit = 0;
            while (exit != 2)
            {
                Console.Clear();
                Console.Write("Name: ");
                name = Console.ReadLine();
                Console.Write("Price: ");
                stringPrice = Console.ReadLine();
                if (decimal.TryParse(stringPrice, out decimal price))
                {
                    Console.Write("Category: ");
                    category = Console.ReadLine();
                    idIterator++;
                    list.Add(new Product() { Name = name, Price = price, Category = category, Id = idIterator });
                    
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
                else
                {
                    ErrorMsg();
                    break;
                }
            }
        }
        public void RemoveProduct()
        {
            if (list.Count != 0)
            {
                string stringId;
                int productId;
                Console.Write("\nEnter product ID: ");
                stringId = Console.ReadLine();
                if (int.TryParse(stringId, out productId))
                {
                    var deleteProduct = list.FirstOrDefault(prod => prod.Id == productId);
                    if (deleteProduct == null)
                    {
                        Console.WriteLine($"!!!!The product with ID: {productId} not found!!!!"); ;
                    }
                    else
                    {
                        list.Remove(deleteProduct);
                        Console.WriteLine($"\n---The Product with ID: {productId} has been removed---");
                    }
                }
                else
                {
                    ErrorMsg();
                }
                if (list.Count == 0)
                {
                    idIterator = 0;
                }
            }
            else
            {
                Console.WriteLine("\n---There are no Products to delete---");
            } 
        }
    }
}
