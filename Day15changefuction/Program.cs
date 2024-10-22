using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15changefuction
{
    internal class Program
    {
        static int Calc(int x, int y)
        {
            return x * y;
        }
        static int Calc(double x, double y)
        {
            return x / y;
        }
        static void Main(string[] args)
        {
            var result = Calc(1, 2);
            Console.WriteLine(result);
        }
    }
}
