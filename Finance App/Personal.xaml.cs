﻿using System;
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
    public sealed partial class Personal : Page
    {
        Enquire Eqy;
        public Personal()
        {
            this.InitializeComponent();
        }
        Dictionary<string, Enquire> elementDictionary = new Dictionary<string, Enquire>();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Eqy = new Enquire();


            Eqy.FirstName = First_name.Text;
            Eqy.LastName = Last_name.Text;
            Eqy.Email = Email.Text;
            Eqy.Subject = Sub.Text;
            Eqy.Enquiry = Enq.Text;

            if (Eqy != null)
            {

                Frame.Navigate(typeof(EnquirySucessful));
            }
            else
            {
                Frame.Navigate(typeof(Personal));
            }
        }


    }
}
