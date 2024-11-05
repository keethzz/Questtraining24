using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyConstructor
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        // Copy constructor
        public Person(Person person)
        {
            Name = person.Name;
            Age = person.Age;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person originalPerson = new Person("Alice", 30);

            // Use the copy constructor to create a new object
            Person copiedPerson = new Person(originalPerson);
            Console.WriteLine("Original Person:");
            originalPerson.DisplayInfo();
            Console.WriteLine("Copied Person:");
            copiedPerson.DisplayInfo();
        }
    }
}
