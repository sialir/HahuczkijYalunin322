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

namespace HahuczkijYalunin322
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(X.Text, out double x) && double.TryParse(Y.Text, out double y))
            {
                double result = 0;
                if ((bool)shx.IsChecked)
                {
                    result = Math.Sinh(x);
                }
                else if ((bool)x2.IsChecked)
                {
                    result = Math.Pow(x, 2);
                }
                else if ((bool)ex.IsChecked)
                {
                    result = Math.Exp(x);
                }
                Result.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите корректные значения для x и y.");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            X.Text = string.Empty;
            Y.Text = string.Empty;
            Result.Text = string.Empty;
        }

        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            var result = MessageBox.Show("Вы уверены, что хотите выйти?", "Подтверждение", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
