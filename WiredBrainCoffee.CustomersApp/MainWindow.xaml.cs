using System.Windows;
using System.Windows.Controls;

namespace WiredBrainCoffee.CustomersApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //BtnAddCustomer.Content = "Customer Added!";
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
    }
}
