using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Northwind_ADO_Project
{
    public partial class Form1 : Form
    {
        // string connectionString = "Data Source=(local);Initial Catalog=Northwind;" + "Integrated Security=true";

        // global control variables
        string value;
        string symbol;
        string filter;
     
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(local);Initial Catalog=Northwind;"
                                    + "Integrated Security=true";
            
            if(cboFilter.SelectedIndex == 0){
                filter = "ProductID";
            }else if (cboFilter.SelectedIndex == 1){
                filter = "ProductName";
            }else if (cboFilter.SelectedIndex == 2){
                filter = "SupplierID";
            }else if (cboFilter.SelectedIndex == 3){
                filter = "CategoryID";
            }else if (cboFilter.SelectedIndex == 4){
                filter = "QuantityPerUnit";
            }else if (cboFilter.SelectedIndex == 5){
                filter = "UnitPrice";
            }else if (cboFilter.SelectedIndex == 6){
                filter = "UnitsInStock";
            }else if (cboFilter.SelectedIndex == 7){
                filter = "UnitsOnOrder";
            }

            if(cboOperator.SelectedIndex == 0){
                symbol = "=";
            }else if(cboOperator.SelectedIndex == 1){
                symbol = ">";
            }else if (cboOperator.SelectedIndex == 2){
                symbol = ">=";
            }else if (cboOperator.SelectedIndex == 3){
                symbol = "<";
            }else if (cboOperator.SelectedIndex == 4){
                symbol = "<=";
            }

            value = txtValue.Text;

            // provide the uquery string with a parameter placeholder.
            string queryString = "SELECT ProductID, ProductName, SupplierID, CategoryID, QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnOrder, ReorderLevel, Discontinued from dbo.products " +
                                 "WHERE " + filter + symbol + value +
                                 "ORDER BT ProductID DESC";
            
            // creates a new connection by using the connectionString in a using block. This ensures that all
            // resources will be closed and displosed when the code exits
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Create the command and PArameter objects.
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@pricePoint", value);

                // open the connection in a try/catch block
                // Create and execute the DataReader, writing the result
                // set to the console window.
                try
                {
                    
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        // reader[0] would be the first field in a table
                        txtSupID.Text = Convert.ToString(reader[2]);
                        txtProductCode.Text = Convert.ToString(reader[0]);
                        txtProductName.Text = Convert.ToString(reader[1]);
                        txtListPrice.Text = Convert.ToString(reader[5]);
                        txtCategory.Text = Convert.ToString(reader[8]);
                        txtReorderLevel.Text = Convert.ToString(reader[4]);
                        txtQuantityPerUnit.Text = Convert.ToString(reader[7]);
                        txtUnitsonHand.Text = Convert.ToString(reader[6]);
                        txtDiscontinued.Text = Convert.ToString(reader[9]);

                        textBox1.Text = "Product Code" + "\t" + "Product Name" + "\t" + "List Price" + "\t\t" + "On Hand" + Environment.NewLine +
                            (Convert.ToString(reader[0])) + "\t\t" + (reader[1]) + "\t\t" + (reader[5]) + "\t\t" + (reader[6]);

                    }
                    reader.Close();
                } catch (Exception ex)
                {
                    throw ex;
                }
            }
        }        
    }
}
