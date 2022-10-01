using System;
using System.Collections.Generic;
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

namespace ISRPO_Palashicheva_PR3._1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        float a;

        private void p3_Click(object sender, RoutedEventArgs e)
        {
            a = float.Parse(tb1.Text);
            tb1.Text = Convert.ToString(a+3);
        }

        private void p2_Click(object sender, RoutedEventArgs e)
        {
            a = float.Parse(tb1.Text);
            tb1.Text = Convert.ToString(a + 2);
        }
        private void p1_Click(object sender, RoutedEventArgs e)
        {
            a = float.Parse(tb1.Text);
            tb1.Text = Convert.ToString(a + 1);
        }

        private void m1_Click(object sender, RoutedEventArgs e)
        {
            a = float.Parse(tb1.Text);
            tb1.Text = Convert.ToString(a - 1);
        }

        private void m2_Click(object sender, RoutedEventArgs e)
        {
            a = float.Parse(tb1.Text);
            tb1.Text = Convert.ToString(a - 2);
        }

        private void m3_Click(object sender, RoutedEventArgs e)
        {
            a = float.Parse(tb1.Text);
            tb1.Text = Convert.ToString(a - 3);
        }

        private void pp3_Click(object sender, RoutedEventArgs e)
        {
            a = float.Parse(tb2.Text);
            tb2.Text = Convert.ToString(a + 3);
        }

        private void pp2_Click(object sender, RoutedEventArgs e)
        {
            a = float.Parse(tb2.Text);
            tb2.Text = Convert.ToString(a + 2);
        }
        private void pp1_Click(object sender, RoutedEventArgs e)
        {
            a = float.Parse(tb2.Text);
            tb2.Text = Convert.ToString(a + 1);
        }

        private void mm1_Click(object sender, RoutedEventArgs e)
        {
            a = float.Parse(tb2.Text);
            tb2.Text = Convert.ToString(a - 1);
        }

        private void mm2_Click(object sender, RoutedEventArgs e)
        {
            a = float.Parse(tb2.Text);
            tb2.Text = Convert.ToString(a - 2);
        }

        private void mm3_Click(object sender, RoutedEventArgs e)
        {
            a = float.Parse(tb2.Text);
            tb2.Text = Convert.ToString(a - 3);
        }

        private void ppp3_Click(object sender, RoutedEventArgs e)
        {
            a = float.Parse(tb3.Text);
            tb3.Text = Convert.ToString(a + 3);
        }

        private void ppp2_Click(object sender, RoutedEventArgs e)
        {
            a = float.Parse(tb3.Text);
            tb3.Text = Convert.ToString(a + 2);
        }
        private void ppp1_Click(object sender, RoutedEventArgs e)
        {
            a = float.Parse(tb3.Text);
            tb3.Text = Convert.ToString(a + 1);
        }

        private void mmm1_Click(object sender, RoutedEventArgs e)
        {
            a = float.Parse(tb3.Text);
            tb3.Text = Convert.ToString(a - 1);
        }

        private void mmm2_Click(object sender, RoutedEventArgs e)
        {
            a = float.Parse(tb3.Text);
            tb3.Text = Convert.ToString(a - 2);
        }

        private void mmm3_Click(object sender, RoutedEventArgs e)
        {
            a = float.Parse(tb3.Text);
            tb3.Text = Convert.ToString(a - 3);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            tb1.Text = "3";
            tb2.Text = "2";
            tb3.Text = "1";
        }
    }
}
