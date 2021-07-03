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
            Date: 09/06/2018
        */
        public frmSimpleCalculator()
        {
            InitializeComponent();
        }


        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValidData())
                {
                    string operator1 = tbOperator.Text;
                    decimal operand1 = Convert.ToDecimal(tbOperand1.Text);
                    decimal operand2 = Convert.ToDecimal(tbOperand2.Text);
                    decimal result = 0m;
                    this.Calculate(operand1, operand2, ref result, operator1);
                    tbResult.Text = result.ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.GetType().ToString() + "\n" + ex.StackTrace, "Exception");
            }
            
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

        public bool IsValidData()
        {
            return

                // Validate the Operand 1 Textbox
                IsPresent(tbOperand1, "Operand 1") &&
                IsDecimal(tbOperand1, "Operand 1") &&
                IsWithinRange(tbOperand1, "Operand 1", 0, 1000000) &&

                // Validate the Operator Textbox
                IsPresent(tbOperator, "Operator") &&
                IsOperator(tbOperator, "Operator") &&

                // Validate the Operator Textbox
                IsPresent(tbOperand2, "Operand 2") &&
                IsDecimal(tbOperand2, "Operand 2") &&
                IsWithinRange(tbOperand2, "Operand 2", 0, 1000000);
        }

        public bool IsPresent(TextBox textbox, string name)
        {
            if(textbox.Text == "")
            {
                MessageBox.Show(name + " is a required feild.", "Entry Error");
                textbox.Focus();
                return false;
            }
            return true;
        }

        public bool IsDecimal(TextBox textbox, string name)
        {
            decimal number = 0m;
            if (Decimal.TryParse(textbox.Text, out number)){
                return true;
            }
            else
            {
                MessageBox.Show(name + " must be a decimal value.", "Entry Error");
                textbox.Focus();
                return false;
            }
        }

        public bool IsWithinRange(TextBox textbox, string name, decimal min, decimal max)
        {
            decimal number = Convert.ToDecimal(textbox.Text);
            if (number < min || number > max)
            {
                MessageBox.Show(name + " must be between " + min.ToString("n0") + " and " + max.ToString("n0") + ".", "Entry Error");
                textbox.Focus();
                return false;
            }
            return true;
       }

        public bool IsOperator(TextBox textbox, string name)
        {
            string symbol = textbox.Text;
            if (symbol == "+" || symbol == "-" || symbol == "*" || symbol == "x" || symbol == "/")
            {
                return true;
            }
            MessageBox.Show(name + " must have specific opperators (+, -, *, x, /)");
            textbox.Focus();
            return false;
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
