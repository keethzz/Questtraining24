using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16refandout
{
    internal class Program
    {
            static void Main()
            {
                int a = 5; 
                RefExample(ref a); // Use ref               
                int b; // Not initialized
                OutExample(out b); // Use out
            }

            static void RefExample(ref int x)
            {
                x += 10; // Changes original value
                Console.WriteLine("After ref: " + x); // Output: 15
            }

            static void OutExample(out int y)
            {
                y = 10; // Must assign value
                Console.WriteLine("After out: " + y); // Output: 10
            }
     }
}
