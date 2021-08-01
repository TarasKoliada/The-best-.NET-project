using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNET_shop
{
    class ProductLogic
    {
        public void Start()
        {
            var getProd = new GetProduct();
            var add = new ProductAdding();
            var remove = new ProductRemoving();
            int choise;
            string strChoise;
            do
            {
                TextInfoClass.ShowChoiseProductMenu();
                strChoise = Console.ReadLine();
                Console.Clear();
                if (int.TryParse(strChoise, out choise))
                {
                    switch (choise)
                    {
                        case 1:
                            getProd.Show();
                            break;
                        case 2:
                            add.AddProduct();
                            break;
                        case 3:
                            remove.RemoveProduct();
                            break;
                        case 0: 
                            break;
                    }
                }
                else
                {
                    TextInfoClass.ErrorMsg();
                }
            } while (choise != 0);
        }
    }
}
