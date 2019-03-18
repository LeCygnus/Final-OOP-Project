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
    /// Interaction logic for Payment_Window.xaml
    /// </summary>
    public partial class Payment_Window : Window
    {
        public MainWindow main;
        public int index;
        public Payment_Window()
        {
            InitializeComponent();
            txtremainingBalance.Text = DataStorage.accountBalance[index].ToString();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Enter(object sender, RoutedEventArgs e)
        {
            //main = new MainWindow();
            DataStorage.accountBalance[index] = DataStorage.accountBalance[index] - Convert.ToDecimal(txtbPayment.Text);
            this.Close();
            main.Show();
        }

        private void Cancel(object sender, RoutedEventArgs e)
        {
            this.Close();
            main.Show();
        }
    }
}
