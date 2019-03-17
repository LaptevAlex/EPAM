using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace task_4_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку:");
            string str = Console.ReadLine();
            Regex pattern = new Regex("<.*?>");
            str = pattern.Replace(str, "_");
            Console.WriteLine("Результат :"+str);
            Console.ReadKey();
        }
    }
}
