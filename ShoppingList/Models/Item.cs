using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingList
{
    internal class Item
    {
        public string ItemName { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public override string ToString()
        {
            return String.Format("{0,-15}\t{1,-10:C}\t{2,-5}", ItemName, Price, Quantity);
        }
    }
}
