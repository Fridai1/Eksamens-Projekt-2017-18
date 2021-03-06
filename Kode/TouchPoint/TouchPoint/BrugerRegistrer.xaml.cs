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

namespace TouchPoint
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class BrugerRegistrer : Page
    {
        public BrugerRegistrer()
        {
            this.InitializeComponent();
            
        }

        private void MainPageKnap(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }

        private void KnapTilUndervisningssted(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(UndervisningsstedView));
        }

        private void Kursusknap(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(KursusView));
        }

        private void TilmeldKursus(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(TilmeldKursusView));
        }


        private void Bruger(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(BrugerOverView));
        }

    }
}
