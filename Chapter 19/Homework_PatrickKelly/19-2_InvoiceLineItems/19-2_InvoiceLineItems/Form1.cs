using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceLineItems
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_MMABooks_3DataSet.InvoiceLineItems' table. You can move, or remove it, as needed.
            this.invoiceLineItemsTableAdapter.Fill(this._MMABooks_3DataSet.InvoiceLineItems);
        }

        private void fillByInvoiceIDToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                int productID = Convert.ToInt32(invoiceIDToolStripTextBox.Text);
                
                invoicesTableAdapter.FillByInvoiceID(_MMABooks_3DataSet.Invoices, productID);
                invoiceLineItemsTableAdapter.FillByInvoiceID(_MMABooks_3DataSet.InvoiceLineItems, productID);
                if (invoicesBindingSource.Count == 0)
                {
                    MessageBox.Show("No invoice found with this ID. Please try again.", "Invoice Not Found");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Invoice ID must be an integer.", "Entry Error");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Number + "\n" + ex.Message, ex.GetType().ToString());
            }

        }
    }
}
