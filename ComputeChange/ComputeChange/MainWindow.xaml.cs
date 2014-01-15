using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonComputeChange_Click(object sender, RoutedEventArgs e)
        {
            float orginalAmount=0;
            float price = 0;
            float amtTendered = 0;

            price = Single.Parse(PriceTextBox.Text);
            //MessageBox.Show(PriceTextBox.Text);


            amtTendered = Single.Parse(AmttenderedTextBox.Text);
            //MessageBox.Show(AmttenderedTextBox.Text);

            orginalAmount =(amtTendered - price) * 100;
            int amount =0;

            MessageBox.Show("OriginalAmt: " + orginalAmount);
                     
            amount = (int)orginalAmount / 25;

            MessageBox.Show("Number of Quarters: " + amount);

            amount = ((int)orginalAmount % 25 /10);
            MessageBox.Show("Number of Dimes: " + amount);


            amount = ((((int)orginalAmount % 25 )% 10)/5);
            MessageBox.Show("Number of Nickles: " + amount);

            amount = ((((int)orginalAmount % 25) % 10) % 5);
            MessageBox.Show("Number of Pennies: " + amount);


           
   
            
           // orginalAmount = Single.Parse(price.Text);

            //Console.WriteLine(orginalAmount);
           // MessageBox.Show("The Original Price of " + orginalAmount.Text + " is equivalent to " + orginalAmount);

        }

        private void PriceTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void PriceTextBox_TextInput(object sender, TextCompositionEventArgs e)
        {
            
        }

        private void PriceTextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void AmttenderedTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
           
        }

        private void AmttenderedTextBox_TextInput(object sender, TextCompositionEventArgs e)
        {
           
        }
    }
}
