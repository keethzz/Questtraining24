using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10qs2
{
    class Employee
    {
        public string FirstName;
        public string LastName;
        public int salary;

        public void TotalSalary()
        {
            Console.WriteLine("$Total Salary: {salary*12}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee();


        }
    }
}
