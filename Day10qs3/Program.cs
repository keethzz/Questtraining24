using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10qs3
{
    class Student
    {
        public string Name;
        public int Mark1;
        public int Mark2;
        public int Mark3;

        public void Total()
        {
            int total = Mark1+ Mark2+Mark3;
            Console.WriteLine($"Total marks: {total}");
        }

        public void  Average()
        {
            double aver = (Mark1 + Mark2 + Mark3) / 3;
            Console.WriteLine($"Average: {aver}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1= new Student();
            Student s2= new Student();
            s1.Name = "Keerthana";
            s1.Mark1 = 20;
            s1.Mark2 = 30;
            s1.Mark3 = 40;
            s1.Total();
            s1.Average();

            s2.Name = "abc";
            s2.Mark1 = 20;
            s2.Mark2 = 20;
            s2.Mark3 = 20;
            s2.Total();
            s2.Average();

        }
    }
}
