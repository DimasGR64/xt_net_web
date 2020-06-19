using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._1._2
{
    class Square
    {
        public int a;
        public int b;
        public static void SquareCreate()
        {
            Square square = new Square();
            Console.WriteLine("input parametr figure ring");
            Console.WriteLine("input side a and side b");
            int.TryParse(Console.ReadLine(), out square.a);
            int.TryParse(Console.ReadLine(), out square.b);
            Console.WriteLine("figure square created");
            Console.WriteLine("-------------");
        }
        public int GetArea()
        {
            int area = a * b;
            return area;
        }
        
    }
}
