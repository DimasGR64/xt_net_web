using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1._1._7
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxi, mini, buffer;

            int[] arr = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                arr[i] = rnd.Next(-99, 99);
            }

            maxi = arr[0];
            mini = arr[0];
            buffer = arr[0];

            for (int i = 0; i < arr.Length; i++) // min and max found
            {
                if (arr[i] > maxi)
                {
                    maxi = arr[i];
                }
                else if (arr[i] < mini)
                    mini = arr[i];
            }
            for (int i = 0; i < arr.Length-1; i++) // sorted array
            {
                for (int j = 0; j < arr.Length-i-1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        buffer = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = buffer;
                    }
                }
            }
            for (int m = 0; m < arr.Length; m++)
            {
                Console.Write(arr[m] + " ");
            }

            Console.WriteLine("\nmax value array: {0}", maxi);
            Console.WriteLine("min value array: " + mini);
        } 
    }
}
