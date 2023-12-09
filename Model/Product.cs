using System.ComponentModel;

namespace WpfNorthwindApp.Model
{
    public class Product :INotifyPropertyChanged
    {
        #region ProductId
        private int productId;

        public int ProductId
        {
            get
            {
                return productId;
            }
            set
            {
                productId = value;
                OnPropertyChanged("ProductId");
            }
        }
        #endregion

        #region ProductName
        private string productName;

        public string ProductName
        {
            get
            {
                return productName;
            }
            set
            {
                productName = value;
                OnPropertyChanged("ProductName");
            }
        }
        #endregion


        #region SupplierID
        private int? supplierID;

        public int? SupplierID
        {
            get
            {
                return supplierID;
            }
            set
            {
                supplierID = value;
                OnPropertyChanged("SupplierID");
            }
        }
        #endregion

        #region CategoryID
        private int? categoryID;

        public int? CategoryID
        {
            get
            {
                return categoryID;
            }
            set
            {
                categoryID = value;
                OnPropertyChanged("CategoryID");
            }
        }
        #endregion

        #region QuantityPerUnit
        private string quantityPerUnit;

        public string QuantityPerUnit
        {
            get
            {
                return quantityPerUnit;
            }
            set
            {
                quantityPerUnit = value;
                OnPropertyChanged("QuantityPerUnit");
            }
        }
        #endregion

        #region UnitPrice
        private decimal? unitPrice;

        public decimal? UnitPrice
        {
            get
            {
                return unitPrice;
            }
            set
            {
                unitPrice = value;
                OnPropertyChanged("UnitPrice");
            }
        }
        #endregion

        #region UnitsInStock
        private int? unitsInStock;

        public int? UnitsInStock
        {
            get
            {
                return unitsInStock;
            }
            set
            {
                unitsInStock = value;
                OnPropertyChanged("UnitsInStock");
            }
        }
        #endregion

        #region UnitsOnOrder
        private int? unitsOnOrder;

        public int? UnitsOnOrder
        {
            get
            {
                return unitsOnOrder;
            }
            set
            {
                unitsOnOrder = value;
                OnPropertyChanged("UnitsOnOrder");
            }
        }
        #endregion

        #region ReorderLevel
        private int? reorderLevel;

        public int? ReorderLevel
        {
            get
            {
                return reorderLevel;
            }
            set
            {
                reorderLevel = value;
                OnPropertyChanged("ReorderLevel");
            }
        }
        #endregion

        #region Discontinued
        private bool discontinued;

        public bool Discontinued
        {
            get
            {
                return discontinued;
            }
            set
            {
                discontinued = value;
                OnPropertyChanged("Discontinued");
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
