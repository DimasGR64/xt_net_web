using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1._1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;

            Console.WriteLine("введите количество строк");

            N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N+1; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
