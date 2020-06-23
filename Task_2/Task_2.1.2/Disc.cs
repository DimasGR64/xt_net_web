using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._1._2
{
    class Disc : Round
    {
        public double InsideRadial;

        public override double GetLenght(double InsideRadial) => base.GetLenght(radial) + 2 * Math.PI * InsideRadial;
        public virtual double GetArea(double InsideRadial) => 2 * Math.PI * (radial - InsideRadial);
    }
}