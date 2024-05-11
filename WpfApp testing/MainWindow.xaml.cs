using System.Windows;
using System.Windows.Controls;

namespace WpfApp_testing
{
    public partial class MainWindow : Window
    {
        double num1;
        double num2;
        double res;
        public MainWindow()
        {
            InitializeComponent();
            SetOpAndEveryThing();
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            num1label.Content = num1Slider.Value;
            num1 = num1Slider.Value;
            SetOpAndEveryThing();
        }

        private void Slider_ValueChanged_1(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            num2label.Content = num2Slider.Value;
            num2 = num2Slider.Value;
            SetOpAndEveryThing();
        }
        private void SetOpAndEveryThing()
        {
            if (plus.IsChecked == true)
            {


                res = num1 + num2;
                result.Text = res.ToString();
            }
            else if (substract.IsChecked == true)
            {

                res = num1 - num2;
                result.Text = res.ToString();
            }
            else if (multiply.IsChecked == true)
            {


                res = num1 * num2;
                result.Text = res.ToString();
            }
            else if (divide.IsChecked == true)
            {

                res = num1 / num2;
                result.Text = res.ToString();
            }
        }

        private void multiply_Checked(object sender, RoutedEventArgs e)
        {
            op.Content = "*"; res = num1 * num2;
            result.Text = res.ToString();
        }

        private void divide_Checked(object sender, RoutedEventArgs e)
        {
            op.Content = "/";
            res = num1 / num2;
            result.Text = res.ToString();
        }

        private void substract_Checked(object sender, RoutedEventArgs e)
        {
            op.Content = "-"; res = num1 - num2;
            result.Text = res.ToString();
        }

        private void plus_Checked(object sender, RoutedEventArgs e)
        {
            if (op != null)
                op.Content = "+"; res = num1 + num2;
            result.Text = res.ToString();
        }
    }
}
