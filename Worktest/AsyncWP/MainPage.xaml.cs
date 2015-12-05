using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
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

namespace AsyncWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        DispatcherTimer dt = new DispatcherTimer();
        static int time = 0;
        public MainPage()
        {
            this.InitializeComponent();
            dt.Interval = new TimeSpan(1000);
            dt.Tick += Dt_Tick;
            dt.Start();
            
        }

        private void Dt_Tick(object sender, object e)
        {
            Debug.WriteLine("{0}",time++);
            num.Text = time.ToString();
        }

        private async void btn_Click(object sender, RoutedEventArgs e)
        {
            //this.progressring.IsActive = !progressring.IsActive;
            //await Task.Delay(3000);
            //this.txt.Text = "微软创新杯";
            //await Task.Run(() => {
            //    for (int i = 0; i < 10; i++)
            //    {
            //       // this.txt.Text = i.ToString();
            //        Task.Delay(4000);
            //        Debug.Write(i);
            //    }
            //});
          
            this.progressring.IsActive = !progressring.IsActive;
            Button nb = new Button();
            nb.Content = "哇塞";
            nb.HorizontalAlignment = HorizontalAlignment.Center;
            stp.Children.Add(nb);
        }
    }
}
