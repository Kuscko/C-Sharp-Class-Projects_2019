using System;
using System.Windows.Forms;

namespace InvoiceTotal
{
    public partial class frmSalesTax : Form
    {

        /*
         * Author: Patrick Kelly
         * Date Created: 10/18/2018
         */


        // Global Variables
        decimal salesTaxPct = 0;

        public frmSalesTax()
        {
            InitializeComponent();
        }

        // This method allows the user to  pass the desired percentage between 0 and 10. It runs through a validation process to see if the
        // information that the user entered is correct.

        private void btnOK_Click(object sender, EventArgs e)

        {
            try
            {
                if (IsValidData()) {
                    salesTaxPct = Convert.ToDecimal(tboSalesTaxPct.Text);
                    this.Tag = salesTaxPct;
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.GetType().ToString() + "\n" + ex.StackTrace, "Exception");
            }



        }

        // validation of data

        public bool IsValidData()
        {
            return
                IsPresent(tboSalesTaxPct, "Sales Tax Pct") &&
                IsDecimal(tboSalesTaxPct, "Sales Tax Pct") &&
                IsWithinRange(tboSalesTaxPct, "Sales Tax Pct", 0, 10);
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
            if (number < min || number > max)
            {
                MessageBox.Show(name + " must be between " + min +
                    " and " + max + ".", "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
        }
    }
}
