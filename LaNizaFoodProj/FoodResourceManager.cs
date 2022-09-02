using RestaurantMenuLibraryProj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaNizaFoodProj
{
    internal class FoodResourceManager
    {
        public static List<Order> LoadBreakFastMenu()
        {
            var output = new List<Order>();
            output.Add(new Order("Breakfast Special", 40.00m, 1));
            output.Add(new Order("Hashbrown and Egg", 20.00m, 1));
            output.Add(new Order("Sunday Special", 60.00m, 1));

            return output;
        }

        public static List<Order> LoadCombosMenu()
        {
            var output = new List<Order>();
            output.Add(new Order("Breakfast and coffee", 45.00m, 1));
            output.Add(new Order("Breakfast and juice", 35.00m, 1));
            output.Add(new Order("Burger and chips", 60.00m, 1));
            output.Add(new Order("Burger, drink and chips", 70.00m, 1));

            return output;
        }

        public static List<Order> LoadChipsMenu()
        {
            var output = new List<Order>();
            output.Add(new Order("Hot Chips", 25.00m, 1));
            output.Add(new Order("Spicy Chips", 30.00m, 1));
            output.Add(new Order("Simbas", 8.00m, 1));
            output.Add(new Order("Doritos", 8.00m, 1));

            return output;
        }

        public static List<Order> LoadBurgersMenu()
        {
            var output = new List<Order>();
            output.Add(new Order("Beef Burger", 49.90m, 1));
            output.Add(new Order("Chicken Burger", 69.90m, 1));
            output.Add(new Order("Sausy Burger", 59.90m, 1));
            output.Add(new Order("Cheese Burger", 59.90m, 1));
            output.Add(new Order("Hawaiian Burger", 79.90m, 1));

            return output;
        }

        public static List<Order> LoadSoftDrinksMenu()
        {
            var output = new List<Order>();
            output.Add(new Order("Coke", 11.00m, 1));
            output.Add(new Order("Fanta", 8.49m, 1));
            output.Add(new Order("Dr Pepper", 18.90m, 1));
            output.Add(new Order("Sprite", 8.99m, 1));

            return output;

        }

        public static List<Order> LoadMilkshakesMenu()
        {
            var output = new List<Order>();
            output.Add(new Order("Chocolate Milkshake", 39.90m, 1));
            output.Add(new Order("Straweberry Milkshake", 39.90m, 1));
            output.Add(new Order("Vanilla Milkshake", 39.90m, 1));
            output.Add(new Order("Mint Milkshake", 39.90m, 1));

            return output;

        }

        public static List<Order> LoadJuicesMenu()
        {
            var output = new List<Order>();
            output.Add(new Order("Orange Juice", 23.33m, 1));
            output.Add(new Order("Cranberry Juice", 23.33m, 1));
            output.Add(new Order("Apple Juice", 23.99m, 1));

            return output;
        }

        public static List<Order> LoadHotDrinksMenu()
        {
            var output = new List<Order>();
            output.Add(new Order("Cappachino", 34.90m, 1));
            output.Add(new Order("Hot Chocolate", 42.90m, 1));
            output.Add(new Order("Coffee", 29.90m, 1));
            output.Add(new Order("Tea", 21.90m, 1));

            return output;
        }
    }
}
