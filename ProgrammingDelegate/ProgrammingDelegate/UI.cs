using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingDelegate
{
    internal class UI
    {
        public static ConsoleKey MainMenu()
        {
            Console.Clear();
            SmallMenuBar();
            Console.WriteLine("1 - Zone 1");
            Console.WriteLine("2 - Zone 2");
            Console.WriteLine("3 - Zone 3");
            Console.WriteLine("4 - Zone 4");
            Console.WriteLine("5 - Zone 5");
            Console.WriteLine("6 - Exit program");
            SmallMenuBar();
            ConsoleKey input = Console.ReadKey(true).Key;
            return input;
        }
        public static decimal AskForPrice()
        {
            Console.Write("Item price: ");
            string inputString = Console.ReadLine();
            decimal outputPrice = decimal.Parse(inputString);
            return outputPrice;
        }
        public static void AddPotetialHighRiskFee(decimal inputShippingFee, bool isHighRisk)
        {
            if (isHighRisk)
            {
                inputShippingFee += 25.0m;
            }
            Console.WriteLine("The shipping fees are: {0}, shipment is high risk: {1}", inputShippingFee, isHighRisk);
            Console.ReadKey();
        }
        private static void SmallMenuBar()
        {
            Console.WriteLine("------------------------------");
        }
    }
}
