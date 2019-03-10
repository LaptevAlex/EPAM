using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            double res = 0;
            Console.WriteLine("Введите значения сторон прямоугольника");
            Console.Write("A= ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("B= ");
            int b = int.Parse(Console.ReadLine());

            if (a > 0 && b > 0)
            {
                res = a * b;
                Console.WriteLine("Площадь прямоугольника = "+res);
                Console.ReadLine();

            }
            else
                Console.WriteLine("Что-то пошло не так");
                Console.ReadLine();
        }
    }
}
