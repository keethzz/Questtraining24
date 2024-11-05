using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day22Arraysorting
{
    class Program
    {
        static void Main()
        {
            int[] arr = {1,2,3,4,5,6};
            for (int i = 0; i < arr.Length-1; i++)
            {
                for (int j = 0; j < arr.Length-i-1; j++)
                {
                    if (arr[j] < arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
        }
    }
}
