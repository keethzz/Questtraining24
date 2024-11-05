using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day22removeduplicate
{
    class Program
    {
        static void Main()
        {
            string text = "Hi hello hi";
            string[] words = text.Split(new char[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            List<string> uniques = new List<string>();

            foreach (var word in words)
            {
                string lower = word.ToLower();
                if (!uniques.Contains(lower)) 
                {
                    uniques.Add(lower);
                }
            }
            foreach (var word in uniques)
            {
                Console.Write(word+" "); 
            }
        }
    }
}
