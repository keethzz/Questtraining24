using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11persondetails
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Person();
            p1.Name = "Abc";
            p1.Addres = new List<Address>();
            p1.Addres.Add(new Address { Type = "Home", Line1 = "abcdefg", Line2 = "ghjkl", Pincode = "670303" });
        }
    }
}
