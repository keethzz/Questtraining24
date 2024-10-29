using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day19ecommercemanagement
{
    abstract class Discount
    {
        public abstract decimal ApplyDiscount(decimal total);
    }
    class PercentageDiscount : Discount
    {
        private decimal percentage;

        public PercentageDiscount(decimal percentage)
        {
            this.percentage = percentage;
        }

        public override decimal ApplyDiscount(decimal total)
        {
            return total - (total * percentage / 100);
        }
    }
}
