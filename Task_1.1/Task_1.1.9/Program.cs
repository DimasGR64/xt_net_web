using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1._1._9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                arr[i] = rnd.Next(-99, 99);
            }
            int summ = 0;

            foreach (int element in arr )
            {
                if (element > 0)
                {
                  summ += element;
                }
            }
            Console.WriteLine(summ);
            
        }
    }
}
