using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15genericpublic
{
    class MyDictionary<TKey, TValue>
    {
        private Dictionary<TKey, TValue> data = new Dictionary<TKey, TValue>();

        // Property to get the count of items in the dictionary
        public int Count => data.Count;

        // Method to add a key-value pair to the dictionary
        public void Add(TKey key, TValue value)
        {
            data.Add(key, value);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating an instance of MyDictionary
            var data = new MyDictionary<string, string>();

            // Adding a key-value pair
            data.Add("Name", "Keerthana");

            // Accessing the count of items
            Console.WriteLine("Count: " + data.Count);
        }
    }
}
