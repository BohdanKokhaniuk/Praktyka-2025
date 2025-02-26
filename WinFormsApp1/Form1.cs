using System;
using System.Globalization;
using System.Windows.Forms;

namespace WinFormsApp1
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Виникла критична помилка: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
