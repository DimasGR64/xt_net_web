using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._1._2
{
    public abstract class AbstractFigure
    {
        public int X { get; set; }
        public int Y { get; set; }
        public AbstractFigure(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
