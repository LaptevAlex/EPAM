using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace task_4_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку:");
            string str = Console.ReadLine();
            Regex pattern = new Regex(@"(\s|^)([0-1]?[0-9]|2[0-3]):[0-5][0-9](\s|$)");
            var array = pattern.Matches(str);
            Console.WriteLine($"Кол-во соответствий {array.Count}");
            Console.ReadKey();
        }
    }
}
