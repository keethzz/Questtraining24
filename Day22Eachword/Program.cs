using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day22Eachword
{
    class Program
    {
        static void Main()
        {
            /* string text = Console.ReadLine();
             string[] words = text.Split(new char[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
             Dictionary<string, int> wordcount = new Dictionary<string, int>();
             foreach (var word in words)
             {
                 string lower = word.ToLower();
                 if (wordcount.ContainsKey(lower))
                 {
                     wordcount[lower]++;
                 }
                 else
                     wordcount[lower] = 1;
             }
             foreach (var item in wordcount)
             {
                 Console.WriteLine($"{item.Key}: {item.Value}");
             }
 */
            string text = "Hi  hello hi";
            var result = text.ToLower().Split(' ').GroupBy(x => x);
            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key} {item.Count()}");
            }
        }
    }
}
