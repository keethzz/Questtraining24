using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4stringformat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] s = { "Arun", "Varun", "Sarun" };
            for (int i = 0; i < s.Length; i++)
            {
                var a = string.Format("{0} is {1} year old.", s[i], i);
                Console.WriteLine(a);
            }
        }
    }
}
