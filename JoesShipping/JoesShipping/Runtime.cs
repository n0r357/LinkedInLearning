using JoesShipping.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoesShipping
{
    internal class Runtime
    {
        public void Start() 
        {
            bool loop = true;
            ShippingCalculator calculator = new ShippingCalculator();

            while (loop)
            {
                switch (UI.MainMenu())
                {
                    case ConsoleKey.D1: //Zone 1 - 25%
                        Console.WriteLine("Zone 1");
                        UI.Continue();
                        break;
                    case ConsoleKey.D2: //Zone 2 - 12% (high risk)
                        Console.WriteLine("Zone 2");
                        UI.Continue();
                        break;
                    case ConsoleKey.D3: //Zone 3 - 8%
                        Console.WriteLine("Zone 3");
                        UI.Continue();
                        break;
                    case ConsoleKey.D4: //Zone 4 - 4% (high risk)
                        Console.WriteLine("Zone 4");
                        UI.Continue();
                        break;
                    case ConsoleKey.D5: //Exit program
                        loop = false;
                        break;
                    default:
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }
            }
        }
    }
}
