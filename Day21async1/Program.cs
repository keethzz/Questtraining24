using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Day21async1
{
    internal class Program
    {
        static void MakeRequest()
        {
            string targetUrl = "https://jsonplaceholder.typicode.com/users";
            var client = new HttpClient();

            var response = client.GetAsync(targetUrl).Result;
            response.EnsureSuccessStatusCode();

            var responseContent = response.Content.ReadAsStringAsync().Result;
            Console.WriteLine(responseContent);
        }

        static void Main(string[] args)
        {
            MakeRequest();
        }
    }
}
