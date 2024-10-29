using Serilog.Events;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day19Seriliog
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Configure the logger
            var logger = new LoggerConfiguration()
                .WriteTo.Console(
                    restrictedToMinimumLevel: LogEventLevel.Information,
                    outputTemplate: "[{Timestamp:HH:mm:ss} {Level:u3}] {Message:lj}{NewLine}")
                .CreateLogger();

            // Log a message
            logger.Information("Application Started");
        }
    }
}
