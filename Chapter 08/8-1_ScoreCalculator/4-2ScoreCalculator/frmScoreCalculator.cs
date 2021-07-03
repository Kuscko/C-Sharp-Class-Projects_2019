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
         * Date: 09/06/2018
         * This calculator uses arrays and outputs them onto strings.
         */
        public frmScoreCalculator()
        {
            InitializeComponent();
        }

        decimal score = 0;
        decimal scoreTotal = 0;
        int scoreCount = 0;
        decimal average = 0;
        decimal[] scoreArray = new decimal[20];

        private void btnAdd_Click(object sender, EventArgs e)
        {
            score = decimal.Parse(tbScore.Text);
            scoreArray[scoreCount] = score;
            scoreTotal += score;
            scoreCount += 1;
            average = scoreTotal / scoreCount;
            tbScoreTotal.Text = scoreTotal.ToString();
            tbScoreCount.Text = scoreCount.ToString();
            tbAverage.Text = average.ToString();
            tbScore.Clear();
            tbScore.Focus();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            decimal[] clearArray = new decimal[20];
            Array.Copy(clearArray, scoreArray, 20);
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
            
            decimal[] displayArray = new decimal[scoreCount];
            Array.Copy(scoreArray, displayArray, scoreCount);
            Array.Sort(displayArray);
            string scoreString = "";
            foreach (Decimal number in displayArray)
            {
                scoreString += number + "\n";
            }
            MessageBox.Show(scoreString, "Sorted Scores");
        }
    }
}
