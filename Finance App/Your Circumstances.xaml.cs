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
    public sealed partial class Your_Circumstances : Page
    {
        public Your_Circumstances()
        {
            this.InitializeComponent();
        }

        private void MyComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MSResult.Text = MS.SelectedItem.ToString();
        }

        private void BasicListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            BasicListBoxResult.Text = BasicListBox.SelectedItem.ToString();
        }

        private void MyCalendarDatePicker_DateChanged(CalendarDatePicker sender, CalendarDatePickerDateChangedEventArgs args)
        {
            if (MyCalendarDatePicker.Date != null)
            {
                DateResult.Text =  MyCalendarDatePicker.Date.Value.Day.ToString() + " " +
                                                          MyCalendarDatePicker.Date.Value.Month.ToString() + " " +
                                                          MyCalendarDatePicker.Date.Value.Year.ToString();

                // Can also use this format
                //DatePickerResult.Text = "You selected " + args.NewDate.Value.Day.ToString() + " " +
                //                                          args.NewDate.Value.Month.ToString() + " " +
                //                                          args.NewDate.Value.Year.ToString();

                // Setting a date in code
                //MyCalendarDatePicker.Date = new DateTime(1977, 1, 5);
            }
            else
            {
                DateResult.Text = "Choose a date";
            }
        }

        private void EM_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            EmploymentResult.Text = EM.SelectedItem.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Expenses));
        }
    }
}
