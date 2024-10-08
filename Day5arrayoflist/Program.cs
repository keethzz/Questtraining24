using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5arrayoflist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var lst = new List<List<int>>();
            for (int i = 0; i < 2; i++)
            {
                var mark = new List<int>();
                Console.WriteLine("Enter no of marks");
                int limit = int.Parse(Console.ReadLine());
                for (int j = 0; j < limit; j++)
                {
                    Console.WriteLine($"Enter mark{j + 1}");
                    mark.Add(int.Parse(Console.ReadLine()));
                }
                lst.Add(mark);
            }
            for (int i = 0; i < lst.Count; i++)
            {
                var a = string.Join(", ", lst[i]);
                Console.WriteLine(a);
            }
        }
    }
}
