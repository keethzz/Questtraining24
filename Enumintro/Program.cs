using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumintro
{
    internal class Program
    {
        public enum Convertto
        {
            Upper,
            Lower
        }
        public static void ConvertCasing(string ip, Convertto target)
        {
            switch (target)
            {
                case Convertto.Upper:
                    Console.WriteLine(ip.ToUpper);
                    break;
                case Convertto.Lower:
                    Console.WriteLine(ip.ToLower);
                    break;
                default:
                    Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            ConvertCasing("Helloo",Convertto.Upper);

        }
    }
}
