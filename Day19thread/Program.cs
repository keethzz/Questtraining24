using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Day19thread
{
    internal class Program
    {
        static void Action1()
        {
            Console.WriteLine($"Action 1: {DateTime.Now}");
        }

        static void Main(string[] args)
        {
            // Set culture to "en-IN" (English - India)
            var ci = new CultureInfo("en-IN");
            CultureInfo.DefaultThreadCurrentCulture = ci;
            CultureInfo.DefaultThreadCurrentUICulture = ci;

            // Print current date and time in main thread
            Console.WriteLine($"Main: {DateTime.Now}");

            // Start a new thread with Action1
            var t = new Thread(Action1);
            t.Start();
        }
    }
}
