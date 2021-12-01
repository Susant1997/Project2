using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Assignment2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Loan_Calculator : Page
    {
        double MonthlyAmountValue;
        int LoanAmountValue;
        int Time;
        double InterestRateValue = 9.5;
        double TotalAmount;
        double FortnightlyValue;
        double WeeklyValue;

        public Loan_Calculator()
        {
            this.InitializeComponent();
        }
       



        private void BasicListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TimeResult.Text = BasicListBox.SelectedItem.ToString() ;
            try
            {

                Time  = int.Parse(TimeResult.Text);  
            }
            catch (FormatException exc)
            {
                // Output the division  to the screen
                TimeMessage.Text = exc.Message + " : Please enter a number";
            }

            catch (Exception exc)
            {
                TimeMessage.Text = "The following exception was generated : " + exc.Message;
            }
        }

        private void MonthlyAmount_SelectionChanged(object sender, RoutedEventArgs e)
        {

            //try
            //{

            //    LoanAmontValue = int.Parse(LoanAmount.Text);  // Enter cash

            //}
            //catch (FormatException exc)
            //{
            //    // Output the division  to the screen
            //    Message.Text = exc.Message + " : Please enter a number";
            //}

            //catch (Exception exc)
            //{
            //    Message.Text = "The following exception was generated : " + exc.Message;
            //}


            //MonthlyAmountValue = (InterestRateValue * dollars) / (1 - Math.Pow(1 + InterestRateValue, Time * -1));

            //MonthlyAmount.Text = MonthlyAmountValue.ToString();

            //total_amount = (number_of_years * loan_amount) + (number_of_years * loan_amount * (interest_rate / 100.00));
           // monthly_amount = total_amount / (number_of_years * 12);


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TotalAmount = ((Time / 12) * LoanAmountValue) + ((Time/12) * LoanAmountValue * (InterestRateValue / 100.00));
            MonthlyAmountValue = TotalAmount / Time;
            FortnightlyValue = MonthlyAmountValue / 2;
            WeeklyValue = MonthlyAmountValue / 4;

            MonthlyAmount.Text = MonthlyAmountValue.ToString();
            FortnightlyAmount.Text = FortnightlyValue.ToString();
            WeeklyAmount.Text = WeeklyValue.ToString();
        }

        private void LoanAmount_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {

                LoanAmountValue = int.Parse(LoanAmount.Text);  // Enter cash

            }
            catch (FormatException exc)
            {
                // Output the division  to the screen
                Message.Text = exc.Message + " : Please enter a number";
            }

            catch (Exception exc)
            {
                Message.Text = "The following exception was generated : " + exc.Message;
            }
        }
    }
}
 