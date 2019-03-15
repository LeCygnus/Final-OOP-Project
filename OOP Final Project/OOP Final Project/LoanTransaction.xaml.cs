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
            foreach (string item in DataStorage.customerList)
            {
                cmbNameList.Items.Add(item);
            }
        }            

        private void CalculationLogic()
        {
            decimal weight;
            decimal discount;

            switch (cmbJewelryQuality.Text)
            {
                case "10k":
                    if (txtbWeight.Text == "")
                        weight = 0;

                    else
                        weight = Convert.ToDecimal(txtbWeight.Text);

                    if (txtbDiscount.Text == "")
                        discount = 0;

                    else
                        discount = Convert.ToDecimal(txtbDiscount.Text)/100;
                    txtblockActualValue.Text = Convert.ToString(DataStorage.priceList[0] * weight - (DataStorage.priceList[0] * weight * discount));
                    break;

                case "18k":
                    if (txtbWeight.Text == "")
                        weight = 0;

                    else
                        weight = Convert.ToDecimal(txtbWeight.Text);

                    if (txtbDiscount.Text == "")
                        discount = 0;

                    else
                        discount = Convert.ToDecimal(txtbDiscount.Text) / 100;

                    txtblockActualValue.Text = Convert.ToString(DataStorage.priceList[1] * weight - (DataStorage.priceList[1] * weight * discount));
                    break;

                case "21k":
                    if (txtbWeight.Text == "")
                        weight = 0;

                    else
                        weight = Convert.ToDecimal(txtbWeight.Text);

                    if (txtbDiscount.Text == "")
                        discount = 0;
                    else
                        discount = Convert.ToDecimal(txtbDiscount.Text) / 100;

                    txtblockActualValue.Text = Convert.ToString(DataStorage.priceList[2] * weight - (DataStorage.priceList[2] * weight * discount));
                    break;
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {           

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


        private void btnUseCurrentDate(object sender, RoutedEventArgs e)
        {
            dpDateOfTransaction.Text = DateTime.Now.ToString("MM/dd/yyyy");
        }

        private void btnAddTransaction_Click(object sender, RoutedEventArgs e)
        {         
            int index;
            index = DataStorage.DataIndex(cmbNameList.Text);

            if (DataStorage.accountBalance[index] == 0)
            {
                //Data storing
                DataStorage.typeOfJewelry.Insert(index,cmbTypeOfJewelry.Text);
                DataStorage.qualityOfJewelry.Insert(index, cmbJewelryQuality.Text);
                DataStorage.weightOfJewelry.Insert(index, Convert.ToDecimal(txtbWeight.Text));
                DataStorage.discount.Insert(index, Convert.ToInt32(txtbDiscount.Text));
                DataStorage.actualValue.Insert(index, Convert.ToDecimal(txtblockActualValue.Text));
                DataStorage.dateOfTransaction.Insert(index, dpDateOfTransaction.Text);
                DataStorage.amountLoaned.Insert(index, Convert.ToDecimal(txtbAmountLoaned.Text));
                DataStorage.interestRate.Insert(index, Convert.ToInt32(txtbInterestRate.Text));
                DataStorage.details.Insert(index, rtbDetails.Text);

                //Generating of unique pin
                Random pin = new Random();

                int codeListSize = DataStorage.eightDigitPin.Count - 1;
                int counter = 0;
                int randomPin = pin.Next(00000000, 100000000);

                bool checking = true;

                //Duplicate Checker
                while (checking && DataStorage.eightDigitPin.Count != 0)
                {
                    foreach (int codes in DataStorage.eightDigitPin)
                    {
                        if (randomPin == codes)
                        {
                            randomPin = pin.Next(00000000, 100000000);
                            break;
                        }
                        counter++;
                        if (codeListSize < counter)
                        {
                            checking = false;
                            break;
                        }
                    }
                }

                //Adding Pin to Storage
                DataStorage.eightDigitPin.Add(randomPin);

                MessageBox.Show(Convert.ToString(randomPin));

                this.Close();

                TransactionWindow transWindow = new TransactionWindow();
                transWindow.Show();
            }
            else if(DataStorage.accountBalance[index] > 0)
            {
                MessageBox.Show("Error! Customer still has " + "Php " + DataStorage.accountBalance[index] + " remaining in his account.");
            }
            else
            {
                MessageBox.Show("Error! Some fields have incorrect values or are blank.");
            }
        }
    }
}
