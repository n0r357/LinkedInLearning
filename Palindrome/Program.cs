using System;
using System.Text;

namespace Pallindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Pallindrome pd = new Pallindrome();

            (bool isTrue, int length) result;
            string input = "";
            while (input != "exit")
            {
                Console.Write("Input: ");
                input = Console.ReadLine();
                if(input != "exit")
                {
                    result = pd.IsPalindrome(input);
                    Console.WriteLine($"Palindrome: {result.isTrue}, Length: {result.length}");
                }
            }
        }
    }
}