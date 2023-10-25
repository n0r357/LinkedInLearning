using System;
using System.Collections.Generic;

namespace partyrsvp
{
    class MainClass
    {
        /*
         * Challenge:
         * - Write a C# function that combines two lists, checks for duplicates and checks the combined list against a third list for overlapping items.
         * 
         * Criteria:
         * - Show total invites, duplicates and missing RSVP guests.
         */
        static List<string> family = new List<string>() { "Harrison", "Kelsey", "Alex", "Haley" };
        static List<string> friends = new List<string>() { "James", "Hannah", "Kelly", "Alex" };
        static List<string> rsvp = new List<string>() { "Kelly", "Harrison" };

        public static void Main(string[] args)
        {
            // MARK: Setup
            Console.WriteLine("Hit ENTER to see your party invite breakdown!");
            Console.ReadKey();

            // MARK: Result
            InviteDetails();
            Console.ReadKey();
        }

        // MARK: Write your solution here
        // Using HashSets
        public static void InviteDetails()
        {
            HashSet<string> invites = new HashSet<string>(family);
            invites.UnionWith(friends);
            Console.WriteLine($"Invites: {invites.Count}");

            HashSet<string> duplicates = new HashSet<string>(family);
            duplicates.IntersectWith(friends);
            Console.WriteLine($"Duplicates: {string.Join(", ", duplicates)}");

            invites.SymmetricExceptWith(rsvp);
            Console.WriteLine($"Missing: {string.Join(", ", invites)}");
        }

        // Alternative - using lists
        //public static void InviteDetails()
        //{
        //    List<string> invites = new List<string>();
        //    List<string> duplicates = new List<string>();
        //    List<string> missing = new List<string>();

        //    foreach (string name in family)
        //    {
        //        if (!invites.Contains(name))
        //        {
        //            invites.Add(name);
        //        } else
        //        {
        //            duplicates.Add(name);
        //        }
        //    }

        //    foreach (string name in friends)
        //    {
        //        if (!invites.Contains(name))
        //        {
        //            invites.Add(name);
        //        }
        //        else
        //        {
        //            duplicates.Add(name);
        //        }
        //    }

        //    foreach (string name in invites)
        //    {
        //        if (!rsvp.Contains(name))
        //        {
        //            missing.Add(name);
        //        }
        //    }

        //    Console.WriteLine($"Invites: {invites.Count.ToString()}");
        //    Console.WriteLine($"Duplicates: {string.Join(", ", duplicates)}");
        //    Console.WriteLine($"Missing: {string.Join(", ", missing)}");
        //}
    }
}