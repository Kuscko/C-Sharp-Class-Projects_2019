using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_1ScoreCalculator
{
    public partial class frmScoreCalculator : Form
    {

        /*
         * Author: Patrick Kelly
         * Date: 10/02/2018
         * This calculator uses lists and outputs them onto strings.
         */
        public frmScoreCalculator()
        {
            InitializeComponent();
        }

        int score = 0;
        decimal scoreTotal = 0;
        int scoreCount = 0;
        decimal average = 0;
        List<int> scoreList = new List<int>(20); //This declares the list to store the information for the user.


        /*
            The following function activeates when the Add_click button is clicked. 
            It gets the score the user enters, creates a score count and gets the number for it from the list length.
        */
        private void btnAdd_Click(object sender, EventArgs e)
        {
            score = int.Parse(tbScore.Text);
            scoreList.Add(score);
            scoreTotal += score;
            scoreCount = scoreList.Count();
            average = scoreTotal / scoreCount;
            tbScoreTotal.Text = scoreTotal.ToString();
            tbScoreCount.Text = scoreCount.ToString();
            tbAverage.Text = average.ToString();
            tbScore.Clear();
            tbScore.Focus();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            scoreList.Clear();
            score = 0;
            scoreTotal = 0;
            scoreCount = 0;
            average = 0;
            
            tbScoreTotal.Clear();
            tbScoreCount.Clear();
            tbAverage.Clear();
            tbScore.Clear();
            tbScore.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            scoreList.Sort();
            string scoreString = "";
            foreach (int number in scoreList)
            {
                scoreString += number + "\n";
            }
            MessageBox.Show(scoreString, "Sorted Scores");
        }
    }
}
