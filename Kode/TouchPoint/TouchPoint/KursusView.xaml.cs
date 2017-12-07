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

namespace TouchPoint
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class KursusView : Page
    {
        public KursusView()
        {
            this.InitializeComponent();
        }

        private void MainpageKnap(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }

        private void KnapTilKursister(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(BrugerOverView));
        }

        private void KnapOpretKursus(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(KursusOpretView));
        }

        private void KnapUndervisningssted(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(UndervisningsstedView));
        }
    }
}
