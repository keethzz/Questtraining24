using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5listdatatype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var lst = new List<int>();

            // Adding single element.
            lst.Add(1);

            // Adding multiple elements.
            var multiValues = new int[] { 20, 30, 40, 50, 50 };
            lst.AddRange(multiValues);

            //updating first element.
            lst[0] = 100;

            //Remove first occurance of 50.
            lst.Remove(50);

            //Remove from specified index.
            lst.RemoveAt(0);

            // Displaying list.
            foreach (var item in lst)           //for(int i = 0;i < lst.Count; i++)
            {
                Console.Write(item + ", ");
            }
        }
    }
}
