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
    public sealed partial class Navigation : Page
    {

        private string[] selectionItems = new string[] { "Steve", "Ute", "Tom", "Victor", "Eve", "Glen", "Quentin", "David", "Sabrina", "Rachel", "Basil", "Tina", "Kathy", "Ivan", "Liam", "Quincey", "Ralf", "Louis", "Mick", "Gillian", "Nathan", "Ferdinand", "Iggy", "Olivia", "Paul", "Pat", "Mikayla", "Nicole", "James", "Penelope", "Amy", "Frank", "Janette", "Fiona", "Kelly", "Odin", "Ewan", "Fred", "Frida", "Amber", "Hannah", "Sacha", "Ulf", "Yasmin", "Helga", "Zac", "Candy", "Xavier", "Dan", "Nigel", "Yana", "Tag", "Zoe", "Wendy", "Tanya", "Xeon", "Becca", "Vicky", "Tanner", "William", "Todd", "Carmen" };

        public Navigation()
        {
            this.InitializeComponent();
            BackButton.Visibility = Visibility.Collapsed;
            MyFrame.Navigate(typeof(Vehicle));
            TitleTextBlock.Text = "Vehicle";
           Vehicle.IsSelected = true;
        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            if (MyFrame.CanGoBack)
            {
                MyFrame.GoBack();
                //Vehicle.IsSelected = true;
            }
        }

        private void IconsListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Vehicle.IsSelected)
            {
                BackButton.Visibility = Visibility.Collapsed;
                MyFrame.Navigate(typeof(Vehicle));
                TitleTextBlock.Text = "Vehicle";
            }
            else if (Personal.IsSelected)
            {
                BackButton.Visibility = Visibility.Visible;
                MyFrame.Navigate(typeof(Personal));
                TitleTextBlock.Text = "Personal";
            }
            else if (Business.IsSelected)
            {
                BackButton.Visibility = Visibility.Visible;
                MyFrame.Navigate(typeof(Business));
                TitleTextBlock.Text = "Business";
            }
            else if (LoanCalculator.IsSelected)
            {
                BackButton.Visibility = Visibility.Visible;
                MyFrame.Navigate(typeof(Loan_Calculator));
                TitleTextBlock.Text = "Loan Calculator";
            }
        }

        private void SearchTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var SearchTextBox = (AutoSuggestBox)sender;
            var filtered = selectionItems.Where(p => p.StartsWith(SearchTextBox.Text)).ToArray();
            SearchTextBox.ItemsSource = filtered;

           
        }
    }
}

