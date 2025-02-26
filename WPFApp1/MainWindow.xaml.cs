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
            if (!TryReadDouble(textBoxX.Text, "x", out double x) ||
                !TryReadDouble(textBoxY.Text, "y", out double y) ||
                !TryReadDouble(textBoxZ.Text, "z", out double z))
            {
                return; // Якщо були помилки, зупиняємо виконання
            }

            double r = x + y + z;
            textBoxR.Text = r.ToString("F2", CultureInfo.InvariantCulture);
        }

        private bool TryReadDouble(string input, string variableName, out double value)
        {
            if (!double.TryParse(input, NumberStyles.Any, CultureInfo.InvariantCulture, out value))
            {
                MessageBox.Show($"Помилка введення значення {variableName}!", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            return true;
        }

        private void SetCulture()
        {
            CultureInfo customCulture = (CultureInfo)CultureInfo.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            CultureInfo.DefaultThreadCurrentCulture = customCulture;
            CultureInfo.DefaultThreadCurrentUICulture = customCulture;
        }
    }
}
