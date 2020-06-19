using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._1._2
{
    class Circle
    {
        public int x;
        public int y;
        public double radial;
        public static void CircleCreate()
        {
            Circle circle = new Circle();
            Console.WriteLine("input parametr figure circle");
            Console.WriteLine("input coordinate centr: x and y");
            int.TryParse(Console.ReadLine(), out circle.x);
            int.TryParse(Console.ReadLine(), out circle.y);
            Console.WriteLine("input radius");
            double.TryParse(Console.ReadLine(), out circle.radial);
            Console.WriteLine("figure circle created");
            Console.WriteLine("-------------");
        }
        public virtual void FigureCreate()
        {
            var str = Console.ReadLine();
            var type = (FigureType)Enum.Parse(typeof(FigureType), str);
            Console.WriteLine("input param figure " + type);
        }
        public virtual double GetLength(double radial) // mrthod for caculate lenght of circle
        {
            Console.WriteLine("please input radial");
            double.TryParse(Console.ReadLine(), out radial);
            double length = 2 * Math.PI * radial;
            return length;
        }
        public virtual double GetArea(double radial) // mrthod for caculate area of circle
        {
            Console.WriteLine("please input radial");
            double.TryParse(Console.ReadLine(), out radial);
            double area = 2 * Math.PI * radial;
            return area;
        }
    }
}
