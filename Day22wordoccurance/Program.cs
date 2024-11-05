using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day22wordoccurance
{
    class Program
    {
        static void Main()
        {
            string text = "Hello, World! Welcome to the world of Python programming.";
            string w = "world";
            string[] words = text.ToLower().Split(new char[] { ' ', '!', '.', ',', '?' }, StringSplitOptions.RemoveEmptyEntries);
            int count = 0;
            foreach (string word in words)
            {
                if (word == w)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
