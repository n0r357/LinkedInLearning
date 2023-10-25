using System;
using System.Collections.Generic;
using System.Linq;

namespace seasonstats
{
    class MainClass
    {
        /*
         * Challenge:
         * - Write a C# function that takes a list of scores and compute the lowest and highest values, as well as the sum and average of all scores.
         */
        public static void Main(string[] args)
        {
            // MARK: Setup
            List<int> scores = new List<int>();

            for(int i = 1; i < 4; i++)
            {
                Console.WriteLine($"How many points did you score in game #{i}?");
                int input = int.Parse(Console.ReadLine());
                scores.Add(input);
            }

            // MARK: Result
            PrintStats(scores);
            Console.ReadKey();
        }

        // MARK: Write your solution here
        public static void PrintStats(List<int> scores)
        {
            scores.Sort((x, y) => x.CompareTo(y));
            int lowest = scores.First();
            int highest = scores.Last();
            int total = scores.Sum();
            double result = scores.Average();

            List<Tuple<string, string>> results = new List<Tuple<string, string>>();
            results.Add(new Tuple<string, string>("Lowest scoring game -> ", lowest.ToString()));
            results.Add(new Tuple<string, string>("Highest scoring game -> ", highest.ToString()));
            results.Add(new Tuple<string, string>("Total season points -> ", total.ToString()));
            results.Add(new Tuple<string, string>("Average points per game-> ", result.ToString()));
            
            foreach(var input in results)
            {
                Console.WriteLine($"{input.Item1}{input.Item2}");
            }
        }
    }
}