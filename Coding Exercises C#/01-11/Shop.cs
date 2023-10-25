using System;
using System.Collections.Generic;

namespace shopinventory
{
    public class Shop
    {
        private Dictionary<int, string> inventoryProperties = new Dictionary<int, string>();
        private Dictionary<int, string> inventoryMethods = new Dictionary<int, string>();

        // MARK: Write your solution here
        // Using properties
        public string this[int index]
        {
            get 
            {
                if(inventoryProperties.TryGetValue(index, out string value))
                {
                    return value;
                }
                else
                {
                    throw new Exception("Properties - Item doesn't exist or hasn't been assigned.");
                }
            } 
            set 
            {
                if (inventoryProperties.ContainsKey(index) || inventoryProperties.ContainsValue(value))
                {
                    throw new Exception("Properties - Duplicates can't be added.");
                }
                else
                {
                    inventoryProperties.Add(index, value);
                }

            } 
        }

        // Using methods
        public void AddToInventory(int index, string item)
        {
            if (inventoryMethods.ContainsKey(index) || inventoryMethods.ContainsValue(item))
            {
                throw new Exception("Methods - Duplicates can't be added.");
            } else
            {
                inventoryMethods.Add(index, item);
            }
        }

        public void RemoveFromInventory(int index)
        {
            if (inventoryMethods.ContainsKey(index) == true)
            {
                inventoryMethods.Remove(index);
            }
        }

        public void GetItemFromInventory(int index) 
        {
            if (inventoryMethods.ContainsKey(index) == true)
            {
                Console.WriteLine($"Value: {inventoryMethods[index]}");
            } else
            {
                throw new Exception("Methods - Item doesn't exist or hasn't been assigned.");
            }
        }

        public void GetAllItemsFromInventory()
        {
            foreach (var itemProperties in inventoryProperties)
            {
                Console.WriteLine($"Properties - Index: {itemProperties.Key} Value: {itemProperties.Value}");
            }
            foreach (var itemMethods in inventoryMethods)
            {
                Console.WriteLine($"Methods - Index: {itemMethods.Key} Value: {itemMethods.Value}");
            }
        }
    }
}