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
    public sealed partial class Your_Details : Page
    {
        int Phonenumber;
        Details Det;
        public Your_Details()

        {
            this.InitializeComponent();
        }

        Dictionary<string, Details> elementDictionary = new Dictionary<string, Details>();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Your_Circumstances));



            Det = new Details();


            Det.FirstName = FN.Text;
            Det.MiddleName = MN.Text;
            Det.LastName = LN.Text;
            Det.PreferName = PN.Text;
            Det.Email = Email.Text;
            Det.Phone = Phone.Text;



        }

        private void Phone_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {

                Phonenumber = int.Parse(Phone.Text);
            }
            catch (FormatException exc)
            {
                // Output the division  to the screen
                PhoneMessage.Text = exc.Message + " : Please enter a number";
            }

            catch (Exception exc)
            {
                PhoneMessage.Text = "The following exception was generated : " + exc.Message;
            }
        }
    }
}
