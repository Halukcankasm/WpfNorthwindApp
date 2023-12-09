using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfNorthwindApp.Model;
using System.Data;
using WpfNorthwindApp.Resource;

namespace WpfNorthwindApp.ModelView
{
    public class ProductVM
    {
        private SqlConnection cnn;

        public List<Product> ProductList;

        public ProductVM() 
        { 
            ProductList = new List<Product>();
            OpenDatabase();
        }

        public List<Product> GetProduct()
        {
            OpenDatabase();
            if (cnn.State == ConnectionState.Open)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[sel_Product]";
                SqlDataReader reader = cmd.ExecuteReader();
                
                while (reader.Read()) 
                {
                    Product product = new Product();
                    product.ProductId = reader.GetInt32(reader.GetOrdinal("ProductID"));
                    product.ProductName = reader.GetString(reader.GetOrdinal("ProductName"));
                    product.SupplierID = SqlHelper.GetNullableInt(reader, "SupplierID");
                    product.CategoryID = SqlHelper.GetNullableInt(reader, "CategoryID");
                    product.UnitPrice = SqlHelper.GetNullableDecimal(reader, "UnitPrice");
                    product.UnitsInStock = SqlHelper.GetNullableInt16(reader, "UnitsInStock");
                    product.UnitsOnOrder = SqlHelper.GetNullableInt16(reader, "UnitsOnOrder");
                    product.ReorderLevel = SqlHelper.GetNullableInt16(reader, "ReorderLevel");
                    product.Discontinued = reader.GetBoolean(reader.GetOrdinal("Discontinued"));
                    ProductList.Add(product);
                }
                cnn.Close();
            }
            return ProductList;
        }
        private void OpenDatabase()
        {
            try
            {
                cnn = new SqlConnection("server=LAPTOP-S65PUQCG\\SQLEXPRESS01; database=NORTHWND; integrated security=true");
                cnn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database bağlanırken sorun oluştu!.\n{ex.Message}", "Error");
            }
        }
    }
}
