using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._1._2
{
    public abstract class AbstractCircleFigure : AbstractFigure
    {
        public double radial;

        public AbstractCircleFigure(int x, int y, int radius) : base(x, y)
        {
            this.radial = radius;
        }

    }
}
