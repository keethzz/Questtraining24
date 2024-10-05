using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4stringreplace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string arr = "This is a long text";
            string rep = Console.ReadLine();
            Console.WriteLine(arr.Replace("This", rep));
        }
    }
}
