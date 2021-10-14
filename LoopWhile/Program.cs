using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int sum = 0, a1;
            while (b >= c)
            {
                b -= c;
                a1 = a;
                while (a1 >= c)
                {
                    sum++;
                    a1 -= c;
                }
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
