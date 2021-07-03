using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factorial
{
    public partial class frmFactorials : Form
    {
        /*
         * Author: Patrick Kelly
         * Date: 08/28/2018
         */
        public frmFactorials()
        {
            InitializeComponent();
        }
        // BtnCalc_Click; Takes 1 as a "base number" and multiplies on itself over and over until it reaches the declared "number".
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Int32 number = Int32.Parse(tbNumber.Text);
            Int64 factorial = 1;
            Int32 basenumber = 1;

            if (number <= 20 || number >= 0)
            {
                if (number == 0)
                { //I did this simple because it was a simple solution.
                    tbFactorial.Text = number.ToString();
                }
                else
                {

                    while (basenumber <= number)//While basenumber is less than or equal to declared number. Run
                    {
                        factorial = factorial * basenumber; //Multiply on itself from 1-number.
                        basenumber += 1;//Adds 1 to basenumber until while condition is met.
                    }
                    tbFactorial.Text = string.Format("{0:N0}", factorial);

                }
            }
            else
            { //Extra stuff for the if-else conditions.
                MessageBox.Show("We cannot calculate higher than number 20 or lower than 0");
                tbNumber.Clear();
                tbNumber.Focus();
            }


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
