using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13abstractandvirtual
{
    abstract class CalculatorBase
    {
            
            public void Add(int a, int b) => Console.WriteLine(a + b);

           
            public void Subtract(int a, int b) => Console.WriteLine(a - b);

         
            public void Multiply(int a, int b) => Console.WriteLine(a * b);

            // Virtual Divide method with single line function
            public virtual void Divide(int a, int b) =>
                Console.WriteLine(a / b);

            // Abstract Power method to be implemented in the derived class
            public abstract void Power(int a, int b);
        
    }
    class Calculator : CalculatorBase
    {
        // Override Divide method with single line function
        public override void Divide(int a, int b) =>
            Console.WriteLine(b == 0 ? "Division by zero is not possible" :(a/b).ToString());

        // Override Power method as a single line function
        public override void Power(int a, int b) => Console.WriteLine(Math.Pow(a, b));
    }
}
