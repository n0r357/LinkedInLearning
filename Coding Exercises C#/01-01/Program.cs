using System;

namespace voting
{
    /*
     * Challenge:
     * - Write a C# function that computes how many times a person has voted for a president.
     */
    class MainClass
    {
        public static void Main(string[] args)
        {
            // MARK: Setup
            Console.WriteLine("How old are you?");
            int input = int.Parse(Console.ReadLine());

            // MARK: Result
            var presidents = CalculatePresidents(input);
            Console.WriteLine($"You've voted for {presidents} presidents!");
            Console.ReadKey();
        }

        // MARK: Write your solution here
        // Easy solution
        public static int CalculatePresidents(int age)
        {
            if (age <= 18)
            {
                Console.WriteLine("Not able to vote!");
                return 0;
            }
            else
            {
                return (age - 18) / 4;
            }
        }

        // Alternative using for-loop and modulus
        //public static int CalculatePresidents(int age)
        //{
        //    int votingYears = age - 18;
        //    int votes = 0;

        //    if (votingYears <= 0)
        //    {
        //        Console.WriteLine("Not able to vote!");
        //        return 0;
        //    }
        //    else
        //    {
        //        for (int i = 1; i <= votingYears; i++)
        //        {
        //            if(i % 4 == 0)
        //            {
        //                votes++;
        //            }
        //        }
        //        return votes;
        //    }
        //}
    }
}