using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoundControlsApp
{
    public partial class frmBoundData : Form
    {
        public frmBoundData()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_MMABooks_3DataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this._MMABooks_3DataSet.Products);

        }



        private void btnFirst_Click(object sender, EventArgs e)
        {
            productsBindingSource.MoveFirst();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            productsBindingSource.MovePrevious();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            productsBindingSource.MoveNext();
        }


        private void btnLast_Click(object sender, EventArgs e)
        {
            productsBindingSource.MoveLast();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            productsBindingSource.AddNew();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            this.Validate();
            this.productsBindingSource.EndEdit();
            this.productsAdapterManager.UpdateAll(this._MMABooks_3DataSet);
            
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            productCodeTextBox.Text = "";
            descriptionTextBox.Text = "";
            unitPriceTextBox.Text = "";
            onHandQuantityTextBox.Text = "";
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            productsBindingSource.RemoveCurrent();
        }
    }
}
