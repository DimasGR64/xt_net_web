using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1._1._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int summ = 0;

            for (int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    summ += i;
                }
            }
            Console.WriteLine(summ);
        }
    }
}
