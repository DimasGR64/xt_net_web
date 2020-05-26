using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, area;
                        
            do
            {
                Console.WriteLine("input side a");

                int.TryParse(Console.ReadLine(), out a);

            } while ( a == 0);

            do
            {
                Console.WriteLine("input side b");

                int.TryParse(Console.ReadLine(), out b);

            } while (b == 0);

            area = a * b;

            Console.WriteLine("rectangle area:" + area);
        }
    }
}
