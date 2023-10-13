using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingList.DataStore
{
    internal class ShoppingCart
    {
        public List<Item> ShoppingList { get; set; }

        public ShoppingCart()
        {
            ShoppingList = new List<Item>();
        }
        public void AddItem()
        {
            ShoppingList.Add(UI.AddItemToCart());
        }
        public void RemoveItem() 
        {
            ShoppingList.RemoveAt(UI.SelectItemFromList(ShoppingList));
        }
    }
}
