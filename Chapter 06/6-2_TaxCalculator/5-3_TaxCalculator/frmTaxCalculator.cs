using System;
using System.Windows.Forms;

namespace _5_3_TaxCalculator
{
    public partial class frmTaxCalculator : Form
    {
        /* 
            Authoer: Patrick Kelly
            Date: 08/30/2018
        */
        public frmTaxCalculator()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal income = decimal.Parse(tbTaxIncome.Text);
            decimal taxOwed = CalculateTax(income); //Calls CalculateTax Method, returns taxes: assigned to taxOwed.

            tbTaxOwed.Text = taxOwed.ToString("c");
            tbTaxIncome.Focus();
        }

        private decimal CalculateTax(decimal income)
        {
            decimal taxes = 0m;
            if (income <= 9225)
            {
                taxes = income * .1m;
            }
            else if (income > 9225 && income <= 37450)
            {
                taxes = (((income - 9225m) * .15m) + 922.50m);
            }
            else if (income > 37450 && income <= 90750)
            {
                taxes = (((income - 37450) * 0.25m) + 5156.25m);
            }
            else if (income > 90750 && income <= 189300)
            {
                taxes = (((income - 90750) * 0.28m) + 18481.25m);
            }
            else if (income > 189300 && income <= 411500)
            {
                taxes = (((income - 189300) * 0.33m) + 46075.25m);
            }
            else if (income > 411500 && income <= 413200)
            {
                taxes = (((income - 411500) * 0.35m) + 119401.25m);
            }
            else
            {
                taxes = (((income - 413200) * 0.396m) + 199966.25m);
            }
            return taxes;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbTaxIncome_TextChanged(object sender, EventArgs e)
        {
            tbTaxOwed.Clear();
        }
    }
}

