using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5age
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myDt = new DateTime(2001, 11, 28);
            Console.WriteLine(myDt);
            Console.WriteLine("Enter date of birth");
            var yrDt = Console.ReadLine();
            var dt = DateTime.Parse(yrDt);
            int yrdiff = Math.Abs(myDt.Year - dt.Year);
            int modiff= Math.Abs(myDt.Month - dt.Month);
            int daydiff = Math.Abs(myDt.Day - dt.Day);
            Console.WriteLine($"{yrdiff} {modiff} {daydiff}");
            
        }
    }
}
