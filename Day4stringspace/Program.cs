using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4stringspace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arr = new string[] { "How", "are", "you" };
            var search = "  o  ";
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Contains(search.Trim().ToLower()))
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }
    }
}
