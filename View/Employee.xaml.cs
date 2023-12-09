using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfNorthwindApp.Model;
using WpfNorthwindApp.ModelView;

namespace WpfNorthwindApp.View
{
    /// <summary>
    /// Interaction logic for Employee.xaml
    /// </summary>
    public partial class Employee : Page, INotifyPropertyChanged
    {
        EmployeeVM employeeVM;

        public ObservableCollection<WpfNorthwindApp.Model.Employee> employeList;

        public ObservableCollection<WpfNorthwindApp.Model.Employee> EmployeeList 
        {
            get
            { 
                return employeList;
            }
            set
            { 
                employeList = value;
                OnPropertyChanged("EmployeeList");
            }
        }
        public string MyProperty { get; set; }
        public Employee()
        {
            employeeVM = new EmployeeVM();
            EmployeeList = new ObservableCollection<WpfNorthwindApp.Model.Employee>();
            GetInfo();

            InitializeComponent();
        }

        private void GetInfo()
        {
            if (EmployeeList != null)
                EmployeeList.Clear();
            EmployeeList = employeeVM.GetEmployess();            
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            AddEmployePopUp addEmployePopUp = new AddEmployePopUp();
            var result = addEmployePopUp.ShowDialog();
            if (result == false) 
            {
                GetInfo();
            }
        }

        private void ListViewItem_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Model.Employee selectedEmployee = ((ListViewItem)sender).DataContext as Model.Employee;
            AddEmployePopUp addEmployePopUp = new AddEmployePopUp(selectedEmployee);
            var isOpen = addEmployePopUp.ShowDialog();
            if (isOpen == false)
            {
                if (addEmployePopUp.AdedEmp == true)
                {
                    GetInfo();
                }
            }
        }


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
