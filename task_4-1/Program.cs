using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_4_1
{ 
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Введите строку:");
                String str = Console.ReadLine();
                Console.WriteLine("Средняя длина слова в строке "+GetLength(str)+" символов");
                Console.ReadKey();
            }

            static public double GetLength(string str)
            {
                char[] arr = str.ToCharArray();
                bool chek = false;
                double sum = 0;
                int numWord = 0;

                for (int i = 0; i < arr.Length; i++)
                {
                    if (char.IsLetter(arr[i]) && chek == false)
                    {
                        numWord++;
                    }

                    if (char.IsLetter(arr[i]))
                    {
                        chek = true;
                        sum++;
                    }

                    else
                    {
                        chek = false;
                    }
                }

                return sum / numWord;
            }
        }
    }

