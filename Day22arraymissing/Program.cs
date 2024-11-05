using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day22arraymissing
{
    internal class Program
    {
        static void Main()
        {
            int[] nums = { 1,2,3,0,5 };
            int missing = Miss(nums);
            Console.WriteLine($"Missing number: {missing}");
        }
        static int Miss(int[] nums)
        {
            int n = nums.Length;
            int realSum = n * (n + 1) / 2;
            int givenSum = 0;
            foreach (int num in nums)
            {
                givenSum += num;
            }
            return realSum - givenSum;
        }
    }
}
