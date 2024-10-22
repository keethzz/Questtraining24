using Day14extramethod.StringExtensionMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14extramethod
{
    internal class Program
    {
        static void Main()
        {
            string sentence = "hello world from the string extension method";
            string titleCase = sentence.ToTitleCase();
            Console.WriteLine(titleCase); // Output: Hello World From The String Extension Method
        }
    }
}
