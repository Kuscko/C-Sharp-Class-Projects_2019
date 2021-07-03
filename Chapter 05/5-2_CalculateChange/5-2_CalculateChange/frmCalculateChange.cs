using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5_2_CalculateChange
{
    public partial class frmCalculateChange : Form
    {

        /*
         *  Author: Patrick Kelly
         *  Date: 08/28/2018
         */
        public frmCalculateChange()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int change = int.Parse(tbChange.Text);
            int quarters = 0;
            int dimes = 0;
            int nickels = 0;
            int pennies = 0;

            // I created a conditional statement to catch(instead of makeing an exception catch)
            // whether or not the user puts in anything higher than 99
            // cents.
            if(change >= 0 && change <= 99)
            {
                quarters = change / 25;
                change %= 25;
                dimes = change / 10;
                change %= 10;
                nickels = change / 5;
                change %= 5;
                pennies = change;
                tbQuarters.Text = quarters.ToString();
                tbDimes.Text = dimes.ToString();
                tbNickels.Text = nickels.ToString();
                tbPennies.Text = pennies.ToString();
            }
            else
            {
                MessageBox.Show("Cannot calculate change more than 100 or less than 0 cents.");
                tbChange.Clear();
                tbChange.Focus();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
