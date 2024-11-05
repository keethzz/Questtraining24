using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ienumerable_collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<string> fruits = new List<string> { "Apple", "Banana", "Cherry" };
            Console.WriteLine("Using IEnumerable:");
            foreach (var fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            // Using ICollection
            ICollection<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            Console.WriteLine("\nUsing ICollection:");
            Console.WriteLine($"Count: {numbers.Count}");
            numbers.Add(6); // Adding an element
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            // Using IList
            IList<string> colors = new List<string> { "Red", "Green", "Blue" };
            Console.WriteLine("\nUsing IList:");
            Console.WriteLine($"Element at index 1: {colors[1]}"); // Accessing an element by index
            colors[1] = "Yellow"; // Modifying an element
            Console.WriteLine("Colors after modification:");
            foreach (var color in colors)
            {
                Console.WriteLine(color);
            }
        }
    }
}
