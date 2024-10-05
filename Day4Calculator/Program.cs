using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter two numbers");
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the operator");
                char s = Console.ReadLine()[0];
                switch (s)                                                  //switch case
                {
                    case '+':
                        Console.WriteLine($"The sum is {add(num1, num2)}");   
                        break;
                    case '-':
                        Console.WriteLine(sub(num1, num2));
                        break;
                    case '*':
                        Console.WriteLine(mul(num1, num2));
                        break;
                    case '/':
                        Console.WriteLine(div(num1, num2));
                        break;
                    default:
                        Console.WriteLine("Wrong operator");
                        break;
                }
            }
        }
        static int add(int n1, int n2)                      //if operator is +
        {
            return n1 + n2;
        }
        static int sub(int n1, int n2)
        {
            return n1 - n2;
        }
        static int mul(int n1, int n2)
        {
            return n1 * n2;
        }
        static double div(int n1, int n2)
        {
            return n1 / n2;
        }
    }
}
