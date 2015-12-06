using System;
using System.Collections.Generic;
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

namespace Classdemouwp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public int num { get; set; }
        public string str { get; set; }
        public MainPage()
        {
            this.InitializeComponent();
            num = 133;
        }

        private async void btn_Click(object sender, RoutedEventArgs e)
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 30000; i++)
                {
                   // str += i.ToString();
                }
            });

            progressring.IsActive = !progressring.IsActive;

            this.txt.Text = num++.ToString();
            if (progressring.IsActive == true)
            {
                btn.Content = "停止菊花";
            }
            else
            {
                btn.Content = "开始菊花";
            }
            Button nb = new Button();
            nb.Content = "新♥";
            nb.HorizontalAlignment
                =HorizontalAlignment.Center;
            stp.Children.Add(nb);
        }


    }
}
