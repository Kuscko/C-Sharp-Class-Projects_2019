using System;
using System.Windows.Forms;

namespace InvoiceTotal
{
    public partial class frmInvoiceTotal : Form
    {
        public frmInvoiceTotal()
        {
            InitializeComponent();
        }

        decimal SalesTaxPct = 7.75m;

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                decimal productTotal = Convert.ToDecimal(txtProductTotal.Text);
                decimal discountPercent = .0m;

                if (productTotal < 100)
                    discountPercent = .0m;
                else if (productTotal >= 100 && productTotal < 250)
                    discountPercent = .1m;
                else if (productTotal >= 250)
                    discountPercent = .25m;

                decimal discountAmount = productTotal * discountPercent;
                decimal subtotal = productTotal - discountAmount;
                decimal tax = subtotal * SalesTaxPct / 100;
                decimal total = subtotal + tax;

                txtDiscountAmount.Text = discountAmount.ToString("c");
                txtSubtotal.Text = subtotal.ToString("c");
                txtTax.Text = tax.ToString("c");
                txtTotal.Text = total.ToString("c");

                txtProductTotal.Focus();
            }
        }


        /*
         * This class object creates a new form under the name salesTaxForm and displays it as a dialog.
         * IF the user clicks the OK button in the dialog then this method gets the tag value, which is a decimal, from the
         * frmSalesTax form and assigns it to SalesTaxPct.  
         */

        private void btnChange_Click(object sender, EventArgs e)
        {
            Form salesTaxForm = new frmSalesTax();
            DialogResult selectedButton = salesTaxForm.ShowDialog();
            if(selectedButton == DialogResult.OK)
            {
                SalesTaxPct = Convert.ToDecimal(salesTaxForm.Tag);
                lblTax.Text = "Tax (" + SalesTaxPct.ToString() + "%):"; // updated; 11/7/2018 - needed format update to lblTax
            }
        }

        // validate data

        public bool IsValidData()
        {
            return
                IsPresent(txtProductTotal, "Subtotal") &&
                IsDecimal(txtProductTotal, "Subtotal") &&
                IsWithinRange(txtProductTotal, "Subtotal", 0, 1000000);
        }

        public bool IsPresent(TextBox textBox, string name)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show(name + " is a required field.", "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
        }

        public bool IsDecimal(TextBox textBox, string name)
        {
            decimal number = 0m;
            if (Decimal.TryParse(textBox.Text, out number))
            {
                return true;
            }
            else
            {
                MessageBox.Show(name + " must be a decimal number.", "Entry Error");
                textBox.Focus();
                return false;
            }
        }

        public bool IsWithinRange(TextBox textBox, string name,
            decimal min, decimal max)
        {
            decimal number = Convert.ToDecimal(textBox.Text);
            if (number <= min || number >= max)
            {
                MessageBox.Show(name + " must be between " + min +
                    " and " + max + ".", "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
        }

        // validation of data - end

        // exit on click

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}