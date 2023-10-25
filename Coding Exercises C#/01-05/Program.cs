using System;
using System.Collections.Generic;

namespace countingvowels
{
    class MainClass
    {
        /*
         * Challenge:
         * - Write a C# function that takes any word or sentence and assigns points based on each vowel and how many times it appears.
         */
        public static Dictionary<char, int> vowelScores = new Dictionary<char, int>()
        {
            { 'a', 1 },
            { 'e', 2 },
            { 'i', 3 },
            { 'o', 4 },
            { 'u', 5 },
            { 'y', 9 }
        };

        public static void Main(string[] args)
        {
            // MARK: Setup
            Console.WriteLine("Type in a word or phrase to find it's vowel score:");
            string input = Console.ReadLine().ToLower();

            // MARK: Result
            VowelCount(input);
            Console.ReadKey();
        }

        // MARK: Write your solution here
        public static void VowelCount(string text)
        {
            int total = 0;
            foreach (char c in text)
            {
                if(vowelScores.TryGetValue(c, out int score))
                {
                    total += score;
                }
            }
            Console.WriteLine($"The total score is: {total}");
        }
    }
}