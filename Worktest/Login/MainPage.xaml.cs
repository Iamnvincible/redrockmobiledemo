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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Login
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        DispatcherTimer dt = new DispatcherTimer();
        int ticks = 0;
        public MainPage()
        {
            this.InitializeComponent();
            dt.Interval = new TimeSpan(100);
            dt.Tick += Dt_Tick;
            dt.Start();
        }

        private void Dt_Tick(object sender, object e)
        {
            num.Text = ticks++.ToString();
        }

        private void loginbtn_Click(object sender, RoutedEventArgs e)
        {
            if (num.Text != "" && password.Password != "")
            {
                App.stunum = Int32.Parse(num.Text);
                App.password = password.Password;
                Frame.Navigate(typeof(BlankPage1), num.Text);
            }
        }
    }
}
