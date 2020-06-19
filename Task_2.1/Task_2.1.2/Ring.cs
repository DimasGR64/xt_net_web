using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._1._2
{
    class Ring : Circle
    {
        public double InsideRadial;
        public static void RingCreate()
        {
            Ring ring = new Ring();
            Console.WriteLine("input parametr figure ring");
            Console.WriteLine("input coordinate centr: x and y");
            int.TryParse(Console.ReadLine(), out ring.x);
            int.TryParse(Console.ReadLine(), out ring.y);
            Console.WriteLine("input radius");
            double.TryParse(Console.ReadLine(), out ring.radial);
            Console.WriteLine("input inside radius");
            double.TryParse(Console.ReadLine(), out ring.radial);
            Console.WriteLine("figure circle created");
            Console.WriteLine("-------------");
        }
        public override double GetLength(double InsideRadial) // mrthod for caculate length of ring
        {
            Console.WriteLine("please input inside radial");
            double.TryParse(Console.ReadLine(), out InsideRadial);
            double lenght_ring = base.GetLength(radial) + 2 * Math.PI * InsideRadial;
            return lenght_ring;
        }
        public override double GetArea(double InsideRadial) // mrthod for caculate area of ring
        {
            Console.WriteLine("please input inside radial");
            double.TryParse(Console.ReadLine(), out InsideRadial);
            double lenght_ring = base.GetLength(radial) + 2 * Math.PI * InsideRadial;
            return lenght_ring;
        }
    }
}