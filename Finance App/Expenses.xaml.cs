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
    public sealed partial class Expenses : Page
    {
        public Expenses()
        {
            this.InitializeComponent();
        }
        private void MyComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            OptionResult.Text = Option.SelectedItem.ToString();
        }

        private void MyComboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Option1Result.Text = Option1.SelectedItem.ToString();
        }

        private void MyComboBox2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Option2Result.Text = Option2.SelectedItem.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Identification));
        }
    }

}
