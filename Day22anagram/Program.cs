using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day22anagram
{
    internal class Program
    {
        static void Main(string[] args)
        {
                string str1 = "listen";
                string str2 = "silent";
                bool isAnagram = IsAnagram(str1, str2);
                Console.WriteLine(isAnagram ? "Anagram" : "Not anagram");
        }
        static bool IsAnagram(string s1, string s2)
        {
            if (s1.Length == s2.Length && s1.OrderBy(c => c).SequenceEqual(s2.OrderBy(c => c)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
