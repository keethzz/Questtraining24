using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4stringupper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arr = new string[] { "How", "are", "you" };
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i].ToUpper());
            }
        }
    }
}
