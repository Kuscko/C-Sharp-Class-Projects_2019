using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ProductMaintenance
{
    public class ProductDB
    {
        public static Product GetProduct(string code)
        {
            // creats a connection to the database
            SqlConnection connection = MMABooksDB.GetConnection();
            // SQL Server Select statement that uses a parameter @ProductCode
            string selectStatement
                = "SELECT ProductCode, Description, UnitPrice "
                + "FROM Products "
                + "WHERE ProductCode = @ProductCode";
            // selects data from the from the database using the 'connection' and with the 'selectstatement'
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            // inserts product code from the txtCode to retrieve the information @ProductCode
            selectCommand.Parameters.AddWithValue("@ProductCode", code);

            try
            {
                // opens the connection to the database, creating a path so the reader can execute.
                connection.Open();
                // creates SqlDataREader Object that executes a reader and retrieves a single row.
                SqlDataReader productReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow);
                if (productReader.Read())
                {
                    // creates a new product Object
                    Product product = new Product();
                    product.Code = productReader["ProductCode"].ToString();
                    product.Description = productReader["Description"].ToString();
                    product.Price = (decimal)productReader["UnitPrice"];
                    // returns Product object for the product
                    return product;
                }
                else
                {
                    // returns null if product is not found.
                    return null;
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }

        public static bool UpdateProduct(Product oldProduct, Product newProduct)
        {
            SqlConnection connection = MMABooksDB.GetConnection();
            string updateStatement =
                "UPDATE Products SET " +
                "Description = @NewDescription, " +
                "UnitPrice = @NewPrice " +
                "WHERE ProductCode = @ProductCode";
            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);
            updateCommand.Parameters.AddWithValue("@NewDescription", newProduct.Description);
            updateCommand.Parameters.AddWithValue("@NewPrice", newProduct.Price);
            updateCommand.Parameters.AddWithValue("@ProductCode", newProduct.Code);
            try
            {
                connection.Open();
                int count = updateCommand.ExecuteNonQuery();
                if(count > 0)
                {
                    return true;
                } else
                {
                    return false;
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }

        public static bool AddProduct(Product product)
        {
            SqlConnection connection = MMABooksDB.GetConnection();
            string insertStatement =
                "INSERT Products " +
                "(ProductCode, Description, UnitPrice) " +
                "VALUES(@Code, @Description, @Price)";
            SqlCommand insertCommand =
                new SqlCommand(insertStatement, connection);
            insertCommand.Parameters.AddWithValue("@Code", product.Code);
            insertCommand.Parameters.AddWithValue("@Description", product.Description);
            insertCommand.Parameters.AddWithValue("@Price", product.Price);
            try
            {
                connection.Open();
                int count = insertCommand.ExecuteNonQuery();
                if (count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }

        public static bool DeleteProduct(Product product)
        {
            SqlConnection connection = MMABooksDB.GetConnection();
            string deleteStatement =
                "DELETE FROM Products " +
                "WHERE ProductCode = @Code ";
            SqlCommand deleteCommand = new SqlCommand(deleteStatement, connection);
            deleteCommand.Parameters.AddWithValue("@Code", product.Code);
            try
            {
                connection.Open();
                int count = deleteCommand.ExecuteNonQuery();
                if (count > 0)
                    return true;
                else
                    return false;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
