using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Насколько высока елочка? ");

            int width = int.Parse(Console.ReadLine()) ;

            Console.WriteLine("Раз, Два, Три - Ёлочка гори!");

            for (int i = width; i > 0; i--)
            {
                Console.WriteLine();

                for (int j = width - i + 1; j <= width; j++)
                {                    
                    if (j < width)
                    {
                       Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }

                for (int j = 0; j < width - i; j++)
                {
                    Console.Write("**");
                }               

                Console.Write(" ");
            }
            Console.WriteLine();
           
            Console.ReadKey();

        }
    }
}
