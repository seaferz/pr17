using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp3
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //объём и площадь
        private void CalculateBoxData(object sender, RoutedEventArgs e)
        {
            try
            {
                double a = double.Parse(txtA.Text);
                double b = double.Parse(txtB.Text);
                double c = double.Parse(txtC.Text);

                double volume = a * b * c;
                double surface = 2 * (a * b + b * c + a * c);

                txtBoxResult.Text = $"Объём: {volume}, Площадь: {surface}";
            }
            catch
            {
                txtBoxResult.Text = "Ошибка: введите корректные числа для a, b и c";
            }
        }

        //сумма и произведение цифр
        private void CalculateDigits(object sender, RoutedEventArgs e)
        {
            try
            {
                int number = int.Parse(txtTwoDigit.Text);

                if (number < 10 || number > 99)
                {
                    txtDigitResult.Text = "Ошибка: введите двузначное число!";
                    return;
                }

                int tens = number / 10;
                int units = number % 10;

                int sum = tens + units;
                int product = tens * units;

                txtDigitResult.Text = $"Сумма: {sum}, Произведение: {product}";
            }
            catch
            {
                txtDigitResult.Text = "Ошибка: введите целое двузначное число.";
            }
        }

        //о программе
        private void ShowAbout(object sender, RoutedEventArgs e)
        {
            string message =
                "Разработал: Чеботарев Максим, ИСП-22\n" +
                "1. Даны длины ребер a, b, c прямоугольного параллелепипеда. Найти его объем V = \r\na·b·c и площадь поверхности S = 2·(a·b + b·c + a·c)\n" +
                "2. Дано двузначное число. Найти сумму и произведение его цифр";

            MessageBox.Show(message, "О программе", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        //выход
        private void ExitApplication(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}