using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemNamespace
{
    public class DiscountedItem : Item
    {
        private double item_discount;
        private double discounted_price;
        private double payment_amount;
        private double change;

        public DiscountedItem(string name, double price, int quantity, double discount)
            : base(name, price, quantity)
        {
            this.item_discount = discount;
        }

        public override double getTotalPrice()
        {
            double discountFraction = item_discount * 0.01;
            double discountAmount = item_price * discountFraction;
            discounted_price = item_price - discountAmount;

            return discounted_price * item_quantity;
        }

        public override void setPayment(double amount)
        {
            payment_amount = amount;
        }

        public double getChange()
        {
            change = payment_amount - getTotalPrice();
            return change;
        }
    }
}
