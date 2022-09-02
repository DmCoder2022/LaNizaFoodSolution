using RestaurantMenuLibraryProj;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaNizaFoodProj
{
    public partial class UserControlFoodMenus : UserControl
    {
        public static UserControlFoodMenus userFoodMenu = new UserControlFoodMenus();
        private List<Order> breakfastList = new List<Order>();
        private List<Order> comboList = new List<Order>();
        private List<Order> chipsList = new List<Order>();
        private List<Order> burgerList = new List<Order>();
        private List<Order> softDrinksList = new List<Order>();
        private List<Order> milkshakesList = new List<Order>();
        private List<Order> juicesList = new List<Order>();
        private List<Order> hotDrinksList = new List<Order>();
        private Order chosenOrder = new Order();
        //private List<Order> tempOrders = new List<Order>(); 

        public UserControlFoodMenus()
        {
            InitializeComponent();
            userFoodMenu = this;
            chosenOrder = new Order();

            LoadFoodResourceData();
            SetFoodMenuBindings();
        }

        private void LoadFoodResourceData()
        {
            breakfastList = FoodResourceManager.LoadBreakFastMenu();
            comboList = FoodResourceManager.LoadCombosMenu();
            chipsList = FoodResourceManager.LoadChipsMenu();
            burgerList = FoodResourceManager.LoadBurgersMenu();
            softDrinksList = FoodResourceManager.LoadSoftDrinksMenu();
            milkshakesList = FoodResourceManager.LoadMilkshakesMenu();
            juicesList = FoodResourceManager.LoadJuicesMenu();
            hotDrinksList = FoodResourceManager.LoadHotDrinksMenu();
        }

        private void SetFoodMenuBindings()
        {
            foreach (var order in breakfastList)
            {
                comboBoxBreakfastMenu.Items.Add(order.DisplayOrderAndPrice());
            }

            foreach (var order in comboList)
            {
                comboBoxCombosMenu.Items.Add(order.DisplayOrderAndPrice());
            }

            foreach (var order in chipsList)
            {
                comboBoxChipsMenu.Items.Add(order.DisplayOrderAndPrice());
            }

            foreach (var order in burgerList)
            {
                comboBoxBurgersMenu.Items.Add(order.DisplayOrderAndPrice());
            }

            foreach (var order in softDrinksList)
            {
                comboBoxSoftDrinksMenu.Items.Add(order.DisplayOrderAndPrice());
            }

            foreach (var order in milkshakesList)
            {
                comboBoxMilkshakesMenu.Items.Add(order.DisplayOrderAndPrice());
            }

            foreach (var order in juicesList)
            {
                comboBoxJuicesMenu.Items.Add(order.DisplayOrderAndPrice());
            }

            foreach (var order in hotDrinksList)
            {
                comboBoxHotDrinksMenu.Items.Add(order.DisplayOrderAndPrice());
            }
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            if (!(listBoxOrderDisplay.Items.Count == 0))
            {
                //Dashboard.main.GetCustomer().AddOrder(chosenOrder);
                int val = int.Parse(numericUpDownQuantity.Value.ToString());
                chosenOrder.SetQuantity(val);
                //Customer temp = Dashboard.main.GetCustomer();
                //temp.AddOrder(chosenOrder);
                //Dashboard.main.UpdateCustomerOrders(temp);
                Dashboard.main.GetCustomer().GetOrders().Add(chosenOrder);
            }
            else
            {
                MessageBox.Show("Error: Please select an option from one of the combo boxes");
            }
        }

        private void comboBoxBreakfastMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxOrderDisplay.Items.Clear();
            int pos = comboBoxBreakfastMenu.SelectedIndex;
            chosenOrder = breakfastList.ElementAt(pos);
            listBoxOrderDisplay.Items.Add(breakfastList.ElementAt(pos).DisplayOrderAndPrice());
        }

        private void comboBoxCombosMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxOrderDisplay.Items.Clear();
            int pos = comboBoxCombosMenu.SelectedIndex;
            chosenOrder = comboList.ElementAt(pos);
            listBoxOrderDisplay.Items.Add(comboList.ElementAt(pos).DisplayOrderAndPrice());
        }

        private void comboBoxChipsMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxOrderDisplay.Items.Clear();
            int pos = comboBoxChipsMenu.SelectedIndex;
            chosenOrder = chipsList.ElementAt(pos);
            listBoxOrderDisplay.Items.Add(chipsList.ElementAt(pos).DisplayOrderAndPrice());
        }

        private void comboBoxBurgersMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxOrderDisplay.Items.Clear();
            int pos = comboBoxBurgersMenu.SelectedIndex;
            chosenOrder = burgerList.ElementAt(pos);
            listBoxOrderDisplay.Items.Add(burgerList.ElementAt(pos).DisplayOrderAndPrice());
        }

        private void comboBoxSoftDrinksMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxOrderDisplay.Items.Clear();
            int pos = comboBoxSoftDrinksMenu.SelectedIndex;
            chosenOrder = softDrinksList.ElementAt(pos);
            listBoxOrderDisplay.Items.Add(softDrinksList.ElementAt(pos).DisplayOrderAndPrice());
        }

        private void comboBoxMilkshakesMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxOrderDisplay.Items.Clear();
            int pos = comboBoxMilkshakesMenu.SelectedIndex;
            chosenOrder = milkshakesList.ElementAt(pos);
            listBoxOrderDisplay.Items.Add(milkshakesList.ElementAt(pos).DisplayOrderAndPrice());
        }

        private void comboBoxJuicesMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxOrderDisplay.Items.Clear();
            int pos = comboBoxJuicesMenu.SelectedIndex;
            chosenOrder = juicesList.ElementAt(pos);
            listBoxOrderDisplay.Items.Add(juicesList.ElementAt(pos).DisplayOrderAndPrice());
        }

        private void comboBoxHotDrinksMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxOrderDisplay.Items.Clear();
            int pos = comboBoxHotDrinksMenu.SelectedIndex;
            chosenOrder = hotDrinksList.ElementAt(pos);
            listBoxOrderDisplay.Items.Add(hotDrinksList.ElementAt(pos).DisplayOrderAndPrice());
        }
    }
}
