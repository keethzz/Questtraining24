using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16indexer
{
    internal class Program
    {
        class ShoppingList
        {
            private string[] _items = new string[10]; // Corrected: use _items as the private field

            // Indexer to access items by index
            public string this[int index]
            {
                get { return _items[index]; } // Corrected: return statement
                set { _items[index] = value; } // Corrected: set logic
            }

            // Property to get the total count of non-null items
            public int TotalItems
            {
                get { return _items.Count(i => i != null); } // Corrected: Count non-null items
            }
        }

        static void Main(string[] args)
        {
            var list = new ShoppingList();
            list[0] = "apple";
            list[1] = "banana";

            // Output the total number of non-null items
            Console.WriteLine("Total Items: " + list.TotalItems);
        }
    }
}
