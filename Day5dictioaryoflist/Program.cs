using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5dictioaryoflist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var d = new Dictionary<string, List<int>>();
            while (true)
            {
                Console.WriteLine("Enter studentID q to exit");
                var option = Console.ReadLine();

                if (option == "q")
                {
                    break;
                }
                var marks = new List<int>();
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine($"Enter mark {i+1} ");
                    var mark = int.Parse(Console.ReadLine());
                    if (!marks.Contains(mark))
                    {
                        marks.Add(mark);
                    }
                    else
                    {
                        Console.WriteLine("Already entered");
                    }
                }
                d.Add(option, marks);
            }
            foreach (var item in d)
            {
                Console.WriteLine($"{item.Key}: {string.Join(", ", item.Value)}");
            }
        }
    }
}
