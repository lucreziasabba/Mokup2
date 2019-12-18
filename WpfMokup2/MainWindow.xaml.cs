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

namespace WpfMokup2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            txtPrimoNum.IsEnabled = true;
            txtSecondoNum.IsEnabled = true;
            sldPrimoNum.IsEnabled = true;
            sldSecondoNum.IsEnabled = true;
            txtSum.IsEnabled = true;
        }
        private void CheckBox_UnChecked(object sender, RoutedEventArgs e)
        {
            txtPrimoNum.IsEnabled = false;
            txtSecondoNum.IsEnabled = false;
            sldPrimoNum.IsEnabled = false;
            sldSecondoNum.IsEnabled = false;
            txtSum.IsEnabled = false;
        }

        private void sldPrimoNum_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            double n1 = (double)sldPrimoNum.Value;
            double n2 = (double)sldSecondoNum.Value;

            double somma = n1 + n2;
            txtSum.Text = somma.ToString();

        }
    }
}
