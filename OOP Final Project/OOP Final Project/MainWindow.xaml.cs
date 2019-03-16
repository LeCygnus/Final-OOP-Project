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
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SettingsWindow Settings;
        TransactionWindow Transactions;
        public MainWindow()
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
        }

        private void ShowTransactions(object sender, RoutedEventArgs e)
        {
                Transactions = new TransactionWindow();
                Transactions.Show();
        }

        private void ShowSettings(object sender, RoutedEventArgs e)
        {
            if (Settings == null)
            {
                Settings = new SettingsWindow();
                this.Hide();
                Settings.ShowDialog();
                this.Show();
                DataStorage.priceList = Settings.priceArray;
            }
            else
            {
                this.Hide();
                Settings.ShowDialog();
                this.Show();
                DataStorage.priceList = Settings.priceArray;
            }
        }

        private void BtnOpenMenu_ClickEvent(object sender, RoutedEventArgs e)
        {
            btnOpenMenu.Visibility = Visibility.Collapsed;
            btnCloseMenu.Visibility = Visibility.Visible;
        }

        private void BtnCloseMenu_ClickEvent(object sender, RoutedEventArgs e)
        {
            btnCloseMenu.Visibility = Visibility.Collapsed;
            btnOpenMenu.Visibility = Visibility.Visible;
        }
    }
    public static class DataStorage
    {
        public static int DataIndex(string input)
        {
            int counter = 0;           
            foreach (string name in customerList)
            {
                if(name == input)
                {
                    
                    break;
                }
                counter++;
            }
            return counter;
        }

        public static decimal[] priceList = new decimal[3];
        public static List<string> customerList = new List<string>();
        public static List<string> address = new List<string>();
        public static List<string> contactNumber = new List<string>();
        public static List<string> typeOfJewelry = new List<string>();
        public static List<string> qualityOfJewelry = new List<string>();
        public static List<string> dateOfTransaction = new List<string>();
        public static List<string> details = new List<string>();
        public static List<string> dateOFLastTransaction = new List<string>();
        public static List<string> customersWithPendingBalance = new List<string>();

        public static List<int> discount = new List<int>();       
        public static List<int> interestRate = new List<int>();       
        public static List<int> eightDigitPin = new List<int>();

        public static List<decimal> weightOfJewelry = new List<decimal>();
        public static List<decimal> actualValue = new List<decimal>();
        public static List<decimal> amountLoaned = new List<decimal>();
        public static List<decimal> accountBalance = new List<decimal>();
    }

}
