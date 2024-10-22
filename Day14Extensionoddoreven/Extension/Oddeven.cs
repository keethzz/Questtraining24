using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14Extensionoddoreven.Extension
{
    internal static class Oddeven
    {
        public static bool IsEven(this int number)
        {
            return number % 2 == 0; // Returns true if the number is divisible by 2
        }

        // Extension method to check if a number is odd
        public static bool IsOdd(this int number)
        {
            return number % 2 != 0; // Returns true if the number is not divisible by 2
        }
    }
}
