using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lowtoup
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ip = "Hello World";
            string s = "";
            foreach (var chr in ip)
            {
                char res = char.IsUpper(chr) ? char.ToLower(chr) : char.ToUpper(chr);
                s = s + res;
            }
            Console.WriteLine(s);

        }
    }
}
