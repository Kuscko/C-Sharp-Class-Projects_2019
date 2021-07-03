using System;
using System.Windows.Forms;

namespace LunchOrder
{
    /*
     *      Author: Patrick Kelly
     *      Modified: 10/18/2018
     */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Global Variables
        decimal addOnPrice = 0.75m;
        decimal mainPrice = 6.95m;
        decimal addOnTotal = 0m;
        decimal salesTax = 0m;
        decimal subtotal = 0m;
        decimal orderTotal = 0m;

        // arrays streamline and condense the methods bellow
        string[,] addOns = {
            {"Lettus, tomato, and onions", "Ketchup, mustard, and mayo", "French fries", "Add-on items ($.75/each)" },
            {"Pepperoni", "Sausage", "Olives", "Add-on items ($.50/each)"},
            {"Croutons", "Bacon bits", "Bread sticks", "Add-on items ($.25/each)" }
        };

        decimal[,] prices = {
            { 6.95m, 0.75m },
            { 5.95m, 0.50m },
            { 4.95m, 0.25m }
        };

        //Clears totals.
        private void ClearTotals()
        {
            lblOrderTotal.Text = "";
            lblSalesTax.Text = "";
            lblSubtotal.Text = "";

            // Clears the order total variables
            subtotal = 0;
            salesTax = 0;
            orderTotal = 0;
            addOnTotal = 0;

        }

        // Clears addons checkboxes
        private void ClearAddOns()
        {
            cbAddOnOne.Checked = false;
            cbAddOnTwo.Checked = false;
            cbAddOnThree.Checked = false;
        }

        /*
         * Statement that checks which Main course is selected and
         * changes the value of the lables sepcifically. Step 3.
         * 
         * This statement is a much more condensed version of the one bellow it.
         */
        private void Courses_CheckChanged(object sender, EventArgs e)
        {
            
            foreach(RadioButton radiobutton in gbxMainCourse.Controls)
            {
                if (radiobutton.Checked)
                {
                    int index = gbxMainCourse.Controls.IndexOf(radiobutton);
                    cbAddOnOne.Text = addOns[index, 0];
                    cbAddOnTwo.Text = addOns[index, 1];
                    cbAddOnThree.Text = addOns[index, 2];
                    gbxAddOns.Text = addOns[index, 3];
                    mainPrice = prices[index, 0];
                    addOnPrice = prices[index, 1];
                }
            }
            ClearTotals();
            ClearAddOns();
        }



        /*
         * Statement that checks which Main course is selected and
         * changes the value of the lables sepcifically. Step 3.
         */
        /* private void Courses_CheckChanged(object sender, EventArgs e)
        {
            if (rdoHamburger.Checked)
            {
                cbAddOnOne.Text = "Lettus, tomato, and onions";
                cbAddOnTwo.Text = "Ketchup, mustard, and mayo";
                cbAddOnThree.Text = "French fries";
                gbxAddOns.Text = "Add-on items ($.75/each)";
                addOnPrice = Convert.ToDecimal(0.75);
                mainPrice = Convert.ToDecimal(6.95);
            } else if(rdoPizza.Checked)
            {
                cbAddOnOne.Text = "Pepperoni";
                cbAddOnTwo.Text = "Sausage";
                cbAddOnThree.Text = "Olives";
                gbxAddOns.Text = "Add-on items ($.50/each)";
                addOnPrice = Convert.ToDecimal(0.50);
                mainPrice = Convert.ToDecimal(5.95);
            } else
            {
                cbAddOnOne.Text = "Croutons";
                cbAddOnTwo.Text = "Bacon bits";
                cbAddOnThree.Text = "Bread sticks";
                gbxAddOns.Text = "Add-on items ($.25/each)";
                addOnPrice = Convert.ToDecimal(0.25);
                mainPrice = Convert.ToDecimal(4.95);
            }

            //Clears the order totals
            ClearTotals();
            ClearAddOns();
        }
        */


        
        // Every time a Addon Checkbox is changed it will look through this to get the
        // Add on Total.
        private void Addons_CheckChanged(object sender, EventArgs e)
        {
            //This statement calls the ClearTotals method (step #7 of 10-2)
            ClearTotals();
            foreach (CheckBox checkbox in gbxAddOns.Controls)
            {
                if(checkbox.Checked)
                {
                    addOnTotal += addOnPrice;
                }
            }  
             
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            subtotal = mainPrice + addOnTotal;
            salesTax = subtotal * .0775m;
            orderTotal = subtotal + salesTax;

            lblSubtotal.Text = subtotal.ToString("C2");
            lblSalesTax.Text = salesTax.ToString("C2");
            lblOrderTotal.Text = orderTotal.ToString("C2");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}