using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;

namespace reflection
{
    /*
     * Challenge:
     * - Write a C# function that can find all concrete classes that inherit from a given abstract class.
     * 
     * Criteria:
     * - Return list of all types.
     */
    class MainClass
    {
        public static void Main(string[] args)
        {
            // MARK: Setup
            Console.WriteLine("Hit ENTER to find the vehicles you're looking for!");
            Console.ReadKey();

            // MARK: Result
            var models = GetModels(typeof(Car));
            foreach (var model in models)
            {
                Console.WriteLine(model.Name);
            }
            Console.ReadKey();
        }

        // MARK: Write your solution here...
        public static List<Type> GetModels(Type car)
        {
            return Assembly.GetExecutingAssembly().GetTypes().Where(t => t.IsSubclassOf(car)).ToList();
        }
    }
}