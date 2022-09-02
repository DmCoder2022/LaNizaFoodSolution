using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantMenuLibraryProj
{
    public class Customer
    {
        private string firstName;
        private string lastName;
        private string emailAddress;
        private string phoneNumber;
        private List<Order> orders = new List<Order>();
        private DateTime date;
        private string customerCode;

        public Customer(string firstName, string lastName, string emailAddress, string phoneNumber, DateTime date)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.emailAddress = emailAddress;
            this.phoneNumber = phoneNumber;
            this.date = date;
            orders = new List<Order>();
        }

        public Customer()
        {
            
        }

        public string CustomerInfo
        {
            get
            {
                return $"FirstName: {firstName} \nLastName: {lastName} \nEmail Address: {emailAddress} \nPhone Number: {phoneNumber} \nDate: {date} \nCustomer Code: {customerCode}";
            }
        }

        public void AddOrder(Order order)
        {
            orders.Add(order);
        }

        public List<Order> GetOrders()
        {
            return orders;
        }

        public decimal GetTotalPrice()
        {
            decimal totalPrice = 0;

            foreach(var order in orders)
            {
                totalPrice += order.GetPrice() * order.GetQuantity();
            }

            return totalPrice;
        }

        public void GenerateCustomerCode()
        {
            Random randomNum = new Random();
            int num = randomNum.Next(100, 999);
            customerCode = CheckLengths(firstName, 4) + CheckLengths(lastName, 4) + num;
        }

        private string CheckLengths(string name, int numberOfCharacters)
        {
            string output = name;
            if(name.Length > numberOfCharacters)
            {
                output = name.Substring(0, numberOfCharacters);
            }
            else
            {
                do
                {
                    output += "X";
                } while (output.Length < 4);
            }

            return output;
        }

    }
}
