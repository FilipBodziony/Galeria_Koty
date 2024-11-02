using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;


namespace kotki_wpf
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

        int number = 1;
        int lastNumber = 1;
        const int minKotValue = 1;
        const int maxKotValue = 4;

        //int maxKotValue = countFiles();
        //private static int countFiles()
        //{
        //    string[] files = System.IO.Directory.GetFiles("assets", "*.jpg");
        //    return files.Length;
        //}

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void btnPREV_Click(object sender, RoutedEventArgs e)
        {
            changePicture(-1);
        }

        private void btnNEXT_Click(object sender, RoutedEventArgs e)
        {
            changePicture(1);
        }

        private void changeNumber(int i)
        {
            if (i != 0)
            {
                number += i;
                changeToCorrectRange(maxKotValue, minKotValue);
            }
            else
            {
                changeToCorrectRange(minKotValue, maxKotValue);
            }
        }

        private void changeToCorrectRange(int first, int last)
        {
            if (number < minKotValue)
            {
                number = first;
            }
            else if (number > maxKotValue)
            {
                number = last;
            }
        }

        private void changePicture(int i)
        {
            if (int.TryParse(txtNumber.Text, out number))
            {
                changeNumber(i);
                lastNumber = number;
                txtNumber.Text = number.ToString();
                changeImageSource(number);
            }
            else
            {
                changeImageSource(lastNumber);
            }

        }

        private void changeImageSource(int num)
        {
            imgKotek.Source = new BitmapImage(new Uri("assets/kot" + num + ".jpg", UriKind.Relative));
        }

        private void txtNumber_TextChanged(object sender, TextChangedEventArgs e)
        {
            changePicture(0);
        }

        private void cbColor_Checked(object sender, RoutedEventArgs e)
        {
            changeBackgroundColor(gridContent, "#1565c0");
        }

        private void cbColor_Unchecked(object sender, RoutedEventArgs e)
        {
            changeBackgroundColor(gridContent, "#00796B");
        }
        private void changeBackgroundColor(System.Windows.Controls.Grid gridName, String colorString)
        {
            Color color = (Color)ColorConverter.ConvertFromString(colorString);
            gridName.Background = new SolidColorBrush(color);
        }
    }
}