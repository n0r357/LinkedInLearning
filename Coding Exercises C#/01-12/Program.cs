using System;
using System.Collections.Generic;
using System.Linq;

namespace gamenight
{
    /*
     * Challenge:
     * - Write a C# function that finds all the players who have higher scores then the last time they played.
     * 
     * Criteria:
     * - Return players with a selected improvement of their score and present them in order by the first letter in their last name.
     */
    class MainClass
    {
        public static List<Player> players = new List<Player>()
        {
            new Player("Harrison", "Ferrone", 233, 198),
            new Player("Alex", "Ferrone", 219, 202),
            new Player("Haley", "Ferrone", 241, 222),
            new Player("John", "Doe", 144, 198),
            new Player("Sally", "Doe", 233, 198),
            new Player("Frank", "Smith", 189, 234),
            new Player("Joan", "Smith", 211, 178)
        };

        public static void Main(string[] args)
        {
            // MARK: Setup
            Console.Write("Enter an improvement index to see which game night attendees fit the bill: ");
            var targetImprovement = int.Parse(Console.ReadLine());

            // MARK: Result
            PrintStats(targetImprovement);
            Console.ReadKey();
        }

        // MARK: Write your solution here...
        public static void PrintStats(int targetImprovement)
        {
            Console.WriteLine($"\nThe following players improved their score by {targetImprovement} or more:");
            var results = players.Where(x => x.currentScore - x.lastScore >= targetImprovement).OrderBy(x => x.lastname).ThenBy(x => x.firstname).GroupBy(x => x.lastname.ElementAt(0)).ToList();
            foreach (var group in results)
            {
                Console.WriteLine($"\n{group.Key}");
                foreach (var player in group)
                {
                    Console.WriteLine($"{player.firstname} {player.lastname} improved by {player.currentScore - player.lastScore}.");
                }
            }
        }
    }
}