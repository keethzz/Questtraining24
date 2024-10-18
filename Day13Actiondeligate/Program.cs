using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13Actiondeligate
{
    //action deligate
    internal class Program
    {
        static void Greet() => Console.WriteLine("Hello!");

        static void GreetWithMessage(string message) => Console.WriteLine(message);

        static void Add(int a, int b) => Console.WriteLine(a + b);

        static void Main(string[] args)
        {

            Action g = Greet;   // g holds a reference to the Greet method

            Action<string> gm = GreetWithMessage;   // gm holds a reference to the GreetWithMessage method

            Action<int, int> a = Add;
            g();    
            gm("Hello!");
            a(1, 2);
        }
    }
    //Predicate deligate 
    // A Predicate is a special type of delegate that specifically returns a boolean value based on the input.
    class PredicateDeligate
    {

        static bool IsEven(int n) => n % 2 == 0;    // Method that checks if a number is even

        static void Main(string[] args)
        {

            Func<int, bool> a = IsEven;
            Predicate<int> b = IsEven;      // b holds a reference to the IsEven method

            var res = a(1);
            var res2 = b(1);

        }
    }
    //Function  delegate
    class functiondelegate
    {
        static int GetNumber()=>10;
        static string Add(int a, int b)=>(a+b).ToString();

        static void Main(string[] args) {
            Func<int> gn = GetNumber;
            Func<int, int, string> a = Add;
        }
    }

}
