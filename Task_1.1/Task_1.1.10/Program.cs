using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1._1._10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[10,10];
            int summ = 0;
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    arr[i, j] = rnd.Next(-99, 99);
                }
            }
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j  = 0; j < arr.GetLength(1); j++)
                {
                    if ((i + j) % 2 == 0)
                        summ += arr[i, j];
                }
            }
                Console.WriteLine(summ);
              
        }
    }
}
