using System;

namespace decomposingurls
{
    class MainClass
    {
        /*
         * Challenge:
         * - Write a function that breaks down a URL into its component paths and print out to the console.
         */
        public static void Main(string[] args)
        {
            // MARK: Setup
            string exampleURL = "www.docs.microsoft.com/dotnet/csharp/whats-new/csharp-version-history";
            Console.WriteLine($"Hit ENTER to break down the URL into its component parts: {exampleURL}");
            Console.ReadKey();

            // MARK: Result
            var components = BreakdownURL(exampleURL);
            for (int i = 0; i < components.Length; i++)
            {
                var indent = new string(' ', i * 2);
                Console.WriteLine($"{indent} -> {components[i]}");
            }
        }

        // MARK: Calculation
        public static string[] BreakdownURL(string urlString)
        {
            string[] splits = urlString.Replace("www.", "").Replace("-", " ").Split('/');

            return splits;
        }
    }
}