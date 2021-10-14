using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopDo
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0, num;
            do
            {
                num = Convert.ToInt32(Console.ReadLine());
                if (num != 0)
                {
                    sum = (num > 0) ? ++sum : --sum;
                }
            } while (num != 0);
            Console.WriteLine((sum == 0) ? "Ошибка" : (sum > 0) ? "Положительных больше" : "Отрицательных больше");
            Console.ReadKey();
        }
    }
}
