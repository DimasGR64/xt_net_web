using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._1._2
{
    public class Round : AbstractCircleFigure
    {
        public virtual double GetLenght(double radial) => 2 * Math.PI * radial;
    }
}
