using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10calculator
{
    class Calculator
    {
        public int Operand1;
        public int Operand2;
        public string Operator;
        public void Display()
        {
            double result = 0;
            switch (Operator)
            {
                case "+":
                    result = Operand1 + Operand2;
                    break;
                case "-":
                    result = Operand1 - Operand2;
                    break;
                case "*":
                    result = Operand1 * Operand2;
                    break;
                case "/":
                    result = Operand1 / Operand2;                   
                    break;
                default:
                    Console.WriteLine("Error: Invalid operator!");
                    return;
            }
            Console.WriteLine($"Result: {Operand1} {Operator} {Operand2} = {result}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator()
            {

                Operand1 =int.Parse(Console.ReadLine()),
                Operand2 = int.Parse(Console.ReadLine()),
                Operator= Console.ReadLine()
            };
            calculator.Display();
            

        }
    }
}
