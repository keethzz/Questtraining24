using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13qs1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 1, 3, 4, 5, 6, 7, 8, 9, 10 };
            var first = arr.First();
            Console.WriteLine(first);

            var last = arr.Last();
            Console.WriteLine(last);

            var lasdefault = arr.LastOrDefault();
            Console.WriteLine(lasdefault);

            var sortedacs = arr.OrderBy(x => x);
            Console.WriteLine(string.Join(", ", sortedacs));
            Console.WriteLine(string.Join(", ",arr.OrderByDescending(x=>x)));

            var mini=arr.Where(x => x > 5).Min();
            Console.WriteLine(mini);

            var maxm=arr.Where(x => x < 5).Max();
            Console.WriteLine(maxm);

            var count =arr.Count();
            Console.WriteLine(count);

            var distinct = arr.Distinct();
            Console.WriteLine(string.Join(", ", distinct));

            var first5= arr.Take(5);
            Console.WriteLine(string.Join(", ", first5));
            var skip5= arr.Skip(5);
            Console.WriteLine(string.Join(", ", skip5));

            // skip the element till the condition breaks
            var takewhile = arr.TakeWhile(x => x<5);
            Console.WriteLine(string.Join(", ", takewhile));
            var skipwhile = arr.SkipWhile(x => x<5);
            Console.WriteLine(string.Join(", ", skipwhile));

            var where= arr.Where(x => x<5);
            Console.WriteLine(string.Join(", ", where));



            var skip3= arr.Skip(3).Take(5).Where(x=>x%2==0).Sum();
            Console.WriteLine(skip3);
        }
    }
}
