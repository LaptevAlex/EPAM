using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace task_4_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "";
            StringBuilder sb = new StringBuilder();
            int N = 100;
            Stopwatch time = new Stopwatch();
            time.Start();
            for (int i = 0; i < N; i++)
            {
                str += "*";
            }
            time.Stop();
            Console.WriteLine($"string: {time.Elapsed.TotalMilliseconds}");
            time.Restart();
            for (int i = 0; i < N; i++)
            {
                sb.Append("*");
            }
            var s = sb.ToString();
            time.Stop();
            Console.WriteLine($"stringBuilder: {time.Elapsed.TotalMilliseconds}");
            Console.ReadKey();
        }
    }
}
