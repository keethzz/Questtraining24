using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4stringfunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Hello World";
            // Changes to uppercase and lowercase.
            Console.WriteLine(text.ToUpper()); 
            Console.WriteLine(text.ToLower());
            
            // Removes the space before and after the s.
            string s = "  Hi every one  ";
            Console.WriteLine(s.Trim()); 
            Console.WriteLine(s.TrimStart()); 
            Console.WriteLine(s.TrimEnd()); 

            // Replace a character with other one.
            Console.WriteLine(text.Replace(" ", "-")); 

            // Remove characters from specified index to other one.
            Console.WriteLine(text.Remove(0, 7));

            // Returns length of the string specified.
            Console.WriteLine(text.Length);

            // Returns length of specified string after removal of space.
            Console.WriteLine(text.Trim().Length); // 11

            // Returns true when specified string contain given sub string.
            Console.WriteLine(text.Contains("Hello")); // true


            // Checking whether the string starts with given substring if yes returns true else false.
            Console.WriteLine(text.StartsWith("    Hello")); // true

            //Case sensitivity is removed.
            Console.WriteLine(text.StartsWith("    hello", StringComparison.OrdinalIgnoreCase)); // true
            Console.WriteLine(text.EndsWith("    ")); // true


            char[] chars = text.ToCharArray();
            Console.WriteLine(string.Join(", ", chars)); // H, e, l, l, o,  , W, o, r, l, d

            string[] words = text.Split(' ');
            Console.WriteLine(string.Join(", ", words)); // , , , , Hello,  World, , , , 

            string[] splits = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries); // Hello, World
        }
    }
}
