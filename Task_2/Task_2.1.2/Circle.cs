using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._1._2
{

    class Circle : Round
    {
        public Circle(int x, int y, int radius) : base (x,y,radius)
        {
        }
        public override double GetLenght(double radial) => 2 * Math.PI * this.radial;
        public virtual double GetArea(double radial) => 2 * Math.PI * this.radial;
    }
}
