using System;
using System.Collections.Generic;
using System.Timers;

namespace affirmingwords
{
    /*
     * Challenge:
     * Write a C# program with a repeating timer.
     * 
     * Criteria:
     * - Random phrase printed at set interval.
     * - Exit program by pressing ENTER.
     */
    class MainClass
    {
        static Timer timer = new Timer();
        static Random random = new Random();
        static int lastRandom = -1;
        static List<string> encouragements = new List<string>()
        {
            "Way to go!",
            "Keep it up!",
            "Almost there!",
            "You're doing great!"
        };

        public static void Main(string[] args)
        {
            bool loop = true;

            do
            {
                // MARK: Setup
                Console.Write("Set timer interval (seconds): ");
                string input = Console.ReadLine();

                // MARK: Result
                if(Int32.TryParse(input, out int interval))
                {
                    StartTimer(interval);
                }

                Console.WriteLine("You can end the timer anytime by pressing ENTER.\n");
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                if (keyInfo.Key == ConsoleKey.Enter)
                {
                    loop = StopTimer();
                }
            } while (loop);
        }

        // MARK: Write your solution here...
        public static void StartTimer(int interval)
        {
            timer.Elapsed += new ElapsedEventHandler(RandomEncouragement);
            timer.Interval = interval * 1000;
            timer.Start();
        }

        public static bool StopTimer()
        {
            timer.Stop();
            timer.Dispose();
            Console.WriteLine("\nProgram terminated.");
            return false;
        }

        public static void RandomEncouragement(object source, ElapsedEventArgs e)
        {
            int newRandom = random.Next(0, encouragements.Count);
            while(newRandom == lastRandom)
            {
                newRandom = random.Next(0, encouragements.Count);
                if (newRandom != lastRandom) break;
            }
            lastRandom = newRandom;
            string encouragement = encouragements[newRandom];
            Console.WriteLine(encouragement);
        }
    }
}