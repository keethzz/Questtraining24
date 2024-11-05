using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day19ecommercemanagement
{
    public interface IDiscountStrategy
    {
        decimal ApplyDiscount(decimal totalAmount);
    }
    public class PercentageDiscountStrategy : IDiscountStrategy
    {
        private readonly decimal _discountPercentage = 2;

        public decimal ApplyDiscount(decimal totalAmount) => totalAmount - (totalAmount * _discountPercentage / 100);
    }
    public class FlatDiscountStrategy : IDiscountStrategy
    {
        public decimal ApplyDiscount(decimal totalAmount) => totalAmount - 200;
    }
}
