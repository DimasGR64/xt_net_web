using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._1._2
{
    public class Line : AbstractFigure
    {
        public int X2;
        public int Y2;
        public Line(int x1, int y1, int x2, int y2) : base(x1,y1)
        {
            this.X2 = x2;
            this.Y2 = y2;
        }

    }
}
