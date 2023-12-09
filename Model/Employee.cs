using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfNorthwindApp.Model
{
    public class Employee : INotifyPropertyChanged
    {
        #region EmployeID
        private int employeeID;

        public int EmployeeID
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

        #region LastName
        private string lastName;

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
                OnPropertyChanged("LastName");
            }
        }
        #endregion

        #region FirstName
        private string firstName;

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
                OnPropertyChanged("FirstName");
            }
        }
        #endregion

        #region Title
        private string title;

        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
                OnPropertyChanged("Title");
            }
        }
        #endregion

        #region TitleOfCourtesy
        private string titleOfCourtesy;

        public string TitleOfCourtesy
        {
            get
            {
                return titleOfCourtesy;
            }
            set
            {
                titleOfCourtesy = value;
                OnPropertyChanged("Title");
            }
        }
        #endregion

        #region BirthDate
        private DateTime? birthDate;

        public DateTime? BirthDate
        {
            get
            {
                return birthDate;
            }
            set
            {
                birthDate = value;
                OnPropertyChanged("BirthDate");
            }
        }
        #endregion

        #region HireDate
        private DateTime? hireDate;

        public DateTime? HireDate
        {
            get
            {
                return hireDate;
            }
            set
            {
                hireDate = value;
                OnPropertyChanged("HireDate");
            }
        }
        #endregion

        #region Address
        private string address;

        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
                OnPropertyChanged("Address");
            }
        }
        #endregion

        #region City
        private string city;

        public string City
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
                OnPropertyChanged("City");
            }
        }
        #endregion

        #region Region
        private string region;

        public string Region
        {
            get
            {
                return region;
            }
            set
            {
                region = value;
                OnPropertyChanged("Region");
            }
        }
        #endregion

        #region PostalCode
        private string postalCode;

        public string PostalCode
        {
            get
            {
                return postalCode;
            }
            set
            {
                postalCode = value;
                OnPropertyChanged("PostalCode");
            }
        }
        #endregion

        #region Country
        private string country;

        public string Country
        {
            get
            {
                return country;
            }
            set
            {
                country = value;
                OnPropertyChanged("Country");
            }
        }
        #endregion

        #region HomePhone
        private string homePhone;

        public string HomePhone
        {
            get
            {
                return homePhone;
            }
            set
            {
                homePhone = value;
                OnPropertyChanged("HomePhone");
            }
        }
        #endregion

        #region Extension
        private string extension;

        public string Extension
        {
            get
            {
                return extension;
            }
            set
            {
                extension = value;
                OnPropertyChanged("Extension");
            }
        }
        #endregion

        #region Photo
        private byte[] photo;

        public byte[] Photo
        {
            get
            {
                return photo;
            }
            set
            {
                photo = value;
                OnPropertyChanged("Photo");
            }
        }
        #endregion

        #region Notes
        private string notes;

        public string Notes
        {
            get
            {
                return notes;
            }
            set
            {
                notes = value;
                OnPropertyChanged("Notes");
            }
        }
        #endregion

        #region ReportsTo
        private int? reportsTo;

        public int? ReportsTo
        {
            get
            {
                return reportsTo;
            }
            set
            {
                reportsTo = value;
                OnPropertyChanged("ReportsTo");
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
