using System;
using System.Collections.Generic;
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
using WpfNorthwindApp.View;

namespace WpfNorthwindApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Employee employee;
        Product product;
        Orders orders;
        public MainWindow()
        {
            employee = new Employee();
            product = new Product();
            orders = new Orders();

            InitializeComponent();        
            
        }

        private void EmployeBtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = employee;
        }

        private void ProductBtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = product;
        }

        private void OrdersBtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = orders;
        }
    }
}
