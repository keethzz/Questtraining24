using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day22prime
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a number:");
            int n = int.Parse(Console.ReadLine());

            if (Prime(n))
                Console.WriteLine($"{n} is prime number.");
            else
                Console.WriteLine($"{n} is not prime number.");
        }
        static bool Prime(int num)
        {
            if (num <= 1)
            { 
            return false;
            }
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                    return false; 
            }
            return true;
        }
    }
}
