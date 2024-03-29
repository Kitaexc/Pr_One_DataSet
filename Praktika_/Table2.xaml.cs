using Praktika_.DataSet1TableAdapters;
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

namespace Praktika_
{


    public partial class Table2 : Page
    {
        ProductsTableAdapter products = new ProductsTableAdapter();
        public Table2()
        {
            InitializeComponent();
            Products.ItemsSource = products.GetData();
        }

        private void Products_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
