using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingList
{
    internal class UI
    {
        public static ConsoleKey MainMenu(List<Item> shoppingList)
        {
            PrintShoppingList(shoppingList);
            Console.WriteLine("Total cost: {0}", shoppingList.Sum(cost => cost.Price * cost.Quantity));
            LargeMenuBar();
            Console.WriteLine("1 - Add item to cart");
            Console.WriteLine("2 - Remove item from cart");
            Console.WriteLine("3 - Quit program");
            SmallMenuBar();
            ConsoleKey input = Console.ReadKey(true).Key;
            return input;
        }
        public static void PrintShoppingList(List<Item> shoppingList)
        {
            Console.Clear();
            ListMenuBar();
            for (int i = 0; i < shoppingList.Count; i++)
            {
                Console.WriteLine("{0,-5}\t{1}", i + 1, shoppingList[i].ToString());
            }
            LargeMenuBar();
        }
        public static Item AddItemToCart()
        {
            Item newItem = new Item
            {
                ItemName = AskForName(),
                Price = AskForPrice(),
                Quantity = AskForQuantity()
            };
            return newItem;
        }
        private static string AskForName()
        {
            Console.Write("Name: ");
            string input = Console.ReadLine();
            return input;
        }
        private static double AskForPrice()
        {
            double input;
            do
            {
                Console.Write("Price: ");
            }
            while (!double.TryParse(Console.ReadLine(), out input));
            return input;
        }
        private static int AskForQuantity()
        {
            int input = -1;
            while (input == -1)
            {
                try
                {
                    Console.Write("Quantity: ");
                    int checkInput = int.Parse(Console.ReadLine());
                    input = checkInput;
                }
                catch
                {
                    Console.WriteLine("Not a valid number!");
                }
            }
            return input;
        }
        public static int SelectItemFromList(List<Item> shoppingList)
        {
            PrintShoppingList(shoppingList);
            Console.Write("Choice: ");
            int input = int.Parse(Console.ReadLine()) - 1;
            return input;
        }
        private static void ListMenuBar()
        {
            LargeMenuBar();
            Console.WriteLine("{0,-5}\t{1,-15}\t{2,-10}\t{3,-5}", "Index:", "Name:", "Price:", "Quantity:");
            LargeMenuBar();
        }
        private static void SmallMenuBar()
        {
            Console.WriteLine("-------------------------");
        }
        private static void LargeMenuBar()
        {
            Console.WriteLine("-------------------------------------------------");
        }
    }
}
