using System;
using System.Windows.Forms;

/*
 *      Author: Patrick Kelly
 *      Modified: 10/18/2018
 */

namespace Conversions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // globabl variable

        string[,] conversionTable = {
			{"Miles to kilometers", "Miles", "Kilometers", "1.6093"},
			{"Kilometers to miles", "Kilometers", "Miles", "0.6214"},
			{"Feet to meters", "Feet", "Meters", "0.3048"},
			{"Meters to feet", "Meters", "Feet", "3.2808"},
			{"Inches to centimeters", "Inches", "Centimeters", "2.54"},
			{"Centimeters to inches", "Centimeters", "Inches", "0.3937"}
		};
        

        // TRYS to validate the data, if the data is valid then it will perform the conversions.
        // If the data is not valid then it will catch and display the exception.
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (isValidData())
                {
                    int index = cboConversions.SelectedIndex;
                    decimal fromLength = Convert.ToDecimal(txtLength.Text);
                    decimal multiplier = Convert.ToDecimal(conversionTable[index, 3]);
                    decimal conversion = fromLength * multiplier;
                    lblCalculatedLength.Text = conversion.ToString("F");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.GetType().ToString() + "\n" + ex.StackTrace, "Exception");
            }
        }

        // checks if the combo box changes value and changes the labels to the respective counter parts for the conversions.
        private void cboConversions_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cboConversions.SelectedIndex;
            lblFromLength.Text = conversionTable[index, 1];
            lblToLength.Text = conversionTable[index, 2];
            lblCalculatedLength.Text = "";
            txtLength.Clear();
            txtLength.Focus();
        }


        // Validates Data - Start
        public bool isValidData()
        {
            int index = cboConversions.SelectedIndex;
            return
                IsPresent(txtLength, conversionTable[index, 1]) &&
                IsDecimal(txtLength, conversionTable[index, 1]);

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
            try
            {
                Convert.ToDecimal(textBox.Text);
                return true;
            }
            catch (FormatException)
            {
                MessageBox.Show(name + " must be a decimal number.", "Entry Error");
                textBox.Focus();
                return false;
            }
        }

        // Validate Data - End

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        // Loads the first item in the rectangular array to the combo box on the form.
        private void Form1_Load(object sender, EventArgs e)
        {
            for(var i = 0; i < 5; i++)
            {
                cboConversions.Items.Add(conversionTable[i, 0]);
                cboConversions.SelectedIndex = 0;
            }
        }

       
        }
}