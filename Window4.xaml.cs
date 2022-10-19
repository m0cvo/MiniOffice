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
using System.Windows.Shapes;

namespace MiniOffice
{
    /// <summary>
    /// Interaction logic for Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        public Window4()
        {
            InitializeComponent();
        }

        private void StaffBtn_Click(object sender, RoutedEventArgs e)
        {
            //StaffList Database
            StaffList staffList = new StaffList();
            staffList.Show();
        }

        private void ClientBtn_Click(object sender, RoutedEventArgs e)
        {
            //Clients Database
            Clients clients = new Clients();
            clients.Show();
        }

        private void StockBtn_Click(object sender, RoutedEventArgs e)
        {
            //Product database
            Stock stock = new Stock();
            stock.Show();
        }

        private void SalesBtn_Click(object sender, RoutedEventArgs e)
        {
            //Sales records Database
            Sales sales = new Sales();
            sales.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
