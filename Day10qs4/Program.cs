using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10qs4
{
    class Smartphone
    {
        public string Name;
        public string Brand;
        public List<string> Ram;
        public void Display()
        {
            Console.WriteLine($"Name: {Name}  Brand: {Brand} Ram:{string.Join(", ", Ram)}");
        }

    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Smartphone s1= new Smartphone();
            s1.Name = "iphone 14";
            s1.Brand = "Apple";
            s1.Ram = new List<string>() { "4GB", "6GB"};
            s1.Display();

            Smartphone s2 = new Smartphone()
            {
                Name = "iphone 15",
                Brand = "Apple",
                Ram = new List<string>() { "6GB", "8GB" }

            };
            s2.Display();

        }
    }
}
