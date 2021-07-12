using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNET_shop
{
    class Menu
    {
        private string Title { get; set; }
        public Action Action { get; set; }
        private List<Menu> MenuItems = new List<Menu>();
        private List<Menu> SubItems = new List<Menu>();

        private Product product = new Product();
        private void Initialize()
        {

            MenuItems.Add(new Menu
            {
                Title = "Product",
                Action = null,
                SubItems = new List<Menu>
                {
                    new Menu
                    {
                        Title = "Show Products",
                        SubItems = new List<Menu>
                        {
                            new Menu
                            {
                                Title = "Show All",
                                Action = product.GetAllProducts

                            },
                            new Menu
                            {
                                Title = "Filter"
                                //Action
                            },
                        }
                    },
                    new Menu
                    {
                        Title = "Add Product",
                        Action = product.AddProduct
                    },
                    new Menu
                    {
                        Title = "Delete Product",
                        Action = product.RemoveProduct
                    }
                }
            });
            MenuItems.Add(new Menu
            {
                Title = "Category",
                Action = null,
                SubItems = new List<Menu>
                {
                    new Menu
                    {
                        Title = "Show Categories",
                        SubItems = new List<Menu>
                        {
                            new Menu
                            {
                                Title = "Show All"
                               // Action = category.ShowCategory
                                
                            },
                            new Menu
                            {
                                Title = "Filter"
                                //Action
                            },
                        }
                    },
                    new Menu
                    {
                        Title = "Add Category"
                        //Action = category.AddCategory
                    },
                    new Menu
                    {
                        Title = "Delete Category"
                        //Action = category.RemoveCategory
                    }
                }
            });
            MenuItems.Add(new Menu 
            {
                Title = "Exit"
                //Action = exit
            });
        }
        private void ShowMenu()
        {
            /*ConsoleKeyInfo key;
            int currentPos = 0;
            do
            {
                for (int i = 0; i < MenuItems.Count; i++)
                {
                    if (currentPos == i)
                    {
                        Console.Write($" => {MenuItems[i].Title}\n");
                    }
                    else
                    {
                        Console.WriteLine(MenuItems[i].Title);
                    }
                }

                key = Console.ReadKey();
            } while (key.Key != ConsoleKey.Escape);*/





               /* foreach (Menu mainMenu in MenuItems)
                {
                    Console.WriteLine(mainMenu.Title);
                    foreach (Menu subMenu in mainMenu.SubItems)
                    {
                        Console.WriteLine($"   {subMenu.Title}");
                        foreach (Menu lastMenu in subMenu.SubItems)
                        {
                            Console.WriteLine($"      {lastMenu.Title}");
                        }
                    }
                }*/

            for (int i = 0; i < MenuItems.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {MenuItems[i].Title}");
                for (int j = 0; j < MenuItems[i].SubItems.Count; j++)
                {
                    Console.WriteLine($"    {j + 1}.{MenuItems[i].SubItems[j].Title}");
                    for (int k = 0; k < MenuItems[i].SubItems[j].SubItems.Count; k++)
                    {
                        Console.WriteLine($"         {k + 1}.{MenuItems[i].SubItems[j].SubItems[k].Title}");
                    }
                }
            }
        }
        public void GetMenu()
        {
            Initialize();
            ShowMenu();
        }
    }
}

