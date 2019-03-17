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
            this.WindowState = WindowState.Maximized;
          //  ListDetails();

        }

      //  public void ListDetails()
        //{
          //  List<CustomerDetails> itemList = new List<CustomerDetails>();

            //int maxIndex = DataStorage.customerList.Count;

           // for (int index = 0; index < maxIndex; index++)
            //{
             //   itemList.Add(new CustomerDetails()
          //      {
                    //ID = index,
                    //Name = DataStorage.customerList[index],
                    //TransactionDate = DataStorage.dateOfTransaction[index],
                    //AmountLoaned = DataStorage.amountLoaned[index],
                    //InterestRate = DataStorage.interestRate[index],
                    //Balance = DataStorage.accountBalance[index]
               // });
            //}

           // listViewMasterList.ItemsSource = itemList;
      //  }

        public void MasterListItems()
        {
            List<string> itemList = new List<string>();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }
        
        private void btnLoan_Click(object sender, RoutedEventArgs e)
        {
            LoanTransaction openTransactionWindow = new LoanTransaction();
            openTransactionWindow.Show();
            this.Close();
        }

        private void btnPay_Click(object sender, RoutedEventArgs e)
        {
            //openTransactionWindow.ShowDialog();
            this.Show();
           // if (DataStorage.customerList != null)
                //ListDetails();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            App.Current.MainWindow.Show();
            this.Close();
        }


        private void listViewMasterList_Initialized(object sender, EventArgs e)
        {

        }

        private void listViewMasterList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }


    }

    public class CustomerDetailsz
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string TransactionDate { get; set; }
        public decimal AmountLoaned { get; set; }
        public decimal InterestRate { get; set; }
        public decimal Balance { get; set; }       
    }


}
