using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    public class NumberCollection
    {
        private int[] numbers = new int[10];

        // Indexer declaration
        public int this[int index]
        {
            get
            {
                // Check if index is valid
                if (index < 0 || index >= numbers.Length)
                {
                    throw new IndexOutOfRangeException("Index is out of range");
                }
                return numbers[index];
            }
            set
            {
                if (index < 0 || index >= numbers.Length)
                {
                    throw new IndexOutOfRangeException("Index is out of range");
                }
                numbers[index] = value;
            }
        }
    }

    // Let's try using our NumberCollection
    var collection = new NumberCollection();
    collection[0] = 100;  // Set value
Console.WriteLine($"Value at index 0: {collection[0]}");  // Get value
}
