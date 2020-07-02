using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._1._2
{
    class Disc : AbstractCircleFigure
    {
        public double InsideRadial;
        public Disc(int x, int y, int radius, int InsideRadial) : base(x,y,radius)
        {
        }
        public double GetLenght(double InsideRadial) => 2 * Math.PI * (radial + InsideRadial);
        public virtual double GetArea(double InsideRadial) => 2 * Math.PI * (radial - InsideRadial);
    }
}