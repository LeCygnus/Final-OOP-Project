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
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void ComboBoxItem_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {
            
        }

        private void NameButton_Click(object sender, RoutedEventArgs e)
        {
            AddNameWindow windowName = new AddNameWindow();
            windowName.Show();
        }
    }
}
