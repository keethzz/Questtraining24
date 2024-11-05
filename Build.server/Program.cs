using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Threading;


namespace Build.server
{

    class ServerProgram
    {
        static void Main(string[] args)
        {
            var server = new ServerBuilder();

            var serverThread = new Thread(() =>
            {
                server.Run(message =>
                {
                    Console.WriteLine($"Received from client: {message}");
                    server.SendMessage($"Echo: {message}");
                });
            });

            serverThread.Start();

            Console.WriteLine("Press Enter to shut down the server...");
            Console.ReadLine();

            server.ShutDown();
            serverThread.Join();
        }
    }
}
