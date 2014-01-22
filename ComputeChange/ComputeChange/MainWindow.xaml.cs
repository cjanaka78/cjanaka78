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

          
            //Converts the text input of the Price to decimal and stores in the price variable 
                price = Decimal.Parse(PriceTextBox.Text);
      
            //Converts the text input of the amtTendered  to decimal and stores in the amtTendered  variable
            amtTendered = Decimal.Parse(AmttenderedTextBox.Text);
     
            //error checking for negative price
            if ((price < 0) )
            {
                MessageBox.Show("price cannot be a negative");
            }

            //error checking for negative amount tendered
            if ((amtTendered < 0))
            {
                MessageBox.Show("Amount Tendered cannot be a negative");
            }
            
            if((price>0) && (amtTendered> 0))
            {
                //Calculates the change 
                change = (amtTendered - price) * 100;


                //prints the Change amount onto the app screen
                textBlockChange.Text = ((int)change).ToString() + " Cents";


                //Calculates the number of Quarters
                numOfQuarters = Convert.ToInt32(change) / 25;

                //prints the number of quarters onto the app screen
                textBlockNumQuarters.Text = numOfQuarters.ToString();


                //Calculates the number of dimes
                numOfDimes = ((int)change % 25 / 10);

                //prints the number of dimes onto the app screen
                textBlockNumDimes.Text = numOfDimes.ToString();

                //Calculates the number of Nickels
                numOfNickels = ((((int)change % 25) % 10) / 5);

                //prints the number of nickles onto the app screen
                textBlockNumNickles.Text = numOfNickels.ToString();

                //Calculates the number of Pennies
                numOfPennies = ((((int)change % 25) % 10) % 5);

                //prints the number of pennies onto the app screen
                textBlockNumPennies.Text = numOfPennies.ToString();

            }
         

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
