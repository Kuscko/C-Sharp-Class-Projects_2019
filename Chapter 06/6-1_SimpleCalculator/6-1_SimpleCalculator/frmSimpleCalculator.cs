using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6_1_SimpleCalculator
{
    public partial class frmSimpleCalculator : Form
    {
        /* 
            Authoer: Patrick Kelly
            Date: 08/30/2018
        */
        public frmSimpleCalculator()
        {
            InitializeComponent();
        }


        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string operator1 = tbOperator.Text;
            decimal operand1 = Convert.ToDecimal(tbOperand1.Text);
            decimal operand2 = Convert.ToDecimal(tbOperand2.Text);
            decimal result = 0m;
            this.Calculate(operand1, operand2, ref result, operator1);
            tbResult.Text = result.ToString();
        }

        private void Calculate(decimal operand1, decimal operand2, ref decimal result, string operator1)
        {
            if (operator1 == "+")
            {
                result = operand1 + operand2;
            }
            else if (operator1 == "-")
            {
                result = operand1 - operand2;
            }
            else if (operator1 == "*" || operator1 == "x")
            {
                result = operand1 * operand2;
            }
            else if (operator1 == "/")
            {
                result = operand1 / operand2;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbOperand1_TextChanged(object sender, EventArgs e)
        {
            tbResult.Clear();
        }
    }
}
