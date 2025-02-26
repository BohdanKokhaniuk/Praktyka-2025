using System;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;

namespace WPFApp1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SetCulture();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            double x = ReadDouble(textBoxX.Text, "x");
            double y = ReadDouble(textBoxY.Text, "y");
            double z = ReadDouble(textBoxZ.Text, "z");

            if (double.IsNaN(x) || double.IsNaN(y) || double.IsNaN(z))
                return; // Якщо були помилки, зупиняємо виконання

            double r = x + y + z;
            textBoxR.Text = r.ToString("F2");
        }

        private double ReadDouble(string input, string variableName)
        {
            if (!double.TryParse(input, out double value))
            {
                MessageBox.Show($"Помилка введення значення {variableName}!", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
                return double.NaN;
            }
            return value;
        }

        private void SetCulture()
        {
            CultureInfo customCulture = (CultureInfo)CultureInfo.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            CultureInfo.CurrentCulture = customCulture;
        }
    }
}
