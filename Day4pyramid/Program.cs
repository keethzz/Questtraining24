using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4pyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the limit");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();

            }
            Console.WriteLine("Enter the limit");
            int a = 1;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("{0,2}", a);  //Console.Write($"{num1+j-1, -3}"); for perfect allignment for more than 4 lines.
                    a ++;
                }
                Console.WriteLine();
            }
        }
    }
}
