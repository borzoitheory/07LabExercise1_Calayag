using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserAccountNamespace;

namespace CashierApplication
{
    public partial class frmLoginAccount : Form
    {
        private Cashier cashier;
        public frmLoginAccount()
        {
            InitializeComponent();
            cashier = new Cashier("Chandler Bing", "Finance", "cashier101", "password123");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string inputUsername = txtUsername.Text;
            string inputPassword = txtPassword.Text;

            if (cashier.checkLogin(inputUsername, inputPassword))
            {
                MessageBox.Show($"Welcome, {cashier.getFullName()} of {cashier.getDepartment()}!");

                    this.Hide();

                frmPurchaseDIscountedItem purchaseForm = new frmPurchaseDIscountedItem(this);
                purchaseForm.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login failed, please try again.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
