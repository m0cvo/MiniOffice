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

namespace MiniOffice
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

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void DBaseBtn_Click(object sender, RoutedEventArgs e)
        {
            //ToDo
        }

        private void WordBtn_Click(object sender, RoutedEventArgs e)
        {
            //Opens new window for user to work on.
            Window1 WorkWindow = new Window1();
            WorkWindow.Show();
            this.Hide();
        }

        private void CalcBtn_Click(object sender, RoutedEventArgs e)
        {
            //ToDo
        }
    }
}
