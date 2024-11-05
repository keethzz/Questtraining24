using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day22qs1
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string fPath = "C:\\Users\\user\\Desktop\\notes.txt";

            try
            {
                string path = await File.ReadAllTextAsync(filePath);
                Console.WriteLine("File Content:");
                Console.WriteLine(path);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Unexpected Error: {e.Message}");
            }
        }
    }
}
