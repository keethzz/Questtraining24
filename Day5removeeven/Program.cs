using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Day5removeeven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var lst = new List<int>();
            Console.WriteLine("Enter list size");
            int size = int.Parse(Console.ReadLine());
            for (int i = 0; i < size; i++)
            {
                lst.Add(int.Parse(Console.ReadLine()));
            }
            for(int i = 0;i<lst.Count;i++)
            {
                if (lst[i] % 2 == 0)
                {
                    lst.RemoveAt(i);
                }
                
            }
            Console.WriteLine(string.Join(",", lst));



        }
    }
}
