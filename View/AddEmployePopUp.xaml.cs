using System.ComponentModel;
using System.Windows;
using WpfNorthwindApp.Model;
using WpfNorthwindApp.ModelView;

namespace WpfNorthwindApp.View
{
    /// <summary>
    /// Interaction logic for AddEmployePopUp.xaml
    /// </summary>
    public partial class AddEmployePopUp : Window
    {
        #region Properties
        #region EditsButtonVisibility
        public Visibility EditsButtonVisibility { get; set; }
        #endregion

        #region AddButtonVisibility
        public Visibility AddButtonVisibility { get; set; }
        #endregion

        #region AddEmploye
        public AddEmploye AddEmploye
        {
            get;
            set;
        }
        #endregion

        #region AdedEmp
        public bool AdedEmp { get; set; }
        #endregion

        #region İsOpenedFromEdit
        public bool isOpenedFromEdit;
        public bool İsOpenedFromEdit
        {
            get
            {
                return isOpenedFromEdit;
            }
            set
            {
                isOpenedFromEdit = value;
                if (isOpenedFromEdit == true)
                {
                    EditsButtonVisibility = Visibility.Visible;
                    AddButtonVisibility = Visibility.Collapsed;
                }
                else
                {
                    EditsButtonVisibility = Visibility.Collapsed;
                    AddButtonVisibility = Visibility.Visible;
                }

            }
        }
        #endregion

        #region Employee
        private Model.Employee employee;
        public Model.Employee Employee
        {
            get
            {
                return employee;
            }
            set
            {
                employee = value;
                OnPropertyChanged("Employee");
            }
        }
        #endregion

        #region EmployeeVM
        public EmployeeVM EmployeeVM { get; set; }
        #endregion
        #endregion

        #region Const
        public AddEmployePopUp()
        {
            AdedEmp = false;
            İsOpenedFromEdit = false;
            AddEmploye = new AddEmploye() { IsEmptyTxt = false, ClearMessages = true };
            Employee = new Model.Employee();
            EmployeeVM = new EmployeeVM();
            InitializeComponent();
        }

        public AddEmployePopUp(Model.Employee employee)
        {
            İsOpenedFromEdit = true;
            AdedEmp = false;
            AddEmploye = new AddEmploye() { IsEmptyTxt = false, ClearMessages = true };
            Employee = employee;
            EmployeeVM = new EmployeeVM();
            InitializeComponent();
        } 
        #endregion

        #region Events
        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(FirstNameTxt.Text) && string.IsNullOrEmpty(LastNameTxt.Text))
            {
                AddEmploye.IsEmptyTxt = true;
                return;
            }
            else
            {
                EmployeeVM.InsertEmploye(Employee);
                AdedEmp = true;
                Employee = new Model.Employee();
                ClearMessages();
            }
        }
        private void TextBox_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            AddEmploye.IsEmptyTxt = false;
        }

        private void SaveEmpButton_Click(object sender, RoutedEventArgs e)
        {
            EmployeeVM.Update(Employee);
            AdedEmp = true;
            this.Employee = new Model.Employee();
            ClearMessages();
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            EmployeeVM.DeleteEmploye(Employee.EmployeeID);
            AdedEmp = true;
            this.Employee = new Model.Employee();
            ClearMessages();
        }
        #endregion

        private void ClearMessages()
        {
            PhoneTxt.Clear();
            AddressTxt.Clear();
            BirtDatePicker.SelectedDate = null;
            TittleTxt.Clear();
            LastNameTxt.Clear();
            FirstNameTxt.Clear();

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
