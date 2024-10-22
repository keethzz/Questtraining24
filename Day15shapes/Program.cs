using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15shapes
{
    public interface IShape
    {
        double GetArea();
        double GetPerimeter();
    }

    // Circle class implementing IShape
    public class Circle : IShape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        // Method to calculate the area of the circle
        public double GetArea()=>Math.PI * Radius * Radius;
        // Method to calculate the perimeter of the circle
        public double GetPerimeter()=> 2 * Math.PI * Radius;
    }
    public class Rectangle : IShape
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }
       // Method to calculate the area of the rectangle (single line)
        public double GetArea() => Length * Width;
        // Method to calculate the perimeter of the rectangle (single line)
        public double GetPerimeter() => 2 * (Length + Width);
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a generic list to store shapes
            var shapes = new List<IShape>();
            shapes.Add(new Circle(5));
            shapes.Add(new Rectangle(4, 6));
            foreach (var shape in shapes)
            {
                Console.WriteLine($"Shape: Area = {shape.GetArea()}, Perimeter = {shape.GetPerimeter()}");
            }
        }
    }
}

