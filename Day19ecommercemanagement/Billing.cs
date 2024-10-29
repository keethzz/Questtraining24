using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day19ecommercemanagement
{
    class BillingService
    {
        private Cart cart;
        private Discount discount;

        public BillingService(Cart cart, Discount discount)
        {
            this.cart = cart;
            this.discount = discount;
        }
         public decimal CalculateTotal()
        {
            decimal total = 0;
            foreach (var item in cart.GetItems())
            {
                total += item.Quantity * item.Price;
            }
            if (discount != null)
            {
                total = discount.ApplyDiscount(total);
            }
            return total;
        }
    }
}
