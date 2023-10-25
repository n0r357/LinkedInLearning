using System;

namespace shopinventory
{
    /*
     * Challenge:
     * - Write a C# function that adds an indexer to an existing class to access its Dictionary property.
     * 
     * Criteria:
     * - Throw an error when an item doesn't exist or hasn't been assigned, or if the user tries to add a duplicate item.
     * - Handle errors in the Main program when using the indexer.
     */
    class MainClass
    {
        static Shop shopProperties = new Shop();
        public static Shop shopMethods = new Shop();
        
        public static void Main(string[] args)
        {

            // MARK: Setup
            Console.WriteLine("Add your inventory items:");

            for(int index = 0; index < 3; index++)
            {
                var item = Console.ReadLine();
                AddItem(index, item);
            }

            // MARK: Result
            Console.WriteLine("Retrieve all stored items:");
            GetAllItems();
            // Get item out of index.
            GetItem(4);
        }

        // MARK: Write your solution here
        public static void AddItem(int index, string name)
        {
            // Properties
            try
            {
                shopProperties[index] = name;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            // Methods
            try
            {
                shopMethods.AddToInventory(index, name);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        // MARK: Write your solution here
        public static void GetAllItems()
        {
            shopProperties.GetAllItemsFromInventory();
            shopMethods.GetAllItemsFromInventory();
        }

        // MARK: Write your solution here
        public static void GetItem(int index)
        {
            // Properties
            try
            {
                Console.WriteLine(shopProperties[index]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            // Methods
            try
            {
                shopMethods.GetItemFromInventory(index);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}