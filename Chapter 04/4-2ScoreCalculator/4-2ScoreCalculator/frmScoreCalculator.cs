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
         * Date: 8/28/2018
         */
        public frmScoreCalculator()
        {
            InitializeComponent();
        }

        decimal score = 0;
        decimal scoreTotal = 0;
        decimal scoreCount = 0;
        decimal average = 0;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            score = decimal.Parse(tbScore.Text);
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
    }
}
