using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Насколько высока елочка? ");

            int width = int.Parse(Console.ReadLine())+1;
            Console.WriteLine("Раз, Два, Три - Ёлочка гори!");

            for (int i = width; i > 0; i--)
            {
                Console.WriteLine();
                for (int g = i; g < width; g++)
                {
                    Console.Write("*");
                   
                }
 
                Console.Write(" ");
            }
           
            Console.ReadKey();

        }
    }
}
