using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNET_shop
{
    class StartProgram
    {
        public void Run()
        {
            var product = new ProductLogic();
            var category = new CategoryLogic();
            string strChoise;
            int choise;
            do
            {
                TextInfoClass.ShowStartProgramMenu();
                strChoise = Console.ReadLine();
                Console.Clear();
                if (int.TryParse(strChoise, out choise))
                {
                    switch (choise)
                    {
                        case 1:
                            product.Start();
                            break;
                        case 2:
                            category.Start();
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
