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
        SettingsWindow Settings;
        TransactionWindow Transactions;
        public decimal[] priceArray;
        public MainWindow()
        {
            InitializeComponent();
            if(priceArray == null)
            {
                priceArray = new decimal[3];
            }
        }

        private void Button_Transactions(object sender, RoutedEventArgs e)
        {
            if (Transactions == null)
            {
                Transactions = new TransactionWindow();
                Transactions.Show();
            }
            else
            {
                Transactions.Show();
            }
            this.Hide();
        }

        private void Button_Settings(object sender, RoutedEventArgs e)
        {
            if(Settings == null)
            {
                Settings = new SettingsWindow();
                Settings.ShowDialog();
                priceArray = Settings.priceArray;
            }
            else
            {
                Settings.ShowDialog();
                priceArray = Settings.priceArray;
            }
        }
    }
    public static class DataStorage
    {
        public static List<string> customerList = new List<string>();
        //public static List<string>  = new List<string>();

        //public static List<int>  = new List<string>();
        //public static List<int> = new List<string>();

    }
}
