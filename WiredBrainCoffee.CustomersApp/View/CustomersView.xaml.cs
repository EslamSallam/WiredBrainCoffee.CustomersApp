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
using WiredBrainCoffee.CustomersApp.Data;
using WiredBrainCoffee.CustomersApp.Model;
using WiredBrainCoffee.CustomersApp.ViewModel;

namespace WiredBrainCoffee.CustomersApp.View
{
    /// <summary>
    /// Interaction logic for CustomersView.xaml
    /// </summary>
    public partial class CustomersView : UserControl
    {
        private CustomersViewModel _ViewModel;

        public CustomersView()
        {
            InitializeComponent();
            _ViewModel = new CustomersViewModel(new CustomerDataProvider());
            DataContext = _ViewModel;
            Loaded += CustomersView_Loaded;
        }

        private async void CustomersView_Loaded(object sender, RoutedEventArgs e)
        {
            await _ViewModel.LoadAsync();
        }

        private void ButtonMoveNavigation_Click(object sender, RoutedEventArgs e)
        {
            //var Col = CustomerListGrid.GetValue(Grid.ColumnProperty);
            //if ((int)Col == 0)
            //    CustomerListGrid.SetValue(Grid.ColumnProperty, 2);
            //else
            //    CustomerListGrid.SetValue(Grid.ColumnProperty, 0);
            var col = Grid.GetColumn(CustomerListGrid);
            var newCol = col == 0 ? 2 : 0;
            Grid.SetColumn(CustomerListGrid, newCol);
        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            _ViewModel.Add();
        }
    }
}
