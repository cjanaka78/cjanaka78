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
            decimal price = 0;
            decimal amtTendered = 0;
            decimal change = 0;
        
            int numOfQuarters = 0;  //Number of Quarters in the Change 
            int numOfDimes = 0;     //Number of Dimes in the Change  
            int numOfNickels = 0;   //Number of Nickes in the Change
            int numOfPennies = 0;   //Number of Pennies in the Change 

            //String result = "" ;

            //Converts the text input of the Price to decimal and stores in the price variable
            price = Decimal.Parse(PriceTextBox.Text);
       
            //MessageBox.Show(PriceTextBox.Text);

            //Converts the text input of the amtTendered  to decimal and stores in the amtTendered  variable
            amtTendered = Decimal.Parse(AmttenderedTextBox.Text);
            //MessageBox.Show(AmttenderedTextBox.Text);


            //Calculates the change 
            change = (amtTendered - price) * 100;

           // result = this.ToString(change);
            

            MessageBox.Show("Change in Cents: " + Convert.ToInt32(change));

            //Calculates the number of Quarters
            numOfQuarters = Convert.ToInt32(change) / 25;

            MessageBox.Show("Number of Quarters: " + numOfQuarters.ToString());

            //Calculates the number of dimes
            numOfDimes = ((int)change % 25 / 10);
            MessageBox.Show("Number of Dimes: " + numOfDimes);

            //Calculates the number of Nickels
            numOfNickels = ((((int)change % 25) % 10) / 5);
            MessageBox.Show("Number of Nickles: " + numOfNickels);

            //Calculates the number of Pennies
            numOfPennies = ((((int)change % 25) % 10) % 5);
            MessageBox.Show("Number of Pennies: " + numOfPennies);


           
   
            
           // change = Single.Parse(price.Text);

            //Console.WriteLine(orginalAmount);
           // MessageBox.Show("The Original Price of " + orginalAmount.Text + " is equivalent to " + orginalAmount);

        }

        private string ToString(decimal change)
        {
            throw new NotImplementedException();
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

        private void textBox2_TextChanged(object sender, TextChangedEventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
    }
}
