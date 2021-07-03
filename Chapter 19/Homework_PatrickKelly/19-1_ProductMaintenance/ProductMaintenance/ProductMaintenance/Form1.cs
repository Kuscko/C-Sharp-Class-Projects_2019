using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProductMaintenance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mMABooksDataSet);

        }

        private void fillByProductCodeToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                int productID = Convert.ToInt32(productIDToolStripTextBox.Text);
                this.productsTableAdapter.FillByProductCode(this.mMABooksDataSet.Products, productIDToolStripTextBox.Text);
                if(productsBindingSource.Count == 0)
                {
                    MessageBox.Show("No product found with this code. Please try again.", "Product Not Found");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void getAllProductsToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'mMABooksDataSet.Products' table. You can move, or remove it, as needed.
                this.productsTableAdapter.Fill(this.mMABooksDataSet.Products);
                
            } catch (SqlException ex)
            {
                MessageBox.Show(ex.Number + "\n" + ex.Message, ex.GetType().ToString());
            }
        }
    }
}
