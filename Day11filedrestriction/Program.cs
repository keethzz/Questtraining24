using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11filedrestriction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NewField f = new NewField()
            {
                Age = 70,
                Name = "Abc"
            };
            Console.WriteLine(f.Name);
            Console.WriteLine(f.Age);

            
        }
    }
}
