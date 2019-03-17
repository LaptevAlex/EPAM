using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            String str1, str2;
            Console.WriteLine("Введите первую строку:");
            str1 = Console.ReadLine();
            Console.WriteLine("Введите вторую строку:");
            str2 = Console.ReadLine();
            DoubleLetters(ref str1, str2);
            Console.WriteLine("Результирующая строка : "+str1);
            Console.ReadKey();
        }

        static public void DoubleLetters(ref string str1, string str2)
        {
            var itogStr = new StringBuilder();
            bool coincide = false;
            for (int i = 0; i < str1.Length; i++)
            {
                coincide = false;
                for (int k = 0; k < str2.Length; k++)
                {
                    if (char.IsLetter(str1[i]) && char.IsLetter(str2[k]) && str1[i] == str2[k])
                    {
                        coincide = true;
                        break;
                    }
                }
                itogStr.Append(str1[i]);
                if (coincide)
                {
                    itogStr.Append(str1[i]);
                }
            }

            str1 = itogStr.ToString();
        }
    }
}
