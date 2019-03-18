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
        //declaring variables for instantiating
        public SettingsWindow settings;
        Payment_Window paymentWindow;
        MainWindow main;
        LoanTransaction addLoanTransaction;
        public List<int> listItemIndex;

        int accountNumber;
        int counter;

        public MainWindow()
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            this.WindowState = WindowState.Maximized;           
        }

        //Used to add data into the List and update outdated customer balances
        public void ListDetails()
        {
            listItemIndex = new List<int>();
            List<CustomerDetails> itemList = new List<CustomerDetails>();
            int maxIndex = DataStorage.customerList.Count;
            listViewMasterList.ItemsSource = null;

            //Logic for adding customer into the list and updating outdated accounts

            for (int index = 0; index < maxIndex; index++)
                {
                if (DataStorage.accountBalance[index] != 0)
                {
                    //Temporary variables
                    //string currentDate = DateTime.Now.ToString("MM/dd/yyyy");

                    //int monthsAccrued = AccruedCalculations.MonthsAccrued(DataStorage.dateOfLastPayment[index]);
                    //decimal balance = DataStorage.accountBalance[index];
                    //decimal interestRate = DataStorage.interestRate[index];
                    //decimal accumlatedAmount = DataStorage.accumulatedAmount[index];

                    //decimal AccruedAmount = AccruedCalculations.AccruedAmount(interestRate, balance, monthsAccrued);
                    //MessageBox.Show(AccruedAmount.ToString());

                    ////Updates customer balances if outdated
                    //if (DataStorage.dateUpdated[index] != currentDate)
                    //{
                    //    DataStorage.accountBalance[index] = balance + AccruedAmount;
                    //    DataStorage.accumulatedAmount[index] = accumlatedAmount + balance;
                    //    DataStorage.dateUpdated[index] = currentDate;
                    //}

                    //Adds basic customer data to list
                    itemList.Add(new CustomerDetails()
                    {
                        //ID = DataStorage.eightDigitPin[index],
                        Name = DataStorage.customerList[index],
                        TransactionDate = DataStorage.dateOfTransaction[index],
                        AmountLoaned = DataStorage.amountLoaned[index].ToString("#,##0.00"),
                        InterestRate = DataStorage.interestRate[index].ToString() + "%",
                        Balance = DataStorage.accountBalance[index].ToString("#,##0.00")
                    });

                    listItemIndex.Add(index);
                }

                //Assigns datasource to the list.
                listViewMasterList.ItemsSource = itemList;
            }
        }

        //Loads data to the MasterList during the start of the program.
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        //Opens LoanWindow
        private void btnOpenLoanTransaction(object sender, RoutedEventArgs e)
        {
            if (settings != null)
            {
                addLoanTransaction = new LoanTransaction();
                addLoanTransaction.main = this;
                addLoanTransaction.Show();
                this.Hide();
            }
            else
            {               
                MessageBox.Show("Please configure the price settings first!", "Invalid Action", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

        //Opens Settings Window
        private void btnOpenPriceSettings(object sender, RoutedEventArgs e)
        {
            //Instantiates Settings Window
            if (settings == null)
            {
                counter++;
                settings = new SettingsWindow();
                settings.main = this;     
                settings.Show();
                this.Close();
            }
            //Reopens settings if instantiated
            else
            {
                settings.Show();
                this.Close();
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
        }

        //Logic to reveal customer details if selected in the List
        private void TransactionDetailsVisibility(int index)
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
                txtbDiscount.Text = Convert.ToString(DataStorage.discount[index]);
                rtxtbDetails.Text = Convert.ToString(DataStorage.details[index]);
        }

        //Reveals customer details when clicked from the listview
        private void listViewMasterList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TransactionDetailsVisibility(listItemIndex[listViewMasterList.SelectedIndex]);
            accountNumber = listItemIndex[listViewMasterList.SelectedIndex];
        }

        private void DebugButton_Click(object sender, RoutedEventArgs e)
        {
            listViewMasterList.ItemsSource = null;
            ListDetails();
        }

        private void listViewMasterList_Initialized(object sender, EventArgs e)
        {

        }

        private void btnOpenPayWindow(object sender, RoutedEventArgs e)
        {
            paymentWindow = new Payment_Window();
            paymentWindow.index = accountNumber;
            paymentWindow.Show();
            paymentWindow.main = this;
            this.Close();

        }

        private void btnExitProgram(object sender, RoutedEventArgs e)
        {
            DebugList();
            listItemIndex = new List<int>();
            List<CustomerDetails> itemList = new List<CustomerDetails>();
            int maxIndex = DataStorage.customerList.Count;
            listViewMasterList.ItemsSource = null;

            //Logic for adding customer into the list and updating outdated accounts

            for (int index = 0; index < maxIndex; index++)
            {
                if (DataStorage.accountBalance[index] != 0)
                {
                    //Temporary variables
                    //string currentDate = DateTime.Now.ToString("MM/dd/yyyy");

                    //int monthsAccrued = AccruedCalculations.MonthsAccrued(DataStorage.dateOfLastPayment[index]);
                    //decimal balance = DataStorage.accountBalance[index];
                    //decimal interestRate = DataStorage.interestRate[index];
                    //decimal accumlatedAmount = DataStorage.accumulatedAmount[index];

                    //decimal AccruedAmount = AccruedCalculations.AccruedAmount(interestRate, balance, monthsAccrued);
                    //MessageBox.Show(AccruedAmount.ToString());

                    ////Updates customer balances if outdated
                    //if (DataStorage.dateUpdated[index] != currentDate)
                    //{
                    //    DataStorage.accountBalance[index] = balance + AccruedAmount;
                    //    DataStorage.accumulatedAmount[index] = accumlatedAmount + balance;
                    //    DataStorage.dateUpdated[index] = currentDate;
                    //}

                    //Adds basic customer data to list
                    itemList.Add(new CustomerDetails()
                    {
                        //ID = DataStorage.eightDigitPin[index],
                        Name = DataStorage.customerList[index],
                        TransactionDate = DataStorage.dateOfTransaction[index],
                        AmountLoaned = DataStorage.amountLoaned[index].ToString("#,##0.00"),
                        InterestRate = DataStorage.interestRate[index].ToString() + "%",
                        Balance = DataStorage.accountBalance[index].ToString("#,##0.00")
                    });

                    listItemIndex.Add(index);
                }

                //Assigns datasource to the list.
                listViewMasterList.ItemsSource = itemList;
            }
            // Application.Current.Shutdown();
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
}
