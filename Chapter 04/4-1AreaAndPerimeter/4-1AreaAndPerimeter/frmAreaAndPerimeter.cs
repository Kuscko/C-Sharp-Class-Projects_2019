using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreaAndPerimeter
{
    /*
     * Author: Patrick Kelly
     * Date: 8/28/2018
     */
    public partial class frmAreaAndPerimeter : Form
    {
        public frmAreaAndPerimeter()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal length = decimal.Parse(tbLength.Text);
            decimal width = decimal.Parse(tbWidth.Text);
            decimal area = length * width;
            decimal perimeter = ((2 * length) + (2 * width));
            tbArea.Text = area.ToString();
            tbPerimeter.Text = perimeter.ToString();         
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
