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

namespace WPFApp1
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            double x, y, z;
            bool ok;
            ok = double.TryParse(textBoxX.Text, out x);
            if (!ok)
            {
                MessageBox.Show("Помилка введення значення x!", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            ok = double.TryParse(textBoxY.Text, out y);
            if (!ok)
            {
                MessageBox.Show("Помилка введення значення y!", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            ok = double.TryParse(textBoxZ.Text, out z);
            if (!ok)
            {
                MessageBox.Show("Помилка введення значення z!", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            double r = x + y + z;
            textBoxR.Text = r.ToString("F2");
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
                       System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
        }
    }
}
