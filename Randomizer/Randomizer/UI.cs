using Randomizer.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randomizer
{
    internal class UI
    {
        public static void StartRandomizer()
        {
            NumberGenerator numberGenerator = new NumberGenerator();
            string input;
            do
            {
                Console.Write("Enter a number for the upper bound: ");
                input = Console.ReadLine();
                try
                {
                    double upperBoundNumber = Double.Parse(input);
                    double randomNumber = numberGenerator.GetRandomNumber(upperBoundNumber);
                    Console.WriteLine("Random number between 0 and {0}: {1}", upperBoundNumber, randomNumber);
                }
                catch (Exception){}
            }
            while (input != "exit");
        }
    }
}
