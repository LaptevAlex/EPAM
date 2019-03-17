using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace task_4_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            string str = Console.ReadLine();
            Regex pattern1 = new Regex(@"^-?[0-9]+\.?[0-9]+$");
            Regex pattern2 = new Regex(@"^-?[0-9]\.?[0-9]+e[-+]?[0-9]+$");
            if (pattern1.IsMatch(str))
            {
                Console.WriteLine("Число в обычной нотации");
            }
            else if (pattern2.IsMatch(str))
            {
                Console.WriteLine("Это число в научной нотации");
            }
            else
            {
                Console.WriteLine("Это не число");
            }
            Console.ReadKey();
        }
    }
}
