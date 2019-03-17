using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace task_4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            GetInfo("ru");
            Console.WriteLine();
            GetInfo("en");
            Console.WriteLine();
            GetInvariantInfo();
            Console.ReadKey();
        }

        static public void GetInfo(string str)
        {
            var culture = CultureInfo.CreateSpecificCulture(str);
            Console.WriteLine(culture.DisplayName);
            Console.Write("Представление даты: ");
            Console.WriteLine(culture.DateTimeFormat.FullDateTimePattern);
            Console.Write("Десятичный разделитель: ");
            Console.WriteLine(culture.NumberFormat.NumberDecimalSeparator);
            Console.Write("Разделитель групп разрядов: ");
            Console.WriteLine(culture.NumberFormat.NumberGroupSeparator);
        }

        static public void GetInvariantInfo()
        {
            Console.WriteLine(CultureInfo.InvariantCulture.DisplayName);
            Console.Write("Представление даты: ");
            Console.WriteLine(CultureInfo.InvariantCulture.DateTimeFormat.FullDateTimePattern);
            Console.Write("Десятичный разделитель: ");
            Console.WriteLine(CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator);
            Console.Write("Разделитель групп разрядов: ");
            Console.WriteLine(CultureInfo.InvariantCulture.NumberFormat.NumberGroupSeparator);
        }
    }
}
