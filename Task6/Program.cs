using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {int res = 0;
            for (int counter = 0; counter <= 1000; counter++)
            {
                
                int one = counter % 3;
                int two = counter % 5;
                

                if (one == 0)
                {
                  
                    res = counter + res;
                    
                }
                else if(two == 0)
                {
                    
                    res = counter + res;
                    
                }
                
            }
            int otvet = res;

            Console.WriteLine("Сумма всех чисел равна = "+otvet);
            Console.ReadLine();
            
        }
    }
}
