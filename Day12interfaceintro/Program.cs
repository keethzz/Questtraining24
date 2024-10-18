using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12interfaceintro
{
    interface IStudent
    {
        string Name { get; set; }
        void Display();
    }
    class SchoolStudent : IStudent
    {
        public string Name { get; set; }
        public string SchoolName { get; set; }
        public void Display()
        {
            Console.WriteLine($"Student Name: {Name} School Name: {SchoolName}");

        }
    }
    class College : IStudent
    {
        public string Name { get; set; }
        public string CollegeName { get; set; }

        public void Display()
        {
            Console.WriteLine($"Student Name: {Name} College Name: {CollegeName}");
        }
    }

        internal class Program
        {
            static void Main()
            {
                var students = new List<IStudent>
                {

                    new SchoolStudent { Name = "Abc" },
                    new College { Name = "dse" }

                };
                foreach (var student in students)
                {
                    student.Display();
                }
            }
        }
    
}