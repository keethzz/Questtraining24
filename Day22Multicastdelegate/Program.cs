using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Day22Multicastdelegate
{
    internal class Program
    {
        delegate void Math(int x, int y);
        static void Add(int x, int y)=> Console.WriteLine(x+y);
        static void Sub(int x, int y) => Console.WriteLine(x - y);
        static void Mul(int x, int y) => Console.WriteLine(x * y);

        static void Main(string[] args)
        {
            Math m = Add;
            m += Sub;
            m += Mul;
            m(1, 2);
        }
    }
}
