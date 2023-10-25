using System;
using System.Collections.Generic;

namespace fibsequence
{
    class MainClass
    {
        /*
         * Challenge:
         * - Write a C# program that produces a Fibonacci sequence matching the input length.
         * 
         * Criteria:
         * - The first two Fibonacci numbers in every sequence are 0 and 1.
         * - Each Fibonacci number is the sum of the two previous numbers.
         */
        public static void Main(string[] args)
        {
            // MARK: Setup
            Console.WriteLine("Enter the number of Fibonacci elements you'd like to calculate:");
            int input = int.Parse(Console.ReadLine());

            // MARK: Result
            var sequence = CalculateFibonacci(input);
            foreach (var fibonacci in sequence)
            {
                Console.WriteLine(fibonacci);
            }
            Console.ReadKey();
        }

        // MARK: Write your solution here
        public static List<int> CalculateFibonacci(int length)
        {
            int a = 0;
            int b = 1;
            int c = 0;

            List<int> sequence = new List<int>();
            sequence.Add(a);
            sequence.Add(b);

            for (int i = 2; i < length; i++)
            {
                c = a + b;
                sequence.Add(c);
                a = b;
                b = c;
            }
            return sequence;
        }
    }
}