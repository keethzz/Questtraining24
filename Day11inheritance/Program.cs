using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11inheritance
{
    class A
    {
        public string Name { get; set; } = "A is name";
        public  void MethodA()
        {
            Console.WriteLine("This is method A");
        }
    }
    class B:A
    {
        public void MethodB()
        {
            Console.WriteLine("This is method B");
        }
        public void MethodA()
        {
            Console.WriteLine("This is method B from A");
            base.MethodA();
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var b = new B();
            b.MethodA();
            b.MethodB();
        }
    }
}
