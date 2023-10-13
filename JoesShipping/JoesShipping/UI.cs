using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoesShipping
{
    internal class UI
    {
        public static ConsoleKey MainMenu()
        {
            PrintShippingMenu();
            Console.WriteLine("1 - Zone 1");
            Console.WriteLine("2 - Zone 2");
            Console.WriteLine("3 - Zone 3");
            Console.WriteLine("4 - Zone 4");
            Console.WriteLine("5 - Exit");
            SmallMenuBar();
            ConsoleKey input = Console.ReadKey(true).Key;
            return input;
        }
        public static void Continue()
        {
            SmallMenuBar();
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
            Console.Clear();
        }
        private static void PrintShippingMenu()
        {
            //Console.Clear();
            SmallMenuBar();
            Console.WriteLine("Joe's Shipping Calculator");
            SmallMenuBar();
        }
        private static void SmallMenuBar()
        {
            Console.WriteLine("-------------------------");
        }
    }
}
