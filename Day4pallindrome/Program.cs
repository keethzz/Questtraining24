using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4pallindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "malayalam";
            var rev = string.Concat(s.Reverse());   //reversing string and then concatinating

            if (s == rev)
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not a palindrome");
            }
        }
    }
}
