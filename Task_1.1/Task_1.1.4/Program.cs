using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1._1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите количество строк");

            int N = int.Parse(Console.ReadLine());
          
            for (int j = 0; j < N; j++)
            {
                for (int i = 0; i < j+1; i++)
                {
                    for (int spase = N; spase > i; spase--)
                    {
                        Console.Write(" ");
                    }
                    for (int stars = 0; stars <= i; stars++)
                    {
                        Console.Write("*");
                    }
                    for (int stars = 1; stars <= i; stars++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                                
            }
            Console.ReadLine();
        }
    }
}
