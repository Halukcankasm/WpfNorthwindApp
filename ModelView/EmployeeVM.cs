using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using WpfNorthwindApp.Model;
using WpfNorthwindApp.Resource;
using MessageBox = System.Windows.MessageBox;

namespace WpfNorthwindApp.ModelView
{
    public class EmployeeVM
    {
        private SqlConnection cnn;

        public ObservableCollection<Employee> EmployeList;

        public EmployeeVM() 
        {
            EmployeList = new ObservableCollection<Employee>();
        }

        public ObservableCollection<Employee> GetEmployess()
        {
            OpenDatabase();
            if (cnn.State == ConnectionState.Open)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[sel_Employee]";                 
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Employee employee = new Employee();
                    employee.EmployeeID = dr.GetInt32(dr.GetOrdinal("EmployeeID"));
                    employee.FirstName = dr.GetString(dr.GetOrdinal("FirstName"));
                    employee.LastName = dr.GetString(dr.GetOrdinal("LastName"));
                    employee.Title = SqlHelper.GetNullableString(dr, "Title");
                    employee.TitleOfCourtesy = SqlHelper.GetNullableString(dr, "TitleOfCourtesy"); 
                    employee.BirthDate = SqlHelper.GetNullableDateTime(dr, "BirthDate");
                    employee.HireDate = SqlHelper.GetNullableDateTime(dr, "HireDate"); 
                    employee.Address = SqlHelper.GetNullableString(dr, "Address");
                    employee.City = SqlHelper.GetNullableString(dr, "City"); 
                    employee.Region = SqlHelper.GetNullableString(dr, "Region");
                    employee.PostalCode = SqlHelper.GetNullableString(dr, "PostalCode");
                    employee.Country = SqlHelper.GetNullableString(dr, "Country");
                    employee.HomePhone = SqlHelper.GetNullableString(dr, "HomePhone");
                    employee.Extension = SqlHelper.GetNullableString(dr, "Extension");
                    employee.Notes = SqlHelper.GetNullableString(dr, "Notes");
                    employee.ReportsTo = SqlHelper.GetNullableInt(dr, "ReportsTo");
                    employee.Photo = SqlHelper.GetNullableByteArray(dr,"Photo");
                    EmployeList.Add(employee);
                }
                cnn.Close();
            }
            return EmployeList; 
        }

        public void InsertEmploye(Employee employee)
        {
            OpenDatabase();
            if (cnn.State == ConnectionState.Open)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[ins_Employee]";
                cmd.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = employee.FirstName; 
                cmd.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = employee.LastName; 
                cmd.Parameters.Add("@Title", SqlDbType.NVarChar).Value = employee.Title == null ? string.Empty : employee.Title;
                cmd.Parameters.Add("@BirthDate", SqlDbType.DateTime).Value = employee.BirthDate; 
                cmd.Parameters.Add("@Address", SqlDbType.NVarChar).Value = employee.Address;
                cmd.Parameters.Add("@HomePhone", SqlDbType.NVarChar).Value = employee.HomePhone;
                var result = cmd.ExecuteNonQuery();
                cnn.Close();
            }
        }


        public void DeleteEmploye(int employeeId)
        {
            OpenDatabase();
            if (cnn.State == ConnectionState.Open)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[del_EmployeeByEmpId]";
                cmd.Parameters.Add("@EmpId", SqlDbType.VarChar).Value = employeeId;
                var result = cmd.ExecuteNonQuery();
                cnn.Close();
            }
        }


        public void Update(Employee employee)
        {
            OpenDatabase();
            if (cnn.State == ConnectionState.Open)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "[dbo].[upd_EmployeeByEmpID]";
                cmd.Parameters.Add("@EmpID ", SqlDbType.Int).Value = employee.EmployeeID;
                cmd.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = employee.LastName;
                cmd.Parameters.Add("@FirstName ", SqlDbType.NVarChar).Value = employee.FirstName;
                cmd.Parameters.Add("@Title", SqlDbType.NVarChar).Value = employee.Title;
                cmd.Parameters.Add("@TitleOfCourtesy", SqlDbType.NVarChar).Value = employee.TitleOfCourtesy;
                cmd.Parameters.Add("@BirthDate", SqlDbType.DateTime).Value = employee.BirthDate;
                cmd.Parameters.Add("@HireDate", SqlDbType.DateTime).Value = employee.HireDate;
                cmd.Parameters.Add("@Address", SqlDbType.NVarChar).Value = employee.Address;
                cmd.Parameters.Add("@City", SqlDbType.NVarChar).Value = employee.City;
                cmd.Parameters.Add("@Region", SqlDbType.NVarChar).Value = employee.Region;
                cmd.Parameters.Add("@PostalCode", SqlDbType.NVarChar).Value = employee.PostalCode;
                cmd.Parameters.Add("@Country", SqlDbType.NVarChar).Value = employee.Country;
                cmd.Parameters.Add("@HomePhone", SqlDbType.NVarChar).Value = employee.HomePhone;
                cmd.Parameters.Add("@Extension", SqlDbType.NVarChar).Value = employee.Extension;
                cmd.Parameters.Add("@Photo", SqlDbType.Image).Value = employee.Photo;
                cmd.Parameters.Add("@Notes", SqlDbType.NText).Value = employee.Notes;
                cmd.Parameters.Add("@ReportsTo", SqlDbType.Int).Value = employee.ReportsTo;
                var result = cmd.ExecuteNonQuery();
                cnn.Close();
            }
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
