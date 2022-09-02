using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantMenuLibraryProj
{
    public class Order
    {
        private string orderName;
        private decimal price;
        private int quantity;

        public Order(string orderName, decimal price, int quantity)
        {
            this.orderName = orderName;
            this.price = price;
            if (quantity > 0)
            {
                this.quantity = quantity;
            }
            else
            {
                quantity = 1;
            }
        }

        public Order()
        {
            
        }

        public string OrderInfo 
        {
            get 
            {
                return $"{orderName}\t\tR{price}\t(x{quantity})";
            } 
         }

        public string OrderNameAndPrice
        {
            get
            {
                return $"{orderName} (R{price})";
            }
        }

        public string DisplayOrderAndPrice()
        {
            return $"{orderName} (R{price})";
        }

        public decimal GetPrice()
        {
            return price;
        }

        public int GetQuantity()
        {
            return quantity;
        }

        public void SetQuantity(int val)
        {
            quantity = val;
        }

    }
}
