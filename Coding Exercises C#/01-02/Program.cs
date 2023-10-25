using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace validatingemails
{
    class MainClass
    {
        /*
         * Challenge:
         * - Write a C# function that checks if an email passes validation criteria.
         * 
         * Criteria:
         * - First character can't be a symbol or number.
         * - Must contain the @ symbol.
         * - Must end with ".com"
         */
        public static void Main(string[] args)
        {
            // MARK: Setup
            Console.WriteLine("Enter the email address you'd like to validate:");
            var input = Console.ReadLine();

            // MARK: Result
            ValidateEmail(input);
            Console.ReadKey();
        }

        // MARK: Write your solution here
        // Regex solution
        public static void ValidateEmail(string email)
        {
            Regex regex = new Regex(@"^[a-z]+@[0-9a-z]+\.com$");
            Match match = regex.Match(email);
            if (match.Success)
            {
                Console.WriteLine(email + " is correct");
            }
            else
            {
                Console.WriteLine(email + " is incorrect");
            }
        }

        //Alternative
        //public static void ValidateEmail(string email)
        //{
        //    char start = email[0];
        //    string middle = "@";
        //    string end = ".com";

        //    if(Char.IsNumber(start) || Char.IsSymbol(start))
        //    {
        //        Console.WriteLine(email + " is incorrect, cant start with number or symbol!");
        //        return;
        //    }

        //    if (!email.Contains(middle))
        //    {
        //        Console.WriteLine(email + " is incorrect, missing the '@' character in the middle!");
        //        return;
        //    }

        //    if(email.Substring(email.Length -4) != end)
        //    {
        //        Console.WriteLine(email + " is incorrect, missing '.com' at the end!");
        //        return;
        //    }
        //    Console.WriteLine(email + " is correct");
        //}
    }
}