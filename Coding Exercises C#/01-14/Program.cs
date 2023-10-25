using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;

namespace shufflingcards
{
    /*
     * Challenge:
     * - Write a C# function that randomly shuffles a deck of 52 card objects.
     * 
     * Criteria:
     * - Return top 5 cards from the shuffled deck.
     */
    class MainClass
    {
        public static void Main(string[] args)
        {
            // MARK: Setup
            Console.WriteLine("Hit ENTER to shuffle the deck and deal the top 5 cards!");
            Console.ReadKey();

            // MARK: Result
            var freshDeck = new Deck();

            var listWatch = Stopwatch.StartNew();
            var shuffledDeckList = ShuffleUsingList(freshDeck.cards);

            Console.WriteLine("\nUsing List:");

            foreach (var card in shuffledDeckList)
            {
                Console.WriteLine(card);
            }

            Console.WriteLine($"Using List (milliseconds): {listWatch.Elapsed.TotalMilliseconds}");
            listWatch.Stop();

            var shuffledDeckForLoop = ShuffleUsingForLoop(freshDeck.cards).Take(5);
            var loopWatch = Stopwatch.StartNew();

            Console.WriteLine("\nUsing For Loop:");

            foreach (var card in shuffledDeckForLoop) 
            { 
                Console.WriteLine(card); 
            }

            Console.WriteLine($"Using For Loop (milliseconds): {loopWatch.Elapsed.TotalMilliseconds}");
            loopWatch.Stop();

            Console.ReadKey();
        }

        // MARK: Write your solution here...
        public static List<string> ShuffleUsingList(List<string> deck)
        {
            
            List<string> shuffledDeck = new List<string>();
            var random = new Random();

            while (shuffledDeck.Count != 5)
            {
                int index = random.Next(0, deck.Count);
                shuffledDeck.Add(deck[index]);
                deck.RemoveAt(index);
            }
            return shuffledDeck;
        }

        public static List<string> ShuffleUsingForLoop(List<string> deck)
        {
            var random = new Random();

            for (int i = 0; i < deck.Count; i++)
            {
                int index = random.Next(0, deck.Count);
                string temp = deck[i];
                deck[i] = deck[index];
                deck[index] = temp;
            }
            return deck;
        }
    }
}