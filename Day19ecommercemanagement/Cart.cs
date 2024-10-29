using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day19ecommercemanagement
{
    internal class Cart
    {
        private List<Item> items = new List<Item>();

        public void AddItem(Item item)
        {
            items.Add(item);
        }

        public void UpdateItemQuantity(string itemName, int quantity)
        {
            Item item = items.Find(i => i.Name == itemName);
            if (item != null)
            {
                item.Quantity = quantity;
            }
        }

        public void RemoveItem(string itemName)
        {
            items.RemoveAll(i => i.Name == itemName);
        }

        public List<Item> GetItems()
        {
            return items;
        }
    }
}
