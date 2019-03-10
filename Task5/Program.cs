using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Насколько высока елочка? ");

            int width = int.Parse(Console.ReadLine());

            Console.WriteLine("Раз, Два, Три - Ёлочка гори!");
            for (int k = 1; k <= width; k++)
            {
                for (int i = k; i > 0; i--)
                {
                    Console.WriteLine();

                    for (int j = k - i + 1; j <= width; j++)
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

                    for (int j = 0; j < k - i; j++)
                    {
                        Console.Write("**");
                    }

                    Console.Write(" ");
                }
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
