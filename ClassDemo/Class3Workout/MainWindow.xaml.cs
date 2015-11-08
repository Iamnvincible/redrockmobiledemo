using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Class3Workout
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
       List<Student> sts = new List<Student>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Student s = new Student();
            s.Name = this.name.Text;
            s.Number = Convert.ToInt32(this.number.Text);
            this.itemsbox.Items.Add(s.Name);
            sts.Add(s);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            sortedbox.ItemsSource = null;
            sortedbox.Items.Clear();
            sts.Sort(new NameSort());
            sortedbox.ItemsSource = sts;
        }
    }
}
