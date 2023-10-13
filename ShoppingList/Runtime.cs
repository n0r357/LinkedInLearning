using ShoppingList.DataStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingList
{
    internal class Runtime
    {
        public void Start()
        {
            bool loop = true;
            ShoppingCart list = new ShoppingCart();

            while (loop)
            {
                switch (UI.MainMenu(list.ShoppingList))
                {
                    case ConsoleKey.D1:
                        list.AddItem();
                        break;
                    case ConsoleKey.D2:
                        list.RemoveItem();
                        break;
                    case ConsoleKey.D3:
                        loop = false;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
