using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14assignment
{
    class Employee
    {
        public int DepId { get; set; }
        public string Name { get; set; }
    }
    class Department
    {
        public int id { get; set; }
        public string Name { get; set; }
    }
    class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<int> lst = new List<int> { 1, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 60, 70 };
            List<string> lsts = new List<string> { "Abc", "Bcd", "Cde" };
            List<string> lsts2 = new List<string> { "1", "2", "3" };
            /*
            //qs1
            var where = lst.Where(x => x % 2 == 0).ToList();
            Console.WriteLine(where);
            foreach (var num in where)
            {
                Console.WriteLine(num);
            }


            //qs2
            var start = lsts.Where(x => x.StartsWith("A")).ToList();
            foreach (var num in start)
            {
                Console.WriteLine(num);
            }


            //qs3
            var descend = lst.OrderByDescending(x => x).ToList();
            foreach (var num in descend)
            {
                Console.WriteLine(num);
            }

            //qs4
            var squareof = lst.Select(x => x * x).ToList();
            foreach (var num in squareof)
            {
                Console.Write(num + " ");
            }

            //qs5 
            var squareofeven = lst.Where(x => x % 2 == 0).Select(x => x * x).ToList();
            foreach (var num in squareofeven)
            {
                Console.Write(num + " ");
            }



            //qs 6
            var startB = lsts.Where(x => x.StartsWith("B")).FirstOrDefault();
            Console.WriteLine(startB);

            //qs 7
            List<string> name = new List<string> { "Abc", "Bcd", "Cde", "Def" };
            List<int> mark = new List<int> { 90, 75, 85, 60 };
            var above80 = name.Where((x, y) => mark[y] > 80).ToList();
            Console.Write(string.Join(", ", above80));


            //qs 8

            var grouplength = lsts.GroupBy(x => x.Length).ToDictionary(x => x.Key, x => x.ToList());
            foreach (var num in grouplength)
            {
                Console.WriteLine(num.Key + " " + string.Join(", ", num.Value));
            }

            //qs 9

            var maxi = lst.Max(x => x);
            Console.WriteLine(maxi);

            //qs 10
            var mini = lst.Min(x => x);
            Console.WriteLine(mini);

            //qs 11
            var greater50 = lst.Where(x => x > 50);
            Console.WriteLine(string.Join(", ", greater50));

            //qs12
            var positivenumb = lst.Where(x => x > 0);
            Console.WriteLine(string.Join(", ", positivenumb));

            //qs 13

            var sum = lst.Sum(x => x);
            Console.WriteLine(sum);

            //qs 14
            var average = lst.Average(x => x);
            Console.WriteLine(average);

            //qs 15
            var distinctValues = lst.Distinct();
            Console.WriteLine(string.Join(", ", distinctValues));

            //qs 16
            var count = lst.Count(x => x > 10);
            Console.WriteLine(count);
            */

            //qs 17
            var departments = new List<Department>()
            {
                new Department{ id = 1, Name="Abc"},
                new Department{id=2,Name="Bcd"}

            };
            var employees = new List<Employee>()
            {
                new Employee{DepId=1, Name="Kerrthana"},
                new Employee{DepId=2,Name = "Sreejith"}
            };
            var empWithDep = employees
                .Join(
                departments,
                e => e.DepId,
                d => d.id,
                (e, d) => new
                {
                    EmployeeName = e.Name,
                    DepartmentName = d.Name
                }
                );

            foreach ( var emp in empWithDep )
            {
                Console.WriteLine($"Employee Name: {emp.EmployeeName}, Department Name: {emp.DepartmentName}");
            }

            //qs 18
            List<Product> products = new List<Product>
            {
            new Product { Name = "Prod1", Price = 100 },
            new Product { Name = "Prod2", Price = 180 },
            new Product { Name = "Prod3", Price = 250 },
            new Product { Name = "Prod4", Price = 50 }
            };
            var product = products.OrderBy(x => x.Price).Where(x=>x.Price>100).ToList();
            foreach (var num in product)
            {
                Console.WriteLine(num.Name + " " + num.Price);
            }

            //qs 19
            var skip5then3 = lst.Skip(3).Take(5);
            Console.WriteLine(string.Join(", ", skip5then3));

            //qs 20
            

        }
    
    }
}
