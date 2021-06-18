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
            List<Product> list = new List<Product>();
           
            int choise, exit, idIterator, productId;
            exit = idIterator = 0;
            string name, category;
            decimal price;
            int iterator = 1;
            do
            {
                Console.WriteLine("\nSelect an action: ");
                Console.WriteLine("1) Get all prooducts.");
                Console.WriteLine("2) Add Product.");
                Console.WriteLine("3) Remove Product.");
                Console.WriteLine("0) Exit");
                Console.Write("Your choise: ");
                choise = int.Parse(Console.ReadLine());

                switch (choise)
                {
                    case 1:
                        if (list.Count == 0)
                        {
                            Console.WriteLine("\nThere are no products yet. Add them and come back here.");
                            idIterator = 0;
                        }
                        else
                        {
                            foreach (Product item in list)
                            {
                                item.showProduct();

                            }
                        }
                        break;

                    case 2:
                        while (exit != 2)
                        {
                            Console.Clear();
                            Console.Write("Name: ");
                            name = Console.ReadLine();
                            Console.Write("Price: ");
                            price = int.Parse(Console.ReadLine());
                            Console.Write("Category: ");
                            category = Console.ReadLine();
                            idIterator++;
                             list.Add(new Product() { Name = name, Price = price, Category = category, Id = idIterator });

                            if (iterator > 0)
                            {
                                Console.WriteLine("\n1) Add another one.");
                                Console.WriteLine("2) Stop");
                                Console.Write("Your choise: ");
                                exit = int.Parse(Console.ReadLine());
                                
                            }
                            iterator++;
                        }
                        exit = 0;
                        break;
                    case 3:
                        Console.Write("\nEnter product ID: ");
                        productId = int.Parse(Console.ReadLine());
                        productId -= 1;
                        list.RemoveAt(productId);//the indexes of the list move down and happens OutOfRangeException
                        break;
                }
            } while (choise != 0);
            
        }
    }
}
