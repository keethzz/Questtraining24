using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5searchdirectory
{
    class Myclass
    {
        public string Data { get; set; }
    }
    internal class Program
    {
        static void changeRef(Myclass obj) => obj.Data = "New";
        static void Main(string[] args)
        {
            var obj = new Myclass();
            obj.Data = "old";
            Console.WriteLine(obj.Data);
            changeRef(obj);


        }
    }
}
