using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WpfNorthwindApp.Model;
using WpfNorthwindApp.Resource;
using WpfNorthwindApp.View;

namespace WpfNorthwindApp.ModelView
{

    public  class OrdersVM
    {
        private SqlConnection cnn;

        public ObservableCollection<Order> OrdersList;

        public OrdersVM()
        {
            OrdersList = new ObservableCollection<Order>();
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

        public ObservableCollection<Order> GetOrders()
        {
            OpenDatabase();
            if (cnn.State == ConnectionState.Open)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[sel_Orders]";
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Order order = new Order();
                    order.OrderID = dr.GetInt32(dr.GetOrdinal("OrderID"));
                    order.CustomerID = SqlHelper.GetNullableString(dr, "CustomerID");
                    order.EmployeeID = SqlHelper.GetNullableInt(dr, "EmployeeID");
                    order.OrderDate = SqlHelper.GetNullableDateTime(dr, "OrderDate");
                    order.RequiredDate = SqlHelper.GetNullableDateTime(dr, "RequiredDate");
                    order.ShippedDate = SqlHelper.GetNullableDateTime(dr, "ShippedDate");
                    order.ShipVia = SqlHelper.GetNullableInt(dr, "ShipVia");
                    order.Freight = SqlHelper.GetNullableDecimal(dr, "Freight");
                    order.ShipName = SqlHelper.GetNullableString(dr, "ShipName");
                    order.ShipAddress = SqlHelper.GetNullableString(dr, "ShipAddress");
                    order.ShipCity = SqlHelper.GetNullableString(dr, "ShipCity");
                    order.ShipRegion = SqlHelper.GetNullableString(dr, "ShipRegion");
                    order.ShipPostalCode = SqlHelper.GetNullableString(dr, "ShipPostalCode");
                    order.ShipCountry = SqlHelper.GetNullableString(dr, "ShipCountry");
                    order.EmployeName = SqlHelper.GetNullableString(dr, "EmployeName");
                    order.CompanyName = SqlHelper.GetNullableString(dr, "CompanyName");
                    order.ContactName = SqlHelper.GetNullableString(dr, "ContactName");
                    OrdersList.Add(order);
                }
                cnn.Close();
            }
            return OrdersList;
        }

    }
}
