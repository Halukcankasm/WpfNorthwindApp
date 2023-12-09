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
using WpfNorthwindApp.ModelView;

namespace WpfNorthwindApp.View
{
    /// <summary>
    /// Interaction logic for Product.xaml
    /// </summary>
    public partial class Product : Page
    {
        ProductVM productVM;
        public List<WpfNorthwindApp.Model.Product> ProductList { get; set; }

        public Product()
        {
            productVM = new ProductVM();
            ProductList = new List<WpfNorthwindApp.Model.Product>();
            GetInfo();

            InitializeComponent();
        }

        private void GetInfo()
        {
            ProductList = productVM.GetProduct();
        }
    }
}
