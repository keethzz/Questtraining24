using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3nullablearray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "abc", "b", "c" };
            string[] nullNames = new string[3];
            Console.WriteLine(names[0].ToUpper());
            Console.WriteLine(nullNames[0]?.ToUpper());         // prints nothing becz uses null array
        }
    }
}
