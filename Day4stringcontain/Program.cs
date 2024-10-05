using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4stringcontain
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arr = new string[] { "How", "are", "you" };
            var search = "ow";
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Contains(search))
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }
    }
}
