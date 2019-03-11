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
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
        }

        private void CalculationLogic()
        {
            decimal weight;
            decimal discount;

            switch (cmbJewelryQuality.Text)
            {
                case "10k":
                    if (txtWeight.Text == "")
                        weight = 0;

                    else
                        weight = Convert.ToDecimal(txtWeight.Text);

                    if (txtDiscount.Text == "")
                        discount = 0;

                    else
                        discount = Convert.ToDecimal(txtDiscount.Text)/100;

                    actualValueText.Text = Convert.ToString(DataStorage.priceList[0] * weight - (DataStorage.priceList[0] * weight * discount));
                    break;

                case "18k":
                    if (txtWeight.Text == "")
                        weight = 0;

                    else
                        weight = Convert.ToDecimal(txtWeight.Text);

                    if (txtDiscount.Text == "")
                        discount = 0;

                    else
                        discount = Convert.ToDecimal(txtDiscount.Text) / 100;

                    actualValueText.Text = Convert.ToString(DataStorage.priceList[1] * weight - (DataStorage.priceList[1] * weight * discount));
                    break;

                case "21k":
                    if (txtWeight.Text == "")
                        weight = 0;

                    else
                        weight = Convert.ToDecimal(txtWeight.Text);

                    if (txtDiscount.Text == "")
                        discount = 0;
                    else
                        discount = Convert.ToDecimal(txtDiscount.Text) / 100;

                    actualValueText.Text = Convert.ToString(DataStorage.priceList[2] * weight - (DataStorage.priceList[2] * weight * discount));
                    break;
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {           
            foreach (string item in DataStorage.customerList)
            {
                cmbNameList.Items.Add(item);
            }
        }

        private void AddName(object sender, RoutedEventArgs e)
        {
            AddNameWindow addName = new AddNameWindow();
            addName.ShowDialog();
            cmbNameList.Items.Clear();
            foreach (string item in DataStorage.customerList)
            {
                cmbNameList.Items.Add(item);
            }
        }

        private void WeightTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            CalculationLogic();
        }

        private void txtDiscount_TextChanged(object sender, TextChangedEventArgs e)
        {
            CalculationLogic();
        }

        private void cmbJewelryQuality_DropDownClosed(object sender, EventArgs e)
        {
            CalculationLogic();
        }

        private void btnAddName_Click(object sender, RoutedEventArgs e)
        {
            AddNameWindow openAddNameWindow = new AddNameWindow();
            openAddNameWindow.ShowDialog();
            cmbNameList.Items.Clear();
            foreach (string item in DataStorage.customerList)
            {
                cmbNameList.Items.Add(item);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bool checking = true;
            int codeListSize = DataStorage.eightDigitPin.Count - 1;
            int counter = 0;
            Random pin = new Random();
            int randomPin = pin.Next(00000000, 100000000);
            bool test = true;

            

            while (checking && DataStorage.eightDigitPin.Count != 0)
            {
                foreach (int codes in DataStorage.eightDigitPin)
                {
                    if (test)
                    {
                        randomPin = pin.Next(00000000, 100000000);
                        break;
                    }
                    counter++;
                    if (codeListSize == counter)
                    {
                        checking = false;
                    }
                }
            }
            DataStorage.eightDigitPin.Add(randomPin);
            MessageBox.Show(Convert.ToString(randomPin));
            this.Close();
        }

    }
}
