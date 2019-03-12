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

namespace OOP_Final_Project
{

    public partial class TransactionWindow : Window
    {       
        public TransactionWindow()
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            listViewMasterList.Items.Add(new ListViewItems() { ID = "1", Name = "Brenn", ContactNumber="09329580029", Date="3/13/2019", AccumAmount="10000", Balance="5000"});
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        class ListViewItems
        {
            public string ID { get; set; }
            public string Name { get; set; }
            public string ContactNumber { get; set; }
            public string Date { get; set; }
            public string AccumAmount { get; set; }
            public string Balance { get; set; }
        }

        private void btnLoan_Click(object sender, RoutedEventArgs e)
        {
            LoanTransaction openTransactionWindow = new LoanTransaction();
            openTransactionWindow.transWindow = this;
            openTransactionWindow.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            App.Current.MainWindow.Show();
            this.Hide();
        }
    }
}
