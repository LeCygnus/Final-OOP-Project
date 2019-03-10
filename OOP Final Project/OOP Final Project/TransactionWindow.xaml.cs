﻿using System;
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
        }

        private void btnLoan_Click(object sender, RoutedEventArgs e)
        {
            LoanTransaction openTransactionWindow = new LoanTransaction();
            openTransactionWindow.Show();           
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            App.Current.MainWindow.Show();
            this.Hide();
        }
    }
}
