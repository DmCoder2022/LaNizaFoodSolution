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
    public partial class Dashboard : Form
    {
        public static Dashboard main = new Dashboard();
        private Customer customer = new Customer();

        public Dashboard()
        {
            InitializeComponent();
            customer = new Customer();
            main = this;
        }

        private void btnUserDetails_Click(object sender, EventArgs e)
        {
            UserControlUserDetails.userDetails.Dock = DockStyle.Fill;
            panelDisplay.Controls.Clear();
            panelDisplay.Controls.Add(UserControlUserDetails.userDetails);
            UserControlUserDetails.userDetails.Show();
            UserControlUserDetails.userDetails.BringToFront();
        }

        private void btnFoodMenus_Click(object sender, EventArgs e)
        {
            UserControlFoodMenus.userFoodMenu.Dock = DockStyle.Fill;
            panelDisplay.Controls.Clear();
            panelDisplay.Controls.Add(UserControlFoodMenus.userFoodMenu);
            UserControlFoodMenus.userFoodMenu.Show();
            UserControlFoodMenus.userFoodMenu.BringToFront();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            UserControlCheckout.userCheckout.Dock = DockStyle.Fill;
            panelDisplay.Controls.Clear();
            panelDisplay.Controls.Add(UserControlCheckout.userCheckout);
            UserControlCheckout.userCheckout.Show();
            UserControlCheckout.userCheckout.BringToFront();
        }

        public void SetCustomer(string fname, string lname, string eaddress, string phoneNr)
        {
            customer = new Customer(fname, lname, eaddress, phoneNr,DateTime.Now);
        }

        public Customer GetCustomer()
        {
            return customer;
        }

        public void UpdateCustomerOrders(Customer c)
        {
            customer.AddOrder(c.GetOrders().ElementAt(0));
        }
    }
}
