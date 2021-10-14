using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopFor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int Sum = 0;
            for (int i = 1; Sum < Math.Pow(n, 2); i += 2)
            {
                Sum += i;
                Console.WriteLine(Sum);
            }
            Console.ReadKey();
        }
    }
}
