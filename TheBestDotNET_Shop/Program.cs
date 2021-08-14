using System;
using TheBestShop.BusinessLogic.Repositories;
using TheBestShop.Domain.Entities;

namespace TheBestDotNET_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            ProductRepository productRepo = new ProductRepository();
            int exit = 1;
            int choise = 0;
            do
            {
                TextInfoClass.ShowChoiseProductMenu();
                choise = int.Parse(Console.ReadLine());
                switch (choise)
                {
                    case 1:
                        Console.Clear();
                        foreach (var item in productRepo.GetAll())
                        {
                            Console.WriteLine("--------------------");
                            Console.WriteLine($"ID: {item.Id}\nName:{item.Name}\nPrice: {item.Price}$");
                            Console.WriteLine("--------------------");
                        }
                        break;
                    case 2:
                        Console.Clear();
                        Console.Write("Enter Product name: ");
                        product.Name = Console.ReadLine();
                        Console.Write("Enter Product price: ");
                        product.Price = decimal.Parse(Console.ReadLine());
                        productRepo.Add(product);
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        Console.Write("\nEnter ID you want to find: ");
                        int id = int.Parse(Console.ReadLine());
                        if (productRepo.GetById(id) == null)
                        {
                            Console.WriteLine($"There is no Product with ID {id}");
                        }
                        else
                        {
                            Console.WriteLine($"\nID: {productRepo.GetById(id).Id}\nName:{productRepo.GetById(id).Name}\nPrice: {productRepo.GetById(id).Price}");
                        }
                        break;
                    case 4:
                        Console.Clear();
                        Console.Write("Enter ID you want to delete: ");
                        int idDelete = int.Parse(Console.ReadLine());
                        if (productRepo.Delete(idDelete) == true)
                        {
                            Console.WriteLine($"\nProduct with ID: {idDelete} was deleted");
                        }
                        else
                        {
                            Console.WriteLine($"\nThere is no Product with ID {idDelete}");
                        }
                        break;
                }
            } while (exit == 0);

            
        }
    }
}
