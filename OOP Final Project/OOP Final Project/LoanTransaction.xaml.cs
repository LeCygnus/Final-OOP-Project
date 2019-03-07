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
    /// Interaction logic for LoanTransaction.xaml
    /// </summary>
    public partial class LoanTransaction : Window
    {
        public LoanTransaction()
        {
            InitializeComponent();
            TransactionData.customerList = DataStorage.customerList;
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (string item in TransactionData.customerList)
            {
                cmbNameList.Items.Add(item);
            }
        }

        private void AddName(object sender, RoutedEventArgs e)
        {
            AddNameWindow addName = new AddNameWindow();
            addName.ShowDialog();
            TransactionData.customerList = DataStorage.customerList;
        }
    }
    public static class TransactionData
    {
        public static List<string> customerList = new List<string>();
    }
}
