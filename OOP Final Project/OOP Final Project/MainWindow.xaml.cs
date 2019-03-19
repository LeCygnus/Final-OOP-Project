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
        //Declaring essential variables
        public SettingsWindow settings;
        Payment_Window paymentWindow;
        LoanTransaction addLoanTransaction;
        List<CustomerDetails> itemList;
        public List<int> listItemIndex;

        bool isItDone;
        bool hasSomething;
        int accountNumber;

        public MainWindow()
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            this.WindowState = WindowState.Maximized;        
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        //Opens Settings Window
        private void btnOpenPriceSettings(object sender, RoutedEventArgs e)
        {
            //Instantiates Settings Window
            if (settings == null)
            {
                settings = new SettingsWindow();
                settings.main = this;
                settings.Show();
            }
            //Reopens settings if instantiated
            else
            {
                settings.Show();
            }
        }

        //Opens LoanWindow
        private void btnOpenLoanTransaction(object sender, RoutedEventArgs e)
        {
            if (settings != null)
            {
                addLoanTransaction = new LoanTransaction();
                addLoanTransaction.main = this;
                listViewMasterList.ItemsSource = null;
                this.Hide();
                addLoanTransaction.ShowDialog();
                isItDone = true;
                ListDetails();
                listViewMasterList.ItemsSource = itemList;
            }
            else
            {               
                MessageBox.Show("Please configure the price settings first!", "Invalid Action", MessageBoxButton.OK, MessageBoxImage.Hand);
            }
        }

        private void btnOpenPayWindow(object sender, RoutedEventArgs e)
        {
            paymentWindow = new Payment_Window();
            paymentWindow.index = accountNumber;
            paymentWindow.main = this;
            isItDone = false;
            paymentWindow.ShowDialog();
            listViewMasterList.ItemsSource = null;
            ListDetails();
            listViewMasterList.ItemsSource = itemList;
            TransactionDetailsVisibility(-1);
            isItDone = true;
        }

        //Exit Button
        private void btnExitProgram(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        //Reveals customer details when clicked from the listview
        private void listViewMasterList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (isItDone)
            {
                TransactionDetailsVisibility(listItemIndex[listViewMasterList.SelectedIndex]);
                accountNumber = listItemIndex[listViewMasterList.SelectedIndex];
            }
        }
        
        //Adding Sample Items to the List
        public void DebugList()
        {
            DataStorage.customerList.Add("Brenn");
            DataStorage.dateOfTransaction.Add("3/17/2019");
            DataStorage.amountLoaned.Add(10000);
            DataStorage.interestRate.Add(5);
            DataStorage.accountBalance.Add(10000);
            DataStorage.dateUpdated.Add("3/18/2019");

            DataStorage.customerList.Add("AhBrenn");
            DataStorage.dateOfTransaction.Add("3/17/2019");
            DataStorage.amountLoaned.Add(102000);
            DataStorage.interestRate.Add(52);
            DataStorage.accountBalance.Add(100200);
            DataStorage.dateUpdated.Add("3/18/2019");
            List<CustomerDetails> itemList = new List<CustomerDetails>();
            ListDetails();
            listViewMasterList.ItemsSource = itemList;
        }

        //Logic to reveal customer details if selected in the List
        private void TransactionDetailsVisibility(int index)
        {
            if (index >= 0)
            {
                gridCustomerDetails.Visibility = Visibility.Visible;
                txtbName.Text = DataStorage.customerList[index];
                txtbAddress.Text = DataStorage.address[index];
                txtbContactNumber.Text = DataStorage.contactNumber[index];
                txtbFirstTransactionDate.Text = DataStorage.dateOfTransaction[index];
                txtbLastTransactionDate.Text = DataStorage.dateOfLastPayment[index];
                txtbAmountLoaned.Text = DataStorage.amountLoaned[index].ToString("#,##0.00");
                txtbInterestRate.Text = Convert.ToString(DataStorage.interestRate[index]);
                txtbAccumulatedAmount.Text = DataStorage.accumulatedAmount[index].ToString("#,##0.00");
                txtbRemainingBalance.Text = DataStorage.accountBalance[index].ToString("#,##0.00");
                txtbTypeOfJewelry.Text = DataStorage.typeOfJewelry[index];
                txtbQualityOfJewelry.Text = DataStorage.qualityOfJewelry[index];
                txtbWeight.Text = Convert.ToString(DataStorage.weightOfJewelry[index]);
                txtbActualValue.Text = DataStorage.actualValue[index].ToString("#,##0.00");
                txtbKaratPrice.Text = DataStorage.karatPrice[index].ToString("#,##0.00");
                txtbDiscount.Text = Convert.ToString(DataStorage.discount[index]);
                rtxtbDetails.Text = Convert.ToString(DataStorage.details[index]);
            }
            else
            {
                gridCustomerDetails.Visibility = Visibility.Hidden;               
            }
        }



        //Used to add data into the List and update outdated customer balances
        public void ListDetails()
        {
            itemList = new List<CustomerDetails>();
            listItemIndex = new List<int>();
            int maxIndex = DataStorage.customerList.Count;

            //Logic for adding customer into the list and updating outdated accounts

            for (int index = 0; index < maxIndex; index++)
            {
                if (DataStorage.accountBalance[index] != 0)
                {
                    //Temporary variables
                    string currentDate = DateTime.Now.ToString("MM/dd/yyyy");

                    int monthsAccrued = AccruedCalculations.MonthsAccrued(DataStorage.dateOfLastPayment[index]);
                    decimal balance = DataStorage.accountBalance[index];
                    decimal interestRate = DataStorage.interestRate[index];
                    decimal accumlatedAmount = DataStorage.accumulatedAmount[index];

                    decimal AccruedAmount = AccruedCalculations.AccruedAmount(interestRate, balance, monthsAccrued);

                    //Updates customer balances if outdated
                    if (DataStorage.dateUpdated[index] != currentDate)
                    {
                        DataStorage.accountBalance[index] = balance + AccruedAmount;
                        DataStorage.accumulatedAmount[index] = accumlatedAmount + AccruedAmount;
                        DataStorage.dateUpdated[index] = currentDate;
                    }

                    //Adds basic customer data to list
                    itemList.Add(new CustomerDetails()
                    {
                        ID = DataStorage.eightDigitPin[index],
                        Name = DataStorage.customerList[index],
                        TransactionDate = DataStorage.dateOfTransaction[index],
                        AmountLoaned = DataStorage.amountLoaned[index].ToString("#,##0.00"),
                        InterestRate = DataStorage.interestRate[index].ToString() + "%",
                        Balance = DataStorage.accountBalance[index].ToString("#,##0.00")
                    });

                    listItemIndex.Add(index);
                }
            }
        }

        //Logic for Search Bar
        private void txtbSearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (DataStorage.accountBalance != null)
            {
                foreach (decimal account in DataStorage.accountBalance)
                {
                    if(account != 0)
                    {
                        hasSomething = true;
                    }
                }
            }
            if (listViewMasterList.HasItems != false)
            {
                CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(listViewMasterList.ItemsSource);
                view.Filter = nameFilter;

                CollectionViewSource.GetDefaultView(listViewMasterList.ItemsSource).Refresh();
            }
            else if(hasSomething)
            {
                CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(listViewMasterList.ItemsSource);
                view.Filter = nameFilter;

                CollectionViewSource.GetDefaultView(listViewMasterList.ItemsSource).Refresh();
            }


        }
        //Name Filter Logic
        private bool nameFilter(object name)
        {
           if (String.IsNullOrEmpty(txtbSearchBar.Text))
             return true;
           else
           {
             return ((name as CustomerDetails).Name.IndexOf(txtbSearchBar.Text, StringComparison.OrdinalIgnoreCase) >= 0);
           }
        }
    }


    //Used for inserting items into the masterlist
    public class CustomerDetails
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string TransactionDate { get; set; }
        public string AmountLoaned { get; set; }
        public string InterestRate { get; set; }
        public string Balance { get; set; }
    }

    //Class for storing data
    public static class DataStorage
    {
        //Used to get the index in Loan Transaction
        public static int DataIndex(string input)
        {
            int counter = 0;
            foreach (string name in customerList)
            {
                if (name == input)
                {

                    break;
                }
                counter++;
            }
            return counter;
        }

        //String type datas
        public static decimal[] priceArray = new decimal[3];
        public static List<string> customerList = new List<string>();
        public static List<string> address = new List<string>();
        public static List<string> contactNumber = new List<string>();
        public static List<string> typeOfJewelry = new List<string>();
        public static List<string> qualityOfJewelry = new List<string>();
        public static List<string> dateOfTransaction = new List<string>();
        public static List<string> dateOfLastPayment = new List<string>();
        public static List<string> dateUpdated = new List<string>();
        public static List<string> details = new List<string>();

        //Int type datas
        public static List<int> eightDigitPin = new List<int>();

        //Decimal type datas
        public static List<decimal> discount = new List<decimal>();
        public static List<decimal> interestRate = new List<decimal>();
        public static List<decimal> weightOfJewelry = new List<decimal>();
        public static List<decimal> actualValue = new List<decimal>();
        public static List<decimal> amountLoaned = new List<decimal>();
        public static List<decimal> accountBalance = new List<decimal>();
        public static List<decimal> accumulatedAmount = new List<decimal>();
        public static List<decimal> karatPrice = new List<decimal>();
    }
}
