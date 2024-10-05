using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3arrayresize
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 };
            //arr[3] = 4 not possible so resize the array using Resize function
            Array.Resize(ref arr, arr.Length * 2);
            arr[3] = 4;
            arr[4] = 5;
            Console.WriteLine(arr.Length);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
        }
    }
}
