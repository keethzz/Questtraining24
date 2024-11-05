using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dayy22Delegate
{
    public delegate int Operation(int a, int b);

    class Program
    {
        public static int Calculate(int x, int y, Operation operation)
        {
            return operation(x, y);
        }
        public static int Add(int a, int b) => a + b;
        public static int Sub(int a, int b) => a - b;
        public static int Multiply(int a, int b)=> a * b;
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 5;
            int sum = Calculate(num1, num2, Add);
            Console.WriteLine($"Sum: {sum}");
            int product = Calculate(num1, num2, Multiply);
            Console.WriteLine($"Product: {product}");
        }
    }
}
