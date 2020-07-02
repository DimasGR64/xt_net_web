using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._1._2
{
    public class Round : AbstractCircleFigure
    {
        public Round(int x, int y, int radius) : base(x, y, radius)
        {
        }
        public virtual double GetLenght(double radial) => 2 * Math.PI * this.radial;
    }
}
