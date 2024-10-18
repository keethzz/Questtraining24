using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Day12filehandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Users\user\Desktop\notes\Testdirectory";
            Directory.CreateDirectory(path);
        }
    }
}
