using System;
using System.Windows.Forms;

namespace Reservations
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValidData())
                {

                    //declares variables for the form, and retrieves the information entered by the user.
                    DateTime arrivalDate = DateTime.Parse(txtArrivalDate.Text);
                    DateTime departureDate = DateTime.Parse(txtDepartureDate.Text);
                    TimeSpan dateSpan = departureDate - arrivalDate;
                    long numberOfDays = dateSpan.Days;
                    decimal price = 0;
                    decimal totalPrice = 0;
                    decimal averagePrice = 0;
                    decimal extraChargeA = 0;
                    decimal extraChargeB = 0;
                    int a = 0;
                    int b = 0;

                    // Checks if the arrival date is less than the departure date.
                    if (arrivalDate < departureDate)
                    {
                        for (int i = 0; i <= numberOfDays - 1; i++)
                        {
                            DateTime date = arrivalDate.AddDays(i);
                            if(date.DayOfWeek == DayOfWeek.Friday || date.DayOfWeek == DayOfWeek.Saturday)
                            {
                                price = 150;
                                a += 1;
                                extraChargeA = a * price;
                            }
                            else
                            {
                                price = 120;
                                b += 1;
                                extraChargeB = b * price;
                            }
                        }
                        // calculates total price & average price per night
                        totalPrice = extraChargeA + extraChargeB;
                        averagePrice = totalPrice / numberOfDays;

                        // outputs the number of nights, total price, and average price to the form
                        txtNights.Text = numberOfDays.ToString();
                        txtTotalPrice.Text = totalPrice.ToString("c");
                        txtAvgPrice.Text = averagePrice.ToString("c");

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.GetType().ToString() + "\n" + ex.StackTrace, "Exception");
            }
        }

        public bool IsValidData()
        {
            return
                // Validates the Arrival Date Textbox
                IsPresent(txtArrivalDate, "Arrival Date") &&
                IsDateTime(txtArrivalDate, "Arrival Date") &&
                IsWithinRange(txtArrivalDate, "Arrival Date", DateTime.Today, DateTime.Today.AddYears(5)) &&

                // validates the Departure Date Texxtbox
                IsPresent(txtDepartureDate, "Departure Date") &&
                IsDateTime(txtDepartureDate, "Departure Date") &&
                IsWithinRange(txtDepartureDate, "Departure Date", DateTime.Today, DateTime.Today.AddYears(5));
        }

        // checks if the textbox has a present value.
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

        // Checks if the textbox has a valid date inside.
        public bool IsDateTime(TextBox textBox, string name)
        {
            DateTime trueDate;
            if (DateTime.TryParse(textBox.Text, out trueDate)){
                return true;
            } else
            {
                MessageBox.Show(name + " must be in a valid date format MM/DD/YYYY (Month/Day/Year)", "Entry Error");
                textBox.SelectAll();
                return false;
            }
            
        }

        // checks if the value of the text box is within a certain range.s
        public bool IsWithinRange(TextBox textBox, string name,
           DateTime min, DateTime max)
        {
            DateTime trueDate = DateTime.Parse(textBox.Text);
            if(trueDate < min || trueDate > max)
            {
                MessageBox.Show(name + "must be between " + min + "&" + max + ".", "Entry Error");
                textBox.SelectAll();
                return false;
            }
            return true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // This method is called on load of the form, and assigns the current date and three days later.  
        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime currentDate = DateTime.Today;
            DateTime futureDate = currentDate.AddDays(3);
            txtArrivalDate.Text = currentDate.ToShortDateString();
            txtDepartureDate.Text = futureDate.ToShortDateString();
        }
    }
}