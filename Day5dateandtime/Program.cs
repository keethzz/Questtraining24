using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5dateandtime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // local time
            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);
            Console.WriteLine(dt.Year);
            Console.WriteLine(dt.Month);
            Console.WriteLine(dt.Day);
            Console.WriteLine(dt.Hour);
            Console.WriteLine(dt.Minute);
            Console.WriteLine(dt.Second);
            Console.WriteLine(dt.Millisecond);

            // Universal time
            DateTime dtu = DateTime.UtcNow;
            Console.WriteLine(dtu);
            Console.WriteLine(dtu.Year);
            Console.WriteLine(dtu.Month);
            Console.WriteLine(dtu.Day);
            Console.WriteLine(dtu.Hour);
            Console.WriteLine(dtu.Minute);
            Console.WriteLine(dtu.Second);
            Console.WriteLine(dtu.Millisecond);

            // Adding date and time to current system.
            var newDate = dt.AddDays(10);
            Console.WriteLine(newDate);
            Console.WriteLine(dt.AddHours(1));
            Console.WriteLine(dt.AddHours(2).AddDays(2));

            //Formatting date and time 
            Console.WriteLine(dt.ToString("dd/MM/yyyy mm:ss:hh"));
            Console.WriteLine(dt.ToString("dd-MM-yyyy"));

            //Constructing date and time.
            var myDt = new DateTime(2024, 10, 7, 12, 50, 59);
            Console.WriteLine(myDt);
        }
    }
}
