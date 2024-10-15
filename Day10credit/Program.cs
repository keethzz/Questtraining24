using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10credit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the card no");
            var cardNo=Console.ReadLine();
            Console.WriteLine("Enter expiry in MM-YY");
            var expiry=Console.ReadLine();
            Console.WriteLine("Enter CSV");
            var cvc = Console.ReadLine();

            var creditCard = new CreditCard()
            {
                Cardno = int.Parse(cardNo),
                ExpiryMonth = byte.Parse(expiry.Split('-')[0]),
                ExpiryYear = byte.Parse(expiry.Split('-')[1]),
                Cvc = int.Parse(cvc)

            };
            Console.WriteLine(creditCard);

        }
    }
}
