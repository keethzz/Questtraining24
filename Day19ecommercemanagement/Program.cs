using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 1. E-commerce Cart Management System
Scenario: You're developing a shopping cart feature for an e-commerce platform.
Questions:
Design a Cart class that allows items to be added, updated, and removed. Each item has a name, quantity, and price.
Challenge: Ensure the Cart class follows the Single Responsibility Principle (SRP) by separating the cart’s functionality from the billing calculations.
Implement a discount system for the cart that allows adding different discount strategies (percentage-based, flat discount, buy-one-get-one).
Challenge: Use the Open/Closed Principle (OCP) to ensure that you can add new discount types without modifying existing code.
*/

namespace Day19ecommercemanagement
{
    class Program
    {
        static void Main(string[] args)
        {
            var cart = new Cart();
            cart.Add(new CartItem { Name = "Item 1", Price = 100, Quantity = 2 });
            cart.Add(new CartItem { Name = "Item 2", Price = 200, Quantity = 3 });
            cart.Add(new CartItem { Name = "Item 3", Price = 300, Quantity = 4 });

            var discountStrategy = new PercentageDiscountStrategy();
            var billingService = new BillingService(discountStrategy);
            var totalAmount = billingService.CalculateTotalAmount(cart.GetAll());
            Console.WriteLine($"Total amount: {totalAmount}");
        }
    }
}
