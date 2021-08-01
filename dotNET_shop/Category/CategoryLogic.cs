using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNET_shop
{
    class CategoryLogic
    {
        public void Start()
        {
            var addCategory = new CategoryAdding();
            var getCategory = new GetCategory();
            var removeCategory = new CategoryRemoving();
            int choise;
            string strChoise;
            do
            {

                TextInfoClass.ShowChoiseCategoryMenu();
                strChoise = Console.ReadLine();
                Console.Clear();
                if (int.TryParse(strChoise, out choise))
                {
                    switch (choise)
                    {
                        case 1:
                            addCategory.AddCategory();
                            break;
                        case 2:
                            getCategory.Show();
                            break;
                        case 3:
                            removeCategory.RemoveCategory();
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
