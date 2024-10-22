using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Day13Assignment16_qs
{
    /*1.Define an abstract class called Shape with an abstract method Area(). 
     * Create two derived classes Circle and Rectangle that implement the Area() method for calculating the area of the respective shapes.
    
    
    abstract class Shape
    {
        public abstract void Area();
    }
    class Circle:Shape {
        public int radius { get; set; } = 2;
        public override void Area()
        {
            double are= 3.14*radius*radius;
            Console.WriteLine(are);
        }
    }
    class Rectangle : Shape
    {
        public int l { get; set; } = 2;
        public int b { get; set; } = 3;
        public override void Area()
        {
            int x = l * b;
            Console.WriteLine(x);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            Circle c = new Circle();
            c.Area(); 

            Rectangle r = new Rectangle();
            r.Area();
        }
    }


    2: Create an abstract class Vehicle with a property Speed and an abstract method Drive().
    Implement the Drive() method in two derived classes Car and Bicycle.
   

    abstract class Vehicle
    {
        public int Speed { get; set; }
        public abstract void Drive();
    }
    class Car : Vehicle
    {
        public override void Drive()
        {
            Console.WriteLine($"The car is driving at {Speed} km/h.");
        }
    }
    class Bicycle : Vehicle
    {
        public override void Drive()
        {
            Console.WriteLine($"The bicycle is riding at {Speed} km/h.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Speed = 100;
            car.Drive();           
            Bicycle bicycle = new Bicycle { Speed = 20 };
            bicycle.Drive();  
        }
    }


    3: Create an interface IAnimal with a method Speak(). 
    Implement the interface in two classes Dog and Cat, each providing their own implementation of Speak().
 

    interface IAnimal
    {
        void Speak();
    }
    class Dog:IAnimal {
        public void Speak() => Console.WriteLine("This is Dog");
    }
    class Cat : IAnimal
    {
        public void Speak() => Console.WriteLine("This is cat");

    }
    class Program
    {
        static void Main(string[] args)
        {
            var dog = new Dog();
            dog.Speak(); 
            var cat = new Cat();
            cat.Speak();  
        }
    }


    4: Write an interface ICalculator that has methods Add(int a, int b) and Subtract(int a, int b).
    Implement this interface in a SimpleCalculator class.

    interface ICalculator
    {
        void Add(int a, int b);
        void Sub(int a, int b);
    }
    class Calculator : ICalculator
    {
        public void Add(int a, int b) => Console.WriteLine($"Sum is {a + b}");
        public void Sub(int a, int b)=>Console.WriteLine($"Difference is {a-b}");
    }
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();
            calculator.Add(5, 3);
            calculator.Sub(5, 3);
        }
    }
    5: Define a delegate Operation that takes two integers as parameters.
    Write methods Add and Multiply that match this delegate signature.
    Demonstrate how to use the delegate to call these methods.


     class ActionDeligate
    {
        delegate void Print(int a, int b);
        static void Add(int a, int b) => Console.WriteLine($"Sum: {a + b}");
        static void Multiply(int a, int b) => Console.WriteLine($"Product: {a * b}");
        static void Main(string[] args)
        {
            Print print = Add;         
            print+= Multiply; 
            print(5,3);        
        }
    }



    6: Create a delegate PrintMessage that takes a string as a parameter.
    Write a method DisplayMessage that prints the string passed to it. 
    Use the delegate to call DisplayMessage.


    class Message
    {
        delegate void PrintMessage(string message);
        static void DisplayMessage(string message)=> Console.WriteLine(message);   

        static void Main(string[] args)
        {
            PrintMessage mes = DisplayMessage; 
            mes("Hello!");
           
        }
    }


7: Define a Func<int, int, int> delegate that takes two integers as parameters and returns their sum.

    class Functiondelegate
    {
        static int Add(int a, int b) => a + b;

        static void Main(string[] args)
        {
            Func<int, int, int> a = Add;

            int result = a(1, 2);
            Console.WriteLine(result);

        }
    }

    8: Write a Func<string, int> delegate that takes a string as input and returns the length of the string.


    class FunctionDelegate2
    {
        static int Leng(string s) => s.Length;
        static void Main(string[] args)
        {
            Func<string,int> findlen = Leng;
            int result = findlen("abc");
            Console.WriteLine(result);
        }
    }


    9: Define an Action<string> delegate that prints a string to the console.
    Use this delegate to call a method that prints a welcome message.




    class ActionDelegate
    {
        static void PrintMessage(string message) => Console.WriteLine(message);
        static void Main(string[] args)
        {

            Action<string> pm = PrintMessage;   
            pm("Hello!");
            
        }
    }


10: Create an Action<int, int> delegate that takes two integers and prints their sum.

    class ActionDelegate2
    {
        static void PrintMessage(int a, int b)=> Console.WriteLine($"Sum is {a+b}");
        static void Main(string[] args)
        {
            Action<int, int> sum = PrintMessage;
            sum(2, 4);

        }
    }

 11: Write a Predicate<int> that checks if a given integer is even.

    class PredicateDeligate
    {
        static bool Even(int n)=>n%2==0;
        static void Main(string[] args)
        {
            Predicate<int> even = Even;
            Console.WriteLine(even(2));
        }
    }


 12: Create a Predicate<string> that checks if a given string starts with the letter 'A'.

    class PredicateDelegate2
    {
        static bool Starts(string s) => s.StartsWith("A");
        static void Main(string[] args)
        {
            Predicate<string> start = Starts;
            Console.WriteLine(start("Amritha"));
            Console.WriteLine(start("Bcd"));
        }
    }


    13: Define an abstract class Appliance with an abstract method TurnOn(). 
    Create a derived class Fan that implements the TurnOn() method.

    abstract class Appliances
    {
        public abstract void TurnOn();
    }
    class Fan:Appliances
    {
        public override void TurnOn() => Console.WriteLine("Fan is rotating");
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Fan app = new Fan();
            app.TurnOn();
        }
    }


14: Create an abstract class Person with an abstract method Work().
    Implement Work() in derived classes Doctor and Engineer to describe their specific jobs.

    abstract class Person
    {
        public abstract void Work();
    }
    class Doctor:Person
    {
        public override void Work() => Console.WriteLine("Iam a Doctor");
    }
    class Engineer:Person
    {
        public override void Work() => Console.WriteLine("I am a Engineer");
     
    }
    internal class Program 
    {
        public static void Main(string[] args)
    {
        Engineer engineer = new Engineer();
        engineer.Work();
        Doctor doctor = new Doctor();
        doctor.Work();
    }
    }


    15: Write a class Animal with a virtual method MakeSound().
    Create a derived class Dog that overrides MakeSound() to print "Bark!".

    class Animal
    {
        public virtual void MakeSound() => Console.WriteLine("Makes sound");
    }
    class Dog:Animal
    {
        public override void MakeSound() => Console.WriteLine("Bark");
        
    }
    class Program
    {
        public static void Main(string[] args)
        {
            var d = new Dog();
            d.MakeSound();
        }
    }

16: Create a base class Employee with a virtual method CalculateBonus(). 
    In the derived class Manager, override CalculateBonus() to provide a custom calculation.
*/
    class Employee
    {
        public virtual void CalculateBonus() => Console.WriteLine("Calculate bonus");
    }
    class Manager:Employee
    {
        public override void CalculateBonus() => Console.WriteLine("Custom calculation");

    }
    class Program
    {
        public static void Main(string[] args)
        {
            Employee e = new Manager();
            e.CalculateBonus();
        }
    }
}
