using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1._1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите количество строк");

            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i < N + 1; i++)
            {
                for (int spase = N; spase > i; spase--)
                {
                    Console.Write(" ");
                }
                for (int stars = 1; stars <= i; stars++)
                {
                    Console.Write("*");
                }
                for (int stars = 2; stars <= i; stars++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
