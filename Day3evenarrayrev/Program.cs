using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3evenarrayrev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4};

            // Till center revrse numbers and convert to array.
            var firstHalf = numbers.Take(numbers.Length / 2).Reverse().ToArray();

            //Skip till centre element and reverse all left elemnts and convert to array.
            var secondHalf = numbers.Skip(numbers.Length / 2 + 1).Reverse().ToArray();

            firstHalf.CopyTo(numbers, 0);
            secondHalf.CopyTo(numbers, numbers.Length / 2 + 1);

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
