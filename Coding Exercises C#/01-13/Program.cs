using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

namespace sendingnewsletters
{
    class MainClass
    {
        /*
         * Challenge:
         * - Write a C# function that searches a JSON payload for a specific property.
         * 
         * Criteria:
         * - Fast data access
         * - Read-only
         * - No serialization needed
         * - Present a list of user-IDs that are missing email.
         */
        public static void Main(string[] args)
        {
            // MARK: Setup
            string jsonString =
            @"{
              ""Name"": ""Weekly Comics Newsletter!"",
              ""Admin"": ""Jane Porter"",
              ""CreatedOn"": ""2022-01-01"",
              ""Subscribers"": [
                {
                  ""Name"": ""Jack Powell"",
                  ""ID"": 231,
                  ""Email"": ""jpowell0@hplussport.com""
                },
                {
                  ""Name"": ""Emily Garcia"",
                  ""ID"": 221
                },
                {
                  ""Name"": ""Richard Dean"",
                  ""ID"": 211
                },
                {
                  ""Name"": ""Jane Larson"",
                  ""ID"": 201,
                  ""Email"": ""jlarsone@hplussport.com""
                }
              ]
            }";

            Console.WriteLine("Hit ENTER to find out who's missing an email!\n");
            Console.ReadKey();

            // MARK: Result
            var customerIDs = DecryptJSON(jsonString);
            foreach (var id in customerIDs)
            {
                Console.WriteLine($"\nSend missing info prompt to user ID: {id}");
            }
            Console.WriteLine("\nHit ENTER to exit program.");
            Console.ReadKey();
        }

        // MARK: Write your solution here...
        public static List<int> DecryptJSON(string json)
        {
            List<int> missingEmails = new List<int>();
            
            using (JsonDocument result = JsonDocument.Parse(json))
            {
                JsonElement root = result.RootElement;
                Console.WriteLine($"{root.GetProperty("Name")} - Admin: {root.GetProperty("Admin")} - Date: {root.GetProperty("CreatedOn")}");

                JsonElement subscribers = root.GetProperty("Subscribers");

                foreach (JsonElement subscriber in subscribers.EnumerateArray())
                {
                    Console.WriteLine($"\n{subscriber.GetProperty("Name")}");
                    if(subscriber.TryGetProperty("Email", out JsonElement email))
                    {
                        Console.WriteLine($"E-mail: {email}");
                    }else
                    {
                        Console.WriteLine("< Missing E-mail >");
                        missingEmails.Add(subscriber.GetProperty("ID").GetInt32());
                    }
                }
            }
            missingEmails.Sort();
            return missingEmails;
        }
    }
}
