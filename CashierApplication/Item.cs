using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemNamespace
{
    public abstract class Item
    {
        protected string item_name;
        protected double item_price;
        protected int item_quantity;
        private double total_price;

        public Item(string item, double price, int quantity)
        {
            this.item_name = item;
            this.item_price = price;
            this.item_quantity = quantity;
        }

        public abstract double getTotalPrice();
        public abstract void setPayment(double amount);
    }
}
