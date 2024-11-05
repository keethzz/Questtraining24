using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Day21async2
{
    internal class Program
    {
        static async Task MakeRequestAsync(int id)
        {
            string targetUrl = $"https://jsonplaceholder.typicode.com/posts/{id}";

            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(targetUrl);
                response.EnsureSuccessStatusCode();

                var responseContent = await response.Content.ReadAsStringAsync();
                await Task.Delay(1000); // Simulate some delay

                Console.WriteLine(responseContent);
            }
        }

        public static async Task Main()
        {
            for (int i = 1; i < 10; i++)
            {
                await MakeRequestAsync(i);
            }
        }
    }
}
