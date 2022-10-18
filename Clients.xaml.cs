using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
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
    /// Interaction logic for Clients.xaml
    /// </summary>
    public partial class Clients : Window
    {
        private readonly ClientContext _clientContext = new ClientContext();
        private CollectionViewSource _collectionViewSource;
        public Clients()
        {
            InitializeComponent();
            _collectionViewSource = (CollectionViewSource)FindResource(nameof(_collectionViewSource));
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _clientContext.Database.EnsureCreated();
            _clientContext.Clients.Load();
            _collectionViewSource.Source = _clientContext.Details.Local.ToObservableCollection();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _clientContext.SaveChanges();

            clientDataGrid.Items.Refresh();
            detailsDataGrid.Items.Refresh();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            _clientContext.Dispose();
            base.OnClosing(e);
        }
    }
}
