using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11studentinheritance
{
    class Student
    {
        public string Name { get; set; } = "Abc";
        public string Email { get; set; } = "abc123@gmail";
        public void Display()
        {
            Console.WriteLine($"Name: {Name} Email: {Email}");
        }
    }
    class School:Student
    {
        public string SchName { get; set; } = "ABC";
        public void Display()
        {
            Console.WriteLine($"Name: {Name} Email: {Email} School :{SchName}");
            base.Display();
        }

    }
    class College:School
    {
        public string CollName { get; set; } = "XYZ";

        public void Display()
        {
            Console.WriteLine($"Name: {Name} Email: {Email} School :{SchName} College :{CollName}");
            base.Display();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var c= new College();
            c.Display();
           
        }
    } 
}
