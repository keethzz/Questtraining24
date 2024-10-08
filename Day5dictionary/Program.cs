using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating dictionary.
            var d = new Dictionary<string, string>();

            // Adding values to dictionary.
            d.Add("First Name", "Keerthana");
            d.Add("Last Name", "Sreejith");

            // Accesing elements.
            Console.WriteLine(d["First Name"]);

            //Updating value
            d["First Name"] = "Sangeeth";
            Console.WriteLine(d["First Name"]);

            //remove value.
            d.Remove("last Name");

            // Checking if a key exist or not.
            if(d.ContainsKey("Last Name"))
            {
                Console.WriteLine("Found");
            } else
            {
                Console.WriteLine("Not found.");
            }

            //looping through dictionary
            foreach(var item in d) { 
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
