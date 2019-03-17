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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OOP_Final_Project
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
            ListDetails();
        }

        public void ListDetails()
        {
            List<CustomerDetails> itemList = new List<CustomerDetails>();

            int maxIndex = DataStorage.customerList.Count;
            int counter = 1;

            //foreach(string name in DataStorage.customerList)
            //{
            //    counter = DataStorage.customerList.IndexOf(name);
            //    if(DataStorage.accountBalance[counter] != 0)
            //    {
            //        DataStorage.customersWithPendingBalance.Add(name);
            //    }
            //}

            for (int index = 0; index < maxIndex; index++)
            {
                if (DataStorage.accountBalance[index] != 0)
                    itemList.Add(new CustomerDetails()
                    {
                        ID = counter + 1,
                        Name = DataStorage.customerList[index],
                        TransactionDate = DataStorage.dateOfTransaction[index],
                        AmountLoaned = DataStorage.amountLoaned[index],
                        InterestRate = DataStorage.interestRate[index],
                        Balance = DataStorage.accountBalance[index]
                    });
                counter++;
            }

            listViewMasterList.ItemsSource = itemList;
        }

        public void MasterListItems()
        {
            List<string> itemList = new List<string>();
        }

        public class CustomerDetails
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public string TransactionDate { get; set; }
            public decimal AmountLoaned { get; set; }
            public decimal InterestRate { get; set; }
            public decimal Balance { get; set; }
        }
    }
}
