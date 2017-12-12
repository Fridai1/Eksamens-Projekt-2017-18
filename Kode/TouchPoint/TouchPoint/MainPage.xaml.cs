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
using TouchPoint.ViewModel;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace TouchPoint
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Login(Object sender, RoutedEventArgs e)
        {
            ((LoginVm)this.DataContext).LoginCommand.Execute(null);

            if (((LoginVm)this.DataContext).Brugernavn != null)
            {
                Frame.Navigate(typeof(BrugerOverView));
            }




        }

        private void Registrer(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(BrugerRegistrer));
        }

        private void TilMeldKursus(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(TilmeldKursusView));
        }
    }
}
