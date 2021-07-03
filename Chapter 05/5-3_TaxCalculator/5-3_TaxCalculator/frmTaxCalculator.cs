using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5_3_TaxCalculator
{
    public partial class frmTaxCalculator : Form
    {
        /*
         *  Author: Patrick Kelly
         *  Date: 08/28/2018
         */
        public frmTaxCalculator()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal income = decimal.Parse(tbTaxIncome.Text);
            decimal taxOwed = 0m;

            if (income <= 9225)
            {
                taxOwed = income * .1m;
            }
            else if(income > 9225 && income <= 37450)
            {
                taxOwed = (((income - 9225m) * .15m) + 922.50m);
            }
            else if (income > 37450 && income <= 90750)
            {
                taxOwed = (((income - 37450) * 0.25m) + 5156.25m);
            }
            else if (income > 90750 && income <= 189300)
            {
                taxOwed = (((income - 90750)* 0.28m) + 18481.25m);
            }
            else if (income > 189300 && income <= 411500)
            {
                taxOwed = (((income - 189300) * 0.33m) + 46075.25m);
            }
            else if (income > 411500 && income <= 413200)
            {
                taxOwed = (((income - 411500)* 0.35m) + 119401.25m);
            }
            else
            {
                taxOwed = (((income - 413200) * 0.396m) + 199966.25m);
            }

            tbTaxOwed.Text = taxOwed.ToString("c");
            tbTaxIncome.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
