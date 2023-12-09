using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using WpfNorthwindApp.ModelView;

namespace WpfNorthwindApp.View
{
    /// <summary>
    /// Interaction logic for Orders.xaml
    /// </summary>
    public partial class Orders : Page
    {
        public ObservableCollection<Model.Order> OrdersList { get; set; }
        public OrdersVM OrdersVM { get; set; }
        public Orders()
        {
            OrdersList = new ObservableCollection<Model.Order>();
            OrdersVM = new OrdersVM();
            GetInfo();
            InitializeComponent();
        }

        private void GetInfo()
        {
            if (OrdersList != null)
                OrdersList.Clear();
            OrdersList = OrdersVM.GetOrders();
        }
    }
}
