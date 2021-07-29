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
        private Category category = new Category();

        //ConsoleKeyInfo keyPushed, subKeyPushed;
        //int mainMenuPosition = 0;
        //int subMenuPosition = 0;
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
                                Title = "Show All",
                                Action = category.ShowCategory
                                
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
                        Title = "Add Category",
                        Action = category.AddCategory
                    },
                    new Menu
                    {
                        Title = "Delete Category",
                        Action = category.RemoveCategory
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
        public void NavMenu()
        {
            ConsoleKeyInfo keyPushed, subKeyPushed;
            int mainMenuPosition = 0;
            int subMenuPosition = 0;
            do
            {
                for (int i = 0; i < MenuItems.Count; i++)
                {

                    if (i == mainMenuPosition)
                    {

                        Console.WriteLine($"-> {i + 1}. {MenuItems[i].Title}");
                        if (subMenuPosition == 1)
                        {
                            do
                            {
                                for (int j = 0; j < MenuItems[i].SubItems.Count; j++)
                                {
                                    if (j == subMenuPosition - 1)
                                    {
                                        Console.WriteLine($"   -> {j + 1}.{MenuItems[i].SubItems[j].Title}");
                                    }
                                    else
                                    {
                                        Console.WriteLine($"     {j + 1}.{MenuItems[i].SubItems[j].Title}");
                                    }
                                }
                                ///
                                subKeyPushed = Console.ReadKey();
                                if (subKeyPushed.Key == ConsoleKey.DownArrow)
                                {
                                    Console.Clear();
                                    subMenuPosition++;
                                    if (subMenuPosition == MenuItems[i].SubItems.Count + 1)
                                    {
                                        subMenuPosition = 1;
                                    }
                                }
                                if (subKeyPushed.Key == ConsoleKey.UpArrow)
                                {
                                    Console.Clear();
                                    subMenuPosition--;
                                    if (subMenuPosition == 0)
                                    {
                                        subMenuPosition = MenuItems[i].SubItems.Count;
                                    }
                                }
                                if (subKeyPushed.Key == ConsoleKey.LeftArrow)
                                {
                                    Console.Clear();
                                    NavMenu();
                                }
                            } while (subKeyPushed.Key != ConsoleKey.Escape);
                            ///
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{i + 1}. {MenuItems[i].Title}");
                    }
                }
                keyPushed = Console.ReadKey();
                if (keyPushed.Key == ConsoleKey.DownArrow)
                {
                    Console.Clear();
                    subMenuPosition = 0;
                    mainMenuPosition++;
                    if (mainMenuPosition == MenuItems.Count)
                    {
                        mainMenuPosition = 0;
                    }
                }
                if (keyPushed.Key == ConsoleKey.UpArrow)
                {

                    Console.Clear();
                    subMenuPosition = 0;
                    mainMenuPosition--;
                    if (mainMenuPosition < 0)
                    {
                        mainMenuPosition = MenuItems.Count - 1;
                    }
                }
                if (keyPushed.Key == ConsoleKey.RightArrow)
                {
                    Console.Clear();
                    subMenuPosition = 0;
                    subMenuPosition++;
                }
                if (keyPushed.Key == ConsoleKey.LeftArrow)
                {
                    Console.Clear();
                    subMenuPosition = 0;
                    subMenuPosition--;
                }
            } while (keyPushed.Key != ConsoleKey.Escape);
        }
        public void GetMenu()
        {
            Initialize();
            //ShowMenu();
            NavMenu();
        }
    }
}
