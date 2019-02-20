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
    /// Interaction logic for SetingsWindow.xaml
    /// </summary>
    public partial class SettingsWindow : Window
    {
        decimal[] priceArray;
        MainWindow mainWindow = new MainWindow();

        public SettingsWindow()
        {
            InitializeComponent();
            if (priceArray == null)
            {
                priceArray = new decimal[3];
            }
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Save(object sender, RoutedEventArgs e)
        {
            switch (selectedCarat.Text)
            {
                case "10k":
                    if (priceGram.Text == "")
                        priceGram.Text = "0";
                    priceArray[0] = Convert.ToDecimal(priceGram.Text);
                    mainWindow.priceArray[0] = priceArray[0];
                    tenK.Text = priceGram.Text;
                    break;

                case "18k":
                    if (priceGram.Text == "")
                        priceGram.Text = "0";
                    priceArray[1] = Convert.ToDecimal(priceGram.Text);
                    mainWindow.priceArray[1] = priceArray[1];
                    eightteenK.Text = priceGram.Text;
                    break;

                case "21k":
                    if (priceGram.Text == "")
                        priceGram.Text = "0";
                    priceArray[2] = Convert.ToDecimal(priceGram.Text);
                    mainWindow.priceArray[2] = priceArray[2];
                    twentyoneK.Text = priceGram.Text;
                    break;

                default:
                    break;
            }
            mainWindow.transactionsButton.Content = "HAHAHAHA";
            selectedCarat.Text = null;
            priceGram.Text = null;
            this.Hide();
            mainWindow.Show();

        }
    }
}
