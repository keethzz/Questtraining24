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
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a cart and add items
            Cart cart = new Cart();
            cart.AddItem(new Item("Laptop", 1, 1000));
            cart.AddItem(new Item("Headphones", 2, 100));

            // Apply a percentage discount
            Discount discount = new PercentageDiscount(10); // 10% discount
            BillingService billingService = new BillingService(cart, discount);

            // Calculate total after discount
            decimal totalAmount = billingService.CalculateTotal();
            Console.WriteLine("Total amount after discount: " + totalAmount);

            // Change the discount strategy to FlatDiscount
            discount = new FlatDiscount(100); // Flat discount of $100
            billingService = new BillingService(cart, discount);
            totalAmount = billingService.CalculateTotal();
            Console.WriteLine("Total amount after flat discount: " + totalAmount);
        }
    }
}
