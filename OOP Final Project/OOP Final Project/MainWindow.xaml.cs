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
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SettingsWindow Settings = new SettingsWindow();
        TransactionWindow Transactions;
        public decimal[] priceArray;
        public MainWindow()
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
        }

        private void ShowTransactions(object sender, RoutedEventArgs e)
        {
            if (Transactions == null)
            {
                Transactions = new TransactionWindow();
                Transactions.Show();
                this.Hide();
            }
            else
            {
                Transactions.Show();
                this.Hide();
            }
        }

        private void ShowSettings(object sender, RoutedEventArgs e)
        {
                this.Hide();
                Settings.ShowDialog();
                this.Show();
                DataStorage.priceList = Settings.priceArray;
        }
    }
    public static class DataStorage
    {
        public static decimal[] priceList = new decimal[3];
        public static List<string> customerList = new List<string>();
        //public static List<string>  = new List<string>();

        public static List<int> eightDigitPin = new List<int>();
        //public static List<int> = new List<string>();

        //public static List<decimal> priceList = new List<decimal>();

    }
}
