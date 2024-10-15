using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10credit
{
    internal class CreditCard
    {
        public long Cardno;
        public byte ExpiryMonth;
        public int ExpiryYear;
        public int Cvc;

        public override string ToString()
        {
            return $"Cardno: {Cardno}, Expiry: {ExpiryMonth}-{ExpiryYear}, Cvc: {Cvc}";
        }
    }
}
