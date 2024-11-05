using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day22Revstring
{
    class Program
    {
        static void Main()
        {
            string org = "Keerthana";
            string rev = "";
            for (int i = org.Length - 1; i >= 0; i--)
            {
                rev = rev + org[i]; 
            }
            Console.WriteLine(rev);
        }
    }
}
