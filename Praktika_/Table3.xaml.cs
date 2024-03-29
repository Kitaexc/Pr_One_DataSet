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
    /// <summary>
    /// Логика взаимодействия для Table3.xaml
    /// </summary>
    public partial class Table3 : Page
    {
        OrdersTableAdapter orders = new OrdersTableAdapter();
        public Table3()
        {
            InitializeComponent();
            Orders.ItemsSource = orders.GetData();
        }

    }
}
