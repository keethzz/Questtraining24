using Day15qs3.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15qs3
{
    internal class Program
    {
       
            static void Main(string[] args)
            {
                var categoryRepository = new CategoryRepository();

                var result = categoryRepository.GetCategoryById(10);
                if (result.Success)
                {
                    Console.WriteLine(result.Data.Name);
                }
                else
                {
                    Console.WriteLine(result.Message);
                }

            }
        
    }
}
