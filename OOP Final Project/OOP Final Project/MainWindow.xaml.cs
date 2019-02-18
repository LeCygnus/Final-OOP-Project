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
        SettingsWindow openSettings;
        TransactionWindow openTransactions;
        public decimal[] priceArray;
        public MainWindow()
        {
            InitializeComponent();
            MessageBox.Show(Convert.ToString(priceArray));
            if(priceArray == null)
            {
                priceArray = new decimal[3];
            }
        }

        private void Button_Transactions(object sender, RoutedEventArgs e)
        {
            if (openTransactions == null)
            {
                openTransactions = new TransactionWindow();
                openTransactions.Show();
            }
            else
            {
                openTransactions.Show();
            }
            this.Hide();
        }

        private void Button_Settings(object sender, RoutedEventArgs e)
        {
            if(openSettings == null)
            {
                openSettings = new SettingsWindow();
                openSettings.Show();
            }
            else
            {
                openSettings.Show();
            }
        }
    }
}
