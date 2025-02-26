using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {        
        static void Main(string[] args)
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
                        System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            double x, y, z;
            bool ok;
            Console.WriteLine("Лабораторна робота №2.\nВиконав: Іванов І.І., група ПІ-67\nВаріант №17.\nЗавдання 1.");            
            do
            {
                Console.Write("Введіть дробове значення x = ");
                ok = double.TryParse(Console.ReadLine(), out x);
                if (!ok)
                    Console.WriteLine("  Помилка введення значення x. Будь-ласка повторіть введення значення ще раз!");
            } while (!ok);
            do
            {
                Console.Write("Введіть дробове значення y = ");
                ok = double.TryParse(Console.ReadLine(), out y);
                if (!ok)
                    Console.WriteLine("  Помилка введення значення y. Будь-ласка повторіть введення значення ще раз!");
            } while (!ok);
            do
            {
                Console.Write("Введіть дробове значення z = ");
                ok = double.TryParse(Console.ReadLine(), out z);
                if (!ok)
                    Console.WriteLine("  Помилка введення значення z. Будь-ласка повторіть введення значення ще раз!");
            } while (!ok);
            double r = x + y + z;
            Console.WriteLine("Результат обчислення: r = {0:F3}", r);
            Console.ReadKey();
        }
    }
}
