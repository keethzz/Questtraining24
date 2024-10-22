using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14qs2
{
    class Person
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public string Age { get; set; }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var lst = new List<Person>()
        {
            new Person{Name = "Person1", Country="US", Age = "20"},
            new Person{Name = "Person2", Country="US", Age = "20"},
            new Person{Name = "Person3", Country="US", Age = "30"},
            new Person{Name = "Person4", Country="UK", Age = "40"},
            new Person{Name = "Person5", Country="India", Age = "50"}
        };
           /* var a = lst.OrderByDescending(x=>x.Age);
            Console.WriteLine(a);
            var dist = lst.Select(x => x.Country).Distinct();
            Console.WriteLine(dist);
           
            // Select many

           var Emailarray = lst.Select(p=>p.Name).ToList();
            var emails = lst.SelectMany(p=>p.Name).ToList();
            foreach(var email in Emailarray)
            {
                Console.WriteLine(email);
            }
           */
           var group = lst.GroupBy(x => x.Country);
            foreach (var group2 in group) {
                foreach (var person in group2)
                {
                    Console.WriteLine($"{person.Name}-{person.Age}");
                }
            }
        }
    }
}
