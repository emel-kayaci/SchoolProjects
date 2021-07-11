using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace UserBMICalculator
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

        private void calculateClickButton(object sender, RoutedEventArgs e)
        {
            float weight = float.Parse(weightTxt.Text, CultureInfo.InvariantCulture.NumberFormat);
            float height = float.Parse(heightTxt.Text, CultureInfo.InvariantCulture.NumberFormat);
            height = height / 100;
            float bmi = weight / (height * height);

            bmiResult.Content = bmi.ToString(("0.##"));

            if (bmi < 18.5)
            {
                bmiResultPanel.Background = Brushes.Gold;
            }
            else if (18.5 < bmi && bmi < 25)
            {
                bmiResultPanel.Background = Brushes.ForestGreen;
            }
            else if (25 < bmi && bmi < 30)
            {
                bmiResultPanel.Background = Brushes.Orange;
            }
            else
            {
                bmiResultPanel.Background = Brushes.Firebrick;
            }
        }

        private bool isNumber(string Text)
        {
            int output;
            return int.TryParse(Text, out output);
        }

        private void keyPressedHeight(object sender, TextCompositionEventArgs e)
        {
            floatNumberChecker(sender, e);
        }

        private void weightTxt_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            floatNumberChecker(sender, e);
        }

        private void floatNumberChecker(object sender, TextCompositionEventArgs e)
        {
            if (e.Text != "." && isNumber(e.Text) == false)
            {
                e.Handled = true;
            }
            else if (e.Text == ".")
            {
                if (((TextBox)sender).Text.IndexOf(e.Text) > -1)
                {
                    e.Handled = true;
                }
            }
        }
    }
}
