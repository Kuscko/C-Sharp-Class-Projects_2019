using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringHandling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*
         * This function gets the user's entered email, it's length then finds the index of both the comhartha and the period and trims the email.
         * If it does not have a comhartha(@) or a period then it returns an error box message. 
         * Otherwise the method parses the username and the domain of the email.
         * Then outputs these values to a messagebox.
         */
        private void btnParse_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string username = "";
            string domain = "";

            int emailLength = email.Length;
            int comhartha = email.IndexOf("@");
            int period = email.IndexOf(".");
            email = email.Trim();
            

            if(comhartha == -1 || period == -1 )
            {
                MessageBox.Show("Please use an at sign (@) or a period (.) inside of your email.", "entry error.");
                txtEmail.Select();
            } else
            {
                username = email.Substring(0, comhartha);
                email.Replace(username, "");
                domain = email.Substring(comhartha + 1);
            }
            MessageBox.Show("User Name: " + username + "\n\n" + "Domain Name: " + domain, "Parsed String");
        }

        /*
         * 
         * This function gets the user's entered city, state and zipcode. IT assumes the values are correct.
         * It then capitalizes the first letter of the city, and the full state.
         * 
         * Then the method inserts a comma and a space between each string value and outputs it to
         * a messagebox.
         * 
         */

        private void btnFormat_Click(object sender, EventArgs e)
        {
            string city = txtCity.Text;
            string state = txtState.Text;
            string zipCode = txtZipCode.Text;

            int cityLength = city.Length;
            int stateLength = state.Length;
            int zipCodeLength = zipCode.Length;
            
            state = state.ToUpper();
            city = city.Substring(0, 1).ToUpper() + city.Substring(1).ToLower();

            string formattedString = city + state + zipCode;

            formattedString = formattedString.Insert(cityLength, ", ");
            formattedString = formattedString.Insert(cityLength + 4, " ");

            MessageBox.Show("City, State, Zip: " + formattedString, "Formatted String");
        }
    }
}
