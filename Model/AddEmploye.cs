using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfNorthwindApp.Model
{
    public class AddEmploye : INotifyPropertyChanged
    {
        #region IsEmptyTxt
        private bool isEmptyTxt;

        public bool IsEmptyTxt
        {
            get
            {
                return isEmptyTxt;
            }
            set
            {
                isEmptyTxt = value;
                OnPropertyChanged("IsEmptyTxt");
            }
        }
        #endregion

        #region ClearMessages
        private bool clearMessages;

        public bool ClearMessages
        {
            get
            {
                return clearMessages;
            }
            set
            {
                clearMessages = value;
                OnPropertyChanged("ClearMessages");
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
