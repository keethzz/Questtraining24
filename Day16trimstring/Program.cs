using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16trimstring
{
    internal class Program
    {
        static bool TrimToFiveChars(ref string data)
        {
            if (data.Length > 5)
            {
                data = data.Substring(0, 5); // Corrected: Assign the trimmed value
                return true; // Return true when trimmed
            }
            return false; // Return false when no trimming is needed
        }

        static void Main(string[] args)
        {
            string text = "Old Data";
            if (TrimToFiveChars(ref text)) // Passing by reference
            {
                Console.WriteLine(text + "..."); // Prints the trimmed data
            }
            else
            {
                Console.WriteLine(text + " (No trimming needed)"); // No trimming case
            }
        }
    }
}
