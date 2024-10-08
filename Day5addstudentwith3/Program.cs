using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5addstudentwith3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var lst = new List<List<int>>();
            // Reading 2 students 3 mark each.
            for (int i = 0; i < 2; i++)
            {
                var mark = new List<int>();
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"Enter mark{j + 1}");
                    mark.Add(int.Parse(Console.ReadLine()));
                }
                lst.Add(mark);
            }
            for (int i = 0; i < lst.Count; i++)
            {
                var a = string.Join(", ", lst[i] );               
                Console.Write(a+" ");
            }




            
             
        }
    }
}
