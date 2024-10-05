using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            greeting(num1, num2);
        }
        static void greeting(int n1, int n2)
        {
            int sum = 0;
            sum = n1 + n2;
            Console.WriteLine($"Sum = {sum}");
        }
    }
}
