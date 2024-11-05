using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day22Mostoccuringchar
{
    class Program
    {
        /*static void Main()
        {
            string s = "heellloo";
            var countchar = new Dictionary<char, int>();
            foreach (char c in s)
            {
                if (countchar.ContainsKey(c))
                    countchar[c]++;
                else
                    countchar[c] = 1;
            }
            var most = countchar.OrderByDescending(x => x.Value).First();
            var least = countchar.OrderBy(x => x.Value).First();
            Console.WriteLine($"Most occurring character: {most.Key} {most.Value}");
            Console.WriteLine($"Least occurring character: {least.Key} {least.Value}");
        }
        */
        static void Main()
        {
            string text = "heellloo";
            var result = text.ToLower()
                              .GroupBy(x => x)
                              .Select(y => new { Word = y.Key, Count = y.Count() });

            var mostOccurring = result.OrderByDescending(x => x.Count).First();
            var leastOccurring = result.OrderBy(x => x.Count).First();

            Console.WriteLine($"Most occurring word: {mostOccurring.Word} {mostOccurring.Count}");
            Console.WriteLine($"Least occurring word: {leastOccurring.Word} {leastOccurring.Count}");
        }
    }
}
