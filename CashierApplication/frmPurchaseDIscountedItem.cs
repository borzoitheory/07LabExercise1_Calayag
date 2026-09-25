using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ItemNamespace;

namespace CashierApplication
{
    public partial class frmPurchaseDIscountedItem : Form
    {
        private DiscountedItem purchasedItem;
        private Form loginFormReference;
        public frmPurchaseDIscountedItem(Form loginForm)
        {
            InitializeComponent();
            this.loginFormReference = loginForm;
        }

        private void Form1_Load(object sender, EventArgs e)
        { 
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtItem.Text;
                double price = Convert.ToDouble(txtPrice.Text);
                int quantity = Convert.ToInt32(txtQuantity.Text);
                double discount = Convert.ToDouble(txtDiscount.Text);

                purchasedItem = new DiscountedItem(name, price, quantity, discount);

                double totalAmount = purchasedItem.getTotalPrice();
                lblTotalAmount.Text = totalAmount.ToString("F2");
            }
            catch (FormatException)
            {
                MessageBox.Show("Input for Price, Discount, and/or Quantity is invalid. Please try again.");
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (purchasedItem != null)
                {
                    // Retrieve payment amount
                    double payment = Convert.ToDouble(txtPayment.Text);

                    // Set payment and calculate change
                    purchasedItem.setPayment(payment);
                    double changeAmount = purchasedItem.getChange();

                    // Display change
                    lblChange.Text = changeAmount.ToString("F2");
                }
                else
                {
                    MessageBox.Show("Please compute the total amount first.");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid numeric value for Payment.");
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            if (loginFormReference != null)
            {
                loginFormReference.Show();
            }

            // naglagay lang po ako ng ganito kasi may error po na
            // nagrrun pa rin po sya kahit inexit na hehe 

        }

    }
}
