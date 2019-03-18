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
    /// Interaction logic for SettingsWindow.xaml
    /// </summary>
    public partial class SettingsWindow : Window
    {
        public MainWindow main;


        public SettingsWindow()
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
        }



        private void Button_Save(object sender, RoutedEventArgs e)
        {

            switch (selectedCarat.Text)
            {
                case "10k":
                    if (priceGram.Text == "")
                        priceGram.Text = "0";
                    DataStorage.priceArray[0] = Convert.ToDecimal(priceGram.Text);
                    txtTenK.Text = priceGram.Text;
                    break;

                case "18k":
                    if (priceGram.Text == "")
                        priceGram.Text = "0";
                    DataStorage.priceArray[1] = Convert.ToDecimal(priceGram.Text);
                    txtEightteenK.Text = priceGram.Text;
                    break;

                case "21k":
                    if (priceGram.Text == "")
                        priceGram.Text = "0";
                    DataStorage.priceArray[2] = Convert.ToDecimal(priceGram.Text);
                    txtTwentyoneK.Text = priceGram.Text;
                    break;

                default:
                    break;
            }
            selectedCarat.Text = null;
            priceGram.Text = null;
        }

        private void btnCancel(object sender, RoutedEventArgs e)
        {
            this.Hide();
            //main = new MainWindow();
            main.settings = this;
            main.Show();
        }
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
    }
}
