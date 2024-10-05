using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4stringoccurance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "this is long long word";
            string[] arr = text.Split(' ');
            string[] next = new string[arr.Length];
            int found = 0;
            foreach (var item in arr)
            {
                if (next.Contains(item))
                {
                    continue;
                }
                int count = 0;
                foreach (var word in arr)
                {
                    if (item == word)
                    {
                        count++;
                    }
                }
                next[found++] = item;
                Console.WriteLine(count);
            }
        }
    }
}
