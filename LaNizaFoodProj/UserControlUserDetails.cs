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
    public partial class UserControlUserDetails : UserControl
    {
        public static UserControlUserDetails userDetails = new UserControlUserDetails();

        public UserControlUserDetails()
        {
            InitializeComponent();
            userDetails = this;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Dashboard.main.SetCustomer(txtFirstName.Text, txtLastName.Text, txtEmailAddress.Text, txtPhoneNumber.Text);
            Dashboard.main.GetCustomer().GenerateCustomerCode();

            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtEmailAddress.Text = "";
            txtPhoneNumber.Text = "";
        }
    }
}
