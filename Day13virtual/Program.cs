using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13virtual
{
     class Student
    {
        public string Name { get; set; }
        public virtual void Display() => Console.WriteLine(Name);
    }
    class ChildStudent:Student
    {
        public string Grade { get; set; }
        public override void Display()
        {
            Console.WriteLine(Name+" "+Grade);
        }
    }
}
