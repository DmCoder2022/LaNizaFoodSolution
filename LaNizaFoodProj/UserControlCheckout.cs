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
    public partial class UserControlCheckout : UserControl
    {
        public static UserControlCheckout userCheckout = new UserControlCheckout();

        public UserControlCheckout()
        {
            InitializeComponent();
            userCheckout = this;
        }

        private void UpdateOrdersBinding()
        {
            try
            {
                txtCustomerInfo.Text = Dashboard.main.GetCustomer().CustomerInfo;
                listBoxUserOrders.DataSource = Dashboard.main.GetCustomer().GetOrders();
                listBoxUserOrders.DisplayMember = "OrderInfo";
                lblTotalPriceValue.Text = "" + Dashboard.main.GetCustomer().GetTotalPrice();
            }catch(Exception e)
            {
                MessageBox.Show("Error: " + e);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnLoadSummary_Click(object sender, EventArgs e)
        {
            UpdateOrdersBinding();
        }
    }
}
