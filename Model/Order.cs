using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfNorthwindApp.Model
{
    public  class Order : INotifyPropertyChanged
    {
        #region OrderID
        private int orderID;

        public int OrderID
        {
            get
            {
                return orderID;
            }
            set
            {
                orderID = value;
                OnPropertyChanged("OrderID");
            }
        }
        #endregion

        #region CustomerID
        private string customerID;

        public string CustomerID
        {
            get
            {
                return customerID;
            }
            set
            {
                customerID = value;
                OnPropertyChanged("CustomerID");
            }
        }
        #endregion

        #region EmployeeID
        private int? employeeID;

        public int? EmployeeID
        {
            get
            {
                return employeeID;
            }
            set
            {
                employeeID = value;
                OnPropertyChanged("EmployeeID");
            }
        }
        #endregion

        #region OrderDate
        private DateTime? orderDate;

        public DateTime? OrderDate
        {
            get
            {
                return orderDate;
            }
            set
            {
                orderDate = value;
                OnPropertyChanged("OrderDate");
            }
        }
        #endregion

        #region RequiredDate
        private DateTime? requiredDate;

        public DateTime? RequiredDate
        {
            get
            {
                return requiredDate;
            }
            set
            {
                requiredDate = value;
                OnPropertyChanged("RequiredDate");
            }
        }
        #endregion

        #region ShippedDate
        private DateTime? shippedDate;

        public DateTime? ShippedDate
        {
            get
            {
                return shippedDate;
            }
            set
            {
                shippedDate = value;
                OnPropertyChanged("ShippedDate");
            }
        }
        #endregion

        #region ShipVia
        private int? shipVia;

        public int? ShipVia
        {
            get
            {
                return shipVia;
            }
            set
            {
                shipVia = value;
                OnPropertyChanged("ShipVia");
            }
        }
        #endregion

        #region Freight
        private decimal? freight;

        public decimal? Freight
        {
            get
            {
                return freight;
            }
            set
            {
                freight = value;
                OnPropertyChanged("Freight");
            }
        }
        #endregion

        #region ShipName
        private string shipName;

        public string ShipName
        {
            get
            {
                return shipName;
            }
            set
            {
                shipName = value;
                OnPropertyChanged("ShipName");
            }
        }
        #endregion

        #region ShipAddress
        private string shipAddress;

        public string ShipAddress
        {
            get
            {
                return shipAddress;
            }
            set
            {
                shipAddress = value;
                OnPropertyChanged("ShipAddress");
            }
        }
        #endregion

        #region ShipCity
        private string shipCity;

        public string ShipCity
        {
            get
            {
                return shipCity;
            }
            set
            {
                shipCity = value;
                OnPropertyChanged("ShipCity");
            }
        }
        #endregion

        #region ShipRegion
        private string shipRegion;

        public string ShipRegion
        {
            get
            {
                return shipRegion;
            }
            set
            {
                shipRegion = value;
                OnPropertyChanged("ShipRegion");
            }
        }
        #endregion

        #region ShipPostalCode
        private string shipPostalCode;

        public string ShipPostalCode
        {
            get
            {
                return shipPostalCode;
            }
            set
            {
                shipPostalCode = value;
                OnPropertyChanged("ShipPostalCode");
            }
        }
        #endregion

        #region ShipCountry
        private string shipCountry;

        public string ShipCountry
        {
            get
            {
                return shipCountry;
            }
            set
            {
                shipCountry = value;
                OnPropertyChanged("ShipCountry");
            }
        }
        #endregion

        #region CompanyName
        private string companyName;

        public string CompanyName
        {
            get
            {
                return companyName;
            }
            set
            {
                companyName = value;
                OnPropertyChanged("CompanyName");
            }
        }
        #endregion

        #region ContactName
        private string contactName;

        public string ContactName
        {
            get
            {
                return contactName;
            }
            set
            {
                contactName = value;
                OnPropertyChanged("ContactName");
            }
        }
        #endregion

        #region EmployeName
        private string employeName;

        public string EmployeName
        {
            get
            {
                return employeName;
            }
            set
            {
                employeName = value;
                OnPropertyChanged("EmployeName");
            }
        }
        #endregion

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion
    }
}
